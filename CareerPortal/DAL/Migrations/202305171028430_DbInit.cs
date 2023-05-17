namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicantJobApplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantId = c.Int(nullable: false),
                        PositionName = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Mail = c.String(nullable: false),
                        ExpectedSalary = c.String(nullable: false),
                        StartTime = c.String(nullable: false),
                        JobId = c.Int(nullable: false),
                        EmployerJobPost_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .ForeignKey("dbo.EmployerJobPosts", t => t.EmployerJobPost_Id)
                .Index(t => t.ApplicantId)
                .Index(t => t.EmployerJobPost_Id);
            
            CreateTable(
                "dbo.ApplicantProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Mail = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Nationality = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 20),
                        DOB = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: false)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false, maxLength: 100),
                        ApplicantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .Index(t => t.ApplicantId);
            
            CreateTable(
                "dbo.ApplicantEducationalQualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantId = c.Int(nullable: false),
                        LevelofEducation = c.String(nullable: false),
                        InstituteName = c.String(nullable: false),
                        YearofPassing = c.Int(nullable: false),
                        Degree = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .Index(t => t.ApplicantId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppliedJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantId = c.Int(nullable: false),
                        JobId = c.Int(nullable: false),
                        ApplicantJobApply_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantId, cascadeDelete: false)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobId, cascadeDelete: false)
                .ForeignKey("dbo.ApplicantJobApplies", t => t.ApplicantJobApply_Id)
                .Index(t => t.ApplicantId)
                .Index(t => t.JobId)
                .Index(t => t.ApplicantJobApply_Id);
            
            CreateTable(
                "dbo.EmployerJobPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Description = c.String(nullable: false, maxLength: 200),
                        Type = c.String(nullable: false, maxLength: 20),
                        Salary = c.Int(nullable: false),
                        Location = c.String(nullable: false, maxLength: 20),
                        RequiredSkills = c.String(nullable: false, maxLength: 200),
                        EducationLevel = c.String(nullable: false, maxLength: 200),
                        Experience = c.String(nullable: false, maxLength: 20),
                        ApplicationDeadline = c.String(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 20),
                        CompanyMail = c.String(nullable: false),
                        Employer_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ManageCategories", t => t.Category_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerProfiles", t => t.Employer_Id, cascadeDelete: false)
                .Index(t => t.Employer_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.ManageCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployerProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Nationality = c.String(nullable: false, maxLength: 20),
                        DateOfBirth = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.EmployerRecruitments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Shortlist = c.Boolean(nullable: false),
                        Employer_Id = c.Int(nullable: false),
                        Applicant_Id = c.Int(nullable: false),
                        JobPost_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.Applicant_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobPost_Id, cascadeDelete: false)
                .ForeignKey("dbo.EmployerProfiles", t => t.Employer_Id, cascadeDelete: false)
                .Index(t => t.Employer_Id)
                .Index(t => t.Applicant_Id)
                .Index(t => t.JobPost_Id);
            
            CreateTable(
                "dbo.ManageJobPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployerJobPosts", t => t.JobId, cascadeDelete: false)
                .Index(t => t.JobId);
            
            CreateTable(
                "dbo.ManageUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicantID = c.Int(nullable: false),
                        EmployerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicantProfiles", t => t.ApplicantID, cascadeDelete: false)
                .ForeignKey("dbo.EmployerProfiles", t => t.EmployerID, cascadeDelete: false)
                .Index(t => t.ApplicantID)
                .Index(t => t.EmployerID);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        Type = c.String(nullable: false),
                        Username = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManageUsers", "EmployerID", "dbo.EmployerProfiles");
            DropForeignKey("dbo.ManageUsers", "ApplicantID", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ManageJobPosts", "JobId", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.EmployerRecruitments", "Employer_Id", "dbo.EmployerProfiles");
            DropForeignKey("dbo.EmployerRecruitments", "JobPost_Id", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.EmployerRecruitments", "Applicant_Id", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ApplicantJobApplies", "EmployerJobPost_Id", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.AppliedJobs", "ApplicantJobApply_Id", "dbo.ApplicantJobApplies");
            DropForeignKey("dbo.AppliedJobs", "JobId", "dbo.EmployerJobPosts");
            DropForeignKey("dbo.EmployerJobPosts", "Employer_Id", "dbo.EmployerProfiles");
            DropForeignKey("dbo.EmployerProfiles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.EmployerJobPosts", "Category_Id", "dbo.ManageCategories");
            DropForeignKey("dbo.AppliedJobs", "ApplicantId", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ApplicantJobApplies", "ApplicantId", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.ApplicantProfiles", "UId", "dbo.Users");
            DropForeignKey("dbo.ApplicantEducationalQualifications", "ApplicantId", "dbo.ApplicantProfiles");
            DropForeignKey("dbo.Notifications", "ApplicantId", "dbo.ApplicantProfiles");
            DropIndex("dbo.ManageUsers", new[] { "EmployerID" });
            DropIndex("dbo.ManageUsers", new[] { "ApplicantID" });
            DropIndex("dbo.ManageJobPosts", new[] { "JobId" });
            DropIndex("dbo.EmployerRecruitments", new[] { "JobPost_Id" });
            DropIndex("dbo.EmployerRecruitments", new[] { "Applicant_Id" });
            DropIndex("dbo.EmployerRecruitments", new[] { "Employer_Id" });
            DropIndex("dbo.EmployerProfiles", new[] { "User_Id" });
            DropIndex("dbo.EmployerJobPosts", new[] { "Category_Id" });
            DropIndex("dbo.EmployerJobPosts", new[] { "Employer_Id" });
            DropIndex("dbo.AppliedJobs", new[] { "ApplicantJobApply_Id" });
            DropIndex("dbo.AppliedJobs", new[] { "JobId" });
            DropIndex("dbo.AppliedJobs", new[] { "ApplicantId" });
            DropIndex("dbo.ApplicantEducationalQualifications", new[] { "ApplicantId" });
            DropIndex("dbo.Notifications", new[] { "ApplicantId" });
            DropIndex("dbo.ApplicantProfiles", new[] { "UId" });
            DropIndex("dbo.ApplicantJobApplies", new[] { "EmployerJobPost_Id" });
            DropIndex("dbo.ApplicantJobApplies", new[] { "ApplicantId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.ManageUsers");
            DropTable("dbo.ManageJobPosts");
            DropTable("dbo.EmployerRecruitments");
            DropTable("dbo.EmployerProfiles");
            DropTable("dbo.ManageCategories");
            DropTable("dbo.EmployerJobPosts");
            DropTable("dbo.AppliedJobs");
            DropTable("dbo.Users");
            DropTable("dbo.ApplicantEducationalQualifications");
            DropTable("dbo.Notifications");
            DropTable("dbo.ApplicantProfiles");
            DropTable("dbo.ApplicantJobApplies");
        }
    }
}

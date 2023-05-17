using AppLayer.Auth;
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppLayer.Controllers
{
    [EnableCors("*","*","*")]
    public class ApplicantProfileController : ApiController
    {
        [Applicant]
        [HttpGet]
        [Route("api/applicantprofiles")]
        public HttpResponseMessage AllApplicants()
        {
            try
            {
                var data = ApplicantProfileService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Applicant]
        [HttpGet]
        [Route("api/applicantprofiles/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = ApplicantProfileService.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantprofiles/create")] 
        public HttpResponseMessage Create(ApplicantProfileDTO obj)
        {
            try
            {
                var data = ApplicantProfileService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantprofiles/update")]
        public HttpResponseMessage Update(ApplicantProfileDTO obj)
        {
            try
            {
                var data = ApplicantProfileService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse (HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantprofiles/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ApplicantProfileService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex.Message);
            }
        }

    }
}

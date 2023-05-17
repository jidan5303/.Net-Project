using AppLayer.Auth;
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppLayer.Controllers
{
    [EnableCors("*","*","*")]
    public class ApplicantJobApplyController : ApiController
    {
        [HttpGet]
        [Route("api/applicantappliedjobs")]
        public HttpResponseMessage AllApplicants()
        {
            try
            {
                var data = ApplicantJobApplyService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Applicant]
        [HttpGet]
        [Route("api/applicantappliedjobs/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = ApplicantJobApplyService.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantappliedjobs/create")]
        public HttpResponseMessage Create(ApplicantJobApplyDTO obj)
        {
            try
            {
                var data = ApplicantJobApplyService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantappliedjobs/update")]
        public HttpResponseMessage Update(ApplicantJobApplyDTO obj)
        {
            try
            {
                var data = ApplicantJobApplyService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicantappliedjobs/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ApplicantJobApplyService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}

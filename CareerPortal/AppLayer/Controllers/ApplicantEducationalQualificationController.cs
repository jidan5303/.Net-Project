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
    [EnableCors("*", "*", "*")]
    public class ApplicantEducationalQualificationController : ApiController
    {
        
        [HttpGet]
        [Route("api/applicanteduqualifications")]
        public HttpResponseMessage AllApplicantsEduQualifications()
        {
            try
            {
                var data = ApplicantEducationalQualificationService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/applicanteduqualifications/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = ApplicantEducationalQualificationService.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicanteduqualifications/create")]
        public HttpResponseMessage Create(ApplicantEducationalQualificationDTO obj)
        {
            try
            {
                var data = ApplicantEducationalQualificationService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicanteduqualifications/update")]
        public HttpResponseMessage Update(ApplicantEducationalQualificationDTO obj)
        {
            try
            {
                var data = ApplicantEducationalQualificationService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/applicanteduqualifications/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ApplicantEducationalQualificationService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}

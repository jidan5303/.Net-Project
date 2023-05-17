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
    public class EmployerRecruitmentController : ApiController
    {
        [Employer]
        [HttpGet]
        [Route("api/EmployerRecruitments")]
        public HttpResponseMessage Read()
        {
            try
            {
                var data = EmployerRecruitmentService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/EmployerRecruitments/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = EmployerRecruitmentService.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/EmployerRecruitments/Create")]
        public HttpResponseMessage Create(EmployerRecruitmentDTO obj)
        {
            try
            {
                var data = EmployerRecruitmentService.Create(obj);
                if(data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new {Msg = "Created", Data = obj});
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new {Msg = "Not Created", Data = obj});
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new {Msg = ex.Message, Data = obj});
            }
        }
        [HttpPost]
        [Route("api/EmployerRecruitments/Update")]
        public HttpResponseMessage Update(EmployerRecruitmentDTO obj)
        {
            try
            {
                var data = EmployerRecruitmentService.Update(obj);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Updated", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }
        [HttpPost]
        [Route("api/EmployerRecruitments/Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = EmployerRecruitmentService.Delete(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Deleted" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}

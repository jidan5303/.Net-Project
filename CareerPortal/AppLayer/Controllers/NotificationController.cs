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
    public class NotificationController : ApiController
    {
        [HttpGet]
        [Route("api/notifications")]
        public HttpResponseMessage Allnotifications()
        {
            try
            {
                var data = NotificationServices.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/notifications/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = NotificationServices.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/notifications/create")]
        public HttpResponseMessage Create(NotificationDTO obj)
        {
            try
            {
                var data = NotificationServices.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/notifications/update")]
        public HttpResponseMessage Update(NotificationDTO obj)
        {
            try
            {
                var data = NotificationServices.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/notifications/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = NotificationServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}

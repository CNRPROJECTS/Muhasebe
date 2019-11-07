using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MuhApi.DB;
using MuhShared;



namespace MuhApi.Controllers
{
    public class LoginController : ApiController
    {
        private  DbRepo _dbrepo = new DbRepo();


        [HttpPost]
        public IHttpActionResult UserLogin(MUserLogin u)
        {
            try
            {
                var LoginResult = _dbrepo.UserLogin(u);
                return Ok(LoginResult);
            }
            catch (Exception e)
            {
                HttpResponseMessage errorResponse = new HttpResponseMessage(HttpStatusCode.BadGateway)
                {
                    ReasonPhrase = e.Message
                };
                throw new HttpResponseException(errorResponse);
            }
        }
    }
}

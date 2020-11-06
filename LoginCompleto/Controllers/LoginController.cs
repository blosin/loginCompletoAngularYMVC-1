using System.Net;
using System.Threading;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [System.Web.Mvc.AllowAnonymous]
    [System.Web.Mvc.RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null) 
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            bool isCredentialValid = (login.Password == "123456");
            if (isCredentialValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}

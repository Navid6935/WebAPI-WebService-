using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        public string GetNavid()
        {
            return "Welcome to WebApi";
        }
        public List<string> GetNavid(int Id)
        {
            return new List<string>
            {
                "Data1","Data2"
            };
        }
    }
}

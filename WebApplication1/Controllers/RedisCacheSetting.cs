using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class RedisCacheSetting
    {
        public bool Enabled { get; set; }
        public string ConnectionString { get; set; }
        public int DefaultSecondsToCache { get; set; }
    }
    public class CacheInstaller :IServiceInstaller
    {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class AppSettings
    {
        public string SMTPIP { get; set; }
        public string SMTPID { get; set; }
        public string SMTPPW { get; set; }
    }
    public class MyOptions
    {
        public string ConnectionString { get; set; }

        public AppSettings AppSettings { get; set; }
    }
}

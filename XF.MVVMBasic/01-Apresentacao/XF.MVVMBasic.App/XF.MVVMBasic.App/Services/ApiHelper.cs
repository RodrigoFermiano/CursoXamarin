using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace XF.MVVMBasic.App.Services
{
    public class ApiHelper
    {
        private readonly HttpClient _HttpClient;

        public ApiHelper()
        {
            _HttpClient = new HttpClient();
        }

        public HttpClient ObterHttClient()
        {
            return _HttpClient;
        }

        internal string ObterUrl(string controller)
        {

            return "http://localhost:3902/api/" + controller + "/";

        }
    }
}

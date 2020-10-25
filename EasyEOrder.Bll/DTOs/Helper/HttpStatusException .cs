using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Helper
{
    public class HttpStatusException : Exception
    {
        public HttpStatusCode Status { get; private set; }

        public HttpStatusException(HttpStatusCode status, string msg) : base(msg)
        {
            Status = status;
        }
    }
}

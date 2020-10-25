using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Helper
{
    public class MyNotFoundException : Exception
    {
        public MyNotFoundException(string message) : base(message)
        { }
    }
}

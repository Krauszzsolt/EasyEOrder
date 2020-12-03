using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Wrapper
{
    public class PageableRequestQuery
    {
        public int? Index { get; set; }
        public int? PageSize { get; set; }
    }
}

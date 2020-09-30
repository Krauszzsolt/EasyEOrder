using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Wrapper
{
    public class SearchableAndPageableRequestQuery : PageableRequestQuery
    {
        public string  SearchTerm { get; set; }
    }
}

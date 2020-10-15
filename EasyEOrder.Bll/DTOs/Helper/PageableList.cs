using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs.Wrapper
{
    public class PageableList<T>
    {
        public List<T> Data  { get; set; }
        public int Index { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
    }

 
}

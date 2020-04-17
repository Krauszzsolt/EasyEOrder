using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Base
    {
        public DateTime CreateTime{ get; set; }

        public DateTime ModifyTime{ get; set; }

        public bool IsDelete { get; set; }

    }
}

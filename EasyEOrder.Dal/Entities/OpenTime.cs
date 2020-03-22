using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class OpenTime
    {
        public Guid Id { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}

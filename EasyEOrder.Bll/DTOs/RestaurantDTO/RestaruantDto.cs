using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs
{
    public class RestaruantDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public Guid MenuId { get; set; }

    }
}

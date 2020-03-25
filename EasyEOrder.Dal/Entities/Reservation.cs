using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public Guid TableId { get; set; }

        public MyUser MyUser { get; set; }

        public Guid UserId { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}

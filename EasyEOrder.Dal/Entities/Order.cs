using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
              
        public int TotalPrice { get; set; }

        public string Comment { get; set; }

        public DateTime OrderTime { get; set; }

        public ICollection<Food> Foods { get; set; }

        public Reservation Reservation { get; set; }

        public Guid ReservationId { get; set; }
    }
}

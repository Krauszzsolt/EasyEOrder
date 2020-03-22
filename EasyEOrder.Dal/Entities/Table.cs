using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Table
    {
        public Guid Id { get; set; }

        public Guid RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public Guid ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public Guid UserId { get; set; }

        public MyUser User { get; set; }

    }
}

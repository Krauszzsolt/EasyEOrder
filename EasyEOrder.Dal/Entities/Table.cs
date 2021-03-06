﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Table : Base
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public Guid RestaurantId { get; set; }

        public Guid ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public string UserId { get; set; }

        public Restaurant Restaurant{ get; set; }


    }
}

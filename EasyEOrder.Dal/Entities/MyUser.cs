using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class MyUser : IdentityUser
    {
        public string Picture { get; set; }

        public Guid? RestaurantId { get; set; }

        public Guid? ReservationId { get; set; }

        public Reservation Reservation{ get; set; }

        public ICollection<Table> Tables { get; set; }

        public ICollection<Comment> Comments{ get; set; }

    }
}

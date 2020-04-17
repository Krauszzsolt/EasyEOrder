
using System;
using System.Collections.Generic;

namespace EasyEOrder.Dal.Entities
{
    public class Restaurant : Base
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Table> Tables { get; set; }

        public ICollection<MyUser> Employees { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public Menu Menu { get; set; }

        public Guid? MenuId { get; set; }

        public ICollection<DayOfWeekOpenTimes> DayOfWeekOpenTimes { get; set; }

    }
}

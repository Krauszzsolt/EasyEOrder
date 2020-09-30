using EasyEOrder.Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Food : Base
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public int Price { get; set; }

        public FoodCategories Category { get; set; }

        public int Rating { get; set; }

        public bool IsAvailable { get; set; }

        public string Description { get; set; }

        public Menu Menu { get; set; }

        public Guid MenuId { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<FoodAllergen> FoodAllergens { get; set; }

        public Cart Cart { get; set; }

        public Guid? OrderId{ get; set; }
    }
}

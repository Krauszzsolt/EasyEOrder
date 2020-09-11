using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Bll.DTOs
{
    public class FoodCreateSelectItemsDto
    {

        public List<SelectListItem> Menu { get; set; }
        public List<SelectListItem> Category { get; set; }
        public List<SelectListItem> Allergen { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Comment : Base
    {
        public Guid Id { get; set; }

        public Guid FoodId { get; set; }

        public String MyUserId { get; set; }

        public string CommentContent { get; set; }
    }
}

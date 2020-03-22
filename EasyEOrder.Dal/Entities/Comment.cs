using System;
using System.Collections.Generic;
using System.Text;

namespace EasyEOrder.Dal.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid FoodId { get; set; }

        public Food Food { get; set; }

        public Guid UserId { get; set; }

        public MyUser User { get; set; }

        public string CommentContent { get; set; }
    }
}

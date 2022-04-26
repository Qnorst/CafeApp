using System;
using System.Collections.Generic;

namespace CafeApp
{
    public partial class DishInOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int DishCount { get; set; }

        public virtual Dish Dish { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace CafeApp
{
    public partial class Order
    {
        public Order()
        {
            DishInOrders = new HashSet<DishInOrder>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DataCreate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<DishInOrder> DishInOrders { get; set; }
    }
}

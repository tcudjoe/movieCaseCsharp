using System;
namespace MovieOrder.API.Entities
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }

    }
}


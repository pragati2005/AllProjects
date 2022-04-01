using System;

namespace Entities
{
    public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImageName { get; set; }

        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
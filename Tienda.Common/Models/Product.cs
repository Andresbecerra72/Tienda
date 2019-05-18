namespace Tienda.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    //se crean los atributos del producto
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime PublishOn { get; set; }

    }
}

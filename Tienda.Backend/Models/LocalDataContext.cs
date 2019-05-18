namespace Tienda.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Tienda.Common.Models.Product> Products { get; set; }
    }
}
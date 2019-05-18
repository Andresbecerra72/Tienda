namespace Tienda.Domain.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext
    {       //interface de conexion a la base de datos
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Tienda.Common.Models.Product> Products { get; set; }
    }
}

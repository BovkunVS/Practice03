using System.Data.Entity;

namespace Demo02_CodeFirst
{
    public class ModelExibitionContainer : DbContext
    {
        public ModelExibitionContainer()
            : base("name=ModelExibitionContainer") { }
        // Ця властивість посилається на таблицю в базі даних
        public virtual DbSet<Owner> OwnerSet { get; set; }
    }
}

using Dapper.Contrib.Extensions;

namespace Domain.Base
{
    public abstract class Entity
    {
        [Key]
        public int id { get; set; }
    }
}

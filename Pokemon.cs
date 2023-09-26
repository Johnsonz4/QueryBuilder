using QueryBuilder;
using QueryBuilder.Models;

namespace QueryBuilder.Models
{
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

      
    }
}



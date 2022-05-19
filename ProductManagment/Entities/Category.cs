using System.ComponentModel.DataAnnotations;

namespace ProductManagment.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}

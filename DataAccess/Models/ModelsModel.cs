using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class ModelsModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

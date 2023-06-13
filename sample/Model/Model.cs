using System.ComponentModel.DataAnnotations;

namespace sample.Model
{
    public class Model
    {
        internal readonly int Id;

        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Department { get; set; }
        [Required]
        public string IsActive { get; set; }


    }

}


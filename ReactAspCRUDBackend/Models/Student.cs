using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactAspCRUDBackend.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string stname { get; set; }
        public string course
        {
            get; set;
        }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}

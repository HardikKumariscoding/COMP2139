using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Date)]
        public string Status { get; set; }


    }
}

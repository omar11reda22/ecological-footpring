using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace final_project.Models
{
    public class result
    {
        [Column(Order = 0), Key, ForeignKey("question")]
        public int Question_ID { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public double value { get; set; }
        [Column(Order = 1), Key, ForeignKey("User")]
        public int User_ID { get; set; }

       
       


    }
}

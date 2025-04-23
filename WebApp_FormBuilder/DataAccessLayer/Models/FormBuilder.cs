using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class FormBuilder
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Question")]
        public string? Questions { get; set; }
        public string Answer { get; set; }
        public string? Answer1 { get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
        public string? Answer4 { get; set; }
       

        public string? Option1 { get; set; }
       
        public string? Option2 { get; set; }
       
        public string? Option3 { get; set; }
        
        public string? Option4 { get; set; }
        public string? Option5 { get; set; }
        public bool IsRequired { get; set; }
        public bool IsSpecified { get; set; }

    }
}

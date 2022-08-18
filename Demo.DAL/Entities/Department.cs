using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Code is Required")]
        public int Code { get; set; }
        [Required(ErrorMessage ="Name is Required!")]
        [StringLength(100, MinimumLength =5 , ErrorMessage ="Name length must be between 5 and 100 chars")]
        public string Name  { get; set; }

        public DateTime DateOfCreation { get; set; }





    }
}

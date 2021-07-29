using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
  
        //What ever you put in display name is what show on the view, as long as you have used the asp net label tag on the view page
        [Required]
        [DisplayName("Category Name")]

        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]  //What ever you put in display name is what show on the view, as long as you have used the asp net label tag on the view page
       [Range(1,int.MaxValue,ErrorMessage ="Display Play Order for categeory must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}

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
        //[DisplayName("Display Order Now")]
        //What ever you put in display name is what show on the view, as long as you have used the asp net label tag on the view page
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]  //What ever you put in display name is what show on the view, as long as you have used the asp net label tag on the view page
        public int DisplayOrder { get; set; }
    }
}

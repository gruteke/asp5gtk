using System.ComponentModel.DataAnnotations;

namespace asp5gtk1.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
    }
}
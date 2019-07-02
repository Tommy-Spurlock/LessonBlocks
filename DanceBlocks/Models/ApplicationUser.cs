using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class ApplicationUser : IdentityUser 
    {

        public ApplicationUser() { }

        // Add profile data for application users by adding properties to the ApplicationUser class

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        // Set up PK -> FK relationships to other objects
        public List<Student> Students { get; set; }

    
    }


}


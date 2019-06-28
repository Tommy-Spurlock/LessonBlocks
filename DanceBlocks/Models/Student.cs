using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime StudentStartDate { get; set; }

        public bool IsActive { get; set; }

        public int DanceTypeId { get; set; }

        public int SkillLevelId { get; set; }

        public int UserId { get; set; }

        public List<Lesson> Lessons { get; set; }

        public SkillLevel SkillLevel { get; set; }

        public DanceType DanceType { get; set; }

        public ApplicationUser User { get; set; }



    }
}

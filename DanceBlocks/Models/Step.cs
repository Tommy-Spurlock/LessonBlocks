using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class Step
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
       
        public string Description { get; set; }

        public int DanceTypeId { get; set; }

        public DanceType DanceType { get; set; }

    
        public int SkillLevelId { get; set; }

        public SkillLevel SkillLevel { get; set; }

        public List<LessonStep> LessonSteps { get; set; }

    }


}

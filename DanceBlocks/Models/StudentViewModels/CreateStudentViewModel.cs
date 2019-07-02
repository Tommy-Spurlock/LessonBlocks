using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models.StudentViewModels
{
    public class CreateStudentViewModel
    {

        public Student Student { get; set; }

        public SelectList DanceTypes { get; set; }

        public SelectList SkillLevels { get; set; }
    }
}

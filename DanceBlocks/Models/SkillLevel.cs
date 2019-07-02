using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class SkillLevel
    {
        public int Id { get; set; }

        public string Level { get; set; }

        public List<Student> Students { get; set; }


        public List<Step> Steps { get; set; }

    }


}

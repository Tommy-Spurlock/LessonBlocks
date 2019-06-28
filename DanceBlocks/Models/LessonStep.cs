using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class LessonStep
    {
        public int Id { get; set; }

        public int LessonId { get; set; }

        public int StepId { get; set; }

        public Lesson Lesson { get; set; }

        public Step Step { get; set; }
    }
}

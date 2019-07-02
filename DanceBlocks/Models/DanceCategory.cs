using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanceBlocks.Models
{
    public class DanceCategory
    {
        public int Id { get; set; }

        public int DanceTypeId { get; set; }

        public int CategoryId { get; set; }

        public DanceType DanceType { get; set; }

        public Category Category { get; set; }

    }
}

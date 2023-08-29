using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChordsCalculator.Models.Models
{
    public class Chords
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Notes { get; set; }
    }
}

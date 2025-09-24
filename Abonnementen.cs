using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaPalace
{
    internal class Abonnementen
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime EindDatum { get; set; }

        public string Display => $"{Type} (tot {EindDatum.ToShortDateString()})";

        public override string ToString()
        {
            return Display;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAI
{
    internal class Create
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }

        public override string ToString()
        {
            return $"{Roll}{Name}{Percent}";

        }
    }
   

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAM_Astronomy.Models
{
    partial class AstronomicalBody
    {
        public string Name { get; internal set; }
        public string Mass { get; internal set; }
        public string Age { get; internal set; }
        public string EmojiIcon { get; internal set; }
        public string Circumference { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAM_Astronomy.Models
{
    [QueryProperty(nameof(AstroName), "astroName")]
    public partial class AstronomicalBodyPage
    {
        string astroName;
        public string AstroName
        {
            get => astroName;
            set
            {
                astroName = value;
                // this is a custom function to update the UI immediately
                UpdateAstroBodyUI(astroName);
            }
        }

        private void UpdateAstroBodyUI(string astroName)
        {
            throw new NotImplementedException();
        }
    }
}

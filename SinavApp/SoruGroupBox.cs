using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public class SoruGroupBox: GroupBox
    {
        public bool CevaplandiMi { get; set; }
        public RadioButton SeciliSecenek { get; set; }
        public int SoruNumarasi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_sample
{
    public interface IColorService
    {
        Color AppendColor(string HexColor);
        Color MakeGreen();
        Color MakeRed();
        Color MakeBlue();
    }

    public class ColorService : IColorService
    {
        public Color AppendColor(string HexColor)
        {
            return ColorTranslator.FromHtml(HexColor);
        }

        public Color MakeBlue()
        {
            return Color.Blue;
        }

        public Color MakeGreen()
        {
            return Color.Green;
        }

        public Color MakeRed()
        {
            return Color.Red;
        }
    }
}

using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zurafMTR.FormUI
{
    public partial class BaseForm : KryptonForm
    {
        public BaseForm()
        {
            var basePalette = new KryptonPalette
            {
                
            };
            basePalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            basePalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;

            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;

            basePalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45;

            basePalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);

            //basePalette.ButtonSpecs.FormClose.Image = "";


            basePalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;

            basePalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;


            basePalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            KryptonManager.GlobalPalette = basePalette;
        }
    }
}

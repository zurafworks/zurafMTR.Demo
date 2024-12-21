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
        public virtual string PageName => "BaseForm";

        public BaseForm()
        {
            var basePalette = new KryptonPalette
            {
                
            };

            #region Form

            #region Preset
            this.BackColor = System.Drawing.Color.FromArgb(250, 252, 252);
            this.Size = new Size(850, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.Text = $"{PageName} - Müşteri Takip Otomasyonu - zurafworks";
            #endregion

            #region Main
            basePalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            basePalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;
            #endregion

            #region Header
            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;

            basePalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);
            basePalette.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45;

            basePalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            #endregion

            #region Button
            basePalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;

            basePalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;


            basePalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
            basePalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

            basePalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;

            #endregion

            #endregion

            KryptonManager.GlobalPalette = basePalette;


            InitializeComponent();



            Label baslik = new Label();
            baslik.Text = "Başlık";
            baslik.Font = new Font("Poppins", 15, FontStyle.Bold);
            baslik.Location = new Point(0, 0);
            baslik.AutoSize = true;
            baslik.ForeColor = Color.Black;
            this.Controls.Add(baslik);


            Label altBaslik = new Label();
            altBaslik.Text = "Alt Başlık";
            altBaslik.Font = new Font("Poppins", 10, FontStyle.Bold);
            altBaslik.Location = new Point(0, 25);
            altBaslik.AutoSize = true;
            altBaslik.ForeColor = Color.Black;
            this.Controls.Add(altBaslik);

            KryptonTextBox textBox = new KryptonTextBox();
            textBox.Text = "TextBox";
            textBox.Size = new Size(200, 23);
            textBox.Location = new Point(0, 45);
            this.Controls.Add(textBox);


            KryptonButton button = new KryptonButton();
            button.Text = "Giriş Yap";
            button.Size = new Size(155, 33);
            button.Location = new Point(0, 80);
            this.Controls.Add(button);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control is KryptonTextBox textBox)
            {
                ApplyTextBoxStyle(textBox);
            }
            else if (e.Control is KryptonButton button)
            {
                ApplyButtonStyle(button);
            }
            else if (e.Control is Label label)
            {
                //ApplyLabelStyle(label);
            }
        }

        private void ApplyTextBoxStyle(KryptonTextBox textBox)
        {
            var defaultItem = new KryptonTextBox();
            if(textBox.StateCommon.Back.Color1 == defaultItem.StateCommon.Back.Color1)
                textBox.StateCommon.Back.Color1 = Color.White;

            if (textBox.StateCommon.Border.Color1 == defaultItem.StateCommon.Border.Color1)
                textBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);

            if (textBox.StateCommon.Border.GraphicsHint == defaultItem.StateCommon.Border.GraphicsHint)
                textBox.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;

            if (textBox.StateCommon.Border.Rounding == defaultItem.StateCommon.Border.Rounding)
                textBox.StateCommon.Border.Rounding = 20;

            if(textBox.StateCommon.Border.Width == defaultItem.StateCommon.Border.Width)
                textBox.StateCommon.Border.Width = 1;

            if (textBox.StateCommon.Content.Color1 == defaultItem.StateCommon.Content.Color1)
                textBox.StateCommon.Content.Color1 = Color.Gray;

            if (textBox.StateCommon.Content.Font == defaultItem.StateCommon.Content.Font)
                textBox.StateCommon.Content.Font = new Font("Poppins", 10, FontStyle.Bold);

            if (textBox.StateCommon.Content.Padding == defaultItem.StateCommon.Content.Padding)
                textBox.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
        }


        private void ApplyButtonStyle(KryptonButton button)
        {
            var defaultItem = new KryptonButton();

            if (button.StateCommon.Back.Color1 == defaultItem.StateCommon.Back.Color1)
                button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);

            if (button.StateCommon.Back.Color2 == defaultItem.StateCommon.Back.Color2)
                button.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);

            if (button.StateCommon.Back.ColorAngle == defaultItem.StateCommon.Back.ColorAngle)
                button.StateCommon.Back.ColorAngle = 45;

            if (button.StateCommon.Border.Rounding == defaultItem.StateCommon.Border.Rounding)
                button.StateCommon.Border.Rounding = 24;

            if (button.StateCommon.Border.Color1 == defaultItem.StateCommon.Border.Color1)
                button.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);

            if (button.StateCommon.Border.Color2 == defaultItem.StateCommon.Border.Color2)
                button.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);

            if (button.StateCommon.Border.ColorAngle == defaultItem.StateCommon.Border.ColorAngle)
                button.StateCommon.Border.ColorAngle = 45;

            if (button.StateCommon.Border.GraphicsHint == defaultItem.StateCommon.Border.GraphicsHint)
                button.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
        }
    }
}

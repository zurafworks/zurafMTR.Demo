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
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(250, 252, 252);
            this.Size = new Size(850, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.Text = "Login - Müşteri Takip Otomasyonu - zurafworks";

           // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
           // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

           // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
           // this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;

           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top;
           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.None;

           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);
           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);
           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45;

           // this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);

           // //this.kryptonPalette1.ButtonSpecs.FormClose.Image = "";


           // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
           //this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

           // this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;

           // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
           // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

           // this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;


           // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(250, 252, 252);
           // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(250, 252, 252);

           // this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;

            Label label = new Label();
            label.Text = "zurafworks Müşteri Takip Otomasyonu";
            label.Font = new Font("Poppins", 15, FontStyle.Bold);
            label.Location = new Point(230, 91);
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            this.Controls.Add(label);


            Label label2 = new Label();
            label2.Text = "Giriş Yap";
            label2.Font = new Font("Poppins", 10, FontStyle.Bold);
            label2.Location = new Point(230, 163);
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            this.Controls.Add(label2);

            KryptonTextBox kryptonTextBox = new KryptonTextBox();
            kryptonTextBox.Text = "Email";
            kryptonTextBox.Size = new Size(379,23);
            kryptonTextBox.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonTextBox.StateCommon.Border.Rounding = 20;
            kryptonTextBox.StateCommon.Border.Width = 1;
            kryptonTextBox.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox.StateCommon.Content.Font = new Font("Poppins", 10, FontStyle.Bold);
            kryptonTextBox.StateCommon.Content.Padding = new Padding(10, 0 , 10 , 0);
            kryptonTextBox.Location = new Point(230, 230);
            this.Controls.Add(kryptonTextBox);

            KryptonTextBox kryptonTextBox2 = new KryptonTextBox();
            kryptonTextBox2.Text = "Şifre";
            kryptonTextBox2.Size = new Size(379,23);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20;
            kryptonTextBox2.StateCommon.Border.Width = 1;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Poppins", 10, FontStyle.Bold);
            kryptonTextBox2.StateCommon.Content.Padding = new Padding(10, 0 , 10 , 0);
            kryptonTextBox2.Location = new Point(230, 267);
            this.Controls.Add(kryptonTextBox2);


            KryptonButton kryptonButton = new KryptonButton();
            kryptonButton.Text = "Giriş Yap";
            kryptonButton.Size = new Size(155, 43);
            kryptonButton.Location = new Point(230, 310);
            kryptonButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);
            kryptonButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);
            kryptonButton.StateCommon.Back.ColorAngle = 45;
            kryptonButton.StateCommon.Border.Rounding = 24;
            kryptonButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(122, 178, 178);
            kryptonButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(77, 134, 156);
            kryptonButton.StateCommon.Border.ColorAngle = 45;
            kryptonButton.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            this.Controls.Add(kryptonButton);
        }
        
    }
}

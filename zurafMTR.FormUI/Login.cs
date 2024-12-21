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
        public override string PageName => "Login";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
            kryptonTextBox.Location = new Point(230, 230);
            this.Controls.Add(kryptonTextBox);

            KryptonTextBox kryptonTextBox2 = new KryptonTextBox();
            kryptonTextBox2.Text = "Şifre";
            kryptonTextBox2.Size = new Size(379,23);
            kryptonTextBox2.Location = new Point(230, 267);
            this.Controls.Add(kryptonTextBox2);


            KryptonButton kryptonButton = new KryptonButton();
            kryptonButton.Text = "Giriş Yap";
            kryptonButton.Size = new Size(155, 43);
            kryptonButton.Location = new Point(230, 310);
            this.Controls.Add(kryptonButton);
        }
        
    }
}

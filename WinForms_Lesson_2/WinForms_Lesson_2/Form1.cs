using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_Lesson_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToShortDateString();
            label5.Text = DateTime.Now.ToString();
            lblPicture.Text = "test";
            Image image = Image.FromFile("icon.png");

            lblPicture.Size = new Size(170, 170);
            lblPicture.Image = image;
            lblPicture.Cursor = Cursors.Hand;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Height = 300;
            textBox1.Multiline = true;
            textBox1.WordWrap = false;
            textBox1.PasswordChar = '*';
            textBox1.TextChanged += TextBox1_TextChanged;
            checkBox1.ThreeState = true;
            checkBox1.Location = new Point();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.Beep(1000, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            MessageBox.Show(check.Text);

        }
    }
}

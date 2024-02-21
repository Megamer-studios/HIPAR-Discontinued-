using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIPAR
{


    public partial class Form2 : Form
    {
        int prog2 = 0;
        int num1 = 1;
        int prog3 = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public void uwu()
        {




        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            num1 = (int)numericUpDown1.Value;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DELAY --
            if (label1.Text == ("2) Why did you start using HIPAR?"))
            {
                prog2 += 1;
            }
            if (label1.Text == ("X) Please give\na proper\nanswer! "))
            {
                prog2 = 2;
            }
            //
            if (prog2 == 0)
            {
                numericUpDown1.Hide();
                label1.Text = ("2) Why did you start using HIPAR?");
                textBox1.Text = ("");
                
            }
            if (prog2 == 1)
            {

                label1.Text = ("X) Please give\na proper\nanswer! ");
                label1.ForeColor =  Color.Red;
                Shake(this);
                textBox1.Text = ("");
                
            }
            if (prog2 == 2)
            {

                label1.Text = ("X) Please give\na proper\nanswer! ");
                label1.ForeColor = Color.Red;

                label1.Font = new System.Drawing.Font(label1.Font.FontFamily.Name, 42);
                Shake(this);
                textBox1.Text = ("");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }

}

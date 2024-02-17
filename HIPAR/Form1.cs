using System.Diagnostics;
namespace HIPAR
{
    public partial class Form1 : Form
    {
        int prog = 0;
        // 0 = basic
        // 1 = first process
        // -1 = GTFO
        // 3 = search
        // -5 = standart process
        // Arigtonyte
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // STANDARTS --
            if (prog == -5)
            {
                label2.Text = ("What process would you like to start?");
                textBox1.Text = ("");
                prog = 2;
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.DimGray;
            }
            if (textBox1.Text == ("exit"))
            {
                this.Close();
            }

            if (prog == 0)
            {
                if (textBox1.Text == ("start"))
                {

                    label2.Text = ("Starting a process.\n Is that what you desire?\n (Y/N)");
                    textBox1.Text = ("");
                    prog = 1;


                }
            }
            // --
            if (prog == 1)
            {
                if (textBox1.Text == ("Y") || textBox1.Text == ("y"))
                {

                    label2.Text = ("What process would you like to start?");
                    textBox1.Text = ("");
                    prog = 2;


                }

            }
            if (prog == 1)
            {
                if (textBox1.Text == ("N") || textBox1.Text == ("n"))
                {

                    label2.Text = ("GTFO then...");
                    textBox1.Text = ("");
                    prog = -1;


                }

            }

            if (prog == 3)
            {


                label2.Text = ("Knowledgee on that topic \ndoesn't seem to be on our database. \n Check out The Arigtonyte Framework databse\n for more information on the search process.");
                textBox1.Text = ("");

                prog = -5;




            }
            if (prog == 4)
            {
                if (textBox1.Text == ("nah id win"))
                {

                    label2.Text = ("*dies*");
                    textBox1.Text = ("");



                }

            }
            // DELAY MAKERS --
            if (label2.Text == ("Follow your heart.\n And you'll find\n What's right."))
            {
                prog = -5;
            }
            if (label2.Text == ("HIPAR \r\n(Highly Intelligent Processing Arigtonyte Result).\r\nA Highly intelligent processing system based on\r\nThe Arygtonite Framework\r\n"))
            {
                prog = -5;
            }
            if (label2.Text == ("https://www.who.int/news-room/fact-sheets/detail/suicide"))
            {
                prog = -5;
            }
            if (label2.Text == ("*dies*"))
            {
                prog = -5;
            }
            if (label2.Text == ("What would you like to search for?"))
            {
                prog = 3;
            }
            if (label2.Text == ("Knowledgee on that topic \ndoesn't seem to be on our database. \n Check out The Arigtonyte Framework databse\n for more information on the search process."))
            {
                prog = -5;
            }
            // --
            // Process --
            if (prog == 2)
            {
                if (textBox1.Text == ("process: search"))
                {

                    label2.Text = ("What would you like to search for?");
                    textBox1.Text = ("");



                }

            }
            if (prog == 2)
            {
                if (textBox1.Text == ("process: lobotomy"))
                {
                    Process.Start(new ProcessStartInfo { FileName = @"https://www.youtube.com/watch?v=rczDieh3_ng&ab_channel=NewAnime", UseShellExecute = true });
                    label2.Text = ("THROUGHOUT HEAVENS AND EARTH\nI ALONE AM THE MOST\nINTELLIGENT");
                    textBox1.Text = ("");
                    prog = 4;


                }

            }
            if (prog == 2)
            {
                if (textBox1.Text == ("process: info"))
                {

                    label2.Text = ("HIPAR \r\n(Highly Intelligent Processing Arigtonyte Result).\r\nA Highly intelligent processing system based on\r\nThe Arygtonite Framework\r\n");
                    textBox1.Text = ("");



                }

            }
            if (prog == 2)
            {
                if (textBox1.Text == ("process: hisui"))
                {
                    Process.Start(new ProcessStartInfo { FileName = @"https://www.who.int/news-room/fact-sheets/detail/suicide", UseShellExecute = true });

                    label2.Text = ("https://www.who.int/news-room/fact-sheets/detail/suicide");
                    textBox1.Text = ("");
                    label2.ForeColor = Color.Blue;



                }

            }
            if (prog == 2)
            {
                if (textBox1.Text == ("process: knowledge"))
                {
                    Process.Start(new ProcessStartInfo { FileName = @"https://rezero.fandom.com/wiki/Rem", UseShellExecute = true });

                    label2.Text = ("Follow your heart,\nAnd you'll find,\nWhat's right,");
                    textBox1.Text = ("");
                    label2.ForeColor = Color.Aqua;
                    label2.BackColor = Color.Blue;



                }

            }
            if (prog == 2)
            {
                if (textBox1.Text == ("process: directory"))
                {
                    openFileDialog1.ShowDialog();
                    label2.Text = ("Directory loaded");
                    textBox1.Text = ("");



                }

                // --
            }
        }
    }
}

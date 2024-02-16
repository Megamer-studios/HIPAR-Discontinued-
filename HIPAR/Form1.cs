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
                if (textBox1.Text == ("Y") || textBox1.Text  == ("y"))
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
            if (prog == 2)
            {
                if (textBox1.Text == ("process: search"))
                {

                    label2.Text = ("What would you like to search for?");
                    textBox1.Text = ("");



                }

            }
            if (prog == 3)
            {


                    label2.Text = ("Knowledgee on that topic \ndoesn't seem to be on our database. \n Check out The Arigtonyte Framework databse\n for more information on the search process.");
                    textBox1.Text = ("");

                    prog = -5;


                

            }
            // DELAY MAKERS --

            if (label2.Text == ("What would you like to search for?"))
            {
                prog = 3;
            }
            if (label2.Text == ("Knowledgee on that topic \ndoesn't seem to be on our database. \n Check out The Arigtonyte Framework databse\n for more information on the search process."))
            {
                prog = -5;
            }
            // --

        }
    }
}

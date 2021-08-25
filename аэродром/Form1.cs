using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Краснов Никита М80-203Б-19
 * Лабораторная № 6 */
namespace аэродром
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public int time;
        public int s;
        public int m;
        public int h;
        public bool day;


        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        private void Form1_load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s + 1;
            if (h > 0 && h < 12)
            {
                day = false;
            }
            if (h > 12 )
            {
                day = true;
            }
            if (s >= 60)
            {
                m = m + 1;
                s = 0;
            }
            if (m >= 60)
            {
                h = h + 1;
                m = 0;
            }
            if(h == 24)
            {
                h = 0;
                m = 0;
                s = 0;
            }
            label1.Text = s.ToString();
            label2.Text = m.ToString();
            label3.Text = h.ToString();
            
            if (h != -1)
            {
                textBox2.BackColor = Color.FromArgb(131, 209, 254);
                textBox3.BackColor = Color.FromArgb(131, 209, 254);
                textBox7.BackColor = Color.FromArgb(131, 209, 254);
                textBox4.BackColor = Color.FromArgb(131, 209, 254);
                textBox5.BackColor = Color.FromArgb(131, 209, 254);
                textBox6.BackColor = Color.FromArgb(131, 209, 254);
                textBox8.BackColor = Color.FromArgb(105, 255, 148);
                textBox9.BackColor = Color.FromArgb(105, 255, 148);
                textBox12.BackColor = Color.FromArgb(105, 255, 148);
                textBox11.BackColor = Color.FromArgb(105, 255, 148);
            }
            if ((h >= 18 && m > 19 && day == true))
            {
                textBox2.BackColor = Color.FromArgb(63, 93, 255);
                textBox3.BackColor = Color.FromArgb(63, 93, 255);
                textBox7.BackColor = Color.FromArgb(63, 93, 255);
                textBox4.BackColor = Color.FromArgb(63, 93, 255);
                textBox5.BackColor = Color.FromArgb(63, 93, 255);
                textBox6.BackColor = Color.FromArgb(63, 93, 255);
                textBox8.BackColor = Color.FromArgb(0, 215, 15);
                textBox9.BackColor = Color.FromArgb(0, 215, 15);
                textBox12.BackColor = Color.FromArgb(0, 215, 15);
                textBox11.BackColor = Color.FromArgb(0, 215, 15);

            }
            if ((h >= 18 && m > 39 && day == true))
            {
                textBox2.BackColor = Color.FromArgb(42, 38, 243);
                textBox3.BackColor = Color.FromArgb(42, 38, 243);
                textBox7.BackColor = Color.FromArgb(42, 38, 243);
                textBox4.BackColor = Color.FromArgb(42, 38, 243);
                textBox5.BackColor = Color.FromArgb(42, 38, 243);
                textBox6.BackColor = Color.FromArgb(42, 38, 243);
                textBox8.BackColor = Color.FromArgb(0, 138, 0);
                textBox9.BackColor = Color.FromArgb(0, 138, 0);
                textBox12.BackColor = Color.FromArgb(0, 138, 0);
                textBox11.BackColor = Color.FromArgb(0, 138, 0);
            }
            if (h >= 19 && day ==true)
            {
                textBox2.BackColor = Color.FromArgb(22, 31, 151);
                textBox3.BackColor = Color.FromArgb(22, 31, 151);
                textBox7.BackColor = Color.FromArgb(22, 31, 151);
                textBox4.BackColor = Color.FromArgb(22, 31, 151);
                textBox5.BackColor = Color.FromArgb(22, 31, 151);
                textBox6.BackColor = Color.FromArgb(22, 31, 151);
                textBox8.BackColor = Color.FromArgb(0, 110, 0);
                textBox9.BackColor = Color.FromArgb(0, 110, 0);
                textBox12.BackColor = Color.FromArgb(0,110,0);
                textBox11.BackColor = Color.FromArgb(0, 110, 0);
            }
            if (h >= 0 && day == false)
            {
                textBox2.BackColor = Color.FromArgb(22, 31, 151);
                textBox3.BackColor = Color.FromArgb(22, 31, 151);
                textBox7.BackColor = Color.FromArgb(22, 31, 151);
                textBox4.BackColor = Color.FromArgb(22, 31, 151);
                textBox5.BackColor = Color.FromArgb(22, 31, 151);
                textBox6.BackColor = Color.FromArgb(22, 31, 151);
                textBox8.BackColor = Color.FromArgb(0, 110, 0);
                textBox9.BackColor = Color.FromArgb(0, 110, 0);
                textBox12.BackColor = Color.FromArgb(0, 110, 0);
                textBox11.BackColor = Color.FromArgb(0, 110, 0);
            }
            if (h >= 6 && day == false)
            {
                textBox2.BackColor = Color.FromArgb(42, 38, 243);
                textBox3.BackColor = Color.FromArgb(42, 38, 243);
                textBox7.BackColor = Color.FromArgb(42, 38, 243);
                textBox4.BackColor = Color.FromArgb(42, 38, 243);
                textBox5.BackColor = Color.FromArgb(42, 38, 243);
                textBox6.BackColor = Color.FromArgb(42, 38, 243);
                textBox8.BackColor = Color.FromArgb(0, 138, 0);
                textBox9.BackColor = Color.FromArgb(0, 138, 0);
                textBox12.BackColor = Color.FromArgb(0, 138, 0);
                textBox11.BackColor = Color.FromArgb(0, 138, 0);
            }
            if ( h >= 6 && m >= 30 && day == false)
            {
                textBox2.BackColor = Color.FromArgb(63, 93, 255);
                textBox3.BackColor = Color.FromArgb(63, 93, 255);
                textBox7.BackColor = Color.FromArgb(63, 93, 255);
                textBox4.BackColor = Color.FromArgb(63, 93, 255);
                textBox5.BackColor = Color.FromArgb(63, 93, 255);
                textBox6.BackColor = Color.FromArgb(63, 93, 255);
                textBox8.BackColor = Color.FromArgb(0, 215, 15);
                textBox9.BackColor = Color.FromArgb(0, 215, 15);
                textBox12.BackColor = Color.FromArgb(0, 215, 15);
                textBox11.BackColor = Color.FromArgb(0, 215, 15);
            }
            if (h >= 6 && m >= 50 && day == false)
            {
                textBox2.BackColor = Color.FromArgb(131, 209, 254);
                textBox3.BackColor = Color.FromArgb(131, 209, 254);
                textBox7.BackColor = Color.FromArgb(131, 209, 254);
                textBox4.BackColor = Color.FromArgb(131, 209, 254);
                textBox5.BackColor = Color.FromArgb(131, 209, 254);
                textBox6.BackColor = Color.FromArgb(131, 209, 254);
                textBox8.BackColor = Color.FromArgb(105, 255, 148);
                textBox9.BackColor = Color.FromArgb(105, 255, 148);
                textBox12.BackColor = Color.FromArgb(105, 255, 148);
                textBox11.BackColor = Color.FromArgb(105, 255, 148);
            }
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            timer.Enabled = false;
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox2.BackColor = Color.FromArgb(255, 255, 255);
            textBox3.BackColor = Color.FromArgb(255, 255, 255);
            textBox7.BackColor = Color.FromArgb(255, 255, 255);
            textBox4.BackColor = Color.FromArgb(255, 255, 255);
            textBox5.BackColor = Color.FromArgb(255, 255, 255);
            textBox6.BackColor = Color.FromArgb(255, 255, 255);
            textBox8.BackColor = Color.FromArgb(255, 255, 255);
            textBox9.BackColor = Color.FromArgb(255, 255, 255);
            textBox12.BackColor = Color.FromArgb(255, 255, 255);
            textBox11.BackColor = Color.FromArgb(255, 255, 255);

        }

        
        

        private void button3_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox13.Text);
            m = Convert.ToInt32(textBox14.Text);
            s = Convert.ToInt32(textBox15.Text);
            timer.Enabled = true;
            timer.Start();
        }
    }
}

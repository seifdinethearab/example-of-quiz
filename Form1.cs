using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.sottofondo;
            SoundPlayer my_sound = new SoundPlayer(str);
            my_sound.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stream str = Properties.Resources.sottofondo;
            SoundPlayer my_sound = new SoundPlayer(str);
            my_sound.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "MUSIC OFF";
                Stream str = Properties.Resources.sottofondo;
                SoundPlayer my_sound = new SoundPlayer(str);
                my_sound.Stop();
            }

            else
            {
               checkBox1.Text = "MUSIC ON";
                Stream str = Properties.Resources.sottofondo;
                SoundPlayer my_sound = new SoundPlayer(str);
                my_sound.Stop();
                my_sound.PlayLooping();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play objplay = new play();
            this.Hide();
            objplay.Show();
        }

        private void creditike(object sender, EventArgs e)
        {
            creditiForm crediti = new creditiForm();
            crediti.Tag = this;
            crediti.Show(this);
            Hide();
        }
    }
}

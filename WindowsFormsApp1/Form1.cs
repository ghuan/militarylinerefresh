using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.checkBox2.Checked = false;
            }
            else
            {
                this.checkBox1.Checked = true;
            }

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.checkBox1.Checked = false;
            }
            else
            {
                this.checkBox2.Checked = true;
            }
            //MessageBox.Show(this.checkBox2.Checked.ToString());
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.Equals("游戏开始"))
            {
                
                this.button1.Text = "游戏结束";
                this.ms = 11;
                this.zms = 1;
                this.label3.Text = "11秒";
                this.label4.Text = "0时0分1秒";
                
                this.timer.Start();

            }
            else {
                this.button1.Text = "游戏开始";
                this.ms = 0;
                this.zms = 0;
                this.label3.Text = "0秒";
                this.label4.Text = "0时0分0秒";
                this.timer.Stop();
                //if (this.isplay == 1) {
               //     this.playSound5.Stop();
               // }
               
                
            }
        }
        private void startGame(object sender, EventArgs e) {
            if (this.ms == 0)
            {
                if (this.tag == 1)
                {
                    this.timer.Interval = 960D;
                    this.tag = 0;
                }
                else {
                    this.timer.Interval = 980D;
                    this.tag = 1;
                }
                this.ms = 33;
            }
            else {
                this.ms = this.ms - 1;
                
            }
            this.zms = this.zms + 1;

            int hour = this.zms / 3600;
            int min = (this.zms - hour * 3600) / 60;
            int t = (this.zms - hour * 3600 - min * 60);
            this.label3.Text = this.ms + "秒";
            this.label4.Text = hour + "时" + min + "分" + t + "秒";
            if (this.checkBox1.Checked) {
                if (this.ms == 6) {
                    this.isplay = 1;
                    this.speaker.SpeakAsync("还有5秒");
                }
                if (this.ms == 0 && this.isplay == 1) {
                    this.isplay = 0;
                    //this.playSound5.Stop();
                }
            } else if (this.checkBox2.Checked) {
                if (this.ms == 11)
                {
                    this.isplay = 1;
                    this.speaker.SpeakAsync("还有10秒");
                }
                if (this.ms == 5 && this.isplay == 1)
                {
                    this.isplay = 0;
                   // this.playSound10.Stop();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.button1.Text == "游戏结束") {
                this.zms = this.zms + 1;
                this.ms = this.ms - 1;
                if (this.ms == 0)
                {
                    this.ms = 33;
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "游戏结束")
            {
                
                
                if (this.zms == 0)
                {
                    this.zms = 0; 
                }
                else {
                    this.zms = this.zms - 1;
                }
                if (this.ms == 33)
                {
                    this.ms = 33;
                }
                else {
                    this.ms = this.ms + 1;
                }

            }

        }
    }
}

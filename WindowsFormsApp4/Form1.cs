using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public int food = 0;
        public int happines = 0;
        public int purity = 0;
        public int health = 0;
        public int experience = 0;
        private int counter;
        int x = 100;
        int level = 1;
        void ExperienceChanged()
        {
            label1.Text = "Уровень:" + Convert.ToString(level);
            label2.Text = "Опыт:" + Convert.ToString(experience) + "/" + Convert.ToString(progressBar5.Maximum);
        }

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }



        public Form1()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)//еда
        {
            if (progressBar2.Value < 100)
            {
                food += 20;
                progressBar2.Maximum = 100;
                progressBar2.Minimum = 0;
                progressBar2.Step = 1;
                progressBar2.Value += 20;

                if (experience <= x - 5)
                {
                    experience += 5;
                    progressBar5.Value += 5;
                }
                ExperienceChanged();

            }
            else
            {
                progressBar2.Value = 100;
            }

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = 0;

            /* timer1.Interval = 1000;
             timer1.Tick += new EventHandler(timer1_Tick);
             timer1.Enabled = true;
             progressBar2.Value -= 20;
             */
            if (counter >= 10)
            {
                timer1.Enabled = false;
                counter = 0;
            }
            else
            {
                counter += 1;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ExperienceChanged();
        }

        private void button5_Click(object sender, EventArgs e)//помыть
        {
            if (progressBar3.Value < 100)
            {
                purity += 20;
                progressBar3.Maximum = 100;
                progressBar3.Minimum = 0;
                progressBar3.Step = 1;
                progressBar3.Value += 20;

                if (experience <= x - 5)
                {
                    experience += 5;
                    progressBar5.Value += 5;
                }
                ExperienceChanged();
            }
            else
            {
                progressBar3.Value = 100;
            }
        }

        private void button6_Click(object sender, EventArgs e)//погладить
        {
            if (progressBar4.Value < 100)
            {
                happines += 20;
                progressBar4.Maximum = 100;
                progressBar4.Minimum = 0;
                progressBar4.Step = 1;
                progressBar4.Value += 20;

                if (experience <= x - 5)
                {
                    experience += 5;
                    progressBar5.Value += 5;
                }
                ExperienceChanged();

            }
            else
            {
                progressBar4.Value = 100;
            }
        }

        private void button7_Click(object sender, EventArgs e)//выгулять
        {
            if (progressBar2.Value > 0)
            {
                food -= 20;
                progressBar2.Value -= 20;


            }
            else
            {
                progressBar2.Value = 0;
            }

            if (progressBar4.Value < 80)
            {
                happines += 40;
                progressBar4.Value += 40;

                if (experience <= x - 5)
                {
                    experience += 5;
                    progressBar5.Value += 5;
                }
                progressBar5.Value += 5;
                ExperienceChanged();

            }
            else
            {
                progressBar4.Value = 100;
            }
        }

        private void button8_Click(object sender, EventArgs e)//таблетки
        {
            if (progressBar1.Value < 100)//здоровье
            {
                health += 20;
                progressBar1.Maximum = 100;
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                progressBar1.Value += 20;

                if (experience <= x - 5)
                {
                    experience += 5;
                    progressBar5.Value += 5;
                }
                ExperienceChanged();

            }
            else
            {
                progressBar1.Value = 100;
            }
        }




        private void progressBar5_Click(object sender, EventArgs e)//опыт
        {

            progressBar5.Maximum = x;
            progressBar5.Minimum = 0;
            progressBar5.Step = 1;

            if (experience < x)
            {
                progressBar5.Value += 5;
            }
            else
            {
                experience = x;
                progressBar5.Value = x;
            }
            if (experience == x)
            {
                x = x * 2;
                level += 1;
                progressBar5.Maximum = x;
                experience = 0;
                progressBar5.Value = experience;

            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.BalloonTipTitle = "Программа была спрятана";
                notifyIcon1.BalloonTipText = "Обратите внимание что программа была спрятана в трей и продолжит свою работу.";
                notifyIcon1.ShowBalloonTip(5000); // Параметром указываем количество миллисекунд, которое будет показываться подсказка
            }
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;

        }







        private void label1_Click(object sender, EventArgs e)//уровень
        {


        }

        private void label2_Click(object sender, EventArgs e)//опыт
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }
    }
}

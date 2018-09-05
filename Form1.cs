using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();

            if (cityBox.Text == "Los Angeles, USA")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(-7).ToString();
            }

            if (cityBox.Text == "New York, USA")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(-4).ToString();
            }

            if (cityBox.Text == "London, UK")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+1).ToString();
            }

            if (cityBox.Text == "Paris, France")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Berlin, Germany")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Stockholm, Sweden")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Athens, Greece")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+3).ToString();
            }

            if (cityBox.Text == "Moscow, Russia")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+3).ToString();
            }

            if (cityBox.Text == "Tehran, Iran")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+4.5).ToString();
            }

            if (cityBox.Text == "New Delhi, India")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+5.5).ToString();
            }

            if (cityBox.Text == "Beijing, China")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+8).ToString();
            }

            if (cityBox.Text == "Tokyo, Japan")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+9).ToString();
            }

            if (cityBox.Text == "Sydney, Australia")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if(currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            timer.Start();
            Status.Text = "Set..";
        }

        private void CancelAlarm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SoundPlayer player = new SoundPlayer();
            player.Stop();
            Status.Text = "Stopped!!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cityBox.Text == "Los Angeles, USA")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(-7).ToString();
            }

            if (cityBox.Text == "New York, USA")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(-4).ToString();
            }
            
            if (cityBox.Text == "London, UK")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+1).ToString();
            }
            
            if (cityBox.Text == "Paris, France")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Berlin, Germany")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Stockholm, Sweden")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+2).ToString();
            }

            if (cityBox.Text == "Athens, Greece")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+3).ToString();
            }

            if (cityBox.Text == "Moscow, Russia")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+3).ToString();
            }

            if (cityBox.Text == "Tehran, Iran")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+4.5).ToString();
            }

            if (cityBox.Text == "New Delhi, India")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+5.5).ToString();
            }

            if (cityBox.Text == "Beijing, China")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+8).ToString();
            }

            if (cityBox.Text == "Tokyo, Japan")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+9).ToString();
            }

            if (cityBox.Text == "Sydney, Australia")
            {
                worldClock.Text = DateTime.UtcNow.AddHours(+10).ToString();
            }
        }
    }
}

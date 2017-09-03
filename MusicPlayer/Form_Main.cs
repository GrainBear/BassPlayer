using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form_Main : Form
    {
        BassHelper bh;
        public Form_Main() {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e) {
            bh = new BassHelper();
            bh.LoadSound(@"F:\音乐\Highland - Solo Tu.mp3");
            bh.ChangeFFT += show;
        }

        private void button1_Click(object sender, EventArgs e) {
            progressBarControl1.Properties.Maximum = Convert.ToInt32(bh.Duration);
            bh.Play();
        }
        float max;
        private void show(float[] fft) {
            
            if (max < fft[2]) {
                max=fft[2];
            }
            textBox1.Invoke(new Action(() => {
                textBox1.Text = max + "," + (fft[2]).ToString();
                progressBarControl1.Position = Convert.ToInt32(bh.CurrentTime);
                if (fft[2] > 0.2) {
                    label1.BackColor = Color.Red;
                }else {
                    label1.BackColor = Color.Chartreuse;
                }
            }));
            
        }
        private void button2_Click(object sender, EventArgs e) {
            bh.Pause();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e) {
            bh.Disponse();
        }

        #region 标题栏操作
        private void Button_Close_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void Button_Min_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        Point offset;
        private void label_Title_MouseDown(object sender, MouseEventArgs e) {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void label_Title_MouseMove(object sender, MouseEventArgs e) {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - 30 - offset.X, cur.Y - offset.Y);
        }
        #endregion
    }
}

using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace csrLogViewer
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        } 

        public static string path2log = "";
        public static string logseed = "";
        public static string logsettings = "";

        public static string wlocation;

        whereis _whereis = new whereis();
        whatis _whatis = new whatis();
        isxy _isxy = new isxy();

        private void dirbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                kiisseli(dialog.FileName);
            }
        }

        private void start_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            kiisseli(fileList[0]);
        }
        private void logpath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kiisseli(logpath.Text);
            }
        }

        public void kiisseli(string logtxt)
        {
            if (logtxt.EndsWith("log.txt"))
            {
                string[] loglines = File.ReadAllLines(logtxt);

                String seeds = loglines[2];
                string[] logsettings2 = loglines[1].Split(':');

                int sFrom = seeds.IndexOf("NOTICE: Offering seed \"") + "NOTICE: Offering seed \"".Length;
                int sTo = seeds.LastIndexOf("\" to RNGesus");

                logseed = seeds.Substring(sFrom, sTo - sFrom);
                logsettings = logsettings2[2];

                path2log = logtxt.ToString();

                logpath.Text = path2log;

                seedseed.Text = "Seed: " + logseed;
                seedsettings.Text = "Settings: " + logsettings;

                whereis.Enabled = true;
                whatis.Enabled = true;
                isxy.Enabled = true;
            } else
            {
                MessageBox.Show("Please select the \"log.txt\" file.", "Wrong file");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _whereis.StartPosition = FormStartPosition.Manual;
            _whereis.Location = this.Location;
            _whereis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _whatis.StartPosition = FormStartPosition.Manual;
            _whatis.Location = this.Location;
            _whatis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _isxy.StartPosition = FormStartPosition.Manual;
            _isxy.Location = this.Location;
            _isxy.Show();
        }

        private void start_Load(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string dragtoexe = Environment.GetCommandLineArgs()[1];
                if (dragtoexe != null)
                    kiisseli(dragtoexe);
            }

            if (path2log.Length > 0)
            {
                logpath.Text = path2log;
                kiisseli(path2log);
                whereis.Enabled = true;
                whatis.Enabled = true;
                isxy.Enabled = true;
            } else
            {
                whereis.Enabled = false;
                whatis.Enabled = false;
                isxy.Enabled = false;
            }

        }

        private void start_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("csrLogViewer");
            processes[0].Kill();
        }
    }
}

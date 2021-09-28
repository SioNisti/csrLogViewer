using System;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;
using Directory = System.IO.Directory;
using System.IO;

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

        whereis _whereis = new whereis();
        //whereis _whereis = new whereis();
        //whereis _whereis = new whereis();

        private void dirbtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path2log = dialog.FileName;
                logpath.Text = dialog.FileName;

                string[] loglines = File.ReadAllLines(path2log);

                String seeds = loglines[2];

                int sFrom = seeds.IndexOf("NOTICE: Offering seed \"") + "NOTICE: Offering seed \"".Length;
                int sTo = seeds.LastIndexOf("\" to RNGesus");

                logseed = seeds.Substring(sFrom, sTo - sFrom);

                seed.Text = "Seed: "+ logseed;

                whereis.Enabled = true;
                whatis.Enabled = true;
                isxy.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _whereis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {
            whereis.Enabled = false;
            whatis.Enabled = false;
            isxy.Enabled = false;
            
        }

        private void logpath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] loglines = File.ReadAllLines(logpath.Text);

                String seeds = loglines[2];

                int sFrom = seeds.IndexOf("NOTICE: Offering seed \"") + "NOTICE: Offering seed \"".Length;
                int sTo = seeds.LastIndexOf("\" to RNGesus");

                logseed = seeds.Substring(sFrom, sTo - sFrom);

                path2log = logpath.Text;

                seed.Text = "Seed: " + logseed;

                whereis.Enabled = true;
                whatis.Enabled = true;
                isxy.Enabled = true;
            }
        }
    }
}

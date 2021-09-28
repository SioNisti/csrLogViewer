using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csrLogViewer
{
    public partial class whatis : Form
    {
        public whatis()
        {
            InitializeComponent();
        }

        private void whatis_Load(object sender, EventArgs e)
        {

        }

        private void whatbtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(start.path2log + "\n----------------------------------------");
            if (lioflo.Text != "")
            {
                itemlocation.Text = Find(lioflo.Text + ":");
            }
        }
        public static string Find(string item)
        {
            string[] loglines = File.ReadAllLines(start.path2log);

            int x = 0;
            string output = "";
            while (x < loglines.Length)
            {
                Debug.WriteLine("\n" + loglines[x].Contains(item) + "\n");
                if (loglines[x].Contains(item))
                {
                    output = loglines[x].Split(':')[2];
                    break;
                }
                x++;
                Debug.WriteLine(x);
            }
            return output;
        }

        private void whatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            start start = new start();
            start.Show();
        }
    }
}

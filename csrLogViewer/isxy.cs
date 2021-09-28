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
    public partial class isxy : Form
    {
        public isxy()
        {
            InitializeComponent();
        }

        private void isbtn_Click(object sender, EventArgs e)
        {
            if (lioflo.Text != "" || liofit.Text != "")
            {
                label1.Text = Find(lioflo.Text, liofit.Text);
            }
        }
        public static string Find(string location, string item)
        {
            string[] loglines = File.ReadAllLines(start.path2log);

            int x = 0;
            string output = "";
            while (x < loglines.Length)
            {
                Debug.WriteLine("\n" + loglines[x].Contains(location) + "\n");
                if (loglines[x].Contains(location))
                {
                    output = loglines[x];
                    Debug.WriteLine(output);
                    break;
                }
                x++;
                Debug.WriteLine(x);
            }

            Debug.WriteLine("\n" + output.EndsWith(item) + "\n");
            switch (output.Contains(item))
            {
                case true:
                    output = "Yes";
                    break;

                case false:
                    output = "No";
                    break;
            }
            return output;
        }

        private void isxy_FormClosing(object sender, FormClosingEventArgs e)
        {
            start start = new start();
            start.Show();
        }
    }
}

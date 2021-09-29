using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace csrLogViewer
{
    public partial class whereis : Form
    {
        public whereis()
        {
            InitializeComponent();
        }

        private void whereis_Load(object sender, EventArgs e)
        {

        }

        private void wherebtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(start.path2log + "\n----------------------------------------");
            if (liofit.Text != "")
            {
                switch (liofit.Text)
                {
                    default:
                        itemlocation.Text = Find(": " + liofit.Text, 0);
                        break;

                    case "Booster (Progressive 1)":
                        itemlocation.Text = Find(": Booster", 0);
                        break;

                    case "Booster (Progressive 2)":
                        itemlocation.Text = Find(": Booster", 1);
                        break;

                    case "Polar Star (Progressive 1)":
                        itemlocation.Text = Find(": Polar Star", 0);
                        break;

                    case "Polar Star (Progressive 2)":
                        itemlocation.Text = Find(": Polar Star", 1);
                        break;

                    case "Missile Launcher":
                        itemlocation.Text = Find(": Missile Launcher", 0);
                        break;

                    case "Missile Expansion 1":
                        itemlocation.Text = Find(": Missile Expansion", 0);
                        break;

                    case "Missile Expansion 2":
                        itemlocation.Text = Find(": Missile Expansion", 1);
                        break;

                    case "Missile Expansion 3":
                        itemlocation.Text = Find(": Missile Expansion", 2);
                        break;

                    case "Missile Expansion 4":
                        itemlocation.Text = Find(": Missile Expansion", 3);
                        break;

                    case "Life Capsule 1":
                        itemlocation.Text = Find(": Life Capsule", 0);
                        break;

                    case "Life Capsule 2":
                        itemlocation.Text = Find(": Life Capsule", 1);
                        break;

                    case "Life Capsule 3":
                        itemlocation.Text = Find(": Life Capsule", 2);
                        break;

                    case "Life Capsule 4":
                        itemlocation.Text = Find(": Life Capsule", 3);
                        break;

                    case "Life Capsule 5":
                        itemlocation.Text = Find(": Life Capsule", 4);
                        break;

                    case "Life Capsule 6":
                        itemlocation.Text = Find(": Life Capsule", 5);
                        break;

                    case "Life Capsule 7":
                        itemlocation.Text = Find(": Life Capsule", 6);
                        break;

                    case "Life Capsule 8":
                        itemlocation.Text = Find(": Life Capsule", 7);
                        break;

                    case "Life Capsule 9":
                        itemlocation.Text = Find(": Life Capsule", 8);
                        break;

                    case "Life Capsule 10":
                        itemlocation.Text = Find(": Life Capsule", 9);
                        break;

                    case "Life Capsule 11":
                        itemlocation.Text = Find(": Life Capsule", 10);
                        break;

                    case "Life Capsule 12":
                        itemlocation.Text = Find(": Life Capsule", 11);
                        break;
                }
            }
        }

        public static string Find(string item, int multiple)
        {
            string[] loglines = File.ReadAllLines(start.path2log);

            int x = 0;
            string output = "";
            if (multiple == 0)
            {
                while (x < loglines.Length)
                {
                    Debug.WriteLine("\n" + loglines[x].EndsWith(item) + "\n");
                    if (loglines[x].EndsWith(item))
                    {
                        output = loglines[x].Split(':')[1];
                        break;
                    }
                    x++;
                    Debug.WriteLine(x);
                }
            }
            else
            {
                int y = 0;
                while (x < loglines.Length)
                {
                    Debug.WriteLine("\n" + loglines[x].EndsWith(item) + "\n");
                    if (y < multiple)
                    {
                        if (loglines[x].EndsWith(item))
                        {
                            y++;
                        }
                    }
                    else if (loglines[x].EndsWith(item) && y == multiple)
                    {
                        output = loglines[x].Split(':')[1];
                        break;
                    }
                    x++;
                    Debug.WriteLine(x);
                }
            }
            return output;
        }

        private void whereis_FormClosing(object sender, FormClosingEventArgs e)
        {
            start start = new start();
            start.StartPosition = FormStartPosition.Manual;
            start.Location = this.Location;
            start.Show();
        }
    }
}

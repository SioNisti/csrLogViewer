using System;
using System.Diagnostics;
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
            switch (liofit.Text)
            {
                case "Arthur's Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Santa's Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Rusty Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Gum Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Clinic Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Teleporter Room Key":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Silver Locket":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "ID Card":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Jellyfish Juice":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Gum Base":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Charcoal":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Bomb":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Hajime":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Kakeru":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Mick":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Nene":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Shinobu":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Life Pot":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Sue's Letter":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Controller":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Broken Sprinkler":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Sprinkler":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Cure-All":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Tow Rope":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Mushroom Badge":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Ma Pignon":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Iron Bond":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Nikumaru Counter":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Booster (Progressive 1)":
                    itemlocation.Text = Find(": Booster", 0);
                    break;

                case "Booster (Progressive 2)":
                    itemlocation.Text = Find(": Booster", 1);
                    break;

                case "Mimiga Mask":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Curly's Air Tank":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Turbocharge":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Arms Barrier":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Whimsical Star":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Map System":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Alien Medal":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Clay Figure Medal":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Chaco's Lipstick":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Curly's Panties":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Little Man":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
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

                case "Super Missile Launcher":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Missile Expansion (Super Missile alt)":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Machine Gun":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Bubbler":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Fireball":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Snake":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Blade":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
                    break;

                case "Nemesis":
                    itemlocation.Text = Find(": " + liofit.Text, 0);
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
            start.Show();
        }
    }
}

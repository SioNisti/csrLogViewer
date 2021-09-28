
namespace csrLogViewer
{
    partial class whereis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whereis));
            this.liofit = new System.Windows.Forms.ComboBox();
            this.itemlocation = new System.Windows.Forms.Label();
            this.wherebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liofit
            // 
            this.liofit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liofit.FormattingEnabled = true;
            this.liofit.Items.AddRange(new object[] {
            "Arthur\'s Key",
            "Santa\'s Key",
            "Rusty Key",
            "Gum Key",
            "Clinic Key",
            "Teleporter Room Key",
            "Silver Locket",
            "ID Card",
            "Jellyfish Juice",
            "Gum Base",
            "Charcoal",
            "Bomb",
            "Hajime",
            "Kakeru",
            "Mick",
            "Nene",
            "Shinobu",
            "Life Pot",
            "Sue\'s Letter",
            "Controller",
            "Broken Sprinkler",
            "Sprinkler",
            "Cure-All",
            "Tow Rope",
            "Mushroom Badge",
            "Ma Pignon",
            "Iron Bond",
            "Nikumaru Counter",
            "Booster (Progressive 1)",
            "Booster (Progressive 2)",
            "Mimiga Mask",
            "Curly\'s Air Tank",
            "Turbocharge",
            "Arms Barrier",
            "Whimsical Star",
            "Map System",
            "Alien Medal",
            "Clay Figure Medal",
            "Chaco\'s Lipstick",
            "Curly\'s Panties",
            "Little Man",
            "Polar Star (Progressive 1)",
            "Polar Star (Progressive 2)",
            "Missile Launcher",
            "Missile Expansion 1",
            "Missile Expansion 2",
            "Missile Expansion 3",
            "Missile Expansion 4",
            "Super Missile Launcher",
            "Missile Expansion (Super Missile alt)",
            "Machine Gun",
            "Bubbler",
            "Fireball",
            "Snake",
            "Blade",
            "Nemesis",
            "Life Capsule 1",
            "Life Capsule 2",
            "Life Capsule 3",
            "Life Capsule 4",
            "Life Capsule 5",
            "Life Capsule 6",
            "Life Capsule 7",
            "Life Capsule 8",
            "Life Capsule 9",
            "Life Capsule 10",
            "Life Capsule 11",
            "Life Capsule 12"});
            this.liofit.Location = new System.Drawing.Point(93, 12);
            this.liofit.Name = "liofit";
            this.liofit.Size = new System.Drawing.Size(186, 21);
            this.liofit.TabIndex = 0;
            // 
            // itemlocation
            // 
            this.itemlocation.AutoSize = true;
            this.itemlocation.Location = new System.Drawing.Point(4, 35);
            this.itemlocation.Name = "itemlocation";
            this.itemlocation.Size = new System.Drawing.Size(67, 13);
            this.itemlocation.TabIndex = 2;
            this.itemlocation.Text = "who knows?";
            // 
            // wherebtn
            // 
            this.wherebtn.Location = new System.Drawing.Point(12, 12);
            this.wherebtn.Name = "wherebtn";
            this.wherebtn.Size = new System.Drawing.Size(75, 21);
            this.wherebtn.TabIndex = 3;
            this.wherebtn.Text = "Where is";
            this.wherebtn.UseVisualStyleBackColor = true;
            this.wherebtn.Click += new System.EventHandler(this.wherebtn_Click);
            // 
            // whereis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 57);
            this.Controls.Add(this.wherebtn);
            this.Controls.Add(this.itemlocation);
            this.Controls.Add(this.liofit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "whereis";
            this.Text = "csrLogViewer: Where is?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.whereis_FormClosing);
            this.Load += new System.EventHandler(this.whereis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox liofit;
        private System.Windows.Forms.Label itemlocation;
        private System.Windows.Forms.Button wherebtn;
    }
}
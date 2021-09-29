
namespace csrLogViewer
{
    partial class whatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(whatis));
            this.whatbtn = new System.Windows.Forms.Button();
            this.itemlocation = new System.Windows.Forms.Label();
            this.lioflo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // whatbtn
            // 
            this.whatbtn.Location = new System.Drawing.Point(12, 12);
            this.whatbtn.Name = "whatbtn";
            this.whatbtn.Size = new System.Drawing.Size(75, 21);
            this.whatbtn.TabIndex = 6;
            this.whatbtn.Text = "What is";
            this.whatbtn.UseVisualStyleBackColor = true;
            this.whatbtn.Click += new System.EventHandler(this.whatbtn_Click);
            // 
            // itemlocation
            // 
            this.itemlocation.AutoSize = true;
            this.itemlocation.Location = new System.Drawing.Point(4, 35);
            this.itemlocation.Name = "itemlocation";
            this.itemlocation.Size = new System.Drawing.Size(67, 13);
            this.itemlocation.TabIndex = 5;
            this.itemlocation.Text = "who knows?";
            // 
            // lioflo
            // 
            this.lioflo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lioflo.FormattingEnabled = true;
            this.lioflo.Items.AddRange(new object[] {
            "Tetsuzou",
            "Hermit Gunsmith Chest",
            "First Cave Life Capsule",
            "",
            "Mimiga Village Chest",
            "Reservoir",
            "Yamashita Farm",
            "Arthur\'s Grave",
            "Assembly Hall",
            "Storage? Chest",
            "Mr. Little (Graveyard)",
            "Ma Pignon Boss",
            "",
            "Professor Booster",
            "",
            "Basil Spot",
            "Cthulhu\'s Adobe",
            "Egg Chest",
            "Egg Observation Room Chest",
            "",
            "West Grasstown Floor",
            "Chaco\'s Bed, where you two Had A Nap",
            "Kulala Chest",
            "West Grasstown Ceiling",
            "Santa",
            "Santa\'s Fireplace",
            "",
            "Gum Chest",
            "Grasstown Hut",
            "Kazuma Crack",
            "Kazuma Chest",
            "Grasstown East Chest",
            "Execution Chamber",
            "MALCO",
            "",
            "Puppy (Curly)",
            "Curly\'s Closet",
            "Polish Spot",
            "Curly Boss",
            "",
            "Puppy (Chest)",
            "Puppy (Dark)",
            "Puppy (Sleep)",
            "Jenka",
            "Pawprint Spot",
            "Puppy (Run)",
            "King",
            "",
            "Labyrinth Life Capsule",
            "Puu Black Boss",
            "Chaba Chest (Machine Gun)",
            "Dr. Gero",
            "Chaba Chest  (Fireball)",
            "Chaba Chest (Spur)",
            "Camp Chest",
            "",
            "Booster Chest",
            "",
            "Boulder Chest",
            "Robot\'s Arm",
            "Drowned Curly",
            "",
            "Ironhead Boss",
            "",
            "Sisters Boss",
            "Dragon Chest",
            "",
            "Clock Room",
            "Little House",
            "",
            "Megane",
            "Chivalry Sakamoto\'s Wife",
            "Plantation Platforming Spot",
            "Itoh",
            "Jail no. 1",
            "Jammed it into Curly\'s Mouth",
            "Kanpachi\'s Bucket",
            "Broken Sprinkler",
            "Plantation Puppy",
            "",
            "Red Demon Boss",
            "",
            "Hell B1 Spot",
            "Hell B3 Chest"});
            this.lioflo.Location = new System.Drawing.Point(93, 12);
            this.lioflo.Name = "lioflo";
            this.lioflo.Size = new System.Drawing.Size(186, 21);
            this.lioflo.TabIndex = 4;
            // 
            // whatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 57);
            this.Controls.Add(this.whatbtn);
            this.Controls.Add(this.itemlocation);
            this.Controls.Add(this.lioflo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "whatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "csrLogViewer: What is?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.whatis_FormClosing);
            this.Load += new System.EventHandler(this.whatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button whatbtn;
        private System.Windows.Forms.Label itemlocation;
        private System.Windows.Forms.ComboBox lioflo;
    }
}
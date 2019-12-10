namespace DnD_SoloPlayers
{
    partial class SD_Custom_Quests
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
            this.Roll_Side_Quest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Side_Quest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Roll_Side_Quest
            // 
            this.Roll_Side_Quest.Location = new System.Drawing.Point(13, 13);
            this.Roll_Side_Quest.Name = "Roll_Side_Quest";
            this.Roll_Side_Quest.Size = new System.Drawing.Size(97, 23);
            this.Roll_Side_Quest.TabIndex = 0;
            this.Roll_Side_Quest.Text = "Roll Side Quest";
            this.Roll_Side_Quest.UseVisualStyleBackColor = true;
            this.Roll_Side_Quest.Click += new System.EventHandler(this.Roll_Side_Quest_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(13, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(350, 247);
            this.textBox1.TabIndex = 1;
            // 
            // Add_Side_Quest
            // 
            this.Add_Side_Quest.Location = new System.Drawing.Point(266, 325);
            this.Add_Side_Quest.Name = "Add_Side_Quest";
            this.Add_Side_Quest.Size = new System.Drawing.Size(97, 23);
            this.Add_Side_Quest.TabIndex = 2;
            this.Add_Side_Quest.Text = "Add Side Quest";
            this.Add_Side_Quest.UseVisualStyleBackColor = true;
            this.Add_Side_Quest.Click += new System.EventHandler(this.Add_Side_Quest_Click);
            // 
            // SD_Custom_Quests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 360);
            this.Controls.Add(this.Add_Side_Quest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Roll_Side_Quest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SD_Custom_Quests";
            this.Text = "Side Quests - Custom Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roll_Side_Quest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_Side_Quest;
    }
}
namespace DnD_SoloPlayers
{
    partial class Dungeon_Crawler
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new DungeonCrawler_UserControl.UserControl1();
            
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, -1);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1000, 670);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // Dungeon_Crawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.elementHost1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dungeon_Crawler";
            this.Text = "Random Combat";
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dungeon_Crawler_FormClosing1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dungeon_Crawler_FormClosed);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private DungeonCrawler_UserControl.UserControl1 userControl11;
    }
}
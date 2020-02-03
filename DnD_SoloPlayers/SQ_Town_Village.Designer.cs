namespace DnD_SoloPlayers
{
    partial class SQ_Town_Village
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.New_One = new System.Windows.Forms.Button();
            this.Accept_Quest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 426);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            // 
            // New_One
            // 
            this.New_One.Location = new System.Drawing.Point(285, 444);
            this.New_One.Name = "New_One";
            this.New_One.Size = new System.Drawing.Size(75, 23);
            this.New_One.TabIndex = 3;
            this.New_One.Text = "New one";
            this.New_One.UseVisualStyleBackColor = true;
            this.New_One.Click += new System.EventHandler(this.New_One_Click);
            // 
            // Accept_Quest
            // 
            this.Accept_Quest.Location = new System.Drawing.Point(433, 444);
            this.Accept_Quest.Name = "Accept_Quest";
            this.Accept_Quest.Size = new System.Drawing.Size(86, 23);
            this.Accept_Quest.TabIndex = 4;
            this.Accept_Quest.Text = "Accept Quest";
            this.Accept_Quest.UseVisualStyleBackColor = true;
            this.Accept_Quest.Click += new System.EventHandler(this.Accept_Quest_Click);
            // 
            // SQ_Town_Village
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.Accept_Quest);
            this.Controls.Add(this.New_One);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SQ_Town_Village";
            this.Text = "Side Quests - Town / Village";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button New_One;
        private System.Windows.Forms.Button Accept_Quest;
    }
}
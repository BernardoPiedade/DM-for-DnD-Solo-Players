namespace DnD_SoloPlayers
{
    partial class NPC_CustomSearch
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
            this.Search_NPC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Keywords_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(15, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 247);
            this.textBox1.TabIndex = 9;
            // 
            // Search_NPC
            // 
            this.Search_NPC.Location = new System.Drawing.Point(271, 73);
            this.Search_NPC.Name = "Search_NPC";
            this.Search_NPC.Size = new System.Drawing.Size(75, 23);
            this.Search_NPC.TabIndex = 8;
            this.Search_NPC.Text = "Search";
            this.Search_NPC.UseVisualStyleBackColor = true;
            this.Search_NPC.Click += new System.EventHandler(this.Search_NPC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ex: \"goblin,fighter\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add keywords separated by a comma.";
            // 
            // Keywords_Input
            // 
            this.Keywords_Input.Location = new System.Drawing.Point(15, 73);
            this.Keywords_Input.Name = "Keywords_Input";
            this.Keywords_Input.Size = new System.Drawing.Size(250, 20);
            this.Keywords_Input.TabIndex = 5;
            // 
            // NPC_CustomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_NPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keywords_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NPC_CustomSearch";
            this.Text = "NPC\'s Custom Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_NPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Keywords_Input;
    }
}
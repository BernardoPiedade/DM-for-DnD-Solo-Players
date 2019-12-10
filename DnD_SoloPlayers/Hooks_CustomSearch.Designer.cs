namespace DnD_SoloPlayers
{
    partial class Hooks_CustomSearch
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
            this.Keywords_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_Hooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Keywords_Input
            // 
            this.Keywords_Input.Location = new System.Drawing.Point(15, 74);
            this.Keywords_Input.Name = "Keywords_Input";
            this.Keywords_Input.Size = new System.Drawing.Size(250, 20);
            this.Keywords_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add keywords separated by a comma.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ex: \"Jungle,cat,pizza\"";
            // 
            // Search_Hooks
            // 
            this.Search_Hooks.Location = new System.Drawing.Point(271, 74);
            this.Search_Hooks.Name = "Search_Hooks";
            this.Search_Hooks.Size = new System.Drawing.Size(75, 23);
            this.Search_Hooks.TabIndex = 3;
            this.Search_Hooks.Text = "Search";
            this.Search_Hooks.UseVisualStyleBackColor = true;
            this.Search_Hooks.Click += new System.EventHandler(this.Search_Hooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(15, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 247);
            this.textBox1.TabIndex = 4;
            // 
            // Hooks_CustomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_Hooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Keywords_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hooks_CustomSearch";
            this.Text = "Hooks Custom Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Keywords_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search_Hooks;
        private System.Windows.Forms.TextBox textBox1;
    }
}
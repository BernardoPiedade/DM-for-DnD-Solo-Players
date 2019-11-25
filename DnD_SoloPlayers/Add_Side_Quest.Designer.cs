namespace DnD_SoloPlayers
{
    partial class Add_Side_Quest
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
            this.label1 = new System.Windows.Forms.Label();
            this.Quest_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.SD_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quest content:";
            // 
            // Quest_Text
            // 
            this.Quest_Text.AcceptsReturn = true;
            this.Quest_Text.AcceptsTab = true;
            this.Quest_Text.AllowDrop = true;
            this.Quest_Text.Location = new System.Drawing.Point(15, 41);
            this.Quest_Text.Multiline = true;
            this.Quest_Text.Name = "Quest_Text";
            this.Quest_Text.Size = new System.Drawing.Size(365, 217);
            this.Quest_Text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "By:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Optional";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(50, 299);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(180, 20);
            this.User_name.TabIndex = 4;
            // 
            // SD_Send
            // 
            this.SD_Send.Location = new System.Drawing.Point(305, 332);
            this.SD_Send.Name = "SD_Send";
            this.SD_Send.Size = new System.Drawing.Size(75, 23);
            this.SD_Send.TabIndex = 5;
            this.SD_Send.Text = "Send";
            this.SD_Send.UseVisualStyleBackColor = true;
            this.SD_Send.Click += new System.EventHandler(this.SD_Send_Click);
            // 
            // Add_Side_Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 367);
            this.Controls.Add(this.SD_Send);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quest_Text);
            this.Controls.Add(this.label1);
            this.Name = "Add_Side_Quest";
            this.Text = "Side Quest - Add Side Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Quest_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.Button SD_Send;
    }
}
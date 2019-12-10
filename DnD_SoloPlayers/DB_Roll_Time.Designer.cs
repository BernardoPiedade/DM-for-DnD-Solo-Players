namespace DnD_SoloPlayers
{
    partial class DB_Roll_Time
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
            this.Short_Time_B = new System.Windows.Forms.Button();
            this.Medium_Time_B = new System.Windows.Forms.Button();
            this.Long_Time_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Short_Time_B
            // 
            this.Short_Time_B.Location = new System.Drawing.Point(53, 33);
            this.Short_Time_B.Name = "Short_Time_B";
            this.Short_Time_B.Size = new System.Drawing.Size(75, 23);
            this.Short_Time_B.TabIndex = 0;
            this.Short_Time_B.Text = "Short Time";
            this.Short_Time_B.UseVisualStyleBackColor = true;
            this.Short_Time_B.Click += new System.EventHandler(this.Short_Time_B_Click);
            // 
            // Medium_Time_B
            // 
            this.Medium_Time_B.Location = new System.Drawing.Point(175, 33);
            this.Medium_Time_B.Name = "Medium_Time_B";
            this.Medium_Time_B.Size = new System.Drawing.Size(84, 23);
            this.Medium_Time_B.TabIndex = 1;
            this.Medium_Time_B.Text = "Medium Time";
            this.Medium_Time_B.UseVisualStyleBackColor = true;
            this.Medium_Time_B.Click += new System.EventHandler(this.Medium_Time_B_Click);
            // 
            // Long_Time_B
            // 
            this.Long_Time_B.Location = new System.Drawing.Point(311, 33);
            this.Long_Time_B.Name = "Long_Time_B";
            this.Long_Time_B.Size = new System.Drawing.Size(76, 23);
            this.Long_Time_B.TabIndex = 2;
            this.Long_Time_B.Text = "Long Time";
            this.Long_Time_B.UseVisualStyleBackColor = true;
            this.Long_Time_B.Click += new System.EventHandler(this.Long_Time_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1 - 4 Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "5 - 8 Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "9 - 12 Hours";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Location = new System.Drawing.Point(199, 117);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 13);
            this.Result_Label.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result:";
            // 
            // DB_Roll_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 156);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Long_Time_B);
            this.Controls.Add(this.Medium_Time_B);
            this.Controls.Add(this.Short_Time_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DB_Roll_Time";
            this.Text = "Dice Bag - Roll for time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Short_Time_B;
        private System.Windows.Forms.Button Medium_Time_B;
        private System.Windows.Forms.Button Long_Time_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Label label5;
    }
}
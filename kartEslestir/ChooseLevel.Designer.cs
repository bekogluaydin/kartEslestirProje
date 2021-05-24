
namespace kartEslestir
{
    partial class ChooseLevel
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(63, 44);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(156, 38);
            this.btnEasy.TabIndex = 5;
            this.btnEasy.Text = "KOLAY";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormal.ForeColor = System.Drawing.Color.White;
            this.btnNormal.Location = new System.Drawing.Point(63, 100);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(156, 38);
            this.btnNormal.TabIndex = 5;
            this.btnNormal.Text = "ORTA";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Maroon;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(63, 154);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(156, 38);
            this.btnHard.TabIndex = 5;
            this.btnHard.Text = "ZOR";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblExit.Location = new System.Drawing.Point(256, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(17, 16);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(41, 15);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Aydın";
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 227);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseLevel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChooseLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblUserName;
    }
}
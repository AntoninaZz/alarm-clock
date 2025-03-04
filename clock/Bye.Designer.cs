
namespace clock
{
    partial class Bye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bye));
            this.lblBye = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBye
            // 
            this.lblBye.AutoSize = true;
            this.lblBye.Location = new System.Drawing.Point(55, 50);
            this.lblBye.Name = "lblBye";
            this.lblBye.Size = new System.Drawing.Size(227, 35);
            this.lblBye.TabIndex = 0;
            this.lblBye.Text = "OK! GOOD BYE!";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(200, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Bye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(278, 144);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblBye);
            this.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Bye";
            this.Text = "Clock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bye_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBye;
        private System.Windows.Forms.Button btnOK;
    }
}

namespace clock
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.lblHelloBye = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloBye
            // 
            this.lblHelloBye.AutoSize = true;
            this.lblHelloBye.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHelloBye.Location = new System.Drawing.Point(88, 85);
            this.lblHelloBye.Name = "lblHelloBye";
            this.lblHelloBye.Size = new System.Drawing.Size(479, 35);
            this.lblHelloBye.TabIndex = 0;
            this.lblHelloBye.Text = "Welcome to the alarm-clock program.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.Location = new System.Drawing.Point(89, 140);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(192, 28);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Journal location: ";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.Location = new System.Drawing.Point(227, 140);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(159, 28);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "C:\\journal.txt";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(350, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(728, 314);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblHelloBye);
            this.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Hello";
            this.Text = "Clock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hello_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloBye;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnOK;
    }
}
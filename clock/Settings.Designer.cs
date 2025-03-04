
namespace clock
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.lblSep = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblHeader.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(543, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "           . . . S E T T I N G   M O D E . . .           ";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(13, 119);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(245, 28);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "enter your time ------>";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.Color.Black;
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHours.Location = new System.Drawing.Point(175, 116);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 37);
            this.txtHours.TabIndex = 2;
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.Black;
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinutes.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMinutes.Location = new System.Drawing.Point(294, 116);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(100, 37);
            this.txtMinutes.TabIndex = 3;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutes_KeyPress);
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader1.Location = new System.Drawing.Point(171, 94);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(39, 24);
            this.lblHeader1.TabIndex = 4;
            this.lblHeader1.Text = " hh";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader2.Location = new System.Drawing.Point(358, 94);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(51, 24);
            this.lblHeader2.TabIndex = 5;
            this.lblHeader2.Text = " mm";
            // 
            // lblSep
            // 
            this.lblSep.AutoSize = true;
            this.lblSep.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSep.Location = new System.Drawing.Point(276, 115);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(25, 38);
            this.lblSep.TabIndex = 6;
            this.lblSep.Text = ":";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(320, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 30);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 284);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSep);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label lblSep;
        private System.Windows.Forms.Button btnOK;
    }
}
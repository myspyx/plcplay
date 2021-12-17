namespace plcplay
{
    partial class Form1
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gpRead = new System.Windows.Forms.GroupBox();
            this.btnReadVariable = new System.Windows.Forms.Button();
            this.txtReadVariable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReadResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.txtWriteVariable = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblWriteResult = new System.Windows.Forms.Label();
            this.cbNewPlc = new System.Windows.Forms.CheckBox();
            this.gpRead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 44);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(118, 25);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.2.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(433, 44);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 26);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(559, 44);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 26);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gpRead
            // 
            this.gpRead.Controls.Add(this.btnReadVariable);
            this.gpRead.Controls.Add(this.txtReadVariable);
            this.gpRead.Controls.Add(this.label4);
            this.gpRead.Controls.Add(this.txtReadResult);
            this.gpRead.Location = new System.Drawing.Point(46, 110);
            this.gpRead.Margin = new System.Windows.Forms.Padding(2);
            this.gpRead.Name = "gpRead";
            this.gpRead.Padding = new System.Windows.Forms.Padding(2);
            this.gpRead.Size = new System.Drawing.Size(324, 269);
            this.gpRead.TabIndex = 4;
            this.gpRead.TabStop = false;
            this.gpRead.Text = "Read";
            // 
            // btnReadVariable
            // 
            this.btnReadVariable.Location = new System.Drawing.Point(215, 32);
            this.btnReadVariable.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadVariable.Name = "btnReadVariable";
            this.btnReadVariable.Size = new System.Drawing.Size(76, 26);
            this.btnReadVariable.TabIndex = 7;
            this.btnReadVariable.Text = "Read";
            this.btnReadVariable.UseVisualStyleBackColor = true;
            this.btnReadVariable.Click += new System.EventHandler(this.btnReadVariable_Click);
            // 
            // txtReadVariable
            // 
            this.txtReadVariable.Location = new System.Drawing.Point(15, 37);
            this.txtReadVariable.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadVariable.Name = "txtReadVariable";
            this.txtReadVariable.Size = new System.Drawing.Size(151, 25);
            this.txtReadVariable.TabIndex = 6;
            this.txtReadVariable.Text = "DB1.DBX0.0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result";
            // 
            // txtReadResult
            // 
            this.txtReadResult.Location = new System.Drawing.Point(15, 145);
            this.txtReadResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadResult.Name = "txtReadResult";
            this.txtReadResult.Size = new System.Drawing.Size(277, 25);
            this.txtReadResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWriteValue);
            this.groupBox1.Controls.Add(this.txtWriteVariable);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.lblWriteResult);
            this.groupBox1.Location = new System.Drawing.Point(416, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(324, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write";
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(25, 70);
            this.txtWriteValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(151, 25);
            this.txtWriteValue.TabIndex = 8;
            this.txtWriteValue.Text = "1";
            // 
            // txtWriteVariable
            // 
            this.txtWriteVariable.Location = new System.Drawing.Point(25, 37);
            this.txtWriteVariable.Margin = new System.Windows.Forms.Padding(2);
            this.txtWriteVariable.Name = "txtWriteVariable";
            this.txtWriteVariable.Size = new System.Drawing.Size(151, 25);
            this.txtWriteVariable.TabIndex = 7;
            this.txtWriteVariable.Text = "DB1.DBX0.0";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(222, 62);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(76, 26);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblWriteResult
            // 
            this.lblWriteResult.Location = new System.Drawing.Point(25, 120);
            this.lblWriteResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWriteResult.Name = "lblWriteResult";
            this.lblWriteResult.Size = new System.Drawing.Size(273, 74);
            this.lblWriteResult.TabIndex = 5;
            // 
            // cbNewPlc
            // 
            this.cbNewPlc.Checked = true;
            this.cbNewPlc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNewPlc.Location = new System.Drawing.Point(261, 43);
            this.cbNewPlc.Name = "cbNewPlc";
            this.cbNewPlc.Size = new System.Drawing.Size(109, 25);
            this.cbNewPlc.TabIndex = 7;
            this.cbNewPlc.Text = "s7-1200";
            this.cbNewPlc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 439);
            this.Controls.Add(this.cbNewPlc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpRead);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "freePLCTest";
            this.gpRead.ResumeLayout(false);
            this.gpRead.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox cbNewPlc;

        private System.Windows.Forms.Label lblWriteResult;

        private System.Windows.Forms.TextBox txtWriteVariable;
        private System.Windows.Forms.TextBox txtWriteValue;

        private System.Windows.Forms.TextBox txtReadVariable;
        private System.Windows.Forms.Button btnReadVariable;


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWrite;

        private System.Windows.Forms.TextBox txtReadResult;

        private System.Windows.Forms.Label label4;


        private System.Windows.Forms.GroupBox gpRead;

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
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
            this.gpRead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(210, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(276, 73);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(317, 31);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.2.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(649, 73);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 44);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(839, 74);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(143, 43);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "DisConnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gpRead
            // 
            this.gpRead.Controls.Add(this.btnReadVariable);
            this.gpRead.Controls.Add(this.txtReadVariable);
            this.gpRead.Controls.Add(this.label4);
            this.gpRead.Controls.Add(this.txtReadResult);
            this.gpRead.Location = new System.Drawing.Point(69, 183);
            this.gpRead.Name = "gpRead";
            this.gpRead.Size = new System.Drawing.Size(486, 449);
            this.gpRead.TabIndex = 4;
            this.gpRead.TabStop = false;
            this.gpRead.Text = "Read";
            // 
            // btnReadVariable
            // 
            this.btnReadVariable.Location = new System.Drawing.Point(322, 54);
            this.btnReadVariable.Name = "btnReadVariable";
            this.btnReadVariable.Size = new System.Drawing.Size(114, 44);
            this.btnReadVariable.TabIndex = 7;
            this.btnReadVariable.Text = "Read";
            this.btnReadVariable.UseVisualStyleBackColor = true;
            this.btnReadVariable.Click += new System.EventHandler(this.btnReadVariable_Click);
            // 
            // txtReadVariable
            // 
            this.txtReadVariable.Location = new System.Drawing.Point(22, 61);
            this.txtReadVariable.Name = "txtReadVariable";
            this.txtReadVariable.Size = new System.Drawing.Size(224, 31);
            this.txtReadVariable.TabIndex = 6;
            this.txtReadVariable.Text = "DB1.DBX0.0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result";
            // 
            // txtReadResult
            // 
            this.txtReadResult.Location = new System.Drawing.Point(22, 242);
            this.txtReadResult.Name = "txtReadResult";
            this.txtReadResult.Size = new System.Drawing.Size(414, 31);
            this.txtReadResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWriteValue);
            this.groupBox1.Controls.Add(this.txtWriteVariable);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.lblWriteResult);
            this.groupBox1.Location = new System.Drawing.Point(624, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 449);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write";
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(38, 116);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(224, 31);
            this.txtWriteValue.TabIndex = 8;
            this.txtWriteValue.Text = "1";
            // 
            // txtWriteVariable
            // 
            this.txtWriteVariable.Location = new System.Drawing.Point(38, 61);
            this.txtWriteVariable.Name = "txtWriteVariable";
            this.txtWriteVariable.Size = new System.Drawing.Size(224, 31);
            this.txtWriteVariable.TabIndex = 7;
            this.txtWriteVariable.Text = "DB1.DBX0.0";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(333, 103);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(114, 44);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblWriteResult
            // 
            this.lblWriteResult.Location = new System.Drawing.Point(38, 200);
            this.lblWriteResult.Name = "lblWriteResult";
            this.lblWriteResult.Size = new System.Drawing.Size(409, 124);
            this.lblWriteResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpRead);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "freePLCTest";
            this.gpRead.ResumeLayout(false);
            this.gpRead.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
namespace TcpSocket
{
    partial class ClientForm
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
            this.BtnSearchFile = new System.Windows.Forms.Button();
            this.LabelHostName = new System.Windows.Forms.Label();
            this.TextBoxHostName = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.ListBoxClientInformations = new System.Windows.Forms.ListBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFile = new System.Windows.Forms.GroupBox();
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearchFile
            // 
            this.BtnSearchFile.Enabled = false;
            this.BtnSearchFile.Location = new System.Drawing.Point(257, 71);
            this.BtnSearchFile.Name = "BtnSearchFile";
            this.BtnSearchFile.Size = new System.Drawing.Size(83, 20);
            this.BtnSearchFile.TabIndex = 4;
            this.BtnSearchFile.Text = "Search";
            this.BtnSearchFile.UseVisualStyleBackColor = true;
            this.BtnSearchFile.Click += new System.EventHandler(this.BtnSearchFile_Click);
            // 
            // LabelHostName
            // 
            this.LabelHostName.AutoSize = true;
            this.LabelHostName.Location = new System.Drawing.Point(3, 16);
            this.LabelHostName.Name = "LabelHostName";
            this.LabelHostName.Size = new System.Drawing.Size(63, 13);
            this.LabelHostName.TabIndex = 5;
            this.LabelHostName.Text = "Host Name:";
            // 
            // TextBoxHostName
            // 
            this.TextBoxHostName.Location = new System.Drawing.Point(6, 36);
            this.TextBoxHostName.Name = "TextBoxHostName";
            this.TextBoxHostName.Size = new System.Drawing.Size(164, 20);
            this.TextBoxHostName.TabIndex = 6;
            this.TextBoxHostName.Text = "127.0.0.1";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(6, 62);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(164, 34);
            this.BtnConnect.TabIndex = 7;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ListBoxClientInformations
            // 
            this.ListBoxClientInformations.FormattingEnabled = true;
            this.ListBoxClientInformations.Location = new System.Drawing.Point(12, 218);
            this.ListBoxClientInformations.Name = "ListBoxClientInformations";
            this.ListBoxClientInformations.Size = new System.Drawing.Size(343, 147);
            this.ListBoxClientInformations.TabIndex = 8;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(173, 16);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 9;
            this.LabelPort.Text = "Port:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(176, 36);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(164, 20);
            this.TextBoxPort.TabIndex = 10;
            this.TextBoxPort.Text = "3000";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(176, 62);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(164, 34);
            this.BtnDisconnect.TabIndex = 11;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Location = new System.Drawing.Point(6, 71);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(245, 20);
            this.TextBoxFileName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Path:";
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(6, 32);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(245, 20);
            this.TextBoxPath.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDisconnect);
            this.groupBox1.Controls.Add(this.TextBoxPort);
            this.groupBox1.Controls.Add(this.LabelPort);
            this.groupBox1.Controls.Add(this.TextBoxHostName);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.LabelHostName);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // GroupBoxFile
            // 
            this.GroupBoxFile.Controls.Add(this.BtnSelectPath);
            this.GroupBoxFile.Controls.Add(this.label2);
            this.GroupBoxFile.Controls.Add(this.TextBoxPath);
            this.GroupBoxFile.Controls.Add(this.TextBoxFileName);
            this.GroupBoxFile.Controls.Add(this.BtnSearchFile);
            this.GroupBoxFile.Controls.Add(this.label1);
            this.GroupBoxFile.Enabled = false;
            this.GroupBoxFile.Location = new System.Drawing.Point(12, 115);
            this.GroupBoxFile.Name = "GroupBoxFile";
            this.GroupBoxFile.Size = new System.Drawing.Size(346, 98);
            this.GroupBoxFile.TabIndex = 17;
            this.GroupBoxFile.TabStop = false;
            this.GroupBoxFile.Text = "File";
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.Location = new System.Drawing.Point(258, 32);
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.Size = new System.Drawing.Size(82, 20);
            this.BtnSelectPath.TabIndex = 16;
            this.BtnSelectPath.Text = "Select";
            this.BtnSelectPath.UseVisualStyleBackColor = true;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 377);
            this.Controls.Add(this.GroupBoxFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListBoxClientInformations);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxFile.ResumeLayout(false);
            this.GroupBoxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSearchFile;
        private System.Windows.Forms.Label LabelHostName;
        private System.Windows.Forms.TextBox TextBoxHostName;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ListBox ListBoxClientInformations;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxFile;
        private System.Windows.Forms.Button BtnSelectPath;
    }
}
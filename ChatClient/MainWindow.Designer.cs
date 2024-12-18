﻿namespace ChatClient
{
    partial class MainWindow
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
            Label label3;
            groupBox1 = new GroupBox();
            label4 = new Label();
            textAlias = new TextBox();
            buttonStop = new Button();
            ipAddressControl1 = new OutilsChat.IPAddressControl();
            label2 = new Label();
            numericPort = new NumericUpDown();
            label1 = new Label();
            buttonStart = new Button();
            richMessages = new RichTextBox();
            textMessage = new TextBox();
            buttonEnvoi = new Button();
            statusBar = new StatusStrip();
            statusBarInfo = new ToolStripStatusLabel();
            listButtonsColors = new GroupBox();
            fichierButton = new Button();
            fichiersGestion = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).BeginInit();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 454);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Message";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textAlias);
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(ipAddressControl1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericPort);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonStart);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(536, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Alias :";
            // 
            // textAlias
            // 
            textAlias.Location = new Point(264, 56);
            textAlias.Margin = new Padding(4);
            textAlias.Name = "textAlias";
            textAlias.Size = new Size(116, 23);
            textAlias.TabIndex = 4;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(414, 25);
            buttonStop.Margin = new Padding(4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(88, 26);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Visible = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // ipAddressControl1
            // 
            ipAddressControl1.BackColor = SystemColors.Control;
            ipAddressControl1.IPAddress = "0.0.0.0";
            ipAddressControl1.IsSubnetMask = false;
            ipAddressControl1.Location = new Point(66, 24);
            ipAddressControl1.Margin = new Padding(4, 5, 4, 5);
            ipAddressControl1.Name = "ipAddressControl1";
            ipAddressControl1.Size = new Size(178, 23);
            ipAddressControl1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Serveur";
            // 
            // numericPort
            // 
            numericPort.Location = new Point(312, 25);
            numericPort.Margin = new Padding(4);
            numericPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPort.Name = "numericPort";
            numericPort.Size = new Size(91, 23);
            numericPort.TabIndex = 1;
            numericPort.TextAlign = HorizontalAlignment.Right;
            numericPort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Port : ";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(414, 24);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(88, 26);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // richMessages
            // 
            richMessages.DetectUrls = false;
            richMessages.Location = new Point(14, 114);
            richMessages.Margin = new Padding(4);
            richMessages.Name = "richMessages";
            richMessages.ReadOnly = true;
            richMessages.Size = new Size(536, 332);
            richMessages.TabIndex = 1;
            richMessages.Text = "";
            // 
            // textMessage
            // 
            textMessage.Enabled = false;
            textMessage.Location = new Point(14, 454);
            textMessage.Margin = new Padding(4);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.ScrollBars = ScrollBars.Both;
            textMessage.Size = new Size(403, 104);
            textMessage.TabIndex = 2;
            // 
            // buttonEnvoi
            // 
            buttonEnvoi.Enabled = false;
            buttonEnvoi.Location = new Point(428, 472);
            buttonEnvoi.Margin = new Padding(4);
            buttonEnvoi.Name = "buttonEnvoi";
            buttonEnvoi.Size = new Size(66, 86);
            buttonEnvoi.TabIndex = 3;
            buttonEnvoi.Text = "Envoyer";
            buttonEnvoi.UseVisualStyleBackColor = true;
            buttonEnvoi.Click += buttonEnvoi_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarInfo });
            statusBar.Location = new Point(0, 574);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 17, 0);
            statusBar.Size = new Size(926, 22);
            statusBar.TabIndex = 5;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarInfo
            // 
            statusBarInfo.Name = "statusBarInfo";
            statusBarInfo.Size = new Size(0, 17);
            // 
            // listButtonsColors
            // 
            listButtonsColors.Location = new Point(601, 14);
            listButtonsColors.Name = "listButtonsColors";
            listButtonsColors.Size = new Size(200, 315);
            listButtonsColors.TabIndex = 6;
            listButtonsColors.TabStop = false;
            listButtonsColors.Text = "Gestion des chaters";
            // 
            // fichierButton
            // 
            fichierButton.Location = new Point(501, 472);
            fichierButton.Name = "fichierButton";
            fichierButton.Size = new Size(58, 86);
            fichierButton.TabIndex = 7;
            fichierButton.Text = "Fichier";
            fichierButton.UseVisualStyleBackColor = true;
            fichierButton.Click += fichierButton_Click;
            // 
            // fichiersGestion
            // 
            fichiersGestion.Location = new Point(601, 346);
            fichiersGestion.Name = "fichiersGestion";
            fichiersGestion.Size = new Size(295, 212);
            fichiersGestion.TabIndex = 8;
            fichiersGestion.TabStop = false;
            fichiersGestion.Text = "Fichiers";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 596);
            Controls.Add(fichiersGestion);
            Controls.Add(fichierButton);
            Controls.Add(listButtonsColors);
            Controls.Add(statusBar);
            Controls.Add(buttonEnvoi);
            Controls.Add(label3);
            Controls.Add(textMessage);
            Controls.Add(richMessages);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Client de Tchatche";
            FormClosing += MainWindow_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).EndInit();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private OutilsChat.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.RichTextBox richMessages;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonEnvoi;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarInfo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAlias;
        private GroupBox listButtonsColors;
        private Button fichierButton;
        private GroupBox fichiersGestion;
    }
}
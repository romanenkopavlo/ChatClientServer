namespace ChatClient
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
            fichierButton = new Button();
            listeMusiqueMP3 = new FlowLayoutPanel();
            splitter1 = new Splitter();
            labelMp3List = new Label();
            listColors = new FlowLayoutPanel();
            colorChangeLabel = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPort).BeginInit();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 605);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
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
            groupBox1.Location = new Point(16, 19);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(613, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 79);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Alias :";
            // 
            // textAlias
            // 
            textAlias.Location = new Point(302, 75);
            textAlias.Margin = new Padding(5);
            textAlias.Name = "textAlias";
            textAlias.Size = new Size(132, 27);
            textAlias.TabIndex = 4;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(473, 33);
            buttonStop.Margin = new Padding(5);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(101, 35);
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
            ipAddressControl1.Location = new Point(75, 32);
            ipAddressControl1.Margin = new Padding(5, 7, 5, 7);
            ipAddressControl1.Name = "ipAddressControl1";
            ipAddressControl1.Size = new Size(203, 31);
            ipAddressControl1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 37);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Serveur";
            // 
            // numericPort
            // 
            numericPort.Location = new Point(357, 33);
            numericPort.Margin = new Padding(5);
            numericPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericPort.Name = "numericPort";
            numericPort.Size = new Size(104, 27);
            numericPort.TabIndex = 1;
            numericPort.TextAlign = HorizontalAlignment.Right;
            numericPort.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Port : ";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(473, 32);
            buttonStart.Margin = new Padding(5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(101, 35);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // richMessages
            // 
            richMessages.DetectUrls = false;
            richMessages.Location = new Point(16, 152);
            richMessages.Margin = new Padding(5);
            richMessages.Name = "richMessages";
            richMessages.ReadOnly = true;
            richMessages.Size = new Size(612, 441);
            richMessages.TabIndex = 1;
            richMessages.Text = "";
            // 
            // textMessage
            // 
            textMessage.Enabled = false;
            textMessage.Location = new Point(16, 605);
            textMessage.Margin = new Padding(5);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.ScrollBars = ScrollBars.Both;
            textMessage.Size = new Size(460, 137);
            textMessage.TabIndex = 2;
            // 
            // buttonEnvoi
            // 
            buttonEnvoi.Enabled = false;
            buttonEnvoi.Location = new Point(489, 629);
            buttonEnvoi.Margin = new Padding(5);
            buttonEnvoi.Name = "buttonEnvoi";
            buttonEnvoi.Size = new Size(75, 115);
            buttonEnvoi.TabIndex = 3;
            buttonEnvoi.Text = "Envoyer";
            buttonEnvoi.UseVisualStyleBackColor = true;
            buttonEnvoi.Click += buttonEnvoi_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarInfo });
            statusBar.Location = new Point(0, 810);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 19, 0);
            statusBar.Size = new Size(1059, 22);
            statusBar.TabIndex = 5;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarInfo
            // 
            statusBarInfo.Name = "statusBarInfo";
            statusBarInfo.Size = new Size(0, 16);
            // 
            // fichierButton
            // 
            fichierButton.Location = new Point(573, 629);
            fichierButton.Margin = new Padding(3, 4, 3, 4);
            fichierButton.Name = "fichierButton";
            fichierButton.Size = new Size(66, 115);
            fichierButton.TabIndex = 7;
            fichierButton.Text = "Fichier";
            fichierButton.UseVisualStyleBackColor = true;
            fichierButton.Click += fichierButton_Click;
            // 
            // listeMusiqueMP3
            // 
            listeMusiqueMP3.AutoScroll = true;
            listeMusiqueMP3.Location = new Point(687, 320);
            listeMusiqueMP3.Name = "listeMusiqueMP3";
            listeMusiqueMP3.Size = new Size(351, 273);
            listeMusiqueMP3.TabIndex = 10;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 810);
            splitter1.TabIndex = 11;
            splitter1.TabStop = false;
            // 
            // labelMp3List
            // 
            labelMp3List.AutoSize = true;
            labelMp3List.Location = new Point(687, 276);
            labelMp3List.Name = "labelMp3List";
            labelMp3List.Size = new Size(61, 20);
            labelMp3List.TabIndex = 12;
            labelMp3List.Text = "MP3 list";
            // 
            // listColors
            // 
            listColors.AutoScroll = true;
            listColors.Location = new Point(687, 67);
            listColors.Name = "listColors";
            listColors.Size = new Size(119, 187);
            listColors.TabIndex = 13;
            // 
            // colorChangeLabel
            // 
            colorChangeLabel.AutoSize = true;
            colorChangeLabel.Location = new Point(687, 30);
            colorChangeLabel.Name = "colorChangeLabel";
            colorChangeLabel.Size = new Size(179, 20);
            colorChangeLabel.TabIndex = 14;
            colorChangeLabel.Text = "Changement des couleurs";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 832);
            Controls.Add(colorChangeLabel);
            Controls.Add(listColors);
            Controls.Add(labelMp3List);
            Controls.Add(splitter1);
            Controls.Add(listeMusiqueMP3);
            Controls.Add(fichierButton);
            Controls.Add(statusBar);
            Controls.Add(buttonEnvoi);
            Controls.Add(label3);
            Controls.Add(textMessage);
            Controls.Add(richMessages);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
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
        private Button fichierButton;
        private FlowLayoutPanel listeMusiqueMP3;
        private Splitter splitter1;
        private Label labelMp3List;
        private FlowLayoutPanel listColors;
        private Label colorChangeLabel;
    }
}
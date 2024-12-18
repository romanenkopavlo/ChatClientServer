using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using OutilsChat;

namespace ChatClient
{
    public partial class MainWindow : Form
    {
        private GestionChat comm;
        private IniFile configFile;
        private Dictionary<int, Color> clients;
        private Dictionary<String, Color> clientsColors;
        private int point_init = 10;
        private int point_x_init_mp3 = 20;
        private int point_y_init_mp3 = 30;
        private Color selectedColor = Color.Black;
        private List<Button> buttons = new List<Button>();
        private bool flag = false;
        private bool sendingMp3 = false;
        private bool firstSong = false;
        private string fichierMp3Name;
        private string pathToMp3;
        private IWavePlayer waveOut;
        private AudioFileReader audioFile;
        



        public MainWindow()
        {
            InitializeComponent();
            comm = null;
            //
            configFile = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "config.ini");
            int port = configFile.ReadValue("Server", "Port", 18);
            String ipAddress = configFile.ReadValue("Server", "IPAddress", "127.0.0.1");
            String alias = configFile.ReadValue("User", "Alias", "JohnDoe");
            //
            this.numericPort.Value = port;
            this.ipAddressControl1.IPAddress = ipAddress;
            this.textAlias.Text = alias;
            this.fichierButton.Enabled = false;
            //
            this.Text += " " + Constants.APP_VERSION;
            this.clients = new Dictionary<int, Color>();
            this.clientsColors = new Dictionary<string, Color>();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Démarrage de connection
            if (comm == null)
            {
                configFile = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "config.ini");
                configFile.WriteValue("Server", "Port", (int)this.numericPort.Value);
                configFile.WriteValue("Server", "IPAddress", this.ipAddressControl1.IPAddress);
                configFile.WriteValue("User", "Alias", this.textAlias.Text);
                //
                this.comm = new GestionChat(this.ipAddressControl1.IPAddress, (int)this.numericPort.Value, this.textAlias.Text);
                this.comm.OnMessageReceived += new OnMessageReceived(this.OnMessageReceived);
                this.comm.OnClientDisconnected += new OnClientDisconnected(this.OnClientDisconnected);
                this.comm.Start();
                //
                if (this.comm.Connected)
                {
                    //
                    this.ipAddressControl1.Enabled = false;
                    this.numericPort.Enabled = false;
                    this.textAlias.Enabled = false;
                    this.buttonStart.Visible = false;
                    this.buttonStop.Visible = true;
                    this.textMessage.Enabled = true;
                    this.buttonEnvoi.Enabled = true;
                    this.fichierButton.Enabled = true;
                    this.AfficherInfo("Connection sur " + this.ipAddressControl1.IPAddress + ":" + this.numericPort.Value + ".");
                }
                else
                {
                    this.AfficherErreur("Erreur de connection sur " + this.ipAddressControl1.IPAddress + ":" + this.numericPort.Value + ".");
                    this.comm = null;
                }
            }
        }

        private void OnClientDisconnected(GestionChat sender)
        {
            // !!! ATTENTION !!!
            // A ce stade on est "encore" dans le contexte d'execution du Thread Réseau
            this.Invoke((OnClientDisconnected)this.DoClientDisconnected, new object[] { sender });
        }

        private void DoClientDisconnected(GestionChat sender)
        {
            // On remet tout en place
            this.ipAddressControl1.Enabled = true;
            this.numericPort.Enabled = true;
            this.textAlias.Enabled = true;
            this.buttonStart.Visible = true;
            this.buttonStop.Visible = false;
            this.textMessage.Enabled = false;
            this.buttonEnvoi.Enabled = false;
            this.fichierButton.Enabled = false;
            this.comm.Stop();
            this.comm = null;
        }

        private void OnMessageReceived(GestionChat sender, OutilsChat.Message message)
        {
            // !!! ATTENTION !!!
            // A ce stade on est "encore" dans le contexte d'execution du Thread Réseau
            this.Invoke((OnMessageReceived)this.DoMessageReceived, new object[] { sender, message });
        }

        private void DoMessageReceived(GestionChat sender, OutilsChat.Message message)
        {
            // Client déjà connu ?
            if (!clients.ContainsKey(message.Id))
            {
                clients.Add(message.Id, Color.Black);
            }
            //

            bool isFound = false;

            foreach (Button btt in buttons)
            {
                if (btt.Text == message.Param1)
                {
                    isFound = true;
                }
            }

            if (!isFound)
            {
                addButtonColor(message.Param1);
            }


            if (this.clientsColors.Count > 0)
            {
                this.AjoutMessage(message, this.clientsColors[message.Param1]);
            }
            else
            {
                this.AjoutMessage(message, this.clients[message.Id]);
            }
        }

        private void AjoutMessage(OutilsChat.Message msg, Color clr)
        {
            //
            int beforeAppend = this.richMessages.TextLength;
            this.richMessages.AppendText(msg.Param1 + " - " + DateTime.Now.ToString() + Environment.NewLine);
            int afterAppend = this.richMessages.TextLength;
            this.richMessages.Select(beforeAppend, afterAppend - beforeAppend);
            this.richMessages.SelectionColor = clr;
            System.Drawing.Font currentFont = richMessages.SelectionFont;
            System.Drawing.FontStyle newFontStyle;
            newFontStyle = FontStyle.Bold;
            richMessages.SelectionFont = new Font(currentFont, newFontStyle);
            //
            beforeAppend = this.richMessages.TextLength;
            this.richMessages.AppendText(msg.Texte + Environment.NewLine);
            afterAppend = this.richMessages.TextLength;
            this.richMessages.Select(beforeAppend, afterAppend - beforeAppend);
            this.richMessages.SelectionColor = clr;
        }

        private void AfficherErreur(string msg)
        {
            this.statusBarInfo.ForeColor = Color.Red;
            this.statusBarInfo.Text = msg;
        }

        private void AfficherInfo(string info)
        {
            this.statusBarInfo.ForeColor = Color.Black;
            this.statusBarInfo.Text = info;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fermeture !! Arret du client
            if (comm != null)
            {
                // Si on laisse le traitement de l'evenement, on va revenir vers la fenetre alors qu'elle n'existera plus
                this.comm.OnClientDisconnected = null;
                this.comm.Stop();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Fermeture !! Arret du client
            if (comm != null)
            {
                this.comm.Stop();
            }
        }

        private void buttonEnvoi_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                addButtonColor(textAlias.Text);
                flag = true;
            }

            if (sendingMp3)
            {
                Label label = new Label();
                Button buttonPlay = new Button();
                Button buttonStopMp3 = new Button();

                label.Text = fichierMp3Name;
                if (!firstSong)
                {
                    label.Location = new Point(20, point_y_init_mp3);
                    firstSong = true;
                } else
                {
                    label.Location = new Point(20, point_y_init_mp3 + (point_y_init_mp3 / 2));
                }
                
                label.Width = 300;
                buttonPlay.Text = "Play";
                buttonPlay.Location = new Point(20, point_y_init_mp3 * 2);
                buttonPlay.Name = fichierMp3Name.Replace(".", "") + "button";
                
                buttonStopMp3.Text = "Stop";
                buttonStopMp3.Location = new Point(100, point_y_init_mp3 * 2);
                buttonStopMp3.Name = fichierMp3Name.Replace(".", "") + "button";
                buttonStopMp3.Enabled = false;

                buttonPlay.Tag = pathToMp3;
                buttonStopMp3.Tag = pathToMp3;
                
                point_y_init_mp3 = point_y_init_mp3 * 2;

                buttonPlay.Click += (sender, e) =>
                {
                    buttonPlay.Enabled = false;
                    buttonStopMp3.Enabled = true;
                    waveOut = new WaveOutEvent();
                    audioFile = new AudioFileReader(buttonPlay.Tag.ToString());
                    waveOut.Init(audioFile);
                    waveOut.Play();
                };

                buttonStopMp3.Click += (sender, e) =>
                {
                    IWavePlayer waveOutLocal = waveOut;
                    waveOutLocal.Stop();
                    buttonStopMp3.Enabled = false;
                    buttonPlay.Enabled = true;
                };

                fichiersGestion.Controls.Add(label);
                fichiersGestion.Controls.Add(buttonPlay);
                fichiersGestion.Controls.Add(buttonStopMp3);
            }

            if (comm != null)
            {
                if (!sendingMp3)
                {
                    this.comm.Ecrire(this.textMessage.Text);
                }
                else
                {
                    this.comm.Ecrire(pathToMp3);
                    sendingMp3 = false;
                    MessageBox.Show("Le lien est envoyé");
                }

                OutilsChat.Message newMessage = new OutilsChat.Message(0, this.textMessage.Text);
                newMessage.Envoi(this.textAlias.Text);
                this.AjoutMessage(newMessage, selectedColor);
            }
        }

        private void addButtonColor(String userName)
        {
            Button button = new Button();
            button.Name = "button " + userName;
            button.Text = userName;
            point_init = point_init + 30;
            button.Location = new Point(20, point_init);
            button.Click += (sender, e) =>
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < richMessages.Lines.Length - 1; i++)
                    {
                        string line = richMessages.Lines[i];
                        if (line.StartsWith(userName))
                        {
                            int start = richMessages.GetFirstCharIndexFromLine(i);
                            string nextLine = richMessages.Lines[i + 1];
                            int length = line.Length + nextLine.Length + Environment.NewLine.Length;
                            richMessages.Select(start, length);

                            if (userName == textAlias.Text)
                            {
                                selectedColor = colorDialog.Color;
                                richMessages.SelectionColor = selectedColor;
                            }
                            else
                            {
                                richMessages.SelectionColor = colorDialog.Color;
                            }

                            if (!clientsColors.ContainsKey(userName))
                            {
                                clientsColors.Add(userName, colorDialog.Color);
                            }
                            richMessages.Select(0, 0);
                        }
                    }
                }
            };
            listButtonsColors.Controls.Add(button);
            buttons.Add(button);
        }

        private void fichierButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers MP3 (.mp3)|*.mp3";
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fichier = openFileDialog.SafeFileName;
                
                string ext = Path.GetExtension(fichier).ToLower();

                if (ext == ".mp3")
                {
                    pathToMp3 = openFileDialog.FileName;
                    fichierMp3Name = fichier;
                    textMessage.Clear();
                    textMessage.Text = fichierMp3Name;
                    sendingMp3 = true;
                }
                else
                {
                    MessageBox.Show("Type de fichier inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

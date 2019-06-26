using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Morse_Translator___Classic
{
    public partial class MainForm : Form
    {

        private delegate void SafeCallDelegate(Control control, string text);
        private delegate string SafeGetControlTextDelegate(Control control);

        private Dictionary<char, string> textToMorseDictionary;
        private Dictionary<char, int> morseToDurationDictionary;
        private Dictionary<char, int> morseToFrequencyDictionary;

        public int DotDuration { get; set; } = 50;
        public int DashDuration { get; set; } = 200;
        public int DotFrequency { get; set; } = 1000;
        public int DashFrequency { get; set; } = 1000;
        public int Amplitude { get; set; } = 800;
        public int SpaceDuration { get; set; } = 500;

        private static string morseCode = "";

        private Queue<Thread> beepThreadQueue = new Queue<Thread>();
        private Thread previousThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDictionary();
            InitializeThreads();
            statusLabel.Text = "Ready.";
        }

        private void InitializeThreads()
        {
            beepThreadQueue.Enqueue(BeepThread());
            beepThreadQueue.Enqueue(BeepThread());
            previousThread = beepThreadQueue.Dequeue();
        }

        private Thread BeepThread()
        {
            return new Thread(() =>
            {
                beepThreadQueue.Enqueue(BeepThread());
                Thread.CurrentThread.IsBackground = true;
                SafeUpdateControl(beepButton, "Stop");
                foreach (char c in morseCode)
                {
                    SafeUpdateControl(statusLabel, "Beeping: " + c);
                    Beep(Amplitude, morseToFrequencyDictionary[c], morseToDurationDictionary[c]);
                }
                SafeUpdateControl(statusLabel, "Ready.");
                SafeUpdateControl(beepButton, "Beep");
            });
        }

        private void InitializeDictionary()
        {
            textToMorseDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."},
                                       {' ', " / " }
                                   };
            morseToDurationDictionary = new Dictionary<char, int>()
            {
                {'.', DotDuration },
                {'-', DashDuration },
                {'/', SpaceDuration }
            };

            morseToFrequencyDictionary = new Dictionary<char, int>()
            {
                {'.', DotFrequency },
                {'-', DashFrequency },
                {'/', 0 }
            };
        }


        private void TextEditText_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            foreach (char c in textEditText.Text.ToLower().ToCharArray())
            {
                try
                {
                    text += textToMorseDictionary[c];
                    statusLabel.Text = "Translated.";
                }
                catch (KeyNotFoundException)
                {
                    statusLabel.Text = "The key \"" + c + "\" cannot be translated.";
                }
            }
            morseCodeEditText.Text = text;
            morseCode = text.Replace(" ", "");
        }

        private void Clear()
        {
            textEditText.Text = "";
            morseCodeEditText.Text = "";
            statusLabel.Text = "Ready.";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BeepButton_Click(object sender, EventArgs e)
        {
            PerformBeep();
        }

        private void PerformBeep()
        {
            if (!previousThread.IsAlive) // If that thread is NOT currently running...
            {
                previousThread = beepThreadQueue.Dequeue();
                previousThread.Start();
            }
            else // If that thread IS currently running...
            {
                previousThread.Abort();
                statusLabel.Text = "Stopped.";
                beepButton.Text = "Beep";
                beepThreadQueue.Enqueue(BeepThread());
            }
        }

        public static void Beep(int Amplitude, int Frequency, int Duration)
        {
            double A = ((Amplitude * (System.Math.Pow(2, 15))) / 1000) - 1;
            double DeltaFT = 2 * Math.PI * Frequency / 44100.0;

            int Samples = 441 * Duration / 10;
            int Bytes = Samples * 4;
            int[] Hdr = { 0X46464952, 36 + Bytes, 0X45564157, 0X20746D66, 16, 0X20001, 44100, 176400, 0X100004, 0X61746164, Bytes };
            using (MemoryStream MS = new MemoryStream(44 + Bytes))
            {
                using (BinaryWriter BW = new BinaryWriter(MS))
                {
                    for (int I = 0; I < Hdr.Length; I++)
                    {
                        BW.Write(Hdr[I]);
                    }
                    for (int T = 0; T < Samples; T++)
                    {
                        short Sample = System.Convert.ToInt16(A * Math.Sin(DeltaFT * T));
                        BW.Write(Sample);
                        BW.Write(Sample);
                    }
                    BW.Flush();
                    MS.Seek(0, SeekOrigin.Begin);
                    using (SoundPlayer SP = new SoundPlayer(MS))
                    {
                        SP.PlaySync();
                    }
                }
            }
        }

        private void SafeUpdateControl(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                var d = new SafeCallDelegate(SafeUpdateControl);
                Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

        private string SafeGetControlText(Control control)
        {
            if (control.InvokeRequired)
            {
                var d = new SafeGetControlTextDelegate(SafeGetControlText);
                Invoke(d, new object[] { control });
            }
            return control.Text;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BeepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformBeep();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(new Dictionary<string, int>() {
                {"dot_freq", DotFrequency },
                { "dash_freq", DashFrequency },
                {"dot_dur",  DotDuration },
                {"dash_dur", DashDuration },
                {"space_dur", SpaceDuration },
                {"amplitude", Amplitude }
            });

            settingsForm.OnSave += UpdateProperties;
            settingsForm.Show();
        }

        private void UpdateProperties(Dictionary<string, int> properties)
        {
            DotDuration    = properties["dot_dur"];
            DashDuration   = properties["dash_dur"];
            DotFrequency   = properties["dot_freq"];
            DashFrequency  = properties["dash_freq"];
            SpaceDuration  = properties["space_dur"];
            Amplitude      = properties["amplitude"];

            morseToDurationDictionary['.'] = DotDuration;
            morseToDurationDictionary['-'] = DashDuration;
            morseToDurationDictionary[' '] = SpaceDuration;

            morseToFrequencyDictionary['.'] = DotFrequency;
            morseToFrequencyDictionary['-'] = DashFrequency; 



        }
    }
}

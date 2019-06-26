using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Translator___Classic
{
    public partial class Settings : Form
    {
        public delegate void OnSaveCallback(Dictionary<string, int> properties);
        public event OnSaveCallback OnSave;

        public Settings(Dictionary<string, int> beepProperties)
        {
            InitializeComponent();
            InitializeTextBoxData(beepProperties);
        }

        private void InitializeTextBoxData(Dictionary<string, int> properties)
        {
            dotFreqNumericUpdown.Text = properties["dot_freq"].ToString();
            dotDurationNumericUpdown.Text = properties["dot_dur"].ToString();
            dashFreqNumericUpdown.Text = properties["dash_freq"].ToString();
            dashDurationNumericUpdown.Text = properties["dash_dur"].ToString();
            spaceDurationNumericUpdown.Text = properties["space_dur"].ToString();
            amplitudeNumericUpdown.Text = properties["amplitude"].ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OnSave(new Dictionary<string, int>
                {
                    { "dot_freq", Int32.Parse(dotFreqNumericUpdown.Text)},
                    { "dash_freq", Int32.Parse(dashFreqNumericUpdown.Text)},
                    { "dot_dur", Int32.Parse(dotDurationNumericUpdown.Text)},
                    { "dash_dur", Int32.Parse(dashDurationNumericUpdown.Text)},
                    { "space_dur", Int32.Parse(spaceDurationNumericUpdown.Text)},
                    { "amplitude", Int32.Parse(amplitudeNumericUpdown.Text)}
                }
            );
            Close();
        }
    }
}

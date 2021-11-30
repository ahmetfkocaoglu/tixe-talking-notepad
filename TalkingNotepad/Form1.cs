using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TalkingNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SpeechSynthesizer synthesizer;
        private void Form1_Load(object sender, EventArgs e)
        {
            synthesizer = new SpeechSynthesizer();
            btnDur.Enabled = false;
            btnDevam.Enabled = false;
            btnDurak.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            synthesizer.Dispose();
            if (richTextBox1.Text!="")
            {
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(richTextBox1.Text);
                btnDur.Enabled = true;
                btnDurak.Enabled = true;
            }

        }

        private void btnDurak_Click(object sender, EventArgs e)
        {
            if (synthesizer.State==SynthesizerState.Speaking)
            {
                synthesizer.Pause();
                btnDevam.Enabled = true;
                btnOku.Enabled = false;
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
            {
                if (synthesizer.State==SynthesizerState.Paused)
                {
                    synthesizer.Resume();
                    btnDevam.Enabled = false;
                    btnOku.Enabled = true;
                }
            }
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
             
        }
    }
}
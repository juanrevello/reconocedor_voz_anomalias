using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Reconocedor_de_Voz_Anomalias
{
    public partial class CargaObservaciones : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();

        public CargaObservaciones()
        {
            InitializeComponent();
        }

        private void CargaObservaciones_Load(object sender, EventArgs e)
        {
            notifyIcon2.Text = "Registro Anomalia";
            notifyIcon2.Icon = SystemIcons.Application;

            Choices commands = new Choices();
            commands.Add(new String[] { "Guardar", "Atras"});
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.LoadGrammar(new DictationGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

            recEngine.RecognizeAsync(RecognizeMode.Multiple);

            //escucha.SetInputToDefaultAudioDevice();
            //escucha.LoadGrammar(new DictationGrammar());
            //escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconocedor);
            //escucha.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Atras")
            {
                button1_Click(null, null);
            }
            else if (e.Result.Text == "Guardar")
            {
                button2_Click(null, null);          
            }
            else
            {
                foreach (RecognizedWordUnit palabra in e.Result.Words)
                {
                    richTextBox1.Text += palabra.Text + " ";
                }
            }
        }

        public string tipoAnomalia;
        
        //Variables
        String observacion = "";

        //Boton Atrás
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            observacion += richTextBox1.Text;
            var records = new List<object>
            {
                new { Id = 1, Anomalía=this.tipoAnomalia, Observación=observacion, fecha=DateTime.Now.ToLocalTime() }
            };

            //using (var writer = new System.IO.StreamWriter("C:/Users/lgavi/source/repos/Reconocedor de Voz Anomalias/file.csv"))
            using (var writer = new System.IO.StreamWriter("C:/Users/Juan/Desktop/git voz fiat/file.csv"))
            using (var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
            MessageBox.Show("Se ha registrador la anomalía correctamente");
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon2.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void CargaObservaciones_Resize_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon2.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon2.Visible = false;
            }
        }
    }
}

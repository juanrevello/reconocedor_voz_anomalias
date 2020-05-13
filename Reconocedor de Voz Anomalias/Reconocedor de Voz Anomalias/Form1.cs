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
    public partial class Form1 : Form
    {
        //Variables
        String colorHandle = "";
        string tipoAnomalia = "";
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();

        //Inicializador
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;

            notifyIcon1.Text = "Registro Anomalia";
            notifyIcon1.Icon = SystemIcons.Application;
            Choices commands = new Choices();
            commands.Add(new String[] { "Mecánica", "Eléctrica", "Seguridad", "Otro", "Siguiente" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Mecánica":
                    tipoAnomalia = "Mecánica";
                    btnMecanica_Click(null, null);
                    btnSiguiente.Enabled = true;
                    break;
                case "Eléctrica":
                    btnElectrica_Click(null, null);
                    tipoAnomalia = "Eléctrica";
                    btnSiguiente.Enabled = true;
                    break;
                case "Seguridad":
                    btnSeguridad_Click(null, null);
                    tipoAnomalia = "Seguridad";
                    btnSiguiente.Enabled = true;
                    break;
                case "Otro":
                    btnOtro_Click(null, null);
                    tipoAnomalia = "Otro";
                    btnSiguiente.Enabled = true;
                    break;
                case "Siguiente":
                    this.Hide();
                    CargaObservaciones f2 = new CargaObservaciones();
                    f2.tipoAnomalia = colorHandle;
                    f2.ShowDialog();
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargaObservaciones f2 = new CargaObservaciones();
            f2.tipoAnomalia = colorHandle;
            f2.ShowDialog();
        }

        private void btnMecanica_Click(object sender, EventArgs e)
        {
            handleClick(btnMecanica.Text);
            btnSiguiente.Enabled = true;

        }

        private void btnElectrica_Click(object sender, EventArgs e)
        {
            handleClick(btnElectrica.Text);
            btnSiguiente.Enabled = true;
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            handleClick(btnSeguridad.Text);
            btnSiguiente.Enabled = true;
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            handleClick(btnOtro.Text);
            btnSiguiente.Enabled = true;
        }

        public void handleClick(String buttonName)
        {
            if (colorHandle == buttonName)
            {
                return;
            }

            
            foreach (Button item in this.Controls.OfType<Button>())
            {
                
                if (item.Text == colorHandle)
                {
                    item.FlatStyle = FlatStyle.Standard;
                    item.FlatAppearance.BorderColor = Color.Lime;
                    item.FlatAppearance.MouseDownBackColor = Color.Silver;
                    continue;
                }
                if (item.Text == buttonName)
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = Color.Lime;
                    item.FlatAppearance.MouseDownBackColor = Color.Silver;
                }
            }
            colorHandle = buttonName;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
    }
}
    

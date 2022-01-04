using FOD_Meraki.Clases.Api_Fod.Modelo;
using System;
using System.Text;
using System.Windows.Forms;

namespace FOD_Meraki.Fomularios.FodApi
{
    public partial class HerramientasAruba : Form
    {
        ManejoArubaRequest _manejoArubaRequest;
        public HerramientasAruba(string serie)
        {
            InitializeComponent();
            _manejoArubaRequest = new ManejoArubaRequest();
            device_serie.Text = serie;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Send_request_ping();
            button1.Enabled = true;
        }

        private void Send_request_ping()
        {
            try
            {
                comando.Text = string.Empty;
                var datos_request = _manejoArubaRequest.Procesar_Ping_Aruba(device_serie.Text,comando_txt.Text,"SWITCH");
                comando.Text += "Nombre del CE: "+datos_request.hostname+ "\r\n";
                comando.Text += "Estado de Consulta > "+datos_request.status + "\r\n\r\n";
                comando.Text += datos_request.output;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Aruba Tools", "Erroral enviar Ping\n" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Comando_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Enabled = false;
                Send_request_ping();
                button1.Enabled = true;
            }
        }
    }
}

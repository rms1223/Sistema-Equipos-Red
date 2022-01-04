using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace InterfazGrafica.Fomularios.Meraki
{
    public partial class Redes_Locales : Form
    {
        private delegate void SafeCallDelegate(string tipo, string ip, string mac, string estado, int i);
        private readonly Dictionary<string, string> ipMac;
        public Redes_Locales()
        {
            InitializeComponent();
            ipMac = new Dictionary<string, string>();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Refresh();
                Thread hilo = new Thread(new ThreadStart(Procesar))
                {
                    IsBackground = true
                };
                hilo.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Procesar()
        {
            try
            {
                ipMac.Clear();


                for (int i = 1; i < 254; i++)
                {
                    
                    string dir = "10.10.10." + i;
                    Ping(dir, 4, 4000);

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private string Validar_IP(string ip)
        {
            string[] val = ip.Split('.');
            int valor = Convert.ToInt32(val[3]);
            string tipo = string.Empty;
            switch (valor)
            {
                case int n when (n >= 1 && n <= 2):
                    tipo = "UTM/ROUTER";
                    break;
                case int n when (n >= 3 && n <= 8):
                    tipo = "SERVIDOR";
                    break;
                case int n when (n >= 9 && n <= 10):
                    tipo = "IMPRESORAS";
                    break;
                case int n when (n >= 11 && n <= 20):
                    tipo = "SWITCHES";
                    break;
                case int n when (n >= 21 && n <= 105):
                    tipo = "APS";
                    break;
                default:
                    tipo = "HOST";
                    break;
            }
            return tipo + " " + valor;
        }
        private void WriteTextSafe(string tipo, string ip, string mac, string estado, int i)
        {
            if (dataGridView2.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                dataGridView2.Invoke(d, new object[] { tipo, ip, mac, estado, i });

            }
            else
            {
                dataGridView2.Rows.Add(tipo, ip, mac, estado);
                label2.Text = " " + dataGridView2.Rows.Count;
            }

        }
        public void Ping(string host, int attemps, int timeout)
        {

            for (int i = 0; i < attemps; i++)
            {
                new Thread(delegate ()
                {
                    try
                    {
                        Ping ping = new Ping();
                        ping.PingCompleted += new PingCompletedEventHandler(PingCompleted);
                        ping.SendAsync(host, timeout, host);

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }).Start();

            }
        }
        private void PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;

            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {

                string macaddres = GetMacAddress(ip);
                string[] arr = new string[3];
                if (!ipMac.ContainsKey(ip))
                {
                    ipMac.Add(ip, macaddres);
                    WriteTextSafe(Validar_IP(ip), ip, macaddres, "  OK ", 0);

                }
            }


        }
        public string GetMacAddress(string ip)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "arp";
            process.StartInfo.Arguments = "-a " + ip;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string data = process.StandardOutput.ReadToEnd();
            string[] subdata = data.Split('-');
            if (subdata.Length >= 8)
            {
                macAddress = subdata[3].Substring(Math.Max(0, subdata[3].Length - 2))
                         + "-" + subdata[4] + "-" + subdata[5] + "-" + subdata[6]
                         + "-" + subdata[7] + "-"
                         + subdata[8].Substring(0, 2);
                return macAddress.ToUpper();
            }

            else
            {
                return "OWN Machine";
            }

        }

        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(79, 79, 82);
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(61, 64, 65);
        }
    }
}

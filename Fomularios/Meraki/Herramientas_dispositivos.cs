using CefSharp;
using CefSharp.WinForms;
using FOD_Meraki.Clases.Api_Fod;
using FOD_Meraki.Fomularios.FodApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace FOD_Meraki.Fomularios.Meraki
{
    public partial class Herramientas_dispositivos : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        private bool _estado_consulta;
        private string _path = string.Empty;
        private readonly string _pathPrincipal = @"https://n389.meraki.com/login/dashboard_login?email=randy.montoya%40fod.ac.cr&go=";
        private readonly string _textLogin = @"&password_login=true";
        readonly List<string> classname = new List<string>() {
            //"DetailsNav",
            "InfoListItemEditor",
            "NodeAddress InfoListItem--separated",
            "InfoListItem InfoListItem--separated SwitchProfile",
            //"InfoListItem InfoListItem--separated IPSettingsItem",
            "InfoListItem InfoListItem--separated LegalAndRegulatory",
            "InfoListItem InfoListItem--separated TopologyLink",
            "alert alert-warning config_template_alert no_margin ssid-admin-hidden strict-network-admin-hidden"

        };

        public Herramientas_dispositivos(string ruta,bool estado)
        {
   
            InitializeComponent();
            _estado_consulta = estado;
            _path = ruta;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            if (!_estado_consulta)
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }
            InitializeChromium();


        }
        public void InitializeChromium()
        {
            
            if (_estado_consulta)
            {
                chromeBrowser = new ChromiumWebBrowser(_path);
            }
            else
            {
                chromeBrowser = new ChromiumWebBrowser(_pathPrincipal + _path + _textLogin);
            }
            chromeBrowser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(web_view_FrameLoadEnd); 
            panel_herramientas_principal.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            

        }
        private void web_view_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            try
            {
                if (!_estado_consulta)
                {
                    chromeBrowser.ExecuteScriptAsync("document.getElementById('email').value= '"+Key.MailUserMeraki+"'");
                    chromeBrowser.ExecuteScriptAsync("document.getElementById('password').value= '"+Key.PasswordUserMeraki+"'");
                    chromeBrowser.ExecuteScriptAsync("document.getElementById('login-btn').click();");
                    
                }
                chromeBrowser.ExecuteScriptAsync("document.getElementById('main-nav').remove();");
                chromeBrowser.ExecuteScriptAsync("document.getElementById('masthead-react').remove();");
            }
            catch (Exception)
            {
               
            }
            timer1.Start();


        }
        private void Eliminar_Data_Extra()
        {
            Thread.Sleep(20);
            
            
            foreach (var element in classname)
            {
                try
                {
                    chromeBrowser.ExecuteScriptAsync("document.getElementsByClassName('" + element + "')[0].remove();");
                }
                catch (Exception)
                {
                    continue;
                }

            }
        }

        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Dispose();
            timer1.Stop();
            this.Dispose();
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Eliminar_Data_Extra();
        }


        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(_path);
        }

        private void VerZonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zonasaps zonasaps = new Zonasaps();
            zonasaps.Show();
        }

        
    }
}

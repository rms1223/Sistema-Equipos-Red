
using FOD_Meraki.Clases.Notify;
using FOD_Meraki.Fomularios;
using InterfazGrafica.Fomularios.Meraki;
using Sistema_Fod.Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazGrafica
{
    
    public partial class Form1 : Form
    {


        private Panel _leftBorder;
        private List<Button> _listaBotones;
        public Form1()
        {
            _ = new TelegramNotify();
            InitializeComponent();
            label2.Text="RMS "+ DateTime.Now.ToString("yyyy");
            _ = new Lectura_File();
            _leftBorder = new Panel();
            _leftBorder.Size = new Size(7, 30);
            panel_menu.Controls.Add(_leftBorder);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            _listaBotones = new List<Button>();
            Cargar_Button(panel_meraki);
            habilitarBotton(meraki_button, Color.FromArgb(103, 179, 70));

        }

        private void Cargar_Button(Panel p)
        {
            foreach (var item in p.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    _listaBotones.Add((Button)item);
                }
            }

            
        }

        private void habilitarBotton(object sender, Color color)
        {
            Button btn = (Button)sender;
            _leftBorder.BackColor = color;
            _leftBorder.Location = new Point(0, btn.Location.Y);
            _leftBorder.Visible = true;

            _leftBorder.BringToFront();

            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam,int Iparam);

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            habilitarBotton(button1, Color.FromArgb(0, 131, 123));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Quitar_Color()
        {
            foreach (var item in _listaBotones)
            {
                item.BackColor = Color.FromArgb(61, 64, 65);
            }
           
        }

        private void Change_ColorButton(object sender)
        {
            Quitar_Color();
            Button btn_color = (Button)sender;
            btn_color.BackColor = Color.FromArgb(79, 79, 82);
        }
        


        private void Cargar_panel(object panel)
        {

            if (panel_interior.Controls.Count > 0)
            {
                panel_interior.Controls.RemoveAt(0);
            }


            Form panel_in = panel as Form;
            panel_in.TopLevel = false;
            panel_in.Dock = DockStyle.Fill;
            panel_interior.Controls.Add(panel_in);
            panel_interior.Tag = panel_in;
            panel_in.Show();


        }

        private void Panel_interior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void Meraki_LR_MouseClick(object sender, MouseEventArgs e)
        {
            Change_ColorButton(meraki_LR);
        }

        private void Meraki_LR_Click(object sender, EventArgs e)
        {
            try
            {

                meraki_LR.Enabled = false;
                Listar_Redes listar_Redes = Listar_Redes.Get_instance;
                listar_Redes.Show();
                Cargar_panel(listar_Redes);
                meraki_LR.Enabled = true;
            }
            catch (Exception)
            {
                meraki_LR.Enabled = true;

            }
            
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            habilitarBotton(meraki_button, Color.FromArgb(103, 179, 70));
            StatusPanel(panel_meraki);
        }


        private void StatusPanel(Panel p)
        {
            if (p.Visible)
            {
                p.Visible = false;
            }
            else
            {
                p.Visible = true;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                button1.Enabled = false;
                Redes_Locales redes_Locales = new Redes_Locales();
                Cargar_panel(redes_Locales);
                button1.Enabled = true;
            }
            catch (Exception)
            {

                button1.Enabled = true;
            }
            
        }

        private void Button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Change_ColorButton(button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Aceptaciones acept = new Aceptaciones();
            Cargar_panel(acept);
            button2.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Consulta_CE_Cartel _consultaCE = new Consulta_CE_Cartel();
            Cargar_panel(_consultaCE);
            button3.Enabled = true;
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            Change_ColorButton(button2);
        }

        private void Button3_MouseClick(object sender, MouseEventArgs e)
        {
            Change_ColorButton(button3);
        }
    }
}

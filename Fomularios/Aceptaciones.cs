using FOD_Meraki.Clases.Api_Fod;
using FOD_Meraki.Clases.MailModel;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace FOD_Meraki.Fomularios
{
    public partial class Aceptaciones : Form
    {
        private Equipos_Redes_Fod _FodApi;
        private Mail _correo;
        private List<Attachment> _attachments;
        public Aceptaciones()
        {
            InitializeComponent();

            _FodApi = new Equipos_Redes_Fod();
            Cargar_Carteles();
            correo_input.Visible = false;
            _correo = new Mail();
            _attachments = new List<Attachment>();
            MailAddress correo = new MailAddress(Key.Mail_User);
        }


        private void Cargar_Carteles()
        {
            cartel.Items.Clear();
            var datos = _FodApi.Get_Carteles();
            foreach (var id_cartel in datos)
            {
               cartel.Items.Add(id_cartel);
            }
        }
        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            nombreCe.Text = _FodApi.Get_NombreCE(codigoce.Text);
            cartel.Focus();
        }

        private bool IsValidEmail()
        {
            try
            {
                MailAddress mail = new MailAddress(correo_input.Text);
                _correo.Mail_Cc.Add(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool IsFormatData()
        {
            bool estado = true;
            if (string.IsNullOrEmpty(nombre_tecnico.Text)) estado = false;
            if (string.IsNullOrEmpty(cartel.Text)) estado = false;
            if (string.IsNullOrEmpty(estado_aceptacion.Text)) estado = false;
            if (string.IsNullOrEmpty(fecha.Text)) estado = false;
            if (string.IsNullOrEmpty(estado_aceptacion.Text)) estado = false;
            if (string.IsNullOrEmpty(codigoce.Text)) estado = false;
            if (checkmail.Checked) estado = IsValidEmail();
            return estado;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (IsFormatData())
                {
                    Body_Mail _dataMail = Format_Data();
                    string request = _FodApi.Registrar_Aceptacion(_dataMail);
                    Enviar_Correo(_dataMail, "OK");
                    Limpiar_Data();
                }
                else
                {
                    MessageBox.Show("Falta ingresar datos","Error de Ingreso de Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error data " + ex);
            }
           
        }
        private void Limpiar_Data()
        {
            descripcion.Text = string.Empty;
            codigoce.Focus();
        }
        private Body_Mail Format_Data()
        {
            Body_Mail body_Mail = new Body_Mail
            {
                estado = estado_aceptacion.SelectedItem.ToString(),
                codigo = codigoce.Text,
                cartel = cartel.SelectedItem.ToString(),
                NombreTecnico = "Técnico de Aceptación: " + nombre_tecnico.Text,
                descripcion = descripcion.Text,
                fecha = fecha.Text,
                nombreCE = nombreCe.Text
            };

            return body_Mail;
        }



        private void Enviar_Correo(Body_Mail body_Mail, string request_aceptacion)
        {
            try
            {
                string data_CE = nombreCe.Text + "(" + codigoce.Text + ")";
                _correo.Mail_To = Key.Mail_To;
                _correo.Mail_Subject = "Aceptación de Red "+data_CE;
                _correo.Mail_Message = body_Mail;
                _correo.Mail_Cc.Add(new MailAddress(Key.Copy_Mail_To));
                _correo.attachments = _attachments;
                Procesar_Email proc = new Procesar_Email(_correo);
                bool estado = proc.Send_Mail();
                if (estado)
                {
                    MessageBox.Show("Registro de Aceptación: "+request_aceptacion+"\nCorreo Enviado", "Opciones de correo y aceptaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro de Aceptación: " + request_aceptacion + "\nError al enviar el Correo", "Opciones de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex, "Opciones de correos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Seleccione los documentos a enviar";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in dialog.FileNames)
                {
                    _attachments.Add(new Attachment(item));
                }
            }
            label3.Text = "Archivos  Cargados: " + _attachments.Count;
        }
        private void Clear_Attachments()
        {
            _attachments.Clear();
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Clear_Attachments();
            label3.Text = "Archivos  Cargados: " + _attachments.Count;
        }

        private void Checkmail_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkmail.Checked)
            {
                correo_input.Visible = true;
            }
            else
            {
                correo_input.Text = string.Empty;
                correo_input.Visible = false;
            }

        }
    }
}

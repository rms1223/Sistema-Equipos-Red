
using FOD_Meraki.Clases.Api_Fod;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Sistema_Fod.Seguridad
{
    class Lectura_File
    {
        public Lectura_File()
        {
            try
            {
                Seguriadad_Archivos.Descifrar_Archivo(Path.Combine(Application.StartupPath, @"Data\Configuration_App.xml.FOD"), Var_Name.Clave);
                XmlTextReader reader = new XmlTextReader(Path.Combine(Application.StartupPath, @"Data\Configuration_App.xml"));
                string nombre_actual = "";
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.None:
                            break;
                        case XmlNodeType.Element:

                            nombre_actual = reader.Name;
                            break;
                        case XmlNodeType.Text:
                            _Cargar_valores(nombre_actual, reader.Value);
                            break;
                        default:
                            break;
                    }

                }
                reader.Close();
                Seguriadad_Archivos.Cifrar_Archivo(Path.Combine(Application.StartupPath, @"Data\Configuration_App.xml"), Var_Name.Clave);
                

            }
            catch (Exception)
            {

                MessageBox.Show("Error al establecer Conexion", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _Cargar_valores(string nombre_campo, string valor)
        {
            switch (nombre_campo)
            {
                case "user":
                    Var_Name.user = valor;
                    break;
                case "pass":
                    Var_Name.pass = valor;
                    break;
                case "server":
                    Var_Name.server = valor;
                    break;
                case "name_database":
                    Var_Name.name_database = valor;
                    break;
                case "fod_token":
                    Key.XApiFodValue = valor;
                    break;
                case "fod_name":
                    Key.XApiFodName = valor;
                    break;
                case "mail_user":
                    Key.Mail_User = valor;
                    break;
                case "mail_pass":
                    Key.Mail_Pass = valor;
                    break;
                case "meraki_mail":
                    Key.MailUserMeraki = valor;
                    break;
                case "meraki_pass":
                    Key.PasswordUserMeraki = valor;
                    break;
                default:
                    break;
            }
        }
    }
}
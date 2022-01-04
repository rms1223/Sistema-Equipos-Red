using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FOD_Meraki.Clases.Api_Fod.Modelo
{
    class Manejo_Vistas
    {
        private DataGridView data;
        private Equipos_Redes_Fod _FodApi;
        private string _networkName;
        private int contador = 0;
        Image img;
        private List<Local_Devices> redesDispositivos;
        public Manejo_Vistas(DataGridView _data)
        {
            data = _data;
            _FodApi = new Equipos_Redes_Fod();
        }

        public int Get_CantidadDispositivos()
        {
            return data.Rows.Count;
        }

        public string CargarTemplate(string codigo)
        {
            try
            {
                return _FodApi.GetConfigTemplates(codigo);
            }
            catch (Exception)
            {
                return "No Especificado";
            }
        }
        
        public string Get_CeName(string codigo)
        {
            _networkName = _FodApi.Get_NombreCE(codigo);
            return _networkName;
        }
        public string Get_Estado_Sistema()
        {

            return _FodApi.Get_Estado_Sistema();
        }


        public void Cargar_Dispositivos(string codigo)
        {
            try
            {

                data.Rows.Clear();
                redesDispositivos = _FodApi.Generate_DevicesInRed(codigo);
                contador = 0;
                if (redesDispositivos.Count != 0)
                {
                    foreach (var item in redesDispositivos)
                    {
                      
                        string valor = item.status.ToUpper();
                        if (valor.Equals("ONLINE")|| valor.Equals("UP"))
                        {
                           
                            img = Image.FromFile(Key.Image_On);
                            
                        }
                        else
                        {
                            img = Image.FromFile(Key.Image_Off);
                        }
                        if (item.name.Contains("UTM"))
                        {
                            data.Rows.Add(img, item.name, item.serial, Key.IP_Router, item.mac,item.model,item.tags, item.notes,"Herramientas-PING");
                        }
                        else
                        {
                            data.Rows.Add(img, item.name, item.serial, item.lanIp, item.mac, item.model, item.tags, item.notes, "Herramientas-PING");
                        }

                        contador++;
                    }
                    

                }
                else
                {
                    data.Rows.Clear();
                    contador = 0;
                    MessageBox.Show("Centro Educativo no Encontrado ", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al procesar los datos verifique su Conexión "+ex, "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {

            //Force a call to the Paint event handler.
            data.Invalidate();
        }


        public string Get_RutaDispositivo(string serie)
        {
            string ruta = string.Empty;
            
            foreach (var item in redesDispositivos)
            {
                if (item.serial == serie)
                {
                    ruta = item.url;
                    break;
                }
            }
            
            return ruta;
        }

        public void Buscar_Dispositivo(string txt_search)
        {

            try
            {
                data.Rows.Clear();
                var redesDispositivos = _FodApi.Buscar_DevicesInRed(txt_search);
                contador = 0;
                
                if (redesDispositivos.Count != 0)
                {
                    foreach (var item in redesDispositivos)
                    {
                        
                        string valor = item.status.ToUpper();
                        if (valor.Equals("ONLINE") || valor.Equals("UP"))
                        {
                            img = Image.FromFile(Key.Image_On);
                        }
                        else
                        {
                            img = Image.FromFile(Key.Image_Off);
                        }
                        if (item.name.Contains("UTM"))
                        {
                            data.Rows.Add(img, item.name, item.serial, Key.IP_Router, item.mac, item.model, item.tags,item.notes,"Herramientas-PING");
                        }
                        else
                        {
                            data.Rows.Add(img, item.name, item.serial, item.lanIp, item.mac, item.model, item.tags,item.notes,"Herramientas-PING");
                        }

                        contador++;
                    }

                }
                else
                {
                    data.Rows.Clear();
                    contador = 0;
                    MessageBox.Show("Centro Educativo no Encontrado ", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception EX)
            {

                MessageBox.Show("Error al procesar los datos verifique su Conexión\n"+EX, "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        
    }
}

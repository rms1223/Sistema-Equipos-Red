using FOD_Meraki.Clases;
using FOD_Meraki.Clases.Api_Fod;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FOD_Meraki.Fomularios
{
    public partial class Consulta_CE_Cartel : Form
    {
        private Equipos_Redes_Fod _FodApi;
        private List<CartelCE> redesDispositivos;
        private List<Equipos_Asignados> dispositivosAsignados;
        public Consulta_CE_Cartel()
        {
            InitializeComponent();
            _FodApi = new Equipos_Redes_Fod();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Cargar_Datos_CartelCE();
        }

        private void Cargar_Datos_CartelCE()
        {
            try
            {

                datagridview_listarRedes.Rows.Clear();
                dataGridView_equipos.Rows.Clear();
                redesDispositivos = _FodApi.Get_Cartel_CE(codigo.Text);
                dispositivosAsignados = _FodApi.Get_Equipos_CE(codigo.Text);
                if (redesDispositivos.Count != 0)
                {
                    foreach (var item in redesDispositivos)
                    {

                        datagridview_listarRedes.Rows.Add(item.codigo_institucion, item.centro_educativo, item.id_categoria, item.provincia, item.canton, item.distrito);

                    }


                }
                else
                {
                    datagridview_listarRedes.Rows.Clear();
                    MessageBox.Show("Centro Educativo No Encontrado", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (dispositivosAsignados.Count != 0)
                {
                    foreach (var item in dispositivosAsignados)
                    {

                        dataGridView_equipos.Rows.Add(item.Equipo,item.Marca,item.Modelo,item.Cantidad);

                    }


                }
                else
                {
                    dataGridView_equipos.Rows.Clear();
                    
                }

            }
            catch (Exception ex)
            {
                dataGridView_equipos.Rows.Clear();
                MessageBox.Show("Error al procesar los datos verifique su Conexión " + ex, "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cargar_Datos_CartelCE();
            }
        }
    }
}

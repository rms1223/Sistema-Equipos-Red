using FOD_Meraki.Clases.Api_Fod;
using FOD_Meraki.Clases.Api_Fod.Modelo;
using FOD_Meraki.Fomularios;
using FOD_Meraki.Fomularios.FodApi;
using FOD_Meraki.Fomularios.Meraki;
using System;
using System.Windows.Forms;

namespace InterfazGrafica.Fomularios.Meraki
{
    public partial class Listar_Redes : Form
    {
        
        private Manejo_Vistas _manejo_Vistas;
        private static Listar_Redes instance = null;
        private bool estado_actual;

        public static Listar_Redes Get_instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Listar_Redes();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private Listar_Redes()
        {
            InitializeComponent();
            estado_actual = false;
            proveedor_name.Text = "Fundación Omar Dengo";
            _manejo_Vistas = new Manejo_Vistas(datagridview_listarRedes);
            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            Procesar_Peticion_Busqueda();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procesar_Peticion_Usuario();
            

        }



        private void Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Procesar_Peticion_Usuario();
            }
        }
        private void Procesar_Peticion_Usuario()
        {
            Buscar buscar = new Buscar();
            try
            {
                
                buscar.Show();
                button1.Enabled = false;
                button3.Enabled = false;
                estado_sistema.Text = _manejo_Vistas.Get_Estado_Sistema();
                nombre_ce.Text = _manejo_Vistas.Get_CeName(codigo.Text);
                template_nombre.Text = _manejo_Vistas.CargarTemplate(codigo.Text);
                _manejo_Vistas.Cargar_Dispositivos(codigo.Text);
                total_registros.Text = $"Total de Registros: {_manejo_Vistas.Get_CantidadDispositivos()}";
                button1.Enabled = true;
                button3.Enabled = true;
                buscar.Close();
            }
            catch (Exception)
            {
                button1.Enabled = true;
                buscar.Close();
            }
        }
       

        private void Procesar_Peticion_Busqueda()
        {
            Buscar buscar = new Buscar();
            try
            {
                buscar.Show();
                _manejo_Vistas.Buscar_Dispositivo(txt_buscar.Text);
                total_registros.Text = $"Total de Registros: {_manejo_Vistas.Get_CantidadDispositivos()}";
                buscar.Close();
            }
            catch (Exception)
            {
                buscar.Close();
                MessageBox.Show("Error al procesar la Consulta","Error....",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Procesar_Peticion_Busqueda();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                
                string serial = datagridview_listarRedes.Rows[e.RowIndex].Cells[2].Value.ToString();
                string _path = _manejo_Vistas.Get_RutaDispositivo(serial);
               
                if (_path.Equals("ARUBA"))
                {
                    string modelo = datagridview_listarRedes.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //HerramientasAruba _herramientasAruba = new HerramientasAruba(serial);
                    //_herramientasAruba.Show();
                }
                else
                {      
                    Herramientas_dispositivos herramientas_dispositivos = new Herramientas_dispositivos(_path,estado_actual);
                    herramientas_dispositivos.Show();
                    estado_actual = true;
                }
                
            }
        }

        private void DireccionamientoIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DireccionamientoIp direccionamientoIp = new DireccionamientoIp();
            direccionamientoIp.Show();
        }

        private void ModelosDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquiposCarteles equiposCarteles = new EquiposCarteles();
            equiposCarteles.Show();
        }

        private void ExportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportDatos exportDatos = new ExportDatos();
            exportDatos.Show();
            ExportDataExcel();
            exportDatos.Close();
        }
        private void ExportDataExcel()
        {
            Microsoft.Office.Interop.Excel.Application exportExcel = new Microsoft.Office.Interop.Excel.Application();
            exportExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            foreach (DataGridViewColumn columna in datagridview_listarRedes.Columns)
            {
                indiceColumna++;
                exportExcel.Cells[1, indiceColumna] = columna.Name;
            }
            int indiceFila = 0;

            foreach (DataGridViewRow filas in datagridview_listarRedes.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in datagridview_listarRedes.Columns)
                {
                    indiceColumna++;
                    exportExcel.Cells[indiceFila + 1, indiceColumna] = filas.Cells[columna.Name].Value;
                }
            }
            exportExcel.Visible = true;

        }

        private void EstandarDePuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estandar_Puertos _puertos = new Estandar_Puertos();
            _puertos.Show();
        }
    }
}

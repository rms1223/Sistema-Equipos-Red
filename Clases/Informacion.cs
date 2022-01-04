

namespace Sistema_Fod.Classes
{
    class Informacion
    {
        public string Codigo_presupuestario { get; set; }
        public string Nombre_centroeducativo { get; set; }
        public string Contactos { get; set; }
        public string Info_Internet { get; set; }
        public string Categoria { get; set; }
        public string Modalidad { get; set; }
        public string Fecha_Visita { get; set; }
        public string Descripcion { get; set; }
        public string Cartel { get; set; }

        public Informacion(string codigo, string nombre, string contacto,
            string internet, string categoria, string modalidad, string fecha, string descriipcion, string cartel)
        {
            Codigo_presupuestario = codigo;
            Nombre_centroeducativo = nombre;
            Contactos = contacto;
            Info_Internet = internet;
            Categoria = categoria;
            Modalidad = modalidad;
            Fecha_Visita = fecha;
            Descripcion = descriipcion;
            Cartel = cartel;
        }
    }
}
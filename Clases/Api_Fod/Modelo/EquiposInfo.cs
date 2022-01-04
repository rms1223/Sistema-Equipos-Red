

namespace FOD_Meraki.Clases.Api_Fod.Modelo
{
    class EquiposInfo
    {
        public string estado { get; set; }
        public string serial { get; set; }
        public string nombre { get; set; }
        public string ip { get; set; }
        public string mac { get; set; }
        public string modelo { get; set; }
        public string tags { get; set; }
        public string codigo { get; set; }
        public string ruta { get; set; }
        
        public EquiposInfo(string name, string serial_dev, string ip_dev, string mac_dev, string model, string tags_dev, string status, string path, string codigoCE)
        {
            nombre = name;
            serial = serial_dev;
            ip = ip_dev;
            mac = mac_dev;
            modelo = model;
            tags = tags_dev;
            estado = status;
            ruta = path;
            codigo = codigoCE;
        }
        public EquiposInfo()
        {

        }
    }
}


namespace FOD_Meraki.Clases.Api_Fod.Modelo
{
    class estado_dispositivos
    {
        public string serial_equipo { get; set; }
        public string estado { get; set; }
        public string dashboard { get; set; }

        public estado_dispositivos()
        {

        }
      
    }
    class Network_Device
    {
        public string status { get; set; }
        public string serial { get; set; }
        public string name { get; set; }
        public string lanIp { get; set; }
        public string mac { get; set; }
        public string model { get; set; }
        public string notes { get; set; }
        public string[] tags { get; set; }
        public string url { get; set; }

        public estado_dispositivos estado_dispositivos { get; set; }
        public Network_Device(string notas, string nombre, string serial_dev, string ip_dev, string mac_dev, string modelo, string[] tags_dev, string estado, string path)
        {
            name = nombre;
            serial = serial_dev;
            lanIp = ip_dev;
            mac = mac_dev;
            model = modelo;
            tags = tags_dev;
            status = estado;
            url = path;
            notes = notas;
        }
        public Network_Device()
        {

        }
    }
}

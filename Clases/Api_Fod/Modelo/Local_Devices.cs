

namespace FOD_Meraki.Clases.Api_Fod.Modelo
{
    class Local_Devices
    {

        public string status { get; set; }
        public string serial { get; set; }
        public string name { get; set; }
        public string lanIp { get; set; }
        public string mac { get; set; }
        public string model { get; set; }
        public string notes { get; set; }
        public string tags { get; set; }
        public string url { get; set; }

        public Local_Devices(string notas, string nombre, string serial_dev, string ip_dev, string mac_dev, string modelo, string tags_dev, string estado, string path)
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
        public Local_Devices()
        {

        }
    }
}


using System.Collections.Generic;

namespace FOD_Meraki.Clases.Api_Fod.Modelo
{   
    /// <summary>
    /// Clase Utilizada para manejar las peticiones entre la vista y el api fod para tools aruba
    /// </summary>
    class ManejoArubaRequest
    {
        Equipos_Redes_Fod _FodApi;
        public ManejoArubaRequest()
        {
            _FodApi = new Equipos_Redes_Fod();
        }

        public PingDevicesAruba Procesar_Ping_Aruba(string serie,string ip_host, string tipo)
        {
            if (tipo.Equals("SWITCH"))
            {
                return _FodApi.Sent_PingAruba_Switch(serie, ip_host);
            }
            else
            {
                return _FodApi.Sent_PingAruba(serie, ip_host);
            }
            
        }


    }
}

using System;


namespace Sistema_Fod.Seguridad
{
    public static class Var_Name
    {

        public static string server { get; set; }
        public static string user { get; set; }
        public static string pass { get; set; }
        public static string name_database { get; set; }

        

        public static string Fecha_Actual
        {
            get
            {

                return DateTime.Now.ToString("dd/MM/yyyy");
            }
        }
        public static string Clave
        {
            get
            {

                return "";
            }
        }
        public static string Tipo_Equipo
        {
            get
            {

                return "Tipo_Equipo";
            }
        }
        public static string Codigo_Equipo
        {
            get
            {

                return "Codigo_Equipo";
            }
        }
        public static string Cantidad
        {
            get
            {

                return "Cantidad";
            }
        }
        public static string Modelo
        {
            get
            {

                return "Modelo";
            }
        }
        public static string Equipo
        {
            get
            {

                return "Equipo";
            }
        }
        public static string Marca
        {
            get
            {

                return "Marca";
            }
        }
    }
}


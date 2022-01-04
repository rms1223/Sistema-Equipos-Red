using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Fod.Seguridad
{
    class Seguriadad_Archivos
    {
        public static void Cifrar_Archivo(string path_file, string key)
        {
            try
            {
                byte[] file_read = File.ReadAllBytes(path_file);
                using (var DES = new DESCryptoServiceProvider())
                {
                    DES.IV = Encoding.UTF8.GetBytes(key);
                    DES.Key = Encoding.UTF8.GetBytes(key);
                    DES.Mode = CipherMode.CBC;
                    DES.Padding = PaddingMode.PKCS7;
                    using (var stream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(stream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(file_read, 0, file_read.Length);
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(path_file + ".FOD", stream.ToArray());
                        stream.Close();
                    }
                    DES.Clear();
                }
                File.Delete(path_file);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar vuelva a intentarlo" + ex, "Error al Iniciar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Descifrar_Archivo(string path_file, string key)
        {
            try
            {
                byte[] file_read_descrifrar = File.ReadAllBytes(path_file);
                using (var DES = new DESCryptoServiceProvider())
                {
                    DES.IV = Encoding.UTF8.GetBytes(key);
                    DES.Key = Encoding.UTF8.GetBytes(key);
                    DES.Mode = CipherMode.CBC;
                    DES.Padding = PaddingMode.PKCS7;
                    using (var stream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(stream, DES.CreateDecryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(file_read_descrifrar, 0, file_read_descrifrar.Length);
                        cryptoStream.FlushFinalBlock();
                        string[] paths = path_file.Split('.');
                        File.WriteAllBytes(paths[0] + "." + paths[1], stream.ToArray());

                        stream.Close();
                    }
                    DES.Clear();
                }
                File.Delete(path_file);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar vuelva a intentarlo" + ex, "Error al Iniciar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

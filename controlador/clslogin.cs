using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using GAES_SIREGU.modelo;
using EASendMail;

namespace GAES_SIREGU.controlador
{
    public class clslogin
    {
        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


        public bool encontraruser(string username, string password)
        {
            string ClaveEncrp = GetSHA256(password);
            using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
            {
                var Find = db.usuarios.Where(x => x.usuario == username && x.contra == ClaveEncrp).FirstOrDefault();
                if (Find != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool editarContraseña(string usuario, string contraAnt, string contraNuev)
        {
            contraNuev = GetSHA256(contraNuev);
            contraAnt = GetSHA256(contraAnt);

            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    int a = db.EditarDatosUsu(usuario, contraAnt, contraNuev);
                    if (a > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool EnviarCorreo(string correoDestino, string nuevaContra)
        {
            try
            {
                SmtpMail objCorreo = new SmtpMail("TryIt");
                objCorreo.From = "jepea659@misena.edu.co";
                objCorreo.To = correoDestino;
                objCorreo.Subject = "Restablecimiento de Contraseña";
                objCorreo.HtmlBody = "SU NUEVA CONTRASEÑA ES: <b>" + nuevaContra + "</b>";


                SmtpServer objServer = new SmtpServer("smtp.gmail.com");
                objServer.User = "jepea659@misena.edu.co";
                objServer.Password = "diosyfutbol1";
                objServer.Port = 587;
                objServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient objCliente = new SmtpClient();
                objCliente.SendMail(objServer, objCorreo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool RestablecerContra(string correo, string usuario, string nuevaContraSHA)
        {
            try
            {
                using (DBSIGERUEntities1 db = new DBSIGERUEntities1())
                {
                    var data = db.RestablecerContra(usuario, correo, nuevaContraSHA);

                    if (data > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public string GenerarContraseñaSegura()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            string contrasenaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contrasenaAleatoria += letra.ToString();
            }
            return contrasenaAleatoria;
        }
    }
}

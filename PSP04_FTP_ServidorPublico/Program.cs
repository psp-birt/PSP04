/*Programa PSP04-FTP
 * Transferir un fichero a un servidor FTP con librerias de .NET
 */
using System;
using System.IO;
using System.Net;
using System.Text;

namespace FTP
{
    class Program
    {
        public static void Main(String[] args)
        {

            # region Crear una conexión FTP
            //Indicamos servidor al que nos vamos a conectar. Nuestro servidor no dispone de ninguna dirección URL o ULI y por lo tanto lo adaptamos a la dirección IP
            //En este caso vamos a subir un fichero local y necesitamos indicarle el nombre del fichero que va a recibir en el servidor.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.dlptest.com/" + "/" + "fichBirtPublico.txt");

            // Si no se especifican las credenciales se asignan unas credenciales de tipo anónimas. El servidor lo deberá permitir.
            request.Credentials = new NetworkCredential("dlpuser", "rNrKYTX9g7z3RgJRmxWuGHbeu");

            //Recogemos en el atributo Method el tipo de operación que vamos a realizar: en este caso subir un fichero.
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;


            #endregion

            #region Obtener contenido del fichero a transferir
            byte[] fileContents;

            //Recogemos el contenido del fichero en un buffer
            string rutaFichero = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "fichero.txt");
            using (StreamReader sourceStream = new StreamReader(rutaFichero))
            {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            #endregion

            #region Transferir el fichero al servidor FTP

            //Creamos un objeto de tipo Stream para enviar la información
            //Hacemos uso del método write, pasamos el contenido del fichero, offset(0) indicando el comienzo del fichero  y longitud del fichero.
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }
            #endregion

            #region Obtener respuesta del servidor
            //Se espera la respuesta y se muestra por consola.
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine("Fichero subido con código: " + response.StatusDescription);
            }
            #endregion
        }
    }
}
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    internal class Program
    {
        // Creamos un cliente reutilizable para las solicitudes de la aplicación.
        private static readonly HttpClient cliente = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)
        };

        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Indicamos la URL de la página que queremos consultar.
            const string url = "https://www.example.com/";

            try
            {
                Console.WriteLine($"Consultando: {url}");

                // Enviamos una solicitud GET y obtenemos la respuesta.
                using HttpResponseMessage respuesta = await cliente.GetAsync(url);

                // Mostramos el código de estado y el tipo de contenido recibido.
                Console.WriteLine($"Estado HTTP: {(int)respuesta.StatusCode} ({respuesta.StatusCode})");
                Console.WriteLine($"Tipo de contenido: {respuesta.Content.Headers.ContentType}");

                // Comprobamos si el servidor ha devuelto un estado entre 200 y 299.
                if (!respuesta.IsSuccessStatusCode)
                {
                    Console.WriteLine("El servidor ha respondido, pero la consulta no ha tenido éxito.");
                    return;
                }

                // Leemos el cuerpo de la respuesta como una cadena de texto.
                string html = await respuesta.Content.ReadAsStringAsync();

                // Mostramos el HTML recibido. La consola no interpreta sus etiquetas.
                Console.WriteLine();
                Console.WriteLine("Contenido de la página:");
                Console.WriteLine(html);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"No se ha podido completar la solicitud: {ex.Message}");
            }
            catch (TaskCanceledException)
            {
                // En este ejemplo no se solicita cancelación manual.
                Console.WriteLine("Se ha superado el tiempo máximo de espera de la solicitud.");
            }
        }
    }
}

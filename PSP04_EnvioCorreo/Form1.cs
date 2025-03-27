// librerías para Windows Forms.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

//import de las librerías de Google API
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using System.Net;



namespace GmailApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {


            //Inicializa los componentes
            InitializeComponent();

            ClientSecrets secrets = new ClientSecrets
            {
                ClientId = googleClientId,
                ClientSecret = googleClientSecret

            };

            //Autentica usuario con API de Gmail.
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(secrets, scopes, "user", CancellationToken.None).Result;

        }

 
        private void button1_Click(object sender, EventArgs e)
        {

            /*Texto del mensaje*/
            string message = $"To: " + this.textPara.Text + "\r\nSubject: " + this.textAsunto.Text + "\r\nContent-Type: text/html;charset=utf-8\r\n\r\n<h1>" + this.textCuerpo.Text + "</h1>";



            /*Creación de servicio y envío de email*/

            try
            {
                var gmailService = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = this.nombreAplicacion
                });
                 
                var newMsg = new Google.Apis.Gmail.v1.Data.Message();   
                newMsg.Raw = Base64UrlEncode(message.ToString());

                var solicitud = gmailService.Users.Messages.Send(newMsg, "me");
                solicitud.Execute();
                MessageBox.Show("Email enviado correctamente");


            }
            catch (Google.GoogleApiException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*método para codificar el mensaje en base64*/
        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }



    }
}

/*

//Importamos las librerías

	using Google.Apis.Auth.OAuth2;
	using Google.Apis.Gmail.v1;
	using Google.Apis.Gmail.v1.Data;
	using Google.Apis.Services;


//creamos las credenciales y sincronizamos con la cuenta de Google

	ClientSecrets secrets = new ClientSecrets
    {
        ClientId = googleClientId,
        ClientSecret = googleClientSecret

    };

UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(secrets, scopes, "user", CancellationToken.None).Result;

//Creamos el servicio 
var gmailService = new GmailService(new BaseClientService.Initializer()
{
    HttpClientInitializer = this.credential,
    ApplicationName = this.nombreAplicacion
});

//Creamos mensaje en formato apropiado.

var msg = new Google.Apis.Gmail.v1.Data.Message();
msg.Raw = Base64UrlEncode(message.ToString());

//Hacemos el envío mediante send y lo ejecutamos.
var solicitud = gmailService.Users.Messages.Send(msg, "me");
solicitud.Execute();


https://googleapis.dev/dotnet/Google.Apis.Gmail.v1/latest/api/Google.Apis.Gmail.v1.html
https://developers.google.com/workspace/gmail?hl=es-419

*/


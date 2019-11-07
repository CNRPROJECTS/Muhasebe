using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhDesktop.Others;
using MuhShared;
using Newtonsoft.Json;


namespace MuhDesktop.Service
{
    class Services
    {
        readonly ErrorMessages ErrMes = new ErrorMessages();
        public async void UserLogin(MUserLogin u)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8090/");
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsJsonAsync("api/Login", u);
         
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        ErrMes.ShorErrorMessages(ErrorMessages.MessageTypes.Error, response.ReasonPhrase);
                    }

                }

            }
            catch (Exception e)
            {
                ErrMes.ShorErrorMessages(ErrorMessages.MessageTypes.Error, e.Message);
                throw;
            }
        }
    }
}

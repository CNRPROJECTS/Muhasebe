using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using MuhShared;
namespace MuhDesktop.Service
{
    class Services
    {
        public async void UserLogin(string username, string password)
        {
            MUserLogin userlogin = new MUserLogin();
            userlogin.Username = username;
            userlogin.Password = password;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8090/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Login", userlogin);
                MessageBox.Show(response.Content.ReadAsStringAsync().ToString());

            }

        }
    }
}

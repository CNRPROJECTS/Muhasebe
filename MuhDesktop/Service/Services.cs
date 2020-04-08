using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhDesktop.Others;
using MuhShared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Web;
using RestSharp;

namespace MuhDesktop.Service
{
    class Services
    {
        readonly ErrorMessages ErrMes = new ErrorMessages();
        public  void UserLogin(MUserLogin u)
        {
            try
            { 
                var client = new RestClient("http://localhost:8090/");
                var request = new RestRequest("api/Login",Method.POST,dataFormat:DataFormat.Json);
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            var json = JsonConvert.SerializeObject(u);
            request.AddParameter("application/json", ParameterType.RequestBody);
            request.AddJsonBody(json);
            var response = client.Execute<MUser>(request);
            
            if (response.StatusCode != HttpStatusCode.OK)
            {
                ErrMes.ShorErrorMessages(ErrorMessages.MessageTypes.Error,response.StatusDescription);
              
            }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
        }
    }
}




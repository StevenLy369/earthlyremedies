using System.Threading.Tasks;
using RestSharp;

namespace EarthlyRemediesClient.Models
{
    class ApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }


        public static async Task<string> GetDetails(int id)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies/{id}", Method.GET);

            var reponse = await client.ExecuteTaskAsync(request);
            return reponse.Content;
        }

        public static async Task Put(int id, string newRemedy)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies/{id}", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newRemedy);
            var response = await client.ExecuteTaskAsync(request);
        }
        public static async Task Post(string newRemedy)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"remedies", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newRemedy);
            var response = await client.ExecuteTaskAsync(request);
        }
    }
}
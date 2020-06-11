using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EarthlyRemediesClient.Models;



namespace EarthlyRemediesClient.Models
{
    public class Remedy
    {

        public int RemedyId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }

        [StringLength(30)]
        public string Ailment { get; set; }
        [Required]
        public string Category { get; set; }
        public string Ingredients { get; set; }
        public int UserId { get; set; }

        public static List<Remedy> GetRemedies()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Remedy> remedyList = JsonConvert.DeserializeObject<List<Remedy>>(jsonResponse.ToString());

            return remedyList;
        }

        public static Remedy GetDetails(int id)
        {
            var apiCallTask = ApiHelper.GetDetails(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Remedy remedy = JsonConvert.DeserializeObject<Remedy>(jsonResponse.ToString());

            return remedy;
        }

        public static void Put(Remedy remedy)
        {
            System.Console.WriteLine("PUT FROM MODEL CALLED!");
            System.Console.WriteLine(remedy.Name);
            string jsonRemedy = JsonConvert.SerializeObject(remedy);
            var apiCallTask = ApiHelper.Put(remedy.RemedyId, jsonRemedy);

        }
        public static void Post(Remedy remedy)
        {
            string jsonRemedy = JsonConvert.SerializeObject(remedy);
            var apiCallTask = ApiHelper.Post(jsonRemedy);
        }
    }
}
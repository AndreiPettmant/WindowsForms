using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetPokeAPI.Classes
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://reqres.in/api/";

        public static async Task<string> GetAll()
        {
            using(HttpClient client = new HttpClient())
            {
               using(HttpResponseMessage res = await client.GetAsync(baseURL + "users"))
                {
                    using(HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Post(string name, string job)
        {
            var inputData = new Dictionary<string, string>
            {
                { "name", name },
                { "job", job },
            };
            var input = new FormUrlEncodedContent(inputData);         
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Put(string id, string name, string job)
        {
            var inputData = new Dictionary<string, string>
            {
                { "name", name },
                { "job", job },
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show("User ID: " + id + " Was successfully deleted");
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }
    }
}

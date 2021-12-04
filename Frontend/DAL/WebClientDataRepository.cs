using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Frontend
{
    public class ComplexResult
    {
        public string Message { get; set; }
        public ResultType ResultType { get; set; }
    }
    public enum ResultType
    {
        OK,
        Error
    }
    public class DataResult<T>
    {
        public T Result { get; private set; }
        public ComplexResult ComplexResult { get; private set; }

        public DataResult(T result, ComplexResult complexResult)
        {
            Result = result;
            ComplexResult = complexResult;
        }
    }
    public interface IDataObject
    {
        string Id { get; set; }
    }
    public class Token : IDataObject
    {
        [JsonPropertyName("userId")]
        public string Id { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

    }
    public class Project : IDataObject
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("permissions")]
        public string Permissions { get; set; }

        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        [JsonPropertyName("createdDateUtc")]
        public DateTime CreatedDateUtc { get; set; }

        [JsonPropertyName("deletedOn")]
        public string DeletedOn { get; set; }

        [JsonPropertyName("drawingCount")]
        public int DrawingCount { get; set; }

        [JsonPropertyName("documentCount")]
        public int DocumentCount { get; set; }

        [JsonPropertyName("userCount")]
        public int UserCount { get; set; }

        [JsonPropertyName("issuesCount")]
        public int IssuesCount { get; set; }

        [JsonPropertyName("organizationId")]
        public string OrganizationId { get; set; }

    }

    public interface IDataRepository<T> where T : IDataObject
    {
        public Task<DataResult<IEnumerable<T>>> GetAll();
    }

    public class WebClientDataRepository : IDataRepository<Project>
    {
        private const string urlAuth = "https://preprod-api.bullclip.com/api/v1/auth/login";
        private const string urlProjects = "https://preprod-api.bullclip.com/api/v1/project/my";
        public async Task<DataResult<IEnumerable<Project>>> GetAll()
        {
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(urlAuth);
                httpRequest.Method = "POST";

                httpRequest.Headers["accept"] = "application/json";
                httpRequest.ContentType = "application/json";

                var data = "{\"username\":\"codetest@drawboard.com\",\"password\":\"K5y&*A99WDo\"}";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                Token token;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string jsonTextResult = streamReader.ReadToEnd();
                    token = JsonConvert.DeserializeObject<Token>(jsonTextResult);
                }
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                string json = await client.GetStringAsync(urlProjects);
                var result = JsonConvert.DeserializeObject<IEnumerable<Project>>(json);


                return new DataResult<IEnumerable<Project>>(result, new ComplexResult { Message = null, ResultType = ResultType.OK });
            }
            catch (Exception ex)
            {
                return new DataResult<IEnumerable<Project>>(null, new ComplexResult { Message = ex.Message, ResultType = ResultType.Error });
            }

        }


    }
}

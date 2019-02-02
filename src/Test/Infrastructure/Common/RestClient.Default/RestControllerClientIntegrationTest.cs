using Newtonsoft.Json;
using Optivem.Platform.Infrastructure.Common.RestClient.Default;
using Optivem.Platform.Infrastructure.Common.Serialization.Json.NewtonsoftJson;
using Optivem.Platform.Test.Common;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Optivem.Platform.Infrastructure.Core.RestClient.Default.Test.Integration
{
    public class RestControllerClientIntegrationTest
    {
        private static JsonSerializationService jsonSerializationService = new JsonSerializationService();

        [Fact]
        public async Task TestGetAsyncId()
        {
            // TODO: VC: DELETE "https://jsonplaceholder.typicode.com/todos"

            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
            };

            var client = new RestControllerClient<int>(httpClient, "todos", jsonSerializationService);

            var actual = await client.GetResourceAsync<TodoDto>(1);

            var expected = new TodoDto
            {
                Id = 1,
                UserId = 1,
                Title = "delectus aut autem",
                Completed = false,
            };

            AssertUtilities.AssertEqual(expected, actual);
        }

        private class TodoDto
        {
            public int Id { get; set; }

            public int UserId { get; set; }

            public string Title { get; set; }

            public bool Completed { get; set; }
        }

        // TODO: VC: Remove dependency on Newtonsoft.Json


    }
}
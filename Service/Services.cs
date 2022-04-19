using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Service.Modal;
using Service.Request;
using Service.Response;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Services
    {
        private readonly string baseUrl = "https://jsonplaceholder.typicode.com";
        //public Services(string _baseUrl)
        //{
        //    baseUrl = _baseUrl;
        //}

        public async Task<PostsResponse> GetPosts()
        {
            return await baseUrl.AppendPathSegment("posts").GetJsonAsync<PostsResponse>().ConfigureAwait(false);
        }

        public async void PostPosts(PostRequest request)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");
            var result=await baseUrl.WithHeader("Content-type", "application/json, charset=UTF-8").AppendPathSegment("posts").PostJsonAsync(content).ConfigureAwait(false);
        }

        public async void PutPost(PutRequest request,string postID)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(request), System.Text.Encoding.UTF8, "application/json");
            var result = await baseUrl.AppendPathSegments("posts",postID).PutJsonAsync(content).ConfigureAwait(false);
        }



    }
}

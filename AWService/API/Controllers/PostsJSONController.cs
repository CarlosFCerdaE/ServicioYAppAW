using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class PostsJSONController : Controller
    {
        // GET: PostsJSON
      

        public async Task<ActionResult> Index()
        {
            var client = new HttpClient();
            var Json = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var result = JsonConvert.DeserializeObject<List<apiCls>>(Json);

            return View(result);
        }
    }
}
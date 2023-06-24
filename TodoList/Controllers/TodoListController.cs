using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System;
using System.Net;


namespace TodoList.Controllers
{
   [ApiController]
   [Route("[controller]")]

   public class TodoListController : ControllerBase
   {

      [HttpGet]
      [(HttpStatusCode.OK, "Success", typeof(string))]
      public async Task<string> GetWebPageContent(string url)
      {
         // Create a new HttpClient instance
         var httpClient = new HttpClient();

         // Send an HTTP GET request to the specified URL and retrieve the response content as a string
         var response = await httpClient.GetAsync(url);
         var content = await response.Content.ReadAsStringAsync();

         // Return the retrieved content
         return content;

      }
   }
}

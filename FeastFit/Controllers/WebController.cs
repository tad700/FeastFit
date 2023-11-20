using FeastFit.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Net.Http;
using System.Xml.Linq;
using FeastFit.Models;
using static System.Net.Mime.MediaTypeNames;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FeastFit.Controllers
{
    public class WebController : Controller
    {
        const int NUMBER = 5;
        private readonly string apiKey = "3c7387a3494f410fb0d2585a5eb6af6d";



        public IActionResult WebIndex(string cuisine,string query, int maxCalories, int minProtein,int minCarbs)
        {
            var arlist = new ArrayList();

            var url = $"https://api.spoonacular.com/recipes/complexSearch?apiKey={apiKey}&minProtein={minProtein}&minCarbs={minCarbs}&maxCalories={maxCalories}&cuisine={cuisine}&query={query}&number={NUMBER}";
            var body = "";
            FeastFitDbContext db = new FeastFitDbContext();


            using (var client = new HttpClient())
            //ADD "{" here
            {
                client.BaseAddress = new Uri(url);
                //Send
                var response = client.GetAsync("").Result;

                //Process
                body = response.Content.ReadAsStringAsync().Result;

                JObject data = JObject.Parse(body);

                int i = 0;
                while (i < NUMBER && i < data["results"].Count())
                {
                    Recipe n = new Recipe();
                    n.IDOfRecipe = (int)data["results"][i]["id"];
                    n.Title = (string)data["results"][i]["title"];
                    n.MaxCalories = (int)data["results"][i]["nutrition"]["nutrients"][0]["amount"];
                    n.ProteinAmount = (int)data["results"][i]["nutrition"]["nutrients"][1]["amount"];
                    n.CarbAmount = (int)data["results"][i]["nutrition"]["nutrients"][2]["amount"];
                    n.RecipeImage = (string)data["results"][i]["image"];
                    arlist.Add(n);
                    i++;
                }

                db.recipes.RemoveRange(db.recipes);
                db.SaveChanges();
                foreach (var item in arlist)
                {
                    if (item != null)
                    {
                        db.Add(item);
                        db.SaveChanges();
                    }
                }

                var recipe = db.recipes.ToList();
                return View(recipe);
            }
            //ADD "}" HERE

            return View();
        }
    }
}

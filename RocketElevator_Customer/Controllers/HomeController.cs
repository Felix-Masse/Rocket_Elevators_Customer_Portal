using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RocketElevator_Customer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Claims;

namespace RocketElevator_Customer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ProductManagement()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);

            //Get building
            HttpClient buildingClient = new HttpClient();
            var responceBuilding = buildingClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Buildings/Customer/" + userName).GetAwaiter().GetResult();
            List<Building> buildingList = JsonConvert.DeserializeObject<List<Building>>(responceBuilding);

            ViewBag.building = buildingList;

            //Get Batteries
            HttpClient batteryClient = new HttpClient();
            var responseBattery = batteryClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Batteries/Customer/" + userName).GetAwaiter().GetResult();
            List<Battery> batteryList = JsonConvert.DeserializeObject<List<Battery>>(responseBattery);

            ViewBag.battery = batteryList;

            HttpClient columnClient = new HttpClient();
            var responseColumn = columnClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Columns/Customer/" + userName).GetAwaiter().GetResult();
            List<Column> columnList = JsonConvert.DeserializeObject<List<Column>>(responseColumn);

            ViewBag.column = columnList;

            HttpClient elevatorClient = new HttpClient();
            var responseElevator = elevatorClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Elevators/Customer/" + userName).GetAwaiter().GetResult();
            List<Elevator> elevatorList = JsonConvert.DeserializeObject<List<Elevator>>(responseElevator);

            ViewBag.elevator = elevatorList;



            return View();
        }

        public IActionResult Intervention()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);

            //Get building
            HttpClient buildingClient = new HttpClient();
            var responceBuilding = buildingClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Buildings/Customer/" + userName).GetAwaiter().GetResult();
            List<Building> buildingList = JsonConvert.DeserializeObject<List<Building>>(responceBuilding);

            ViewBag.building = buildingList;

            //Get Batteries
            HttpClient batteryClient = new HttpClient();
            var responseBattery = batteryClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Batteries/Customer/" + userName).GetAwaiter().GetResult();
            List<Battery> batteryList = JsonConvert.DeserializeObject<List<Battery>>(responseBattery);

            ViewBag.battery = batteryList;

            HttpClient columnClient = new HttpClient();
            var responseColumn = columnClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Columns/Customer/" + userName).GetAwaiter().GetResult();
            List<Column> columnList = JsonConvert.DeserializeObject<List<Column>>(responseColumn);

            ViewBag.column = columnList;

            HttpClient elevatorClient = new HttpClient();
            var responseElevator = elevatorClient.GetStringAsync("https://felixrestapicode.azurewebsites.net/api/Elevators/Customer/" + userName).GetAwaiter().GetResult();
            List<Elevator> elevatorList = JsonConvert.DeserializeObject<List<Elevator>>(responseElevator);

            ViewBag.elevator = elevatorList;



            return View();
        }
    }
}

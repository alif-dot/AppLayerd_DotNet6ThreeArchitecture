﻿using App.BLL.Services.Contracts;
using App.DAL.Models;
using App.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ShowEmployees()
        {
            List<Employee> listEmployyes = await _employeeService.GetEmployees();
            return View(listEmployyes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
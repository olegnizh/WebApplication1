﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models.Db;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }
    }

}

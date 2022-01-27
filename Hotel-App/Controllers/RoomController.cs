using Hotel_App.Data;
using Hotel_App.Models.Entities;
using Hotel_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Controllers
{
    public class RoomController : Controller
    {

        private AppDbContext _dbContext;

        public RoomController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Rooms.Include(r => r.RoomImages).ToListAsync());
        }

        //***** Detail *****//
        public async Task<IActionResult> Detail(int id)
        {
            var room = await _dbContext.Rooms.Include(r => r.RoomImages).FirstOrDefaultAsync(r => r.Id == id);
            var comments = await _dbContext.Comments.ToListAsync();
            if(room == null)
            {
                return NotFound();
            }
            return View(new RoomIndexViewModel { 
                Room = room,
                Comments = comments
            });
        }

        //***** Comment *****//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comment(CreateCommentViewModel model)
        {
            Comment comment = new Comment
            {
                FullName = model.FullName,
                Email = model.Email,
                Text = model.Text,
                RoomId = model.RoomId
            };

            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Detail), "Room", new {id = model.RoomId });
        }
    }
}

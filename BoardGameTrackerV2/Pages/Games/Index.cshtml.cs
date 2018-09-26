using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BoardGameTrackerV2.Data;
using BoardGameTrackerV2.Models;

namespace BoardGameTrackerV2.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly BoardGameTrackerV2.Data.ApplicationDbContext _context;

        public IndexModel(BoardGameTrackerV2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}

using BlazorApp1.Data;
using BlazorApp1.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<Game> AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return game;
        }

        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);

            var games = await _context.Games.ToListAsync();
            return games;

        }
    }
}

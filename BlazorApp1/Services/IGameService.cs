using BlazorApp1.Entity;

namespace BlazorApp1.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGame(Game game);
    }
}

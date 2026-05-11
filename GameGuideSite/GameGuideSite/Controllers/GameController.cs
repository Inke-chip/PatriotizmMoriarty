using Microsoft.AspNetCore.Mvc;
using GameGuideSite.Models;
using System.Collections.Generic;

namespace GameGuideSite.Controllers
{
    public class GamesController : Controller
    {
        private static List<Game> games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Title = "World of Warcraft",
                Description = "Легендарная MMORPG от Blizzard с огромным открытым миром.",
                Rating = 8.5,
                OnlinePlayers = 1250000,
                Lore = "Азерот - мир, где Орда и Альянс борются за выживание против древних злых сил.",
                LastUpdateSummary = "Обновление 10.2.5: Новые эпохальные подземелья, улучшения Dragonriding и события в честь Древа Жизни.",
                GuideLink = "/guides/wow",
                ImageUrl = "https://via.placeholder.com/300x160?text=WoW"
            },
            new Game
            {
                Id = 2,
                Title = "Counter-Strike 2",
                Description = "Культовый командный шутер от Valve на новом движке Source 2.",
                Rating = 9.2,
                OnlinePlayers = 1800000,
                Lore = "Террористы против спецназа — никакой глубокой истории, только тактический экшен.",
                LastUpdateSummary = "Последнее обновление: Новая карта Thera, баланс AWP, улучшенная система тикрейта.",
                GuideLink = "/guides/cs2",
                ImageUrl = "https://via.placeholder.com/300x160?text=CS2"
            },
            new Game
            {
                Id = 3,
                Title = "Genshin Impact",
                Description = "Action-RPG с открытым миром и гача-механиками.",
                Rating = 7.9,
                OnlinePlayers = 650000,
                Lore = "Два брата-путешественника ищут ответы в мире Тейват, где каждый регион чтит своего Архонта.",
                LastUpdateSummary = "Версия 4.4: Регион Чэньюйская долина, новый персонаж Сиян (5★), фейерверки и ивенты.",
                GuideLink = "/guides/genshin",
                ImageUrl = "https://via.placeholder.com/300x160?text=Genshin"
            }
        };

        public IActionResult Index()
        {
            return View(games);
        }

        public IActionResult Details(int id)
        {
            var game = games.Find(g => g.Id == id);
            if (game == null)
                return NotFound();
            return View(game);
        }
    }
}
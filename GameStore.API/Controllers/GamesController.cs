using GameStore.Business.Interfaces;
using GameStore.Business.Models;
using GameStore.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
    {

    [ApiController]
    [Route("[controller]")]
    public class GamesController : Controller
        {
       private readonly IGameService _gameService;
        public GamesController(IGameService gameService)
            {
            this._gameService = gameService;
            }


        // GET: GameController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameModel>>> Get()
            {
            var games = await _gameService.GetAllAsync();
            return Ok(games);



            }

        // GET: GameController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameModel>> Details(string id)
            {
            Guid.TryParse(id,out Guid myGuid);
        var game=  await  _gameService.GetByIdAsync(myGuid);
        
            return Ok(game);
            }

        // GET: GameController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
            {
            try
                {
                return RedirectToAction(nameof(Index));
                }
            catch
                {
                return View();
                }
            }
        }
    }

using GameStore.Business.Interfaces;
using GameStore.Business.Models;
using GameStore.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
    {

    [ApiController]
    [Route("[controller]")]
    public class GenresController : Controller
        {
       private readonly IGenreService _genreService;
        public GenresController(IGenreService genreService)
            {
            this._genreService = genreService;
            }


        // GET: GenresController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreModel>>> Index()
            {
            var genres = await _genreService.GetAllAsync();
            return Ok(genres);
            }

        // GET: GenresController/Details/5
        public async Task<ActionResult<GenreModel>> Details(string id)
            {
            Guid.TryParse(id, out Guid myGuid);
            var genre = await _genreService.GetByIdAsync(myGuid);

            return Ok(genre);
            }

        // GET: GenresController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: GenresController/Create
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

        // GET: GenresController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: GenresController/Edit/5
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

        // GET: GenresController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: GenresController/Delete/5
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

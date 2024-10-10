using GameStore.Business.Interfaces;
using GameStore.Business.Models;
using GameStore.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
    {

    [ApiController]
    [Route("[controller]")]
    public class PlatformsController : Controller
        {

        private readonly IPlatformService _platformService;
        public PlatformsController(IPlatformService platformService)
            {
            this._platformService = platformService;
            }


        // GET: PlatformsController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformModel>>> Index()
            {
            var platform = await _platformService.GetAllAsync();
            return Ok(platform);
            }

        // GET: PlatformsController/Details/5
        public async Task<ActionResult<PlatformModel>> Details(string id)
            {
            Guid.TryParse(id, out Guid myGuid);
            var platform = await _platformService.GetByIdAsync(myGuid);

            return Ok(platform);
            }

        // GET: PlatformsController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: PlatformsController/Create
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

        // GET: PlatformsController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: PlatformsController/Edit/5
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

        // GET: PlatformsController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: PlatformsController/Delete/5
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

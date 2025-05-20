using drustvena_mreza.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using drustvena_mreza.Models;

namespace drustvena_mreza.Controllers
{
    [Route("api/korisnik")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private GrupaRepository grupaRepository = new GrupaRepository();
        private KorisnikRepository korisnikRepository = new KorisnikRepository();
        private ClanstvaRepository clanstvaRepository = new ClanstvaRepository();

        [HttpGet]
        public ActionResult<List<Korisnik>> GetAll()
        {
            List<Korisnik> allKorisnik = KorisnikRepository.AllKorisnik.Values.ToList();
            return allKorisnik;
        }
    }
}

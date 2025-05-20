using drustvena_mreza.Models;
using drustvena_mreza.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace drustvena_mreza.Controllers
{
    [Route("api/grupa/{grupaId}/korisnik")]
    [ApiController]
    public class ClanstvaController : Controller
    {
        private GrupaRepository grupaRepository = new GrupaRepository();
        private KorisnikRepository korisnikRepository = new KorisnikRepository();
        private ClanstvaRepository clanstvaRepository = new ClanstvaRepository();


        [HttpGet]
        public ActionResult<List<Korisnik>> GetById(int grupaId)
        {
            if (!GrupaRepository.AllGrupa.ContainsKey(grupaId))
            {
                return NotFound();
            }

            List<Korisnik> allKorisnik = KorisnikRepository.AllKorisnik.Values.ToList();
            List<Korisnik> grupaKorisnik = new List<Korisnik>();

            foreach (Korisnik korisnik in allKorisnik)
            {
                foreach (Grupa grupa in korisnik.Grupa)
                {
                    if (grupa.Id == grupaId)
                    {
                        grupaKorisnik.Add(korisnik);
                    }
                }
            }
            return Ok(grupaKorisnik);
        }
    }
}

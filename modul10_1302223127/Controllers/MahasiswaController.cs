using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223127.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Fauzein Mulya Warman", "1302223127", new List<string>{ "KPL", "PBO", "Basdat"}, 2022),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007", new List<string>{ "Alpro", "Strukdat", "UX"}, 2022),
            new Mahasiswa("Muhammad Dias Adani", "1302223134", new List<string>{ "IMK", "Proting II", "ADPL"}, 2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}

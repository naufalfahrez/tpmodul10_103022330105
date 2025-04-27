using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul10_103022330105
{
    [ApiController]
    [Route("api/[controller]")]

    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa{Nama = "Naufal Fahreza", NIM = "103022330105"},
            new Mahasiswa{Nama = "Raka Valrizqy Akhdansyah", NIM = "103022330096"},
            new Mahasiswa{Nama = "Muhammad Faiz Adya", NIM = "103022300048"},
            new Mahasiswa{Nama = "Muhammad Rakan Yusra", NIM = "103022330044"},
            new Mahasiswa{Nama = "Duhan Hasanain", NIM = "103022330080"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaIdx(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }

    }
}

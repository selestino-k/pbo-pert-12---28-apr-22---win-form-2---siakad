using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbo_pert_12___28_apr_22___win_form_2___siakad.Entitas
{
    public class Mahasiswa
    {
        public string Nim { get; set; } //Key
        public string Nama { get; set; }
        public bool JenisKelamin { get; set; }
        public string Angkatan { get; set; }

        private static List<Mahasiswa> ListMahasiwa = new List<Mahasiswa>();

        public Mahasiswa(string nim, string nama, bool jenisKelamin, string angkatan)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                Console.WriteLine("Mahasiswa dengan nim : {0} sudah ada.", nim);

                return;
            }

            Nim = nim;
            Nama = nama;
            JenisKelamin = jenisKelamin;
            Angkatan = angkatan;

            ListMahasiwa.Add(this);
        }

        public static void Cetak()
        {
            Console.WriteLine("Daftar Mahasiswa");

            if (ListMahasiwa.Count == 0)
            {
                Console.WriteLine("Belum ada data.");

                return;
            }

            for (int i = 0; i < ListMahasiwa.Count; i++)
            {
                var mahasiswa = ListMahasiwa[i];
                string strJk = mahasiswa.JenisKelamin == true ? "Laki-laki" : "Perempuan";
                Console.WriteLine("{0}. NIM : {1}, Nama : {2}, JK : {3}, Angkatan : {4}", i + 1, mahasiswa.Nim, mahasiswa.Nama, strJk, mahasiswa.Angkatan);
            }
        }

        public static void Edit(string nim, string namaBaru, bool jkBaru, string angkatanBaru)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                mahasiswa.Nama = namaBaru;
                mahasiswa.JenisKelamin = jkBaru;
                mahasiswa.Angkatan = angkatanBaru;
            }
        }

        public static void Edit(Mahasiswa newData)
        {

            var mahasiswa = ListMahasiwa.Find(x => x.Nim == newData.Nim);

            if (mahasiswa != null)
            {
                mahasiswa.Nama = newData.Nama;
                mahasiswa.JenisKelamin = newData.JenisKelamin;
                mahasiswa.Angkatan = newData.Angkatan;
            }
        }

        public static void Hapus(string nim)
        {
            var mahasiswa = ListMahasiwa.Find(x => x.Nim == nim);

            if (mahasiswa != null)
            {
                ListMahasiwa.Remove(mahasiswa);
                Console.WriteLine("Data telah dihapus");
            }
            else
            {
                Console.WriteLine("NIM tidak ditemukan. Tidak ada data yang dihapus.");
            }
        }
    }
}

using System;
using System.Collections.Generic;

using PerpustakaanAppMVC.Model.Entity;
using PerpustakaanAppMVC.Model.Repository;
using PerpustakaanAppMVC.Model.Context;
using System.Windows.Forms;

namespace PerpustakaanAppMVC.Controller
{
    public class MahasiswaController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private MahasiswaRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Mahasiswa> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Mahasiswa> list = new List<Mahasiswa>();

            var repo = new MahasiswaRestApiRepository();
            return repo.ReadByNama(nama);

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data mahasiswa
        /// </summary>
        /// <returns></returns>
        public List<Mahasiswa> ReadAll()
        {
            // membuat objek collection
            List<Mahasiswa> list = new List<Mahasiswa>();

            // membuat objek dari class MahasiswaRestApiRepository
            var repo = new MahasiswaRestApiRepository();
            list = repo.ReadAll();

            return list;
        }

        public List<Mahasiswa> ReadByNpm(string npm)
        {
            var repo = new MahasiswaRestApiRepository();
            return repo.ReadByNpm(npm);
        }

        public int Create(Mahasiswa mhs)
        {
            int result = 0;

            var repo = new MahasiswaRestApiRepository();
            result = repo.Create(mhs);
            if (result > 0)
            {
                MessageBox.Show(
                    "Data mahasiswa berhasil disimpan",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Data mahasiswa gagal disimpan",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
            }
            return result;
        }

        public int Update(Mahasiswa mhs)
        {
            int result = 0;

            var repo = new MahasiswaRestApiRepository();
            result = repo.Update(mhs);

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diperbarui",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal diperbarui",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(Mahasiswa mhs)
        {
            int result = 0;

            var repo = new MahasiswaRestApiRepository();
            result = repo.Delete(mhs);
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal dihapus",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
    }
}

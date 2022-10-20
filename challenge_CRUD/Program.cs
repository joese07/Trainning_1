// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Data;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD
{

    public class challengeCRUD
    {
        static void Main(string[] args)
        {
            //READ Spesialis
            //SpecialisRepositories spesialisRepositories = new SpecialisRepositories();
            //var data = spesialisRepositories.Get();
            //foreach (var item in data)
            //{
            //    Console.WriteLine("ID Spesialis : " + item.Id);
            //    Console.WriteLine("Nama Spesialis : " + item.Nama);
            //    Console.WriteLine("Catatan : " + item.Catatan);
            //    Console.WriteLine();
            //   }

            //READ SELECT Spesialis
            //var selectData = spesialisRepositories.Get(3);

            //    Console.WriteLine("ID Spesialis : " + selectData.Id);
            //    Console.WriteLine("Nama Spesialis : " + selectData.Nama);
            //    Console.WriteLine("Catatan : " + selectData.Catatan);
            //    Console.WriteLine();

            ////INSERT Spesialis
            //Spesialis spesialis = new Spesialis(0,"Penyakit Luar", "Penyakit Luar");
            //var result = spesialisRepositories.Insert(spesialis);
            //if(result > 0)
            //{
            //    Console.WriteLine("Insert data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to insert data");
            //}

            //UPDATE Data
            //Spesialis updateSpesialis = new Spesialis(1002, "Penyakit Organ Dalam", "Penyakit Orgam Dalam");
            //var hasil = spesialisRepositories.Update(updateSpesialis);
            //if (hasil > 0)
            //{
            //    Console.WriteLine("Update data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed Update Data");
            //}

            //DELETE Data
            //try
            //{
            //    var delete = spesialisRepositories.Delete(1002);

            //    Console.WriteLine("Delete Successful");
            //}
            //catch
            //{
            //    Console.WriteLine("Failed Delete data");
            //}


            //READ Rekam Medis
            //RekamMedisRepositories rekamMedisRepositories = new RekamMedisRepositories();
            //var data = rekamMedisRepositories.Get();
            //foreach (var item in data)
            //{
            //    Console.WriteLine("ID Spesialis : " + item.Id);
            //    Console.WriteLine("Riwayat  : " + item.Riwayat);
            //    Console.WriteLine("ID Dokter : " + item.Id_Dokter);
            //    Console.WriteLine("ID Obat : " + item.Id_Obat);
            //    Console.WriteLine("Tanggal : " + item.Tanggal);
            //    Console.WriteLine();
            //}

            //READ SELECT Rekam Medis
            //var selectData = rekamMedisRepositories.Get(3);
            //Console.WriteLine("ID Spesialis : " + selectData.Id);
            //Console.WriteLine("Riwayat  : " + selectData.Riwayat);
            //Console.WriteLine("ID Dokter : " + selectData.Id_Dokter);
            //Console.WriteLine("ID Obat : " + selectData.Id_Obat);
            //Console.WriteLine("Tanggal : " + selectData.Tanggal);
            //Console.WriteLine();


            ////INSERT Rekam Medis
            //RekamMedis rekamMedis = new RekamMedis(0, "Penyakit Kulit", 2, 4, "2022-10-20 09:13:00"); ;
            //var result = rekamMedisRepositories.Insert(rekamMedis);
            //if (result > 0)
            //{
            //    Console.WriteLine("Insert data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to insert data");
            //}

            //Update Rekam Medis
            //RekamMedis updateRekamMedis = new RekamMedis(1002,"Penyakit infeksi kulit",2,4, "2022-10-20 09:13:00");
            //var hasil = rekamMedisRepositories.Update(updateRekamMedis);
            //if (hasil > 0)
            //{
            //    Console.WriteLine("Update data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed Update Data");
            //}

            //DELETE Rekam Medis
            //var delete = rekamMedisRepositories.Delete(1002);

            //READ Pasien
            //PasienRepositories pasienRepositories = new PasienRepositories();
            //var data = pasienRepositories.Get();
            //foreach (var item in data)
            //{
            //    Console.WriteLine("ID Spesialis : " + item.Id);
            //    Console.WriteLine("Nama  : " + item.Nama);
            //    Console.WriteLine("No Telepon : " + item.No_telepon);
            //    Console.WriteLine("Alamat : " + item.Alamat);
            //    Console.WriteLine("Id Rekam Medis : " + item.Id_rekam_medis);
            //    Console.WriteLine();
            //}

            //READ SELECT Pasien
            //var selectData = pasienRepositories.Get(2);
            //Console.WriteLine("ID Spesialis : " + selectData.Id);
            //Console.WriteLine("Riwayat  : " + selectData.Nama);
            //Console.WriteLine("ID Dokter : " + selectData.No_telepon);
            //Console.WriteLine("ID Obat : " + selectData.Alamat);
            //Console.WriteLine("Tanggal : " + selectData.Id_rekam_medis);
            //Console.WriteLine();


            ////INSERT Pasien
            //Pasien pasien = new Pasien(0, "Amanda", "Perempuan", "14045", "Bandung",1) ;
            //var result = pasienRepositories.Insert(pasien);
            //if (result > 0)
            //{
            //    Console.WriteLine("Insert data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to insert data");
            //}

            //Update Pasien
            //Pasien updatePasien = new Pasien(1002, "Amanda Nicole", "Perempuan", "14045", "Bandung", 1);
            //var hasil = pasienRepositories.Update(updatePasien);
            //if (hasil > 0)
            //{
            //    Console.WriteLine("Update data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed Update Data");
            //}

            //DELETE pasien
            //var delete = pasienRepositories.Delete(1002);


            //READ Obat
            //ObatRepositories obatRepositories = new ObatRepositories();
            //var data = obatRepositories.Get();
            //foreach (var item in data)
            //{
            //    Console.WriteLine("ID Spesialis : " + item.Id);
            //    Console.WriteLine("Riwayat  : " + item.Nama);
            //    Console.WriteLine("ID Dokter : " + item.Catatan);
            //    Console.WriteLine("ID Obat : " + item.Expired);
            //    Console.WriteLine();
            //}

            //READ SELECT Obat
            //var selectData = obatRepositories.Get(2);
            //Console.WriteLine("ID Spesialis : " + selectData.Id);
            //Console.WriteLine("Riwayat  : " + selectData.Nama);
            //Console.WriteLine("ID Dokter : " + selectData.Catatan);
            //Console.WriteLine("ID Obat : " + selectData.Expired);
            //Console.WriteLine();


            ////INSERT Obat
            //Obat obat = new Obat(0, "Hufarizine", "obat yang bermanfaat untuk mengobati gejala atau keluhan akibat reaksi alergi", "2022-10-20 10:00:00");
            //var result = obatRepositories.Insert(obat);
            //if (result > 0)
            //{
            //    Console.WriteLine("Insert data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to insert data");
            //}

            //Update Obat
            //Obat updateObat = new Obat(1005, "Hufarizine", "obat yang bermanfaat untuk mengobati gejala atau keluhan akibat reaksi alergi, khususnya makanan", "2022-10-20 10:00:00");
            //var hasil = obatRepositories.Update(updateObat);
            //if (hasil > 0)
            //{
            //    Console.WriteLine("Update data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed Update Data");
            //}

            //DELETE Obat
            //var delete = obatRepositories.Delete(1005);

            //READ Dokter
            DokterRepositories dokterRepositories = new DokterRepositories();
            //var data = dokterRepositories.Get();
            //foreach (var item in data)
            //{
            //    Console.WriteLine("ID dokter : " + item.Id);
            //    Console.WriteLine("Nama  : " + item.Nama);
            //    Console.WriteLine("Jenis Kelamin  : " + item.Jenis_kelamin);
            //    Console.WriteLine("No Telepon : " + item.No_telepon);
            //    Console.WriteLine("Alamat : " + item.Alamat);
            //    Console.WriteLine("Id Spesialis : " + item.Id_Spesialis);
            //    Console.WriteLine();
            //}

            var data = dokterRepositories.Show();
            foreach (var item in data)
            {
                Console.WriteLine("ID dokter : " + item.Id);
                Console.WriteLine("Nama  : " + item.Nama);
                Console.WriteLine("Jenis Kelamin  : " + item.Jenis_kelamin);
                Console.WriteLine("No Telepon : " + item.No_telepon);
                Console.WriteLine("Alamat : " + item.Alamat);
                Console.WriteLine("Nama Spesialis : " + item.Nama_Spesialis);
                Console.WriteLine();
            }

            //READ SELECT Dokter
            var selectData = dokterRepositories.Get(1);
            Console.WriteLine("ID dokter: " + selectData.Id);
            Console.WriteLine("Nama  : " + selectData.Nama);
            Console.WriteLine("Jenis Kelamin : " + selectData.Jenis_kelamin);
            Console.WriteLine("No Telepon : " + selectData.No_telepon);
            Console.WriteLine("Alamat: " + selectData.Alamat);
            Console.WriteLine("Nama Spesialis : " + selectData.Id_Spesialis);
            Console.WriteLine();


            ////INSERT dokter
            //Dokter dokter = new Dokter(0, "Tester nih ya", "laki - laki", "02929292", "Jakarta", "3");
            //var result = dokterRepositories.Insert(dokter);
            //if (result > 0)
            //{
            //    Console.WriteLine("Insert data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to insert data");
            //}

            //Update Dokter
            //Dokter updateDokter = new Dokter(1005, "Joese Rio Telysana", "laki - laki", "02929292", "Jakarta", 3);
            //var hasil = dokterRepositories.Update(updateDokter);
            //if (hasil > 0)
            //{
            //    Console.WriteLine("Update data berhasil");
            //}
            //else
            //{
            //    Console.WriteLine("Failed Update Data");
            //}

            //DELETE Dokter
            //var delete = dokterRepositories.Delete(1007);

            PasienRepositories pasienRepositories = new PasienRepositories();
            RekamMedisRepositories rekamMedisRepositories = new RekamMedisRepositories();


            //Console.WriteLine("Halo ini aplikasi Puskesmas");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();


            //Console.WriteLine("1. Proses Obat");
            //Console.WriteLine("2. Proses Pasien");
            //Console.WriteLine("3. Proses Dokter");
            //Console.WriteLine("4. Proses Rekam Medis");
            //Console.WriteLine("Silahkan Pilih Proses : ");



            //int pilihanProses = Convert.ToInt16(Console.ReadLine());
      

            //switch (pilihanProses)
            //{
            //    case 1:
            //        Console.WriteLine("Silahkan isi Data Obat : ");
            //        Console.Write("Nama : ");

            //        break;

            //    case 2:
            //        try
            //        {
            //            Console.WriteLine("Silahkan Isi Data Pasien : ");
            //            Console.Write("Nama : ");
            //            string namaPasien = Console.ReadLine();
            //            Console.Write("Jensi Kelamin : ");
            //            string jenisKelamin = Console.ReadLine();
            //            Console.Write("No Telepon : ");
            //            string noTelepon = Console.ReadLine();
            //            Console.Write("Alamat :  ");
            //            string alamat = Console.ReadLine();

            //            Console.WriteLine("Punya Riwayat diperiksa ? ");
            //            Console.Write("pilihan YA / TIDAK : ");
            //            string riwayat = Console.ReadLine();

            //            string pilihan;

            //            if (riwayat == "YA")
            //            {

            //                var data = rekamMedisRepositories.Get();
            //                foreach (var item in data)
            //                {
            //                    Console.WriteLine("ID : " + item.Id);
            //                    Console.WriteLine("Riwayat  : " + item.Riwayat);
            //                    Console.WriteLine("ID Dokter : " + item.Id_Dokter);
            //                    Console.WriteLine("ID Obat : " + item.Id_Obat);
            //                    Console.WriteLine("Tanggal : " + item.Tanggal);
            //                    Console.WriteLine();
            //                }

            //                Console.Write("silahkan pilih ID riwayat : ");
            //                pilihan = Console.ReadLine();
                        
            //            }
            //            else
            //            {
            //                Console.WriteLine("Silahkan isi riwayat : ");

            //                Console.Write("Keluhan penyakit : ");
            //                string keluhan = Console.ReadLine();

            //                RekamMedis rekamMedis = new RekamMedis(0, "Penyakit Kulit", 2, 4, "2022-10-20 09:13:00"); ;
            //                var resultRekamMedis = rekamMedisRepositories.Insert(rekamMedis);
            //                if (resultRekamMedis > 0)
            //                {
            //                    Console.WriteLine("Insert data berhasil");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Failed to insert data");
            //                }


            //            }

            //            Pasien pasien = new Pasien(0, namaPasien, jenisKelamin, noTelepon, alamat, pilihan);
            //            var result = pasienRepositories.Insert(pasien);
            //            if (result > 0)
            //            {
            //                Console.WriteLine("Insert data berhasil");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Failed to insert data");
            //            }

            //        }
            //        catch
            //        {
            //            Console.WriteLine("something Wrong..");
            //        }


            //        break;
            //    case 3:
            //        Console.WriteLine("Proses Dokter");
            //        break;
            //    case 4:
            //        Console.WriteLine("Proses Rekam Medis");
            //        break;

            //};



        }
    }
}
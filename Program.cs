using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExePabd
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
            new Program().CreateDatabase();
        }
        public void CreateDatabase()
        {
            SqlConnection con = null;
            try
            { 
                con = new SqlConnection("data source= DIZKY\\DIZKY ;database=Apotek;Integrated Security = True");
                con =Open();

                SqlCommand cm = new SqlCommand("Create table Customer(Id_Customer char (5) primary key,Nama Varchar (50),Alamat Varchar (50),Jenis_kelamin char (20),)"+
                    "Create table Karyawan(Id_Karyawan char (15) primary key,Nama Varchar (50),Alamat Varchar (50),Jenis_kelamin char (20),)"+
                    "Create table Obat(Id_obat char (20) primary key,Nama_obat Varchar (45),Harga_obat money ,)"+
                    "Create table Supplier (Id_supplier char (20) primary key,Nama Varchar (50),Alamat Varchar (50),no_telepon char (30),)"+
                    "Create table Transaksi(Id_transaksi char (8) primary key,Id_karyawan char (15) foreign key references Karyawan(Id_karyawan),Id_customer char (5) foreign key references Customer(Id_customer),Nama_obat Varchar (45),Jumlah_biaya money,)"+
                    "Create table Supply(Kode_supply char (25) primary key,Id_supplier char (20) foreign key references Supplier(Id_supplier),Id_karyawan char (15) foreign key references Karyawan(Id_karyawan),Id_obat char (20),Nama_obat Varchar (40),Harga_obat money",con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambah Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagagl Menambah Data" + e);
                Console.ReadKey();
            }
            finally {
                con.Close();
                    }
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source= DIZKY\\DIZKY ;database=Apotek;Integrated Security = True");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Customer (Id_Customer,Nama,Alamat,Jenis_kelamin) values ('00-01','Belindut','Inggris','Perempuan');"+
                "insert into Customer (Id_Customer,Nama,Alamat,Jenis_kelamin) values ('00-02','Zaenudin','Surabaya','laki-laki');"+
                "insert into Customer (Id_Customer,Nama,Alamat,Jenis_kelamin) values ('00-03','Mamat','Kediri','laki-laki');"+
                "insert into Customer (Id_Customer,Nama,Alamat,Jenis_kelamin) values ('00-04','Sapini','Pati','Perempuan');"+
                "insert into Customer (Id_Customer,Nama,Alamat,Jenis_kelamin) values ('00-05','Alkatiri','Surakarta','laki-laki');"+
                "insert into Karyawan (Id_Karyawan,Nama,Alamat,Jenis_kelamin) values ('11-11','Sapana','Sleman','Perempuan');"+
                "insert into Karyawan (Id_Karyawan,Nama,Alamat,Jenis_kelamin) values ('22-22','Anton','Malang','laki-laki');"+
                "insert into Karyawan (Id_Karyawan,Nama,Alamat,Jenis_kelamin) values ('33-33','Ceking','Amazon','laki-laki');"+
                "insert into Karyawan (Id_Karyawan,Nama,Alamat,Jenis_kelamin) values ('44-44','Titi','Amerika','Perempuan');"+
                "insert into Karyawan (Id_Karyawan,Nama,Alamat,Jenis_kelamin) values ('55-55','Hidayah','Purworejo','Perempuan');"+
                "insert into Obat (Id_obat,Nama_obat,Harga_obat) values ('10-20','Paramex','4000');"+
                "insert into Obat (Id_obat,Nama_obat,Harga_obat) values ('30-40','Panadol','5000');"+
                "insert into Obat (Id_obat,Nama_obat,Harga_obat) values ('50-60','Paratusin','8000');"+
                "insert into Obat (Id_obat,Nama_obat,Harga_obat) values ('70-80','FgTrosis','6000');"+
                "insert into Obat (Id_obat,Nama_obat,Harga_obat) values ('90-100','TolakAngin','9000');"+
                "insert into Supplier (Id_supplier,Nama,Alamat,no_telepon) values ('90-90','Ahmad','Magelang','08976672');"+
                "insert into Supplier (Id_supplier,Nama,Alamat,no_telepon) values ('80-80','Maemu','Kediri','08566865');"+
                "insert into Supplier (Id_supplier,Nama,Alamat,no_telepon) values ('70-70','Amen','TimorLeste','08196759');"+
                "insert into Supplier (Id_supplier,Nama,Alamat,no_telepon) values ('60-60','Kuir','Serang','08632865');"+
                "insert into Supplier (Id_supplier,Nama,Alamat,no_telepon) values ('90-90','Olin','Wedari','08343678');"+
                "insert into Transaksi (Id_transaksi,Id_karyawan,Id_customer,Nama_obat,Jumlah_biaya) values ('99-88','11-11','00-01','Paramex',16000);"+
                "insert into Transaksi (Id_transaksi,Id_karyawan,Id_customer,Nama_obat,Jumlah_biaya) values ('77-66','22-22','00-02','Panadol',20000);"+
                "insert into Transaksi (Id_transaksi,Id_karyawan,Id_customer,Nama_obat,Jumlah_biaya) values ('55-44','33-33','00-03','Paratusin',16000);"+
                "insert into Transaksi (Id_transaksi,Id_karyawan,Id_customer,Nama_obat,Jumlah_biaya) values ('33-22','44-44','00-04','FgTrosis',12000);"+
                "insert into Transaksi (Id_transaksi,Id_karyawan,Id_customer,Nama_obat,Jumlah_biaya) values ('11-00','55-55','00-05','TolakAngin',18000);"+
                "insert into Supply (Kode_supply,Id_supplier,Id_karyawan,Id_obat,Nama_obat,Harga_obat) values ('003','90-90','11-11','10-20','Paramex','4000');"+
                "insert into Supply (Kode_supply,Id_supplier,Id_karyawan,Id_obat,Nama_obat,Harga_obat) values ('004','80-80','22-22','30-40','Panadol','5000');"+
                "insert into Supply (Kode_supply,Id_supplier,Id_karyawan,Id_obat,Nama_obat,Harga_obat) values ('005','70-70','33-33','50-60','Paratusin','8000');"+
                "insert into Supply (Kode_supply,Id_supplier,Id_karyawan,Id_obat,Nama_obat,Harga_obat) values ('006','60-60','44-44','70-80','FgTrosis','6000');"+
                "insert into Supply (Kode_supply,Id_supplier,Id_karyawan,Id_obat,Nama_obat,Harga_obat) values ('007','50-50','55-55','90-100','TolakAngin','9000');"+
              cm.ExecuteNonQuery();

              Console.WriteLine("Sukses Menambah Data");
              Console.ReadKey();
            }
            catch (Execption e)
            {
                Console.WriteLine("Gagal menambah Data" +e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}

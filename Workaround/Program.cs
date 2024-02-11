using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
	class Program
	{
		static void Main(string[] args)
		{
			//Vatandas vatandas = new Vatandas("Metehan", "Sözen", 2000, 1111111111);
			//Console.WriteLine(vatandas.Ad);
			//selamla();
			//Vatandas.selamla2();

			//Diziler / Arrays
			string ogr1 = "metehan";
			string ogr2 = "ali";
			string ogr3 = "karde";

			string[] ogrenciler = new string[3];
			ogrenciler[0] = ogr1;
			ogrenciler[1] = ogr2;
			ogrenciler[2] = ogr3;
			ogrenciler = new string[4];
			ogrenciler[3] = "Zuhal";

			string[] sehirler = new string[] {"Adana","İzmir","Bursa" };
			string[] sehirler2 = new string[] {"Sivas","Kastamonu","Antalya" };
			sehirler2 = sehirler;
			sehirler[0] = "Elazığ";
            foreach (var item in sehirler2)
            {
				Console.WriteLine(item);
            }

            for (int i = 0; i< ogrenciler.Length; i++)
			{
				Console.WriteLine(ogrenciler[i]);
			}
			foreach(string ogr in ogrenciler)
			{
				Console.WriteLine(ogr);
			}

			Person person1 = new Person();
			person1.FirstName = "METEHAN";
			person1.LastName = "SÖZEN";
			person1.DateOfBirth = 2000;
			person1.NationalIdentity = 123;

			Person person2 = new Person();
			person2.FirstName = "Rüveyda";

			//string --> referans tip ama değer tip gibi çalışır............. aslında bir char arraydir

			Console.WriteLine("\nList Yapısı\n");
			List<string> yeniSehirler1 = new List<string> {"Ankara", "İstanbul", "İzmir"};
			yeniSehirler1.Add("İzmir");

            foreach (var item in yeniSehirler1)
            {
				Console.WriteLine(item);
            }

            PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);



		}

		static void selamla()
		{
			Console.WriteLine("Merhaba");
		}
	}

	public class Vatandas
	{
		private string _ad;
        public Vatandas(string Ad, string Soyad, int DogumYili, long TcNo)
        {
			this.Ad = Ad;
			this.Soyad = Soyad;
			this.TcNo = TcNo;
			this.DogumYili = DogumYili;
        }
        public string Ad 
		{
			get { return _ad; }
			set { _ad = value + " Bey"; } 
		}
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

		public static void selamla2()
		{
			Console.WriteLine("Merhaba");
		}
	}
}
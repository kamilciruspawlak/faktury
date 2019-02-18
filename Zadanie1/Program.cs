using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	class Program
	{
		
		static void Main(string[] args)
		{
			//zadanie polega na utworzeniu po 3 faktur i wpłat i wyświetleniu ich składników na konsoli
			//musisz zbudować generator numeru dokumentów, 
			//sam ustal ile i jakie parametry przekażesz do metody (klasa generator) :D
			List<Faktura> Faktury = new List<Faktura>();
			
			for (int i = 1000; i < 1003; i++)
			{

				var fakturka = new Faktura() {
					Id = Faktury.Count +1 ,
					NumerKolejny =Faktury.Count + 1,
					WartoscNetto = i,
					WartoscVat = i-977,
				};
				fakturka.Numer = Generator.GenerujNumer(fakturka.Maska, fakturka.NumerKolejny);
				fakturka.WartoscBrutto = fakturka.WartoscNetto * (1+ fakturka.WartoscVat/100);

				Faktury.Add(fakturka);
			}
			foreach (var item in Faktury)
			{
				Console.WriteLine(item.Id);
				Console.WriteLine(item.NumerKolejny);
				Console.WriteLine(item.Maska);
				Console.WriteLine(item.Numer);
				Console.WriteLine(item.WartoscBrutto);
				Console.WriteLine(item.WartoscNetto);
				Console.WriteLine(item.WartoscVat);
				Console.WriteLine("\n");
			}


			List<Wplata> Wplaty = new List<Wplata>();
			for (int i = 1000; i < 1003; i++)
			{
				var wplatka = new Wplata() {
					Id = Wplaty.Count +1 ,
					NumerKolejny =Wplaty.Count + 1,
					WartoscNetto = i,
					WartoscVat = i-977,
				};
				wplatka.Numer = Generator.GenerujNumer(wplatka.Maska, wplatka.NumerKolejny);
				wplatka.WartoscBrutto = wplatka.WartoscNetto * (1+ wplatka.WartoscVat/100);

				Wplaty.Add(wplatka);
			}

			foreach(var item in Wplaty)
			{
				Console.WriteLine(item.Id);
				Console.WriteLine(item.NumerKolejny);
				Console.WriteLine(item.Maska);
				Console.WriteLine(item.Numer);
				Console.WriteLine(item.WartoscBrutto);
				Console.WriteLine(item.WartoscNetto);
				Console.WriteLine(item.WartoscVat);
				Console.WriteLine("\n");
			}

			Console.ReadKey();

		}

	}
}

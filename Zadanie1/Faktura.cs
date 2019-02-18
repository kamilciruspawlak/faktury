using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Faktura
    {
        public int Id { get; set; }
        // NumerKolejny jest nadawany dla każdego nowego dokumentu jako koljna liczba naturalna
        public int NumerKolejny { get; set; }
        public string Maska { get; set; }
        public decimal WartoscNetto { get; set; }
        public decimal WartoscVat { get; set; }
        public decimal WartoscBrutto { get; set; }
        public string Numer { get; set; }

        public Faktura()
        {
            Maska = "FV $n4/$m2/$r2";
            // maska jest wzorem dla numeru dokumentu
            // $ oznacza, że zaraz po nim następuje wzór składający się z dwóch znaków:
            //  - litera oznacza co powinno się teraz w tym miejscu znaleźć (n - numer kolejny, m - miesiąc, r - rok)
            //  - cyfra oznacza z ilu znaków powinien się składać dany składnik
        }
        


    }
}

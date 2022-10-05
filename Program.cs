namespace CA221005
{
    class Ember
    {
        private string _nev;
        public string Nev
        {
            get => _nev;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("nem lehet csupa space valakinek a neve!");
                if (value.Length < 3)
                    throw new Exception("egy név minimum 3 karakter hosszú!");
                if (value.Contains('!'))
                    throw new Exception("hiba");

                _nev = value;
            }
        }

        private int _eletkor;
        public int Eletkor
        {
            get => _eletkor;
            set
            {
                if (value < 0)
                    throw new Exception(message: "az életkor nem lehet negatív!");
                if (value > 120)
                    throw new Exception("hát ez minimum gyanús életkornak...");
                _eletkor = value;
            }
        }

        #region példa setter/getter metódusokra (ha nem tudna a nyelv property-t)
        //public void SetEletkor(int eletkor)
        //{
        //    if (eletkor < 0)
        //        throw new Exception(message: "az életkor nem lehet negatív!");
        //    if (eletkor > 120)
        //        throw new Exception("hát ez minimum gyanús életkornak...");

        //    _eletkor = eletkor;
        //}
        //public int GetEletkor()
        //{
        //    return _eletkor;
        //}
        #endregion
    }

    internal class Program
    {
        static void Main()
        {
            Ember ember = new Ember();

            Console.Write("Hogy hívnak <ember>? ");
            ember.Nev = Console.ReadLine();
            Console.WriteLine($"Úgy hívnak, hogy {ember.Nev}!");

            #region példa setter/getter metódusok használatára (értékadás, hívás)
            //ember.SetEletkor(31);
            //Console.WriteLine(ember.GetEletkor());
            #endregion

            Console.Write($"Hány éves {ember.Nev}? ");
            ember.Eletkor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Szóval {ember.Nev} {ember.Eletkor} éves...");
        }
    }
}
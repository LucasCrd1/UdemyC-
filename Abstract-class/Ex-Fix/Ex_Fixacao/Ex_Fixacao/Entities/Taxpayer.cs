namespace Ex_Fixacao.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Taxpayer() { }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}

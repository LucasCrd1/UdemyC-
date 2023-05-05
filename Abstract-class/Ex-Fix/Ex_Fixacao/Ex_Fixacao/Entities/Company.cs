namespace Ex_Fixacao.Entities
{
    class Company : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }
        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if (NumberOfEmployees < 10)
            {
                tax += AnualIncome * 0.16;
            }
            else
            {
                tax += AnualIncome * 0.14;
            }
            return tax;
        }
    }
}

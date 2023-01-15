namespace Program.PensionPlan
{
    public class Person
    {
        public float TaxBase { get; set; }
        public float PensionPlanLegalPerson { get; set; }
        public float PensionPlanCompany { get; set; }
        public string Country { get; set; }

        public Person() { }

        public Person(float taxBase, float pensionPlanLegalPerson, float pensionPlanCompany, string country)
        {
            TaxBase = taxBase;
            PensionPlanLegalPerson = pensionPlanLegalPerson;
            PensionPlanCompany = pensionPlanCompany;
            Country = country;
        }

        public override string ToString()
        {
            return " Tax base: " + TaxBase +
                " Pension plan legal person: " + PensionPlanLegalPerson +
                " Pension plan company: " + PensionPlanCompany +
                " Pension plan country: " + Country;
        }
    }
}

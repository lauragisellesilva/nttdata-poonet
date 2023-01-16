namespace CalculatorProject.Inheritance
{
    public class Address : NttDataBase
    {
        private string street { get; set; }
        private string city { get; set; }
        private string region { get; set; }

        public Address(string street, string city, string region)
        {
            this.street = street;
            this.city = city;
            this.region = region;
        }
    }
}

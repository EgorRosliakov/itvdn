namespace Task2
{
    public class Address
    {
        private string index;

        public string Index
        {
            set => index = value;
            get => index;           
        }

        private string country;

        public string Country
        {
            set => country = value;         
            get => country;          
        }

        private string city;

        public string City
        {
            set => city = value;         
            get => city;         
        }

        private string street;

        public string Street
        {
            set => street = value;           
            get => street;           
        }

        private int house;

        public int House
        {
            set => house = value;          
            get => house;          
        }

        private int apartment;

        public int Apartment
        {
            set => apartment = value;          
            get => apartment;           
        }

        public override string ToString() => $"{index} {country} {city} {street} {house} {apartment}";
       
    }
}

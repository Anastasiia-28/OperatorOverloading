namespace OperatorOverloading
{
    public class City
    {
        public int NumResidents { get; set; }

        public static int operator +(City city, int value)
        {
            return city.NumResidents + value;
        }
        public static int operator -(City city, int value)
        {
            return city.NumResidents - value;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.NumResidents > city2.NumResidents;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.NumResidents < city2.NumResidents;
        }
        public static bool operator ==(City city1, City city2)
        {
            //return Object.Equals(city1, city2);
            if (city1.NumResidents == city2.NumResidents)
                return true;
            return false;
        }
        public static bool operator !=(City city1, City city2)
        {
            //return !Object.Equals(city1, city2);
            if (city1.NumResidents != city2.NumResidents)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is City objectType)
                return NumResidents == objectType.NumResidents;

            return false;
        }
    }
}

namespace HelloCSharp.Tools.Physics
{
    public struct Weight
    {
        private readonly int _weight;

        private Weight(int weight)
        {
            _weight = weight;
        }

        public static Weight FromGrams(int grams)
        {
            return new Weight(grams);
        }

        public static Weight FromKilograms(int kilograms)
        {
            return new Weight(kilograms * 1000);
        }

        public static Weight FromMilligrams(int milligrams)
        {
            return new Weight((int)(milligrams * 0.001));
        }

        public int GetGrams()
        {
            return _weight;
        }
    }
}
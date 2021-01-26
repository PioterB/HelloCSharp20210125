namespace HelloCSharp.Domain
{
    public class SandwichLabel
    {
        public SandwichLabel(string name, SandwichSize size, Allergens allergens)
        {
            Name = name;
            Size = size;
            Allergens = allergens;
        }

        public string Name { get; }

        public SandwichSize Size { get; }

        public Allergens Allergens { get; }
    }
}
namespace search_list
{
    public class General
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public General(int value)
        {
            Value = value;
        }

        public General(string name)
        {
            Name = name;
        }

        public General(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
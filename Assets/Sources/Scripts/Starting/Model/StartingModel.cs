namespace Project.Starting
{
    public class StartingModel
    {
        public int Value { get; private set; }

        public void Load(string text)
        {
            if (int.TryParse(text, out int value) == false)
                return;
            
            Value = value;
        }
    }
}
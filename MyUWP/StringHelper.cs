namespace MyUWP
{
    public  class StringHelper
    {
        public string Input { get; set; }

        public StringHelper(string input)
        {
            this.Input = input;
        }

        public bool ValidateString()
        {
            return string.IsNullOrEmpty(Input);
        }

    }
}

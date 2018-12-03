namespace ChatClient
{
    public class Message
    {
        public string Name { get; }

        public Message(string name)
        {
            Name = name;
        }

        public override string ToString ()
        {
            return Name;
        }
    }
}

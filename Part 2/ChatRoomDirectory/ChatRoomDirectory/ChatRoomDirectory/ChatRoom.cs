namespace ChatRoomDirectory
{
    public class ChatRoom
    {
        public string Name { get; }
        public string Port { get; }
        public string IPAddress { get; }

        public ChatRoom(string name, string port, string ipaddress)
        {
            Name = name;
            Port = port;
            IPAddress = ipaddress;
        }

        public override string ToString()
        {
            return Name + "," + Port + "," + IPAddress + ",";
        }
    }
}

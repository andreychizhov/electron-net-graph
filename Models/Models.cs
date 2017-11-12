namespace electron_net.Models
{
    public class node
    {
        public int id { get; set; }
        public string label { get; set; }
    }

    public class edge
    {        
        public int from { get; set; }
        public int to { get; set; }
        public string arrows { get; set; }
    }
}
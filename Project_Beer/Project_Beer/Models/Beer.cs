namespace Project_Beer.Models
{
    public class Beer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameDisplay { get; set; }
        public string Description { get; set; }
        public Glass Glass { get; set; }
        public LabelSet Labels { get; set; } 
    }
}
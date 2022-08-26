namespace WebAPI.Models
{
    public class CardRequest
    {
        public int Id { get; set; }
  
        public string Name { get; set; }
        
        public string CardType { get; set; }

        public string CardName { get; internal set; }
    }
}

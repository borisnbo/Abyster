namespace Abyster.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Numero { get; set; }
        public double Price { get; set; }
        public bool isUsed { get; set; }
        public static string state(bool etat) => etat ? "Used" : "Not Used";
    }
}

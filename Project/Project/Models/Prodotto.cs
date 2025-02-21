namespace Project.Models;

public class Prodotto
{
    public int Id { get; set; }
    public string Nome {get; set;}
    public double Prezzo {get; set;}
    public string Descrizione { get; set; }
    public string Copertina {get; set;}
    public List<string> ImmaginiAggiuntive = new List<string>();

}
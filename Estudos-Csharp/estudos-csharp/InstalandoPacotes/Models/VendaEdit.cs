namespace InstalandoPacotes.Models;

public class VendaEdit
{
    public VendaEdit(int id, string produto, decimal preco, DateTime dataVenda)
    {
        Id = id;
        Produto = produto;
        Preco = preco;
        DataVenda = dataVenda;
    }

    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }

}

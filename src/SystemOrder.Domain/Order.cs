namespace SystemOrder.Domain;

public class Order
{
    public Guid Id { get; set; }
    public string NomeOrder { get; set; }
    public string Prod { get; set; }
    public int Quant { get; set; }
    public decimal PrecUnit { get; set; }
    public DateTime Creat { get; set; }
    public decimal Total { get; set; }
}

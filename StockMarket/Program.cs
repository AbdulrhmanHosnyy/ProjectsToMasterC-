
class Program
{
    static void Main(string[] args)
    {
        var stock = new Stock("Amazon");
        stock.Price = 100;

        stock.OnPriceChanged += (Stock stock, decimal oldPrice) =>
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name}: {stock.Price}");
        };

        stock.ChangeStockPriceBy(0.05m);
        stock.ChangeStockPriceBy(-0.02m);
        stock.ChangeStockPriceBy(0.00m);
        Console.ReadKey();
    }

}

public delegate void StockPriceChangeHandler(Stock stock, Decimal oldPrice);


public class Stock
{
    private string name;
    private decimal price;

    public event StockPriceChangeHandler OnPriceChanged;
    public string Name => name;
    public decimal Price { get => price; set => this.price = value; }

    public Stock(string name)
    {
        this.name = name;
    }

    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = price;
        this.price += Math.Round(this.price * percent, 2);
        if(OnPriceChanged != null)  // make sure there is subscriber
        {
            OnPriceChanged(this, oldPrice); //firing the event
        }
    }
}
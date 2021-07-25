public class CoinInfo { 
    public string Id { get; set; }
    public string Name {get; set; }
    public string Internal {get;set;}
    public string Algorithm {get; set; }
    public double BlockNumber {get; set; }

    public CoinInfo () { }

    public override string ToString() { 
        return $"Id: {this.Id}, Name: {this.Name}, Internal: {this.Internal}, Algorithm: {this.Algorithm}: BlockNumber: {this.BlockNumber}";
    }
}
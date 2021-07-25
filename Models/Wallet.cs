using System.Collections.Generic;

public class Wallet { 

    public string Id { get; set; }
    public string Url { get; set; }

    public string Name { get; set; }
    public string Security { get; set; }
    public string EaseOfUse { get; set; }
    public bool Recommended { get; set;}
    public bool Sponsored { get; set; }

    public List<string> CoinsToDisplay { get; set; }

    public Wallet () {}

    public override string ToString() { 
        string CoinsToDisplayString = string.Join(", ", this.CoinsToDisplay);
        return $"Id: {this.Id}, Url: {this.Url}, Name: {this.Name}, Security: {this.Security},  EaseOfUse: {this.EaseOfUse}, Recommended: {this.Recommended},Sponsored: {this.Sponsored}, Coins: {CoinsToDisplayString}";
        }
    }

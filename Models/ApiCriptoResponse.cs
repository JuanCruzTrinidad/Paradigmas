using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class ApiCriptoResponse<T>{

    public string Response { get; set; }
    public string Message { get; set; }
    public bool HasWarning { get; set; }
    public int Type { get; set; }
    public T Data {get; set;}

    public ApiCriptoResponse () {}
}

public class WalletList { 
    [JsonPropertyName("2486")]
    public Wallet Ejemplo1 {get; set;}
    [JsonPropertyName("2495")]
    public Wallet Ejemplo2 {get; set;}
    [JsonPropertyName("2497")]
    public Wallet Ejemplo3 {get; set;}
    [JsonPropertyName("2499")]
    public Wallet Ejemplo4 {get; set;}

    public WalletList () {}

    public List<Wallet> GetWalletList ()  { 
        return new List<Wallet> { Ejemplo1, Ejemplo2, Ejemplo3, Ejemplo4 };
    }
}

public class CoinInfoResponse { 

    public CoinInfo CoinInfo { get; set; }
    public CoinInfoResponse() {}
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

public class WalletServices { 

    public WalletServices () { }

    public List<Wallet> GetAllWallets() {

        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("https://min-api.cryptocompare.com/data/wallets/general?api_key=1fd28f2ef148e8bb4f671fe400001d5ebe81de6aec5c862391680e1c49b1c83b").Result;
        byte[] data = response.Content.ReadAsByteArrayAsync().Result;
        ApiCriptoResponse<WalletList> walletResponse = JsonSerializer.Deserialize<ApiCriptoResponse<WalletList>>(data);
        return walletResponse.Data.GetWalletList();
     }

}
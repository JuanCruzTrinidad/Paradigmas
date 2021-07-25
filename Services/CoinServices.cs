using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

public class CoinServices { 

    public CoinServices () { }

    public List<CoinInfoResponse> GetAllCoins() {

        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("https://min-api.cryptocompare.com/data/top/totalvolfull?limit=10&tsym=USD&api_key=1fd28f2ef148e8bb4f671fe400001d5ebe81de6aec5c862391680e1c49b1c83b").Result;
        byte[] data = response.Content.ReadAsByteArrayAsync().Result;
        ApiCriptoResponse<List<CoinInfoResponse>> coinResponse = JsonSerializer.Deserialize<ApiCriptoResponse<List<CoinInfoResponse>>>(data);
        return coinResponse.Data;
     }

}
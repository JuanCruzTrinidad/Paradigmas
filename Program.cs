using System;
using System.Net.Http;

namespace Funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            WalletServices walletServices = new WalletServices();
            CoinServices coinServices = new CoinServices();
            foreach ( Wallet wallet in walletServices.GetAllWallets()){ 
                Console.WriteLine(wallet);
            }
            foreach (CoinInfoResponse coin in coinServices.GetAllCoins()){ 
                Console.WriteLine(coin.CoinInfo);
            }
        }
    }
}

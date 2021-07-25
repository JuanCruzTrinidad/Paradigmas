using System;
using System.Net.Http;

namespace Funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            WalletServices walletServices = new WalletServices();
            foreach ( Wallet wallet in walletServices.GetAllWallets()){ 
                Console.WriteLine(wallet.Name);
            }
        }
    }
}

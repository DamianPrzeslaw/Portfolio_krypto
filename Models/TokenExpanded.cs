using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using CoinGecko.Clients;

namespace Portfolio_Krypto.Models
{
    public class TokenExpanded:Token
    {
        public double worth_current { get; set; }
        public double current_price { get; set; }

        public double profit { get; set; }
        public double profit_dolar { get; set; }
        public Uri image { get; set; }

   
        public TokenExpanded(Token i)
        {
            id = i.id;
            userName = i.userName;
            tokenName = i.tokenName;
            price_buy = i.price_buy;
            amount = i.amount;
            date_buy = i.date_buy;
            id_geco = i.id_geco;    
        }
        public TokenExpanded() { }

        public async Task update()
        {
            try
            {
                CoinGeckoClient client = new CoinGeckoClient();
                var result = await client.CoinsClient.GetCoinMarkets("usd", new[] { id_geco}, "MarketCapDesc", 1, 1, true, "1h", "");
                current_price =(double)result[0].CurrentPrice;
                image = result[0].Image;
                profit = (current_price / price_buy)-1;
                profit = Math.Round( profit *100,2);
                worth_current = Math.Round(current_price * amount,2);
                profit_dolar = Math.Round(worth_current - (price_buy * amount));
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}

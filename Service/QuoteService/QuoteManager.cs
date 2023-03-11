using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shipment_Project.Shared.Response;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Shipment_Project.Service.QuoteService
{


    public class QuoteManager : IQuoteManager
    {
        private readonly HttpClient _httpClient;

        public QuoteManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RandomQuote> GetAuthorQuote()
        {
            try
            {
                var url = "https://api.quotable.io/random";
                //var queryParameters = "?userId=1&postId=2";
                //var url = baseUrl + queryParameters;

                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var posts = JsonConvert.DeserializeObject<RandomQuote>(responseData);
                    return posts;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return null;
        }

        public async Task<QuoteByAlbert> GetQuoteByAlbert()
        {
            try
            {
                var baseUrl = "https://api.quotable.io/quotes/random";
                var queryParameters = "?limit=30&author=Albert%20Einstein";
                var url = baseUrl + queryParameters;

                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var randomQuotes = JsonConvert.DeserializeObject<List<RandomQuote>>(responseData);


                    //foreach (var item in randomQuotes)
                    //{
                    //    await Console.Out.WriteLineAsync(item.content.Length.ToString());
                    //}


                    var ShortDataCount = randomQuotes
                                        .GroupBy(x => x.content.Length).Where(a => a.Key < 10).ToList();

                    var mediumDataCount = randomQuotes
                                        .GroupBy(x => x.content.Length).Where(y => y.Key >= 11 && y.Key <= 20).ToList();

                    var longDataCount = randomQuotes
                                        .GroupBy(x => x.content.Length).Where(y => y.Key > 20).ToList();

                    var posts = new QuoteByAlbert()
                    {

                        TotalCount = randomQuotes.Count,
                        longDataCount = longDataCount.Count,
                        mediumDataCount = mediumDataCount.Count,
                        ShortDataCount = ShortDataCount.Count,
                        QuotesbyAlbert = randomQuotes
                    };


                    return posts;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return null;
        }
    }
}

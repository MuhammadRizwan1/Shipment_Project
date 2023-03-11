using System.Threading.Tasks;
using System;
using Shipment_Project.Shared.Response;
using System.Collections.Generic;

namespace Shipment_Project.Service.QuoteService
{
    public interface IQuoteManager
    {
        Task<RandomQuote> GetAuthorQuote();
        Task<QuoteByAlbert> GetQuoteByAlbert();
    }
}

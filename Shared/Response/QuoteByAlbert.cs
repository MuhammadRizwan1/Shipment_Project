using System.Collections.Generic;

namespace Shipment_Project.Shared.Response
{
    public class QuoteByAlbert
    {
        public int TotalCount { get; set; }
        public int ShortDataCount { get; set; }
        public int mediumDataCount { get; set; }
        public int longDataCount { get; set; }
        public List<RandomQuote> QuotesbyAlbert { get; set; }
    }
}

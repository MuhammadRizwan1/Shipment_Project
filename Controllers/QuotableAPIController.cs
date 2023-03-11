using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Shipment_Project.Service.QuoteService;
using Shipment_Project.Shared.Response;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shipment_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotableAPIController : ControllerBase
    {

        private readonly IQuoteManager _quoteManager;

        public QuotableAPIController(IQuoteManager quoteManager)
        {
            _quoteManager = quoteManager;
        }

        // GET: api/<QuotableAPIController>
        [HttpGet("GetAuthorQuote")]
        public async Task<RandomQuote> Get()
        {
            var response=await _quoteManager.GetAuthorQuote();
            return response;
        }


        // GET: api/<QuotableAPIController>
        [HttpGet("GetQuoteByAlbert")]
        public async Task<QuoteByAlbert> GetQuoteByAlbert()
        {
            var response = await _quoteManager.GetQuoteByAlbert();
            return response;
        }
    }
}

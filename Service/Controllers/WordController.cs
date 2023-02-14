using Client;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IReverseService _reverseService;
        private readonly IReaderWriter _readerWriter;
        public WordController(IReverseService reverseService, IReaderWriter readerWriter)
        {
            _reverseService = reverseService;
            _readerWriter = readerWriter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var words = _readerWriter.ReadWords();
            var rWords = _reverseService.Reverse(words);
            _readerWriter.WriteWords(rWords);
            return Ok();
        }
    }
}
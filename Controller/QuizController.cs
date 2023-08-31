using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quiz.Model;
using Quiz.Services;
using System.Reflection.Metadata.Ecma335;

namespace Quiz.Controller
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {
        private IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuizzez()
        {
          //  var quizzes = await _quizService.GetAllQuizzes();
            return Ok();
        }
        [HttpGet("{owner}")]
        public async Task<IActionResult> GetByOwner(string owner)
        {
            // var ownerQuizzes = await _quizService.GetAllQuizzesByOwner(owner);
            return Ok(); //(ownerQuizzes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuiz(CreateQuizReqest reqest)
        {
            return Ok(); //await _quizService.CreateQuiz(reqest);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuiz(string id, CreateQuizRequest request)
        {
           //  await _quizService.UpdateQuiz(request, id);
            return Ok();
        }

        public async Task<IActionResult> DeleteQuiz(string id)
        {
            await _quizService.DeleteQuiz(id);
            return Ok();
        }
    }
}

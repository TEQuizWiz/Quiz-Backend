using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Quiz.Model;

namespace Quiz.Services
{
    public interface IQuizService
    {
        IActionResult CreateQuiz(CreateQuizReqest reqest);
        Task DeleteQuiz(string id);
        Task GetAllQuizzes();
        Task GetAllQuizzesByOwner(string owner);
        IActionResult UpdateQuiz(CreateQuizRequest request, string id);
    }
    public class QuizService : IQuizService
    {
        public IActionResult CreateQuiz(CreateQuizReqest reqest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteQuiz(string id)
        {
            throw new NotImplementedException();
        }

        public Task GetAllQuizzes()
        {
            throw new NotImplementedException();
        }

        public Task GetAllQuizzesByOwner(string owner)
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateQuiz(CreateQuizRequest request, string id)
        {
            throw new NotImplementedException();
        }
    }
}

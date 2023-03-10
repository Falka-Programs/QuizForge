using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizForge.Models.QuizModels;
using QuizForge.Models.UserModels;

namespace QuizForge.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Quizes models
        public DbSet<Quiz> Quizzes => Set<Quiz>();
        public DbSet<QuizQuestion> QuizQuestions => Set<QuizQuestion>();
        public DbSet<QuestionAnswers> QuestionAnswers => Set<QuestionAnswers>();
        //************

        //UserModels
        public DbSet<UserPoint> UserPoints => Set<UserPoint>();
        public DbSet<UserQuiz> UserQuizzes => Set<UserQuiz>();
    }
}
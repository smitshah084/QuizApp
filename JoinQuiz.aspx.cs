using System;

namespace QuizApp
{
    public partial class JoinQuiz : System.Web.UI.Page
    {
        protected void btnJoinQuiz_Click(object sender, EventArgs e)
        {
            string quizCode = txtQuizCode.Text;

            // Fetch quiz from DB using the quiz code

            // If quiz is found, navigate to the quiz-taking page
            Response.Redirect($"TakeQuiz.aspx?code={quizCode}");
        }
    }
}

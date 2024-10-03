using System;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class QuizResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadResults();
            }
        }

        private void LoadResults()
        {
            // Fetch quiz results from DB
            lblScore.Text = "Your Score: 8/10";

            // Sample correct answers
            var correctAnswers = new List<Question>
            {
                new Question { QuestionText = "What is 2+2?", CorrectAnswer = "4" },
                new Question { QuestionText = "Capital of France?", CorrectAnswer = "Paris" }
            };
            rptCorrectAnswers.DataSource = correctAnswers;
            rptCorrectAnswers.DataBind();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace QuizApp
{
    public partial class TakeQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuiz();
            }
        }

        private void LoadQuiz()
        {
            // Fetch the quiz from the database using the query string code
            string quizCode = Request.QueryString["code"];
            lblQuizName.Text = "Quiz: " + quizCode; // Set quiz name

            // Example questions (replace with DB data)
            var questions = new List<Question>
            {
                new Question { QuestionText = "What is 2+2?", Option1 = "2", Option2 = "3", Option3 = "4", Option4 = "5" },
                new Question { QuestionText = "Capital of France?", Option1 = "London", Option2 = "Paris", Option3 = "Berlin", Option4 = "Rome" }
            };

            rptQuestions.DataSource = questions;
            rptQuestions.DataBind();
        }

        protected void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            int score = 0;
            var userAnswers = new List<string>();

            foreach (RepeaterItem item in rptQuestions.Items)
            {
                var rbl = (RadioButtonList)item.FindControl("rblOptions");
                userAnswers.Add(rbl.SelectedValue);

                // Calculate score (you can replace this with DB stored correct answers)
                string correctAnswer = "Option3"; // Example correct answer for all questions
                if (rbl.SelectedValue == correctAnswer)
                {
                    score++;
                }
            }

            // Save user submission to the database and calculate score
            Response.Redirect($"QuizResults.aspx?score={score}&total={rptQuestions.Items.Count}");
        }
    }
}

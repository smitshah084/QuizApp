using System;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class CreateQuiz : System.Web.UI.Page
    {
        private static List<Question> questions = new List<Question>();

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            questions.Add(new Question
            {
                QuestionText = txtQuestion.Text,
                Option1 = txtOption1.Text,
                Option2 = txtOption2.Text,
                Option3 = txtOption3.Text,
                Option4 = txtOption4.Text,
                CorrectAnswer = ddlCorrectAnswer.SelectedValue
            });
            ClearForm();
        }

        protected void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            // Generate quiz code and save quiz to the database
            string quizCode = Guid.NewGuid().ToString().Substring(0, 6);
            // Save questions and quizCode to DB

            Response.Write($"Quiz submitted successfully. Your Quiz Code is: {quizCode}");
        }

        private void ClearForm()
        {
            txtQuestion.Text = string.Empty;
            txtOption1.Text = string.Empty;
            txtOption2.Text = string.Empty;
            txtOption3.Text = string.Empty;
            txtOption4.Text = string.Empty;
            ddlCorrectAnswer.SelectedIndex = 0;
        }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
    }
}

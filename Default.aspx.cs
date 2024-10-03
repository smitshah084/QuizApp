using System;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCreatedQuizzes();
                LoadCompletedQuizzes();
            }
        }

        protected void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateQuiz.aspx");
        }

        protected void btnJoinQuiz_Click(object sender, EventArgs e)
        {
            Response.Redirect("JoinQuiz.aspx");
        }

        private void LoadCreatedQuizzes()
        {
            // Fetch from DB (dummy data for now)
            gvCreatedQuizzes.DataSource = new List<Quiz>
            {
                new Quiz { QuizName = "Sample Quiz 1" }
            };
            gvCreatedQuizzes.DataBind();
        }

        private void LoadCompletedQuizzes()
        {
            // Fetch from DB (dummy data for now)
            gvCompletedQuizzes.DataSource = new List<Quiz>
            {
                new Quiz { QuizName = "Sample Quiz 1" }
            };
            gvCompletedQuizzes.DataBind();
        }
    }

    public class Quiz
    {
        public string QuizName { get; set; }
    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuizResults.aspx.cs" Inherits="QuizApp.QuizResults" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quiz Results</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Your Results</h2>
            <asp:Label ID="lblScore" runat="server" Text="Your Score"></asp:Label>
            <br />
            <h3>Correct Answers:</h3>
            <asp:Repeater ID="rptCorrectAnswers" runat="server">
                <ItemTemplate>
                    <div>
                        <%# Eval("QuestionText") %>: <%# Eval("CorrectAnswer") %>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>

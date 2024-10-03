<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateQuiz.aspx.cs" Inherits="QuizApp.CreateQuiz" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Quiz</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Create Quiz</h2>

            <asp:TextBox ID="txtQuestion" runat="server" placeholder="Enter question"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtOption1" runat="server" placeholder="Option 1"></asp:TextBox>
            <asp:TextBox ID="txtOption2" runat="server" placeholder="Option 2"></asp:TextBox>
            <asp:TextBox ID="txtOption3" runat="server" placeholder="Option 3"></asp:TextBox>
            <asp:TextBox ID="txtOption4" runat="server" placeholder="Option 4"></asp:TextBox>
            <asp:DropDownList ID="ddlCorrectAnswer" runat="server">
                <asp:ListItem>Option 1</asp:ListItem>
                <asp:ListItem>Option 2</asp:ListItem>
                <asp:ListItem>Option 3</asp:ListItem>
                <asp:ListItem>Option 4</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="btnAddQuestion" runat="server" Text="Add Question" OnClick="btnAddQuestion_Click" />
            <br /><br />
            <asp:Button ID="btnSubmitQuiz" runat="server" Text="Submit Quiz" OnClick="btnSubmitQuiz_Click" />
        </div>
    </form>
</body>
</html>

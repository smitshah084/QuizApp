<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TakeQuiz.aspx.cs" Inherits="QuizApp.TakeQuiz" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Take Quiz</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Take Quiz</h2>
            <asp:Label ID="lblQuizName" runat="server" Text="Quiz Name"></asp:Label>
            <br /><br />
            <asp:Repeater ID="rptQuestions" runat="server">
                <ItemTemplate>
                    <div>
                        <strong>Question <%# Container.ItemIndex + 1 %>:</strong>
                        <%# Eval("QuestionText") %><br />
                        <asp:RadioButtonList ID="rblOptions" runat="server">
                            <asp:ListItem Text='<%# Eval("Option1") %>' Value="Option1"></asp:ListItem>
                            <asp:ListItem Text='<%# Eval("Option2") %>' Value="Option2"></asp:ListItem>
                            <asp:ListItem Text='<%# Eval("Option3") %>' Value="Option3"></asp:ListItem>
                            <asp:ListItem Text='<%# Eval("Option4") %>' Value="Option4"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="btnSubmitQuiz" runat="server" Text="Submit Quiz" OnClick="btnSubmitQuiz_Click" />
        </div>
    </form>
</body>
</html>

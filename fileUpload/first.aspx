<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="fileUpload.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Height="21px" Text="Upload" OnClick="Button1_Click" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
        </p>
    </form>
</body>
</html>

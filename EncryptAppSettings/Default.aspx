<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EncryptAppSettings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>AppSettings</h2>
        <div>
            <b>Value Read From encrypted:</b>
            <asp:Label ID="lblAppSettingValue" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <b>Real Value:</b>
            <asp:Label ID="lblAppSettingSupposedValue" runat="server" Text=" myuser - mypassword"></asp:Label>
        </div>
        <h2>Connection String</h2>
        <div>
            <b>Value Read From encrypted:</b>
            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <b>Real Value:</b>
            <asp:Label ID="Label22" runat="server" Text=" Server=localhost;Database=MyDB;User ID=myuser;Password=mypassword;"></asp:Label>
        </div>
    </form>
</body>
</html>

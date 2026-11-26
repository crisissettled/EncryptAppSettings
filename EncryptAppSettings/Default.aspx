<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EncryptAppSettings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Value From encrypted:
            <asp:Label ID="lblAppSettingValue" runat="server" Text=""></asp:Label>
        </div>
        <div>
            Real Value:
            <asp:Label ID="lblAppSettingSupposedValue" runat="server" Text="abc23423423Xysdf_asdf3"></asp:Label>
        </div>
    </form>
</body>
</html>

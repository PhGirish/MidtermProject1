<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adrotator.aspx.cs" Inherits="MidtermProject1.adrotator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" OnAdCreated="AdRotator1_AdCreated" AdvertisementFile="~/XMLFile1.xml" />
        </div>
    </form>
</body>
</html>




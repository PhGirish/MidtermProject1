<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MidtermProject1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
            width: 268px;
        }
        .auto-style4 {
            width: 266px;
        }
        .auto-style5 {
            width: 268px;
        }
        .auto-style6 {
            width: 272px;
        }
    </style>
    <link rel="stylesheet" href="/css/WF2.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1" style="border: thin solid #008080">
            <tr>
                <td class="style2" 
                    style="text-align: center; border-bottom-style: solid; border-bottom-width: thin; border-bottom-color: #008080;">
                    COURSE WE OFFER</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="btnview1" runat="server" onclick="btnview1_Click" 
                        style="font-weight: 700" Text="course1" />

                    <asp:Button ID="btnview2" runat="server" onclick="btnview2_Click" 
                        style="font-weight: 700" Text="course2" />

                    <asp:Button ID="btnview3" runat="server" onclick="btnview3_Click" 
                        style="font-weight: 700" Text="course3" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged" >
                        <asp:View ID="View1" runat="server" >
                            <table border="1" class="style3" >
                                <tr>
                                    <td class="auto-style4" style="text-align: center">
                                        View -1</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MACHINE LEARNING</td>
                                </tr>
                            </table>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            <table border="1" class="style3">
                                <tr>
                                    <td class="auto-style5" style="text-align: center">
                                        View -2</td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MICRO EDUCATION</td>
                                </tr>
                            </table>
                        </asp:View>
                        <asp:View ID="View3" runat="server">
                            <table border="1" class="style3">
                                <tr>
                                    <td class="auto-style6" style="text-align: center">
                                        View -3</td>
                                </tr>
                                <tr>
                                    <td class="auto-style6">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CLOUD</td>
                                </tr>
                            </table>
                        </asp:View>
                    </asp:MultiView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

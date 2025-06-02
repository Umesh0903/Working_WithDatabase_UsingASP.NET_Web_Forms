<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkingWithDataBase.aspx.cs" Inherits="DataBaseConnectivity.WorkingWithDataBase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
   <style>
       #UserForm {
       width:300px;
       }
   </style>

</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="#99CCFF">
                <EditRowStyle BackColor="#66FF99" />
                <HeaderStyle BorderColor="#3399FF" />
            </asp:GridView>
        </div>

        <div id="UserForm">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control mt-2 mb-2" placeholder="Enter ID"></asp:TextBox>
              <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control mb-2" placeholder="Enter Name"></asp:TextBox>
              <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control mb-2" placeholder="Enter city"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary ms-2" Width="100" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="btn btn-secondary" Width="100" OnClick="Button2_Click"/> 
             <br /><br />
            <asp:Button ID="Button3" runat="server" Text="Delete" CssClass="btn btn-primary ms-2" Width="100" OnClick="Button3_Click"/>
            <asp:Button ID="Button4" runat="server" Text="Update" CssClass="btn btn-secondary" Width="100" OnClick="Button4_Click"/> 




        </div>
    </form>
        </center>
</body>
</html>
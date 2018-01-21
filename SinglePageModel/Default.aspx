<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SinglePageModel.Default" %>
<%@ Import Namespace="AutoLotDAL.Models" %>
<%@ Import Namespace="AutoLotDAL.Repos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat="server">
        public IEnumerable<Inventory> GetData()
        {
            var inventoryRepo = new InventoryRepo();
            return inventoryRepo.GetAll();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:GridView ID="GridView1" runat="server" ItemType="AutoLotDAL.Models.Inventory" SelectMethod="GetData">
            </asp:GridView>
        </div>
        

    </form>
</body>
</html>

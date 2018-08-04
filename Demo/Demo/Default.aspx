<script runat="server">

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        Response.Write("Adding the numbers")



    End Sub
</script>
<form id="form1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
</form>

<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="asp_app.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your contact pagesss.</h3>
        <address>
            One Microsoft Way<br />
            Redmond, WA 98052-6399<br />
            <abbr title="Phone">P:</abbr>
            425.555.0100
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
        <asp:Label ID="Label1" runat="server" Text="Name:" CssClass="form-label"></asp:Label>
        <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                       <asp:CheckBox id="checkbox1" runat="server"
                    AutoPostBack="True"
                    Text="Include 8.6% sales tax"
                    TextAlign="Right"
                    OnCheckedChanged="Check_Clicked"/>
        <h1>TEST</h1>
    </main>
</asp:Content>

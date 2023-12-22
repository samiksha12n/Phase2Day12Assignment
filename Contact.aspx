<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Assignment11MasterPage.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Contact Page</h2>
    <asp:Repeater ID="Article" runat="server">
            <ItemTemplate>
                <div>
                    <h3><%# Eval("Title") %></h3>
                    <p><%# Eval("Content") %></p>
                    <p>Publish Date: <%# Eval("PublishDate") %></p>
                    <hr />
                </div>
            </ItemTemplate>
        </asp:Repeater>
</asp:Content>

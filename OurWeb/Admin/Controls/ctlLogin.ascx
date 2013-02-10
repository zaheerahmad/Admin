<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlLogin.ascx.cs" Inherits="AdminSite.Controls.ctlLogin" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>

<div class="span6 offset3">
<div class="page-header">
    <h1>Please Login Here</h1>
</div>
<div class = "row">
    <div>
         <div class="alert alert-error" id="divStatusError" runat="server">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        <form name="loginForm" class="form-horizontal" runat="server">
          <div class="control-group">
            <label class="control-label" for="inputError">User Name:</label>
            <div class="controls">
                <asp:TextBox ID="txtUser" placeHolder="Enter username here..." runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTextUser" runat="server" ErrorMessage="*" ControlToValidate="txtUser" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="control-group">
            <label class="control-label" for="inputPassword">Password</label>
            <div class="controls">
              <asp:TextBox ID="txtPassword" TextMode="Password" placeHolder="Enter password here..." runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTextPassword" runat="server" ErrorMessage="*" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="control-group">
            <div class="controls">
              <label class="checkbox">
                <input type="checkbox"> Remember me
              </label>
              <asp:Button class="btn" Text="Sign in" runat="server" type="submit" 
                    ID="btnSignIn" onclick="btnSignIn_Click" /><br />
              <%--<button type="submit" class="btn" onclick="ButtonSignIn_Click">Sign in</button>--%>
              
            </div>
          </div>
          
        </form>    
    </div>
</div>
</div>
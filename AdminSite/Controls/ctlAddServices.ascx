<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlAddServices.ascx.cs" Inherits="AdminSite.Controls.ctlAddServices" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>

<script type="text/javascript">
    $(document).ready(function () {
        $("li#add").click(function () {
            $("li.#home").css({ "class": "active" });
        });
    });
</script>
<div class="span2">
    <ul class="nav nav-list">
      <li class="nav-header">Sercices</li>
      <li id="home"><a href="#">Home</a></li>
      <li id="add" class="active"><a href="Admin.aspx?ctl=2">Add Services</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=3">Manage Services</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Services<small> Add Service</small></h1>
    </div>
    <form name="frmAddService" class="form-horizontal" runat="server">
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
      <div class="control-group">
        <label class="control-label" for="txtServiceTitle">Service Title</label>
        <div class="controls">
          <asp:TextBox ID="txtServiceTitle" runat="server" placeHolder="Type Service Title..."></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvServiceTitle" ControlToValidate="txtServiceTitle" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="txtServiceDescription">Service Description</label>
        <div class="controls">
          <asp:TextBox ID="txtServiceDescription" runat="server" placeHolder="Type Service Description..." TextMode="MultiLine" MaxLength="100" Height="50px" Width="400px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvServiceDescription" ControlToValidate="txtServiceDescription" runat="server" ForeColor="Red" Text="*" />
        </div>
      </div>
      <div class="control-group">
        <label class="control-label" for="fuServicePicture">Add Service Picture</label>
        <div class="controls">
            <asp:FileUpload ID="fuServicePicture" runat="server"/>
        </div>
      </div>
      <div class="control-group">
        <div class="controls">
            <asp:Button ID="btnAddService" class="btn" runat="server" Text="Add Service" 
                onclick="btnAddService_Click"/>
        </div>
      </div>
    </form>
</div>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlContact.ascx.cs" Inherits="OurWeb.Controls.ctlContact" %>
<script type="text/javascript" src="../assets/js/jquery.form.js"></script>
<%--<script type="text/javascript">
    $(document).ready(function () {
        var options = { target: "#alert" };
        $("#form-contact").ajaxForm(options);
    }); 
</script>--%>
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="../assets/js/googlemap-config.js"></script>
<script type="text/javascript" src="../assets/js/jquery-workarounds.js"></script>
 <!-- header -->
        <div id="header">
        	
            <a href="#" class="button small float-right">Get in touch</a>
            <a href="Home.aspx?ctl=1" class="button blue float-right">Check our works</a>
            
            <h2>Contact</h2> <p>Duis autem vel eum iriure dolor in hendrerit in vulputate</p>
            
        </div>
        <!-- //header -->
        
        <!-- path -->
        <div id="path">
        	
            <strong>You are here:</strong> <a href="Home.aspx?ctl=0">Home</a> / <a href="Home.aspx?ctl=3">Contact</a>
            
        </div>
        <!-- //path -->
                
        <!-- content -->
        <div id="content">
         
            <!-- set size -->
            <div class="set-size">
            
            	<!-- column -->
            	<div class="column-460 float-left">
                	<h4>Where are we?</h4>
                    <p>
                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
                    </p>
                    <p>
                    Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit 
                    </p>
                    <br />
                    <!-- google map holder -->
                    <div id="map_canvas" class="curved shaded"></div>
                    <!-- //google map holder -->
                </div>
                <!-- //column -->
                
                <!-- column -->
                <div class="column-460 float-right">
                
                	<h4>Contact us</h4>
                    
                	<div class="column-220 float-left">
                    <p>
                        <strong>Corporate Info</strong><br />
                        123 Main Street #3<br />
                        San Francisco, CA, 94101<br />
                        <strong>Phone</strong>: (866) 123-4567 ext#1<br />
                        <strong>FAX</strong>: (866) 123-0000
                    </p>
                    </div>
                    
                    <div class="column-220 float-right">
                    <p>
                        <strong>Sales Inquiries</strong><br />
                        <strong>Email</strong>: webdesign@shegy.pl<br />
                        <strong>Phone</strong>: (866) 123-0000 ext.#6
                    </p>
                    </div>
                    
                    <div class="clear"></div>
                    <br />
                    <h4>Send a message</h4>
                    
                    <div class="form">
                    <div class="message"><div id="alert"></div></div>
                    <form action="" method="post" ID="frmContact">
                        <div>
                            <label for="txtName">Name:</label>
                            <input type="text" value="" class="input-text" name="name" id="txtName" />
                            <%--<asp:TextBox ID="txtName" name="name" class="input-text" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTextName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator>--%>
                        </div>
                        <div>
                            <label for="email">E-mail:</label>
                            <input type="text" value="" class="input-text" name="email" id="email" />
                            <%--<asp:TextBox ID="txtEmail" name="email" class="input-text" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTextEmail" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>--%>
                        </div>
                        <div>
                            <label for="message">Message:</label>
                            <textarea cols="" rows="" class="input-textarea" name="message" id="message"></textarea>
                            <%--<asp:TextBox ID="txtMessage" name="message" class="input-textarea" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTextMessage" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMessage"></asp:RequiredFieldValidator>--%>
                        </div>
                        <div>
                            <input type="submit" value="Send message" class="button small float-right" />
                            <%--<asp:Button ID="btnSubmitMessage" runat="server" 
                                class="button small float-right" Text="Send Message" 
                                onclick="btnSubmitMessage_Click" />--%>
                        </div>
                    </form>
                    </div>

                </div>
                <!-- //column -->
            
            </div>
            <!-- //set size -->
            
            <div class="clear"></div>
            
        </div>
        <!-- //content -->
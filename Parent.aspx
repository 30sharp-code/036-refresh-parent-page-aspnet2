<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Parent.aspx.cs" Inherits="Parent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Parent Page</title>
<script language="javascript" type="text/javascript">
   function OpenWindow(strChildPageUrl)
       {
          window.open (strChildPageUrl, 'NewPage','width=600px,height=600px,scrollbars=1');
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="javascript:OpenWindow('Child.aspx')">Show Child</a>
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="227px" Width="562px">
            Panel</asp:Panel>
    
    </div>
    </form>
</body>
</html>

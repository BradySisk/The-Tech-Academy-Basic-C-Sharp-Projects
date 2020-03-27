<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Kockout.WebForm1" %>

<!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
        <p> First Name :<span data-bind="text:firstName"/></p>  
        <p> Last Name :<span data-bind="text:LastName"/></p>  
      
    </div>  
    </form>  
    <script src="Scripts/knockout-3.3.0.js"></script>  
    <script type="text/javascript">  
        var vm =  
            {  
                firstName: "Yatendra",  
                LastName: "Sharma"  
            };  
        ko.applyBindings(vm);  
    </script>  
</body>  
</html>  

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empdetails.aspx.cs" Inherits="WebApplication1.empdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><table><tr>
       <td>name</td> <td>
            <input type="text" id="txtname" />
        </td>
        <td>email</td><td>
<input type="text" id="empid" name="txtemail" />
        </td>
        <td> <input type="button" id="btnsubmit" value="submit" /></td>
                </tr>
        
        
</table>
    <p>result of ur</p><div id="result" ></div>
    </div >
    </form>
</body>
</html>

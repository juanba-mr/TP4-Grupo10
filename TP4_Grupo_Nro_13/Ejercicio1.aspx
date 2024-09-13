<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_Grupo_Nro_13.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            width: 201px;
            text-align: left;
        }
        .auto-style3 {
            width: 201px;
            text-align: left;
        }
        .auto-style4 {
            width: 36px;
        }
        .auto-style5 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%; margin-bottom: 0px;">
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESTINO INICIAL</td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PROVINCIA:</td>
                <td>
                    <asp:DropDownList ID="ddlProvinciaInicio" runat="server" Width="102px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged" style="margin-bottom: 0px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
             <tr>
                 <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOCALIDAD:</td>
                 <td>
                        <asp:DropDownList ID="ddlLocalidadInicio" runat="server" Width="102px" AutoPostBack="True">
                        </asp:DropDownList>
                 </td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td>
                        &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
             <tr>
                 <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESTINO FINAL</td>
                 <td>
                        &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
             <tr>
                 <td class="auto-style2">&nbsp;</td>
                 <td>
                        &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
             <tr>
                 <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PROVINCIA:</td>
                 <td>
                        <asp:DropDownList ID="ddlProvinciaFinal" runat="server" OnSelectedIndexChanged="ddlProvinciaFinal_SelectedIndexChanged" Height="18px" Width="102px">
                        </asp:DropDownList>
                 </td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
        </table>
        <table style="margin-bottom: 0px;" class="auto-style5">
             <tr>
                 <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOCALIDAD:</td>
                 <td>
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server" Width="102px" AutoPostBack="True">
                        </asp:DropDownList>
                 </td>
                <td class="auto-style4">&nbsp;</td>
             </tr>
            
        </table>
    </form>
</body>
</html>

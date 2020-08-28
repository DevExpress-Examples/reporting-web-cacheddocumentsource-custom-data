<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CustomCachedDocumentSourceSerialization.Default" %>
<%@ Register Assembly="DevExpress.XtraReports.v18.1.Web.WebForms, Version=18.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>DevExpress ASP.NET project</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" Height="800px">
            </dx:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
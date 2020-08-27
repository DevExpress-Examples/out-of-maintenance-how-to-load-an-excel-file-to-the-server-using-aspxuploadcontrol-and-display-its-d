<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<script type="text/javascript">
		function OnFileUploadComplete(s, e) {
			Spreadsheet.PerformCallback();
		}
	</script>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxUploadControl ID="UploadCallbackSpreadsheet" runat="server" ShowUploadButton="True" OnFileUploadComplete="Upload_FileUploadComplete">
				<ValidationSettings AllowedFileExtensions=".xls,.xlsx">
				</ValidationSettings>
				<ClientSideEvents FileUploadComplete="OnFileUploadComplete" />
			</dx:ASPxUploadControl>
			<dx:ASPxSpreadsheet ID="Spreadsheet" ClientInstanceName="Spreadsheet" runat="server" OnLoad="Spreadsheet_Load"></dx:ASPxSpreadsheet>
			<dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton"></dx:ASPxButton>
		</div>
	</form>
</body>
</html>
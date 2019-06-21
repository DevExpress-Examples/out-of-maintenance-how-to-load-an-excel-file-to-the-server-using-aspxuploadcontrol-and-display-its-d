<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to load an excel file to the server using ASPxUploadControl and display its data in ASPxSpreadsheet
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t119832/)**
<!-- run online end -->


This example shows how to load an excel file from your computer to the server using <strong>ASP</strong><strong>xUploadControl</strong> and then display its data in <strong>ASPxSpreadsheet</strong>.<br>To do this, you first need to place the <strong>ASPxSpreadsheet</strong> and <strong>ASPxUploadControl </strong>controls on a page and, secondly, handle the<strong> ASPxSpreadsheet.Load </strong>event and both the server-side and the client-side <strong>ASPxUploadControl</strong><strong>.FileUploadControl</strong> events.<br>After uploading the excel file from your computer, save it in the "~/XlsTables/" directory using the <strong>ASPxUploadControl.FileUploadControl</strong> event handler on the server-side. You may choose any filename and then save it in the <strong>Session["FileName"]</strong> object to use later.<br>In the <strong>ASPxSpreadsheet.<strong>Load </strong></strong>event handler you need to check the value of the <strong>Session</strong><strong>[</strong><strong>"</strong><strong>FileName</strong><strong>"</strong><strong>]</strong><strong> </strong>object. If it's <strong>null</strong>, do nothing. Otherwise use the ASPxSpreadsheet.Open method with this name as a parameter.<br><br>See also: <a href="https://www.devexpress.com/Support/Center/p/E5199">How to load an excel file to the server using ASPxUploadControl and display its data in ASPxGridView</a>

<br/>



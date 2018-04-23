using DevExpress.Web.Office;
using System;
using System.Web.UI;

public partial class _Default : Page {
    string FilePath {
        get { return Session["FilePath"] == null ? String.Empty : Session["FilePath"].ToString(); }
        set { Session["FilePath"] = value; }
    }
    protected void Page_PreInit(object sender, EventArgs e) {
        if (!IsPostBack)
            FilePath = String.Empty;
    }
    protected void Upload_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        String uploadedFilePath = Server.MapPath("~/XlsTables/") + e.UploadedFile.FileName;
        e.UploadedFile.SaveAs(uploadedFilePath);
        if (!String.IsNullOrEmpty(FilePath))
            DocumentManager.CloseDocument(FilePath);
        FilePath = uploadedFilePath;
    }
    protected void Spreadsheet_Load(object sender, EventArgs e) {
        if (!String.IsNullOrEmpty(FilePath)) {
            Spreadsheet.Open(FilePath);
        }
    }
}
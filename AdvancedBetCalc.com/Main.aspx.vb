Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.ContentType = "Download AdvancedBetCalc.exe"
        Dim Header As [String] = "Attachment; Filename=AdvancedBetCalc.exe"
        Response.AppendHeader("Content-Disposition", Header)
        Dim Dfile As New System.IO.FileInfo(Server.MapPath("Download/AdvancedBetCalc.exe"))
        Response.WriteFile(Dfile.FullName)
        'Don't forget to add the following line
        Response.[End]()
    End Sub

End Class
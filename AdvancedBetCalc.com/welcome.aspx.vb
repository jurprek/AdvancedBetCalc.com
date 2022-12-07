Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Numerics

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Dim address1 As String = "http://www.advancedbetcalc.com/Download/ValueTips.txt"
        '  Dim client1 As WebClient = New WebClient()
        '  Dim reader1 As StreamReader = New StreamReader(client1.OpenRead(address1))
        '  ValueTips.Text = reader1.ReadToEnd

        '  Dim MyMailMessage As New MailMessage()

        '  Try

        'MyMailMessage.From = New MailAddress("webnarudzbamed@gmail.com")
        '  MyMailMessage.To.Add("webnarudzbamed@gmail.com")
        '  MyMailMessage.Subject = "Narudzba Meda Internetom"
        ' MyMailMessage.Body = "AdvancedBetCalc.com/index.aspx = LoadPage"
        ' Dim SMTP As New SmtpClient("smtp.gmail.com")
        ' SMTP.Port = 587
        ' SMTP.EnableSsl = True
        ' SMTP.Credentials = New System.Net.NetworkCredential("webnarudzbamed@gmail.com", "OPGSertic2015")
        ' SMTP.Send(MyMailMessage)

        'MsgBox("OK")

        '        Catch ex As Exception
        'MsgBox(ex.ToString)

        'End Try

    End Sub

End Class
Public Class Kelly
    Inherits System.Web.UI.Page
    Dim x, y, z, w As String
    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label5.Visible = False

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        x = Format(bank.Text * (bookieskfc.Text * (1 / fairkfc.Text) - 1) / (bookieskfc.Text - 1), "fixed")
        If x > 0 Then Kelly006.Text = x.ToString() Else Kelly006.Text = ("DO NOT PLAY!")
        If Kelly006.Text = ("DO NOT PLAY!") Then Label5.Visible = True Else Label5.Visible = False

    End Sub
End Class
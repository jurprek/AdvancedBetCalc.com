Public Class Spread_Calc
    Inherits System.Web.UI.Page

    Private Sub SpreadBtn_Click(sender As System.Object, e As System.EventArgs) Handles SpreadBtn.Click

        MiscIFUNDER.Text = FormatNumber((MiscSELL.Text - MiscWasPoints.Text) * MiscINVEST.Text, 2)
        MiscIFOVER.Text = FormatNumber((MiscWasPoints.Text - MiscBUY.Text) * MiscINVEST.Text, 2)

    End Sub

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub
End Class
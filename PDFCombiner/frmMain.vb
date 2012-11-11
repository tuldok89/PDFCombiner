Public Class frmMain

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        'Dim loc As New Point(btnHelp.Location.X + Me.Location.X,
        '                     btnHelp.Location.Y + btnHelp.Size.Height)
        cmsHelp.Show(btnHelp, New Point(0, btnHelp.Height))

    End Sub
End Class

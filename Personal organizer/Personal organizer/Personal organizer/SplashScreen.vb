Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVersion.Text = My.Application.Info.Version.ToString

    End Sub
End Class
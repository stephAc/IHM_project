Public Class Connexion
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnAnnulerConnexion_Click(sender As Object, e As EventArgs) Handles btnAnnulerConnexion.Click
        shop.Show()
        Me.Hide()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click

        shop.connecte = True 'variable dans shop.vb
        Library.Show()
        Me.Hide()
    End Sub
End Class
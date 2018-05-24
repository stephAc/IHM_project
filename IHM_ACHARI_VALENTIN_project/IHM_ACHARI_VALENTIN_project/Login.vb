Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    '------NAVIGATION------

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        shop.Show()
        Me.Hide()
    End Sub

    Private Sub linkCompte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCompte.LinkClicked
        Connexion.Show()
        Me.Hide()
    End Sub

    Private Sub btnEnvoyer_Click(sender As Object, e As EventArgs) Handles btnEnvoyer.Click
        shop.connecte = True 'variable dans shop.vb

        Console.WriteLine(shop.connecte)
        Library.Show()
        Me.Hide()
    End Sub
End Class
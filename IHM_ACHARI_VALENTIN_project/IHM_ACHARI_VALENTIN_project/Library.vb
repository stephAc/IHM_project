Public Class Library
    Private Sub Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '------NAVIGATION------

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        shop.Show()
        Me.Hide()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Account.Show()
        Me.Hide()
    End Sub

    Private Sub btnInscription_Click(sender As Object, e As EventArgs) Handles btnInscription.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
Public Class shop

    Enum Categorie
        Aucun
        Récents
        Note
        Type
    End Enum

    Private Sub shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None


        '------Variable------

        Dim cats As Array
        cats = System.Enum.GetValues(GetType(Categorie))
        For Each cat In cats
            cboBoxTrier.Items.Add(cat)
        Next
        cboBoxTrier.SelectedIndex = 1
    End Sub

    '------NAVIGATION------

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        Library.Show()
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

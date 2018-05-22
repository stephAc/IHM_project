Public Class Library

    'test pour enlever le teste connexion
    Private Sub Library_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        pnlNonConnecter.Controls.Clear() 'Pour virer le panel si jamais il a été créé mais ne fonctionne pas
        connexion()
        Console.WriteLine("chargé")
    End Sub


    Private Sub Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        connexion()
        Console.WriteLine("chargé")
    End Sub

    '------TestConnexion------
    Private Sub connexion()
        If Not shop.connecte Then

            Dim pnlMessage As New FlowLayoutPanel
            pnlMessage.Width = 500
            pnlMessage.Height = 400
            pnlMessage.AutoSize = False
            pnlMessage.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right & AnchorStyles.Top
            pnlMessage.FlowDirection = FlowDirection.TopDown

            Dim btnConnexion As New Button
            btnConnexion.Text = "Se connecter"
            btnConnexion.Height = 20
            btnConnexion.Width = 100
            AddHandler btnConnexion.Click, AddressOf btnInscription_Click

            Dim lblMessage As New Label
            lblMessage.AutoSize = True
            lblMessage.Text = "Un compte est requis pour accéder à sa bibliothèque"

            pnlMessage.Controls.Add(lblMessage)
            pnlMessage.Controls.Add(btnConnexion)
            pnlNonConnecter.Controls.Add(pnlMessage)
        End If

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
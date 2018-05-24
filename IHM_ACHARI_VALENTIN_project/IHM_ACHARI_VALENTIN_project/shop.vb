Public Class shop

    '------VariablesGlobales------
    Public connecte As Boolean = False

    Dim magasin As shop

    '------Variables------
    Enum Categorie
        Aucun
        Récents
        Note
        Type
    End Enum

    Public pac As New Jeux("PacMan", My.Resources.rien, "Aventure", 5)
    Public pong As New Jeux("Pong", My.Resources.rien, "adv", 3)
    Public tetris As New Jeux("Tétris", My.Resources.rien, "adv", 8)

    Dim tabJeu() As Jeux = {pac, pong, tetris}

    '------CréationPanelJeu------
    'creer le panel l'ajouter a la classe jeu puis 
    'panelGlobal?control.add(jeu._panJeu)  exemple d'ajout 


    Private Sub shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Remplissage panel Game
        creationTabGameShop()

        'Remplissage de la combo box
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

    '------Méthodes------

    Private Sub creationTabGameShop()

        For Each i In tabJeu
        
            Dim img As New PictureBox
            img.Width = 150
            img.Width = 180
            img.Image = i._jacket

            Dim pnlGame As New Panel
            pnlGame.Width = 150
            pnlGame.Height = 180
            pnlGame.AutoSize = False

            pnlGame.Controls.Add(img)

            i._panJeu = pnlGame

            pnlGame.Controls.Add(pnlGame)
        Next
    End Sub

End Class

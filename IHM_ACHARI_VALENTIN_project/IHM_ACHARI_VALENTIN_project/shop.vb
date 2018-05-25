Public Class shop

    '------VariablesGlobales------
    Public Shared connecte As Boolean = False

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
    Public r1 As New Jeux("PacMan", My.Resources.rien, "Aventure", 5)
    Public r2 As New Jeux("Pong", My.Resources.rien, "adv", 3)
    Public r3 As New Jeux("Tétris", My.Resources.rien, "adv", 8)

    Dim tabJeu() As Jeux = {pac, pong, tetris, r1, r2, r3}


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

            Console.WriteLine("titi")
            Dim pnlJeu As New Panel
            pnlJeu.Width = 150
            pnlJeu.Height = 180
            pnlJeu.AutoSize = False
            pnlJeu.BackgroundImage = i._jacket
            AddHandler pnlJeu.Click, AddressOf descriptionJeu

            i._panJeu = pnlJeu
            pnlGame.Controls.Add(pnlJeu)
        Next
    End Sub

    Private Sub descriptionJeu(sender As Object, e As EventArgs)

        Dim pnlDescriJeu As New FlowLayoutPanel
        pnlDescriJeu.AutoSize = True
        pnlDescriJeu.Height = 150
        pnlDescriJeu.Width = 150
        pnlDescriJeu.Anchor = AnchorStyles.Left & AnchorStyles.Bottom & AnchorStyles.Right & AnchorStyles.Top
        pnlDescriJeu.FlowDirection = FlowDirection.TopDown

        Dim lblTitreJeu As New Label
        Dim lblTypeJeu As New Label
        Dim lblNoteJeu As New Label

        pnlDescriJeu.BackColor = Color.Green

        Console.WriteLine("ttoto")

        lblTitreJeu.Text = "Titre : " & sender._nomJ
        lblTypeJeu.Text = "Type : " & sender.type
        lblNoteJeu.Text = "Note : " & sender._note


        pnlDescriJeu.Controls.Add(lblTitreJeu)
        pnlDescriJeu.Controls.Add(lblTypeJeu)
        pnlDescriJeu.Controls.Add(lblNoteJeu)

        pnlGameDescri.Controls.Add(pnlDescriJeu)
    End Sub
End Class

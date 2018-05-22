Public Class shop

    'My.Reessource.nomImg  chemin pour image


    '------VariablesGlobales------
    Public connecte As Boolean = False

    '------Variables------
    Enum Categorie
        Aucun
        Récents
        Note
        Type
    End Enum

    'En préparation
    Class Jeux
        Public _nomJeux As New Label
        Public _jacket As Image
        Public _type As String
        Public _note As Integer
        Public _panJeu As Panel


        '------ConstructeurJeux------
        Sub New(nomJ As String, img As Image)
        End Sub
    End Class





    '------CréationPanelJeu------
    'creer le panel l'ajouter a la classe jeu puis 
    'panelGlobal?control.add(jeu._panJeu)  exemple d'ajout 


    Private Sub shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

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

    '------Get------


    '------Set------



End Class

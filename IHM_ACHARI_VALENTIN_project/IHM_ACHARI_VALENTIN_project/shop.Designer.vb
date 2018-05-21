<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shop
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlNav = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnInscription = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabLayGameDescription = New System.Windows.Forms.TableLayoutPanel()
        Me.LabDescri = New System.Windows.Forms.Label()
        Me.ListBoxDescription = New System.Windows.Forms.ListBox()
        Me.pnlGame = New System.Windows.Forms.FlowLayoutPanel()
        Me.panRecherhe = New System.Windows.Forms.Panel()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.cboBoxTrier = New System.Windows.Forms.ComboBox()
        Me.lblTrier = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.pnlNav.SuspendLayout()
        Me.TabLayGameDescription.SuspendLayout()
        Me.panRecherhe.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlNav.Controls.Add(Me.btnShop)
        Me.pnlNav.Controls.Add(Me.btnLibrary)
        Me.pnlNav.Controls.Add(Me.btnAccount)
        Me.pnlNav.Controls.Add(Me.btnInscription)
        Me.pnlNav.Controls.Add(Me.btnExit)
        Me.pnlNav.Location = New System.Drawing.Point(25, 12)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(1040, 40)
        Me.pnlNav.TabIndex = 0
        '
        'btnShop
        '
        Me.btnShop.BackColor = System.Drawing.Color.DarkRed
        Me.btnShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShop.Location = New System.Drawing.Point(3, 3)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(202, 34)
        Me.btnShop.TabIndex = 0
        Me.btnShop.Text = "Magasin"
        Me.btnShop.UseVisualStyleBackColor = False
        '
        'btnLibrary
        '
        Me.btnLibrary.BackColor = System.Drawing.Color.DarkRed
        Me.btnLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLibrary.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLibrary.Location = New System.Drawing.Point(211, 3)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(202, 34)
        Me.btnLibrary.TabIndex = 1
        Me.btnLibrary.Text = "Bibliothèque"
        Me.btnLibrary.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.DarkRed
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAccount.Location = New System.Drawing.Point(419, 3)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(202, 34)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.Text = "Compte"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnInscription
        '
        Me.btnInscription.BackColor = System.Drawing.Color.DarkRed
        Me.btnInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnInscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInscription.Location = New System.Drawing.Point(627, 3)
        Me.btnInscription.Name = "btnInscription"
        Me.btnInscription.Size = New System.Drawing.Size(202, 34)
        Me.btnInscription.TabIndex = 3
        Me.btnInscription.Text = "Inscription/Connexion"
        Me.btnInscription.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkRed
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(835, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Quitter"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TabLayGameDescription
        '
        Me.TabLayGameDescription.ColumnCount = 1
        Me.TabLayGameDescription.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TabLayGameDescription.Controls.Add(Me.LabDescri, 0, 0)
        Me.TabLayGameDescription.Controls.Add(Me.ListBoxDescription, 0, 1)
        Me.TabLayGameDescription.Location = New System.Drawing.Point(28, 83)
        Me.TabLayGameDescription.Name = "TabLayGameDescription"
        Me.TabLayGameDescription.RowCount = 2
        Me.TabLayGameDescription.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TabLayGameDescription.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TabLayGameDescription.Size = New System.Drawing.Size(253, 626)
        Me.TabLayGameDescription.TabIndex = 7
        '
        'LabDescri
        '
        Me.LabDescri.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabDescri.AutoSize = True
        Me.LabDescri.BackColor = System.Drawing.SystemColors.Info
        Me.LabDescri.Font = New System.Drawing.Font("Broadway", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDescri.Location = New System.Drawing.Point(3, 0)
        Me.LabDescri.Name = "LabDescri"
        Me.LabDescri.Size = New System.Drawing.Size(247, 93)
        Me.LabDescri.TabIndex = 0
        Me.LabDescri.Text = "Game Description"
        Me.LabDescri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabDescri.UseCompatibleTextRendering = True
        '
        'ListBoxDescription
        '
        Me.ListBoxDescription.FormattingEnabled = True
        Me.ListBoxDescription.Location = New System.Drawing.Point(3, 96)
        Me.ListBoxDescription.Name = "ListBoxDescription"
        Me.ListBoxDescription.Size = New System.Drawing.Size(247, 524)
        Me.ListBoxDescription.TabIndex = 1
        '
        'pnlGame
        '
        Me.pnlGame.Enabled = False
        Me.pnlGame.Location = New System.Drawing.Point(308, 198)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(764, 551)
        Me.pnlGame.TabIndex = 9
        '
        'panRecherhe
        '
        Me.panRecherhe.Controls.Add(Me.btnRecherche)
        Me.panRecherhe.Controls.Add(Me.cboBoxTrier)
        Me.panRecherhe.Controls.Add(Me.lblTrier)
        Me.panRecherhe.Controls.Add(Me.txtRecherche)
        Me.panRecherhe.Location = New System.Drawing.Point(308, 59)
        Me.panRecherhe.Name = "panRecherhe"
        Me.panRecherhe.Size = New System.Drawing.Size(764, 133)
        Me.panRecherhe.TabIndex = 11
        '
        'btnRecherche
        '
        Me.btnRecherche.Location = New System.Drawing.Point(657, 14)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(97, 23)
        Me.btnRecherche.TabIndex = 3
        Me.btnRecherche.Text = "Recherche"
        Me.btnRecherche.UseVisualStyleBackColor = True
        '
        'cboBoxTrier
        '
        Me.cboBoxTrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBoxTrier.FormattingEnabled = True
        Me.cboBoxTrier.Location = New System.Drawing.Point(514, 14)
        Me.cboBoxTrier.Name = "cboBoxTrier"
        Me.cboBoxTrier.Size = New System.Drawing.Size(121, 21)
        Me.cboBoxTrier.TabIndex = 2
        '
        'lblTrier
        '
        Me.lblTrier.AutoSize = True
        Me.lblTrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTrier.Location = New System.Drawing.Point(433, 15)
        Me.lblTrier.Name = "lblTrier"
        Me.lblTrier.Size = New System.Drawing.Size(75, 20)
        Me.lblTrier.TabIndex = 1
        Me.lblTrier.Text = "Trier par :"
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(13, 15)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(400, 20)
        Me.txtRecherche.TabIndex = 0
        '
        'shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1084, 761)
        Me.Controls.Add(Me.panRecherhe)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.TabLayGameDescription)
        Me.Controls.Add(Me.pnlNav)
        Me.Name = "shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magasin"
        Me.pnlNav.ResumeLayout(False)
        Me.TabLayGameDescription.ResumeLayout(False)
        Me.TabLayGameDescription.PerformLayout()
        Me.panRecherhe.ResumeLayout(False)
        Me.panRecherhe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNav As FlowLayoutPanel
    Friend WithEvents btnShop As Button
    Friend WithEvents btnLibrary As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnInscription As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TabLayGameDescription As TableLayoutPanel
    Friend WithEvents LabDescri As Label
    Friend WithEvents ListBoxDescription As ListBox
    Friend WithEvents pnlGame As FlowLayoutPanel
    Friend WithEvents panRecherhe As Panel
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents lblTrier As Label
    Friend WithEvents cboBoxTrier As ComboBox
    Friend WithEvents btnRecherche As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Account
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
        Me.pnlNav.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlNav
        '
        Me.pnlNav.Controls.Add(Me.btnShop)
        Me.pnlNav.Controls.Add(Me.btnLibrary)
        Me.pnlNav.Controls.Add(Me.btnAccount)
        Me.pnlNav.Controls.Add(Me.btnInscription)
        Me.pnlNav.Controls.Add(Me.btnExit)
        Me.pnlNav.Location = New System.Drawing.Point(25, 12)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(1040, 40)
        Me.pnlNav.TabIndex = 1
        '
        'btnShop
        '
        Me.btnShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnShop.Location = New System.Drawing.Point(3, 3)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(202, 34)
        Me.btnShop.TabIndex = 2
        Me.btnShop.Text = "Magasin"
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'btnLibrary
        '
        Me.btnLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLibrary.Location = New System.Drawing.Point(211, 3)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(202, 34)
        Me.btnLibrary.TabIndex = 1
        Me.btnLibrary.Text = "Bibliothèque"
        Me.btnLibrary.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAccount.Location = New System.Drawing.Point(419, 3)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(202, 34)
        Me.btnAccount.TabIndex = 0
        Me.btnAccount.Text = "Compte"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnInscription
        '
        Me.btnInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnInscription.Location = New System.Drawing.Point(627, 3)
        Me.btnInscription.Name = "btnInscription"
        Me.btnInscription.Size = New System.Drawing.Size(202, 34)
        Me.btnInscription.TabIndex = 3
        Me.btnInscription.Text = "Inscription/Connexion"
        Me.btnInscription.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(835, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(202, 34)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Quitter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 761)
        Me.Controls.Add(Me.pnlNav)
        Me.Name = "Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        Me.pnlNav.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNav As FlowLayoutPanel
    Friend WithEvents btnShop As Button
    Friend WithEvents btnLibrary As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnInscription As Button
    Friend WithEvents btnExit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connexion))
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.btnAnnulerConnexion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgBox
        '
        Me.imgBox.BackColor = System.Drawing.Color.DarkRed
        Me.imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgBox.InitialImage = CType(resources.GetObject("imgBox.InitialImage"), System.Drawing.Image)
        Me.imgBox.Location = New System.Drawing.Point(266, 25)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(550, 150)
        Me.imgBox.TabIndex = 6
        Me.imgBox.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnConnexion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAnnulerConnexion)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(541, 402)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(275, 46)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnConnexion
        '
        Me.btnConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConnexion.Location = New System.Drawing.Point(3, 3)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(130, 40)
        Me.btnConnexion.TabIndex = 0
        Me.btnConnexion.Text = "Connexion"
        Me.btnConnexion.UseVisualStyleBackColor = True
        '
        'btnAnnulerConnexion
        '
        Me.btnAnnulerConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulerConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAnnulerConnexion.Location = New System.Drawing.Point(139, 3)
        Me.btnAnnulerConnexion.Name = "btnAnnulerConnexion"
        Me.btnAnnulerConnexion.Size = New System.Drawing.Size(130, 40)
        Me.btnAnnulerConnexion.TabIndex = 1
        Me.btnAnnulerConnexion.Text = "Annuler"
        Me.btnAnnulerConnexion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.lblMdp)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblLog)
        Me.Panel1.Location = New System.Drawing.Point(266, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 106)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(364, 20)
        Me.TextBox3.TabIndex = 5
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMdp.Location = New System.Drawing.Point(16, 66)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(113, 20)
        Me.lblMdp.TabIndex = 4
        Me.lblMdp.Text = "Mot de passe :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.BackColor = System.Drawing.Color.DarkRed
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLog.Location = New System.Drawing.Point(16, 19)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(56, 20)
        Me.lblLog.TabIndex = 0
        Me.lblLog.Text = "Login :"
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1084, 761)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgBox)
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgBox As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnConnexion As Button
    Friend WithEvents btnAnnulerConnexion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblMdp As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblLog As Label
End Class

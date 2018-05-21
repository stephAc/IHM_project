<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEnvoyer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkCompte = New System.Windows.Forms.LinkLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.picBoxFond = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxFond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(69, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 323)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inscription"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEnvoyer)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAnnuler)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(643, 254)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(275, 46)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnEnvoyer
        '
        Me.btnEnvoyer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEnvoyer.Location = New System.Drawing.Point(3, 3)
        Me.btnEnvoyer.Name = "btnEnvoyer"
        Me.btnEnvoyer.Size = New System.Drawing.Size(130, 40)
        Me.btnEnvoyer.TabIndex = 0
        Me.btnEnvoyer.Text = "Envoyer"
        Me.btnEnvoyer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAnnuler.Location = New System.Drawing.Point(139, 3)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(130, 40)
        Me.btnAnnuler.TabIndex = 1
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.linkCompte)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.lblMdp)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblLog)
        Me.Panel1.Location = New System.Drawing.Point(24, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 278)
        Me.Panel1.TabIndex = 0
        '
        'linkCompte
        '
        Me.linkCompte.AutoSize = True
        Me.linkCompte.LinkColor = System.Drawing.Color.White
        Me.linkCompte.Location = New System.Drawing.Point(17, 234)
        Me.linkCompte.Name = "linkCompte"
        Me.linkCompte.Size = New System.Drawing.Size(234, 20)
        Me.linkCompte.TabIndex = 6
        Me.linkCompte.TabStop = True
        Me.linkCompte.Text = "Avez-vous déjà un compte ?"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(17, 175)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(500, 26)
        Me.TextBox3.TabIndex = 5
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdp.Location = New System.Drawing.Point(13, 152)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(113, 20)
        Me.lblMdp.TabIndex = 4
        Me.lblMdp.Text = "Mot de passe :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(500, 26)
        Me.TextBox2.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(13, 86)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(500, 26)
        Me.TextBox1.TabIndex = 1
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.Location = New System.Drawing.Point(13, 13)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(56, 20)
        Me.lblLog.TabIndex = 0
        Me.lblLog.Text = "Login :"
        '
        'imgBox
        '
        Me.imgBox.BackColor = System.Drawing.Color.DimGray
        Me.imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgBox.InitialImage = CType(resources.GetObject("imgBox.InitialImage"), System.Drawing.Image)
        Me.imgBox.Location = New System.Drawing.Point(69, 46)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(550, 150)
        Me.imgBox.TabIndex = 5
        Me.imgBox.TabStop = False
        '
        'picBoxFond
        '
        Me.picBoxFond.Image = Global.IHM_ACHARI_VALENTIN_project.My.Resources.Resources.login_zoro
        Me.picBoxFond.Location = New System.Drawing.Point(2, 1)
        Me.picBoxFond.Name = "picBoxFond"
        Me.picBoxFond.Size = New System.Drawing.Size(1080, 759)
        Me.picBoxFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBoxFond.TabIndex = 6
        Me.picBoxFond.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 761)
        Me.Controls.Add(Me.imgBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picBoxFond)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxFond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblLog As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblMdp As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents linkCompte As LinkLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnEnvoyer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents imgBox As PictureBox
    Friend WithEvents picBoxFond As PictureBox
End Class

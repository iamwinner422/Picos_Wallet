<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connexion))
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.boxPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(107, 240)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(86, 31)
        Me.btnEffacer.TabIndex = 17
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mot de passe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'boxUser
        '
        Me.boxUser.BackColor = System.Drawing.Color.White
        Me.boxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxUser.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxUser.ForeColor = System.Drawing.Color.Black
        Me.boxUser.Location = New System.Drawing.Point(59, 110)
        Me.boxUser.Name = "boxUser"
        Me.boxUser.Size = New System.Drawing.Size(260, 18)
        Me.boxUser.TabIndex = 11
        Me.boxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "VEUILLEZ VOUS CONNECTEZ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(59, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 2)
        Me.Panel3.TabIndex = 18
        '
        'boxPassword
        '
        Me.boxPassword.BackColor = System.Drawing.Color.White
        Me.boxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPassword.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxPassword.ForeColor = System.Drawing.Color.Black
        Me.boxPassword.Location = New System.Drawing.Point(59, 189)
        Me.boxPassword.Name = "boxPassword"
        Me.boxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.boxPassword.Size = New System.Drawing.Size(260, 18)
        Me.boxPassword.TabIndex = 13
        Me.boxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPassword.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(59, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 2)
        Me.Panel1.TabIndex = 14
        '
        'boxNum
        '
        Me.boxNum.Location = New System.Drawing.Point(219, 282)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(100, 20)
        Me.boxNum.TabIndex = 19
        Me.boxNum.Visible = False
        '
        'btnConnexion
        '
        Me.btnConnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnexion.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnConnexion.ForeColor = System.Drawing.Color.White
        Me.btnConnexion.Image = Global.Picos_Wallet.My.Resources.Resources.login_17px
        Me.btnConnexion.Location = New System.Drawing.Point(209, 240)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(110, 31)
        Me.btnConnexion.TabIndex = 16
        Me.btnConnexion.Text = "Se connecter"
        Me.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnConnexion.UseVisualStyleBackColor = False
        '
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(378, 314)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.boxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxUser)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 353)
        Me.Name = "connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnConnexion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents boxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
End Class

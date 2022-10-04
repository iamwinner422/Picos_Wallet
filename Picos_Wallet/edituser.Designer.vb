<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edituser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edituser))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Mot de passe"
        '
        'boxPass
        '
        Me.boxPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.boxPass.Location = New System.Drawing.Point(26, 190)
        Me.boxPass.Name = "boxPass"
        Me.boxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.boxPass.Size = New System.Drawing.Size(281, 22)
        Me.boxPass.TabIndex = 32
        Me.boxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'boxLogin
        '
        Me.boxLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.boxLogin.Location = New System.Drawing.Point(26, 126)
        Me.boxLogin.Name = "boxLogin"
        Me.boxLogin.Size = New System.Drawing.Size(281, 22)
        Me.boxLogin.TabIndex = 30
        Me.boxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 19.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "EDITION DU COMPTE"
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Light", 8.75!)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnDelete.Image = Global.Picos_Wallet.My.Resources.Resources.trash_15px
        Me.btnDelete.Location = New System.Drawing.Point(169, 64)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(138, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Supprimer le compte"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(113, 245)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(89, 31)
        Me.btnEffacer.TabIndex = 35
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Image = Global.Picos_Wallet.My.Resources.Resources.ok_17px
        Me.btnAjouter.Location = New System.Drawing.Point(220, 245)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(87, 31)
        Me.btnAjouter.TabIndex = 34
        Me.btnAjouter.Text = "Modifier"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'edituser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 303)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxLogin)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(349, 342)
        Me.MinimumSize = New System.Drawing.Size(349, 342)
        Me.Name = "edituser"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edition du compte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class

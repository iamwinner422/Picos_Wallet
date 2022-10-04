<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newPtf
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newPtf))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxNom = New System.Windows.Forms.TextBox()
        Me.listeDevise = New System.Windows.Forms.ComboBox()
        Me.DevisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Devises = New Picos_Wallet.devises()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.DevisesTableAdapter = New Picos_Wallet.devisesTableAdapters.devisesTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Devises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NOUVEAU PORTEFEUILLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Devise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nom "
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNom.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxNom.ForeColor = System.Drawing.Color.Black
        Me.boxNom.Location = New System.Drawing.Point(42, 111)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(281, 22)
        Me.boxNom.TabIndex = 24
        Me.boxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listeDevise
        '
        Me.listeDevise.BackColor = System.Drawing.Color.WhiteSmoke
        Me.listeDevise.DataSource = Me.DevisesBindingSource
        Me.listeDevise.DisplayMember = "code_dvs"
        Me.listeDevise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listeDevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listeDevise.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.listeDevise.Location = New System.Drawing.Point(41, 179)
        Me.listeDevise.Name = "listeDevise"
        Me.listeDevise.Size = New System.Drawing.Size(282, 23)
        Me.listeDevise.TabIndex = 28
        Me.listeDevise.ValueMember = "code_dvs"
        '
        'DevisesBindingSource
        '
        Me.DevisesBindingSource.DataMember = "devises"
        Me.DevisesBindingSource.DataSource = Me.Devises
        '
        'Devises
        '
        Me.Devises.DataSetName = "devises"
        Me.Devises.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEffacer
        '
        Me.btnEffacer.BackColor = System.Drawing.Color.Transparent
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(140, 303)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(78, 31)
        Me.btnEffacer.TabIndex = 30
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEffacer.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Image = Global.Picos_Wallet.My.Resources.Resources.ok_17px
        Me.btnAjouter.Location = New System.Drawing.Point(236, 303)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(87, 31)
        Me.btnAjouter.TabIndex = 29
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'DevisesTableAdapter
        '
        Me.DevisesTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Date de fin"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(42, 246)
        Me.DateTimePicker1.MinDate = New Date(2020, 8, 30, 15, 42, 25, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(281, 25)
        Me.DateTimePicker1.TabIndex = 42
        Me.DateTimePicker1.Value = New Date(2020, 8, 31, 0, 0, 0, 0)
        '
        'newPtf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(360, 362)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.listeDevise)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxNom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 401)
        Me.MinimumSize = New System.Drawing.Size(376, 401)
        Me.Name = "newPtf"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau Portefeuille"
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Devises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxNom As System.Windows.Forms.TextBox
    Friend WithEvents listeDevise As System.Windows.Forms.ComboBox
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Devises As Picos_Wallet.devises
    Friend WithEvents DevisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevisesTableAdapter As Picos_Wallet.devisesTableAdapters.devisesTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class

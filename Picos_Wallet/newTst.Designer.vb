<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newTst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newTst))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listeCat = New System.Windows.Forms.ComboBox()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Categories = New Picos_Wallet.categories()
        Me.listeLib = New System.Windows.Forms.ComboBox()
        Me.TypetransacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Libelle = New Picos_Wallet.libelle()
        Me.boxMontant = New System.Windows.Forms.TextBox()
        Me.boxComment = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoriesTableAdapter = New Picos_Wallet.categoriesTableAdapters.categoriesTableAdapter()
        Me.Type_transacTableAdapter = New Picos_Wallet.libelleTableAdapters.type_transacTableAdapter()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypetransacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Libelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 19.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 36)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "AJOUTER UNE TRANSACTION"
        '
        'listeCat
        '
        Me.listeCat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.listeCat.DataSource = Me.CategoriesBindingSource
        Me.listeCat.DisplayMember = "nom_cat"
        Me.listeCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listeCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listeCat.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.listeCat.Location = New System.Drawing.Point(21, 97)
        Me.listeCat.Name = "listeCat"
        Me.listeCat.Size = New System.Drawing.Size(262, 23)
        Me.listeCat.TabIndex = 29
        Me.listeCat.ValueMember = "nom_cat"
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "categories"
        Me.CategoriesBindingSource.DataSource = Me.Categories
        '
        'Categories
        '
        Me.Categories.DataSetName = "categories"
        Me.Categories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listeLib
        '
        Me.listeLib.BackColor = System.Drawing.Color.WhiteSmoke
        Me.listeLib.DataSource = Me.TypetransacBindingSource
        Me.listeLib.DisplayMember = "libelle_type"
        Me.listeLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listeLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listeLib.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.listeLib.Location = New System.Drawing.Point(21, 166)
        Me.listeLib.Name = "listeLib"
        Me.listeLib.Size = New System.Drawing.Size(262, 23)
        Me.listeLib.TabIndex = 30
        Me.listeLib.ValueMember = "libelle_type"
        '
        'TypetransacBindingSource
        '
        Me.TypetransacBindingSource.DataMember = "type_transac"
        Me.TypetransacBindingSource.DataSource = Me.Libelle
        '
        'Libelle
        '
        Me.Libelle.DataSetName = "libelle"
        Me.Libelle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'boxMontant
        '
        Me.boxMontant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxMontant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxMontant.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.boxMontant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.boxMontant.Location = New System.Drawing.Point(21, 243)
        Me.boxMontant.Name = "boxMontant"
        Me.boxMontant.Size = New System.Drawing.Size(262, 22)
        Me.boxMontant.TabIndex = 31
        '
        'boxComment
        '
        Me.boxComment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxComment.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.boxComment.ForeColor = System.Drawing.Color.Black
        Me.boxComment.Location = New System.Drawing.Point(324, 166)
        Me.boxComment.Multiline = True
        Me.boxComment.Name = "boxComment"
        Me.boxComment.Size = New System.Drawing.Size(262, 99)
        Me.boxComment.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(324, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(262, 22)
        Me.DateTimePicker1.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(320, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Commentaire"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(320, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Date & Heure"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Montant"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Catégorie"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Libellé"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'Type_transacTableAdapter
        '
        Me.Type_transacTableAdapter.ClearBeforeFill = True
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(127, 291)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(87, 31)
        Me.btnEffacer.TabIndex = 42
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.btnAjouter.Location = New System.Drawing.Point(21, 291)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(87, 31)
        Me.btnAjouter.TabIndex = 41
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'newTst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(611, 345)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.boxComment)
        Me.Controls.Add(Me.boxMontant)
        Me.Controls.Add(Me.listeLib)
        Me.Controls.Add(Me.listeCat)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(627, 384)
        Me.Name = "newTst"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter une transation"
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypetransacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Libelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listeCat As System.Windows.Forms.ComboBox
    Friend WithEvents listeLib As System.Windows.Forms.ComboBox
    Friend WithEvents boxMontant As System.Windows.Forms.TextBox
    Friend WithEvents boxComment As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Categories As Picos_Wallet.categories
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As Picos_Wallet.categoriesTableAdapters.categoriesTableAdapter
    Friend WithEvents Libelle As Picos_Wallet.libelle
    Friend WithEvents TypetransacBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_transacTableAdapter As Picos_Wallet.libelleTableAdapters.type_transacTableAdapter
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
End Class

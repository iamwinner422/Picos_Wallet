<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listeLib
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listeLib))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibelletypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypetransacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Libelles = New Picos_Wallet.libelles()
        Me.Type_transacTableAdapter = New Picos_Wallet.libellesTableAdapters.type_transacTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxLib = New System.Windows.Forms.TextBox()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.boxCat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypetransacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Libelles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "LIBELLES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumtypeDataGridViewTextBoxColumn, Me.LibelletypeDataGridViewTextBoxColumn, Me.NumcatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TypetransacBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(496, 173)
        Me.DataGridView1.TabIndex = 13
        '
        'NumtypeDataGridViewTextBoxColumn
        '
        Me.NumtypeDataGridViewTextBoxColumn.DataPropertyName = "num_type"
        Me.NumtypeDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumtypeDataGridViewTextBoxColumn.Name = "NumtypeDataGridViewTextBoxColumn"
        '
        'LibelletypeDataGridViewTextBoxColumn
        '
        Me.LibelletypeDataGridViewTextBoxColumn.DataPropertyName = "libelle_type"
        Me.LibelletypeDataGridViewTextBoxColumn.HeaderText = "Libellés"
        Me.LibelletypeDataGridViewTextBoxColumn.Name = "LibelletypeDataGridViewTextBoxColumn"
        Me.LibelletypeDataGridViewTextBoxColumn.Width = 250
        '
        'NumcatDataGridViewTextBoxColumn
        '
        Me.NumcatDataGridViewTextBoxColumn.DataPropertyName = "num_cat"
        Me.NumcatDataGridViewTextBoxColumn.HeaderText = "Numéro de la catégorie"
        Me.NumcatDataGridViewTextBoxColumn.Name = "NumcatDataGridViewTextBoxColumn"
        '
        'TypetransacBindingSource
        '
        Me.TypetransacBindingSource.DataMember = "type_transac"
        Me.TypetransacBindingSource.DataSource = Me.Libelles
        '
        'Libelles
        '
        Me.Libelles.DataSetName = "libelles"
        Me.Libelles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Type_transacTableAdapter
        '
        Me.Type_transacTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(230, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Rechercher"
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.boxSearch.Location = New System.Drawing.Point(227, 51)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(281, 22)
        Me.boxSearch.TabIndex = 42
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Libellé"
        '
        'boxLib
        '
        Me.boxLib.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxLib.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxLib.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxLib.ForeColor = System.Drawing.Color.Black
        Me.boxLib.Location = New System.Drawing.Point(12, 281)
        Me.boxLib.Name = "boxLib"
        Me.boxLib.Size = New System.Drawing.Size(281, 22)
        Me.boxLib.TabIndex = 44
        '
        'btnEffacer
        '
        Me.btnEffacer.BackColor = System.Drawing.Color.Transparent
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(114, 309)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(101, 31)
        Me.btnEffacer.TabIndex = 47
        Me.btnEffacer.Text = "Supprimer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.btnAjouter.Location = New System.Drawing.Point(12, 308)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(96, 31)
        Me.btnAjouter.TabIndex = 46
        Me.btnAjouter.Text = "Modifier"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'boxCat
        '
        Me.boxCat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxCat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxCat.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxCat.ForeColor = System.Drawing.Color.Black
        Me.boxCat.Location = New System.Drawing.Point(318, 281)
        Me.boxCat.MaxLength = 1
        Me.boxCat.Name = "boxCat"
        Me.boxCat.Size = New System.Drawing.Size(190, 22)
        Me.boxCat.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(314, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Numéro de la catégorie"
        '
        'listeLib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(520, 351)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxCat)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(536, 390)
        Me.Name = "listeLib"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libellés"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypetransacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Libelles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Libelles As Picos_Wallet.libelles
    Friend WithEvents TypetransacBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_transacTableAdapter As Picos_Wallet.libellesTableAdapters.type_transacTableAdapter
    Friend WithEvents NumtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelletypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumcatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxLib As System.Windows.Forms.TextBox
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents boxCat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

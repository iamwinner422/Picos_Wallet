<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listDvs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listDvs))
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumdvsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodedvsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.button = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DevisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dvs = New Picos_Wallet.Dvs()
        Me.DevisesTableAdapter = New Picos_Wallet.DvsTableAdapters.devisesTableAdapter()
        Me.boxDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dvs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEffacer
        '
        Me.btnEffacer.BackColor = System.Drawing.Color.Transparent
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEffacer.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(451, 332)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(101, 36)
        Me.btnEffacer.TabIndex = 54
        Me.btnEffacer.Text = "Effacer"
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
        Me.btnAjouter.Location = New System.Drawing.Point(344, 332)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(101, 36)
        Me.btnAjouter.TabIndex = 53
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-55, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Libellé"
        '
        'boxCode
        '
        Me.boxCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxCode.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxCode.ForeColor = System.Drawing.Color.Black
        Me.boxCode.Location = New System.Drawing.Point(12, 304)
        Me.boxCode.MaxLength = 3
        Me.boxCode.Name = "boxCode"
        Me.boxCode.Size = New System.Drawing.Size(202, 22)
        Me.boxCode.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(226, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Rechercher"
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.boxSearch.Location = New System.Drawing.Point(224, 71)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(328, 22)
        Me.boxSearch.TabIndex = 49
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 37)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "DEVISES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumdvsDataGridViewTextBoxColumn, Me.CodedvsDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.button})
        Me.DataGridView1.DataSource = Me.DevisesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 173)
        Me.DataGridView1.TabIndex = 55
        '
        'NumdvsDataGridViewTextBoxColumn
        '
        Me.NumdvsDataGridViewTextBoxColumn.DataPropertyName = "num_dvs"
        Me.NumdvsDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumdvsDataGridViewTextBoxColumn.Name = "NumdvsDataGridViewTextBoxColumn"
        Me.NumdvsDataGridViewTextBoxColumn.Width = 65
        '
        'CodedvsDataGridViewTextBoxColumn
        '
        Me.CodedvsDataGridViewTextBoxColumn.DataPropertyName = "code_dvs"
        Me.CodedvsDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodedvsDataGridViewTextBoxColumn.Name = "CodedvsDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 240
        '
        'button
        '
        Me.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button.HeaderText = "Modifier"
        Me.button.Name = "button"
        Me.button.Text = "Modifier"
        Me.button.UseColumnTextForButtonValue = True
        '
        'DevisesBindingSource
        '
        Me.DevisesBindingSource.DataMember = "devises"
        Me.DevisesBindingSource.DataSource = Me.Dvs
        '
        'Dvs
        '
        Me.Dvs.DataSetName = "Dvs"
        Me.Dvs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevisesTableAdapter
        '
        Me.DevisesTableAdapter.ClearBeforeFill = True
        '
        'boxDesc
        '
        Me.boxDesc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxDesc.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxDesc.ForeColor = System.Drawing.Color.Black
        Me.boxDesc.Location = New System.Drawing.Point(229, 304)
        Me.boxDesc.Name = "boxDesc"
        Me.boxDesc.Size = New System.Drawing.Size(323, 22)
        Me.boxDesc.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(225, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Description"
        '
        'listDvs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(561, 380)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxDesc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(577, 419)
        Me.MinimumSize = New System.Drawing.Size(577, 419)
        Me.Name = "listDvs"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devises"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dvs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Dvs As Picos_Wallet.Dvs
    Friend WithEvents DevisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevisesTableAdapter As Picos_Wallet.DvsTableAdapters.devisesTableAdapter
    Friend WithEvents boxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumdvsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodedvsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents button As System.Windows.Forms.DataGridViewButtonColumn
End Class

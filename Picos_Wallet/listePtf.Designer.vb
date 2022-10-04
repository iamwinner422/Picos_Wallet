<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listePtf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listePtf))
        Me.PortefeuillesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Portefeuilles = New Picos_Wallet.portefeuilles()
        Me.PortefeuillesTableAdapter = New Picos_Wallet.portefeuillesTableAdapters.portefeuillesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxNom = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Dvs = New Picos_Wallet.Dvs()
        Me.DvsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Picos_walletDataSet = New Picos_Wallet.picos_walletDataSet()
        Me.DevisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevisesTableAdapter = New Picos_Wallet.picos_walletDataSetTableAdapters.devisesTableAdapter()
        CType(Me.PortefeuillesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portefeuilles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dvs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picos_walletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PortefeuillesBindingSource
        '
        Me.PortefeuillesBindingSource.DataMember = "portefeuilles"
        Me.PortefeuillesBindingSource.DataSource = Me.Portefeuilles
        '
        'Portefeuilles
        '
        Me.Portefeuilles.DataSetName = "portefeuilles"
        Me.Portefeuilles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PortefeuillesTableAdapter
        '
        Me.PortefeuillesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(82, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "E D I T I O N "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Date de fin"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 241)
        Me.DateTimePicker1.MinDate = New Date(2020, 8, 30, 15, 42, 25, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(281, 25)
        Me.DateTimePicker1.TabIndex = 50
        Me.DateTimePicker1.Value = New Date(2020, 8, 31, 0, 0, 0, 0)
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Image = Global.Picos_Wallet.My.Resources.Resources.ok_17px
        Me.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjouter.Location = New System.Drawing.Point(24, 298)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(282, 45)
        Me.btnAjouter.TabIndex = 48
        Me.btnAjouter.Text = "Modifier"
        Me.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Devise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nom "
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNom.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.boxNom.ForeColor = System.Drawing.Color.Black
        Me.boxNom.Location = New System.Drawing.Point(27, 106)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(281, 22)
        Me.boxNom.TabIndex = 44
        Me.boxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.DataSource = Me.DevisesBindingSource
        Me.ComboBox1.DisplayMember = "code_dvs"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(27, 174)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(279, 23)
        Me.ComboBox1.TabIndex = 52
        Me.ComboBox1.ValueMember = "code_dvs"
        '
        'Dvs
        '
        Me.Dvs.DataSetName = "Dvs"
        Me.Dvs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DvsBindingSource
        '
        Me.DvsBindingSource.DataSource = Me.Dvs
        Me.DvsBindingSource.Position = 0
        '
        'Picos_walletDataSet
        '
        Me.Picos_walletDataSet.DataSetName = "picos_walletDataSet"
        Me.Picos_walletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevisesBindingSource
        '
        Me.DevisesBindingSource.DataMember = "devises"
        Me.DevisesBindingSource.DataSource = Me.Picos_walletDataSet
        '
        'DevisesTableAdapter
        '
        Me.DevisesTableAdapter.ClearBeforeFill = True
        '
        'listePtf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(331, 366)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxNom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(347, 405)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(347, 405)
        Me.Name = "listePtf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portefeuilles"
        CType(Me.PortefeuillesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portefeuilles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dvs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picos_walletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Portefeuilles As Picos_Wallet.portefeuilles
    Friend WithEvents PortefeuillesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PortefeuillesTableAdapter As Picos_Wallet.portefeuillesTableAdapters.portefeuillesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxNom As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Dvs As Picos_Wallet.Dvs
    Friend WithEvents DvsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Picos_walletDataSet As Picos_Wallet.picos_walletDataSet
    Friend WithEvents DevisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevisesTableAdapter As Picos_Wallet.picos_walletDataSetTableAdapters.devisesTableAdapter
End Class

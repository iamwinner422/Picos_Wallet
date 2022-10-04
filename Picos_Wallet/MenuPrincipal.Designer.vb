<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.barreMenu = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatégorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortefeuilleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortefeuillesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatégoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortefeuilleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DépensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToutesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PortefeuillesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Portefeuilles1 = New Picos_Wallet.portefeuilles1()
        Me.PortefeuillesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Portefeuilles = New Picos_Wallet.portefeuilles()
        Me.PortefeuillesTableAdapter = New Picos_Wallet.portefeuillesTableAdapters.portefeuillesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInfos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLib = New System.Windows.Forms.Button()
        Me.btnDvs = New System.Windows.Forms.Button()
        Me.btnPtf = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxHeure = New System.Windows.Forms.TextBox()
        Me.boxDate = New System.Windows.Forms.TextBox()
        Me.boxMontant = New System.Windows.Forms.TextBox()
        Me.boxComment = New System.Windows.Forms.TextBox()
        Me.boxCat = New System.Windows.Forms.TextBox()
        Me.boxLibelle = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NumtstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommenttstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontanttstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeuretstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumptfDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opération = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Transac = New Picos_Wallet.transac()
        Me.lblNomPtf = New System.Windows.Forms.Label()
        Me.lblDateHeure = New System.Windows.Forms.Label()
        Me.lblSolde = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pnlBarre = New System.Windows.Forms.Panel()
        Me.PortefeuillesTableAdapter1 = New Picos_Wallet.portefeuilles1TableAdapters.portefeuillesTableAdapter()
        Me.TransactionsTableAdapter = New Picos_Wallet.transacTableAdapters.transactionsTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnNew1 = New System.Windows.Forms.Button()
        Me.Picos_walletDataSet1 = New Picos_Wallet.picos_walletDataSet1()
        Me.PortefeuillesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PortefeuillesTableAdapter2 = New Picos_Wallet.picos_walletDataSet1TableAdapters.portefeuillesTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomptfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.devise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.solde_ptf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumuserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.barreMenu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortefeuillesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portefeuilles1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortefeuillesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Portefeuilles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picos_walletDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortefeuillesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barreMenu
        '
        Me.barreMenu.BackColor = System.Drawing.Color.Transparent
        Me.barreMenu.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.barreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.NouveauToolStripMenuItem, Me.ListeToolStripMenuItem, Me.PortefeuilleToolStripMenuItem1, Me.EtatToolStripMenuItem})
        Me.barreMenu.Location = New System.Drawing.Point(0, 0)
        Me.barreMenu.Name = "barreMenu"
        Me.barreMenu.Size = New System.Drawing.Size(974, 24)
        Me.barreMenu.TabIndex = 0
        Me.barreMenu.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem, Me.QuitterToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem1})
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AProposToolStripMenuItem.Text = "&Editer mon compte"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.QuitterToolStripMenuItem.Text = "&A Propos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'QuitterToolStripMenuItem1
        '
        Me.QuitterToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.QuitterToolStripMenuItem1.Name = "QuitterToolStripMenuItem1"
        Me.QuitterToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.QuitterToolStripMenuItem1.Text = "&Quitter"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviseToolStripMenuItem, Me.CatégorieToolStripMenuItem, Me.PortefeuilleToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.NouveauToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'DeviseToolStripMenuItem
        '
        Me.DeviseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DeviseToolStripMenuItem.Name = "DeviseToolStripMenuItem"
        Me.DeviseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeviseToolStripMenuItem.Text = "&Devise"
        '
        'CatégorieToolStripMenuItem
        '
        Me.CatégorieToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CatégorieToolStripMenuItem.Name = "CatégorieToolStripMenuItem"
        Me.CatégorieToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CatégorieToolStripMenuItem.Text = "&Catégorie"
        '
        'PortefeuilleToolStripMenuItem
        '
        Me.PortefeuilleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PortefeuilleToolStripMenuItem.Name = "PortefeuilleToolStripMenuItem"
        Me.PortefeuilleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PortefeuilleToolStripMenuItem.Text = "&Portefeuille"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TransactionsToolStripMenuItem.Text = "&Transaction"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortefeuillesToolStripMenuItem, Me.DeviseToolStripMenuItem1, Me.CatégoriesToolStripMenuItem})
        Me.ListeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ListeToolStripMenuItem.Text = "&Liste"
        '
        'PortefeuillesToolStripMenuItem
        '
        Me.PortefeuillesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PortefeuillesToolStripMenuItem.Name = "PortefeuillesToolStripMenuItem"
        Me.PortefeuillesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PortefeuillesToolStripMenuItem.Text = "&Portefeuilles"
        '
        'DeviseToolStripMenuItem1
        '
        Me.DeviseToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DeviseToolStripMenuItem1.Name = "DeviseToolStripMenuItem1"
        Me.DeviseToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.DeviseToolStripMenuItem1.Text = "&Devises"
        '
        'CatégoriesToolStripMenuItem
        '
        Me.CatégoriesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CatégoriesToolStripMenuItem.Name = "CatégoriesToolStripMenuItem"
        Me.CatégoriesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CatégoriesToolStripMenuItem.Text = "&Libellés"
        '
        'PortefeuilleToolStripMenuItem1
        '
        Me.PortefeuilleToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditerToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.PortefeuilleToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.PortefeuilleToolStripMenuItem1.Name = "PortefeuilleToolStripMenuItem1"
        Me.PortefeuilleToolStripMenuItem1.Size = New System.Drawing.Size(79, 20)
        Me.PortefeuilleToolStripMenuItem1.Text = "&Portefeuille"
        '
        'EditerToolStripMenuItem
        '
        Me.EditerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EditerToolStripMenuItem.Text = "&Editer"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SupprimerToolStripMenuItem.Text = "&Supprimer"
        '
        'EtatToolStripMenuItem
        '
        Me.EtatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RevenusToolStripMenuItem, Me.DépensesToolStripMenuItem, Me.ToutesToolStripMenuItem})
        Me.EtatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.EtatToolStripMenuItem.Name = "EtatToolStripMenuItem"
        Me.EtatToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.EtatToolStripMenuItem.Text = "&Etats"
        '
        'RevenusToolStripMenuItem
        '
        Me.RevenusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.RevenusToolStripMenuItem.Name = "RevenusToolStripMenuItem"
        Me.RevenusToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RevenusToolStripMenuItem.Text = "&Revenus"
        '
        'DépensesToolStripMenuItem
        '
        Me.DépensesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.DépensesToolStripMenuItem.Name = "DépensesToolStripMenuItem"
        Me.DépensesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DépensesToolStripMenuItem.Text = "&Dépenses"
        '
        'ToutesToolStripMenuItem
        '
        Me.ToutesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ToutesToolStripMenuItem.Name = "ToutesToolStripMenuItem"
        Me.ToutesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ToutesToolStripMenuItem.Text = "&Toutes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NomptfDataGridViewTextBoxColumn, Me.devise, Me.solde_ptf, Me.NumuserDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.Action})
        Me.DataGridView1.DataSource = Me.PortefeuillesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(223, 231)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(529, 172)
        Me.DataGridView1.TabIndex = 13
        Me.DataGridView1.Visible = False
        '
        'PortefeuillesBindingSource1
        '
        Me.PortefeuillesBindingSource1.DataMember = "portefeuilles"
        Me.PortefeuillesBindingSource1.DataSource = Me.Portefeuilles1
        '
        'Portefeuilles1
        '
        Me.Portefeuilles1.DataSetName = "portefeuilles1"
        Me.Portefeuilles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label1.Location = New System.Drawing.Point(304, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PORTEFEUILLES DISPONIBLES"
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.Label12)
        Me.pnlMenu.Controls.Add(Me.lblInfos)
        Me.pnlMenu.Controls.Add(Me.Label9)
        Me.pnlMenu.Controls.Add(Me.btnLib)
        Me.pnlMenu.Controls.Add(Me.btnDvs)
        Me.pnlMenu.Controls.Add(Me.btnPtf)
        Me.pnlMenu.Controls.Add(Me.Label8)
        Me.pnlMenu.Controls.Add(Me.btnAjouter)
        Me.pnlMenu.Controls.Add(Me.Label7)
        Me.pnlMenu.Controls.Add(Me.btnModif)
        Me.pnlMenu.Controls.Add(Me.btnSupp)
        Me.pnlMenu.Controls.Add(Me.Label6)
        Me.pnlMenu.Controls.Add(Me.Label5)
        Me.pnlMenu.Controls.Add(Me.Label4)
        Me.pnlMenu.Controls.Add(Me.Label3)
        Me.pnlMenu.Controls.Add(Me.Label2)
        Me.pnlMenu.Controls.Add(Me.boxHeure)
        Me.pnlMenu.Controls.Add(Me.boxDate)
        Me.pnlMenu.Controls.Add(Me.boxMontant)
        Me.pnlMenu.Controls.Add(Me.boxComment)
        Me.pnlMenu.Controls.Add(Me.boxCat)
        Me.pnlMenu.Controls.Add(Me.boxLibelle)
        Me.pnlMenu.Controls.Add(Me.DataGridView2)
        Me.pnlMenu.Controls.Add(Me.lblNomPtf)
        Me.pnlMenu.Controls.Add(Me.lblDateHeure)
        Me.pnlMenu.Controls.Add(Me.lblSolde)
        Me.pnlMenu.Controls.Add(Me.lblUser)
        Me.pnlMenu.Controls.Add(Me.pnlBarre)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 24)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(974, 611)
        Me.pnlMenu.TabIndex = 45
        Me.pnlMenu.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(208, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(255, 21)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Cliquez sur Ajouter pour commencer"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'lblInfos
        '
        Me.lblInfos.AutoSize = True
        Me.lblInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInfos.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.lblInfos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblInfos.Location = New System.Drawing.Point(131, 255)
        Me.lblInfos.Name = "lblInfos"
        Me.lblInfos.Size = New System.Drawing.Size(408, 28)
        Me.lblInfos.TabIndex = 45
        Me.lblInfos.Text = "Aucune transaction disponible pour le moment."
        Me.lblInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfos.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(692, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 37)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "LISTE"
        '
        'btnLib
        '
        Me.btnLib.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLib.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnLib.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnLib.Image = Global.Picos_Wallet.My.Resources.Resources.tags_20px
        Me.btnLib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLib.Location = New System.Drawing.Point(692, 287)
        Me.btnLib.Name = "btnLib"
        Me.btnLib.Size = New System.Drawing.Size(274, 43)
        Me.btnLib.TabIndex = 43
        Me.btnLib.Text = "Libellés"
        Me.btnLib.UseVisualStyleBackColor = True
        '
        'btnDvs
        '
        Me.btnDvs.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDvs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDvs.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnDvs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnDvs.Image = Global.Picos_Wallet.My.Resources.Resources.us_dollar_20px
        Me.btnDvs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDvs.Location = New System.Drawing.Point(692, 240)
        Me.btnDvs.Name = "btnDvs"
        Me.btnDvs.Size = New System.Drawing.Size(274, 43)
        Me.btnDvs.TabIndex = 42
        Me.btnDvs.Text = "Devises"
        Me.btnDvs.UseVisualStyleBackColor = True
        '
        'btnPtf
        '
        Me.btnPtf.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPtf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPtf.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnPtf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnPtf.Image = Global.Picos_Wallet.My.Resources.Resources.wallet_20px
        Me.btnPtf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPtf.Location = New System.Drawing.Point(692, 334)
        Me.btnPtf.Name = "btnPtf"
        Me.btnPtf.Size = New System.Drawing.Size(274, 43)
        Me.btnPtf.TabIndex = 41
        Me.btnPtf.Text = "Portefeuilles"
        Me.btnPtf.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(494, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Heure"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.UseMnemonic = False
        Me.Label8.Visible = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Image = Global.Picos_Wallet.My.Resources.Resources.Wplus_20px
        Me.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjouter.Location = New System.Drawing.Point(593, 129)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(77, 31)
        Me.btnAjouter.TabIndex = 39
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 28)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "TRANSACTIONS"
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnModif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModif.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnModif.ForeColor = System.Drawing.Color.White
        Me.btnModif.Image = Global.Picos_Wallet.My.Resources.Resources.ok_17px
        Me.btnModif.Location = New System.Drawing.Point(356, 552)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(98, 31)
        Me.btnModif.TabIndex = 37
        Me.btnModif.Text = "Modifier"
        Me.btnModif.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModif.UseVisualStyleBackColor = False
        Me.btnModif.Visible = False
        '
        'btnSupp
        '
        Me.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupp.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnSupp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnSupp.Image = Global.Picos_Wallet.My.Resources.Resources.cancel_17px
        Me.btnSupp.Location = New System.Drawing.Point(460, 552)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(98, 31)
        Me.btnSupp.TabIndex = 36
        Me.btnSupp.Text = "Supprimer"
        Me.btnSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSupp.UseVisualStyleBackColor = True
        Me.btnSupp.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Commentaire"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(352, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Date "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.UseMnemonic = False
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Montant"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Libellé"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(352, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Catégorie"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'boxHeure
        '
        Me.boxHeure.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxHeure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxHeure.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxHeure.ForeColor = System.Drawing.Color.Black
        Me.boxHeure.Location = New System.Drawing.Point(498, 450)
        Me.boxHeure.Name = "boxHeure"
        Me.boxHeure.Size = New System.Drawing.Size(134, 20)
        Me.boxHeure.TabIndex = 30
        Me.boxHeure.Visible = False
        '
        'boxDate
        '
        Me.boxDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxDate.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxDate.ForeColor = System.Drawing.Color.Black
        Me.boxDate.Location = New System.Drawing.Point(356, 450)
        Me.boxDate.Name = "boxDate"
        Me.boxDate.Size = New System.Drawing.Size(134, 20)
        Me.boxDate.TabIndex = 29
        Me.boxDate.Visible = False
        '
        'boxMontant
        '
        Me.boxMontant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxMontant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxMontant.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxMontant.ForeColor = System.Drawing.Color.Black
        Me.boxMontant.Location = New System.Drawing.Point(27, 450)
        Me.boxMontant.Name = "boxMontant"
        Me.boxMontant.Size = New System.Drawing.Size(276, 20)
        Me.boxMontant.TabIndex = 28
        Me.boxMontant.Visible = False
        '
        'boxComment
        '
        Me.boxComment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxComment.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxComment.ForeColor = System.Drawing.Color.Black
        Me.boxComment.Location = New System.Drawing.Point(27, 511)
        Me.boxComment.Multiline = True
        Me.boxComment.Name = "boxComment"
        Me.boxComment.Size = New System.Drawing.Size(276, 72)
        Me.boxComment.TabIndex = 27
        Me.boxComment.Visible = False
        '
        'boxCat
        '
        Me.boxCat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxCat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxCat.Enabled = False
        Me.boxCat.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxCat.ForeColor = System.Drawing.Color.Black
        Me.boxCat.Location = New System.Drawing.Point(356, 393)
        Me.boxCat.Name = "boxCat"
        Me.boxCat.Size = New System.Drawing.Size(276, 20)
        Me.boxCat.TabIndex = 26
        Me.boxCat.Visible = False
        '
        'boxLibelle
        '
        Me.boxLibelle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxLibelle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxLibelle.Enabled = False
        Me.boxLibelle.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.boxLibelle.ForeColor = System.Drawing.Color.Black
        Me.boxLibelle.Location = New System.Drawing.Point(27, 393)
        Me.boxLibelle.Name = "boxLibelle"
        Me.boxLibelle.Size = New System.Drawing.Size(276, 20)
        Me.boxLibelle.TabIndex = 25
        Me.boxLibelle.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumtstDataGridViewTextBoxColumn, Me.CommenttstDataGridViewTextBoxColumn, Me.MontanttstDataGridViewTextBoxColumn, Me.HeuretstDataGridViewTextBoxColumn, Me.DatetstDataGridViewTextBoxColumn, Me.NumtypeDataGridViewTextBoxColumn, Me.NumptfDataGridViewTextBoxColumn1, Me.Opération})
        Me.DataGridView2.DataSource = Me.TransactionsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(9, 162)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(665, 201)
        Me.DataGridView2.TabIndex = 24
        '
        'NumtstDataGridViewTextBoxColumn
        '
        Me.NumtstDataGridViewTextBoxColumn.DataPropertyName = "num_tst"
        Me.NumtstDataGridViewTextBoxColumn.HeaderText = "Num."
        Me.NumtstDataGridViewTextBoxColumn.Name = "NumtstDataGridViewTextBoxColumn"
        Me.NumtstDataGridViewTextBoxColumn.Visible = False
        Me.NumtstDataGridViewTextBoxColumn.Width = 50
        '
        'CommenttstDataGridViewTextBoxColumn
        '
        Me.CommenttstDataGridViewTextBoxColumn.DataPropertyName = "comment_tst"
        Me.CommenttstDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.CommenttstDataGridViewTextBoxColumn.Name = "CommenttstDataGridViewTextBoxColumn"
        Me.CommenttstDataGridViewTextBoxColumn.Width = 220
        '
        'MontanttstDataGridViewTextBoxColumn
        '
        Me.MontanttstDataGridViewTextBoxColumn.DataPropertyName = "montant_tst"
        Me.MontanttstDataGridViewTextBoxColumn.HeaderText = "Montant"
        Me.MontanttstDataGridViewTextBoxColumn.Name = "MontanttstDataGridViewTextBoxColumn"
        '
        'HeuretstDataGridViewTextBoxColumn
        '
        Me.HeuretstDataGridViewTextBoxColumn.DataPropertyName = "heure_tst"
        Me.HeuretstDataGridViewTextBoxColumn.HeaderText = "Heure"
        Me.HeuretstDataGridViewTextBoxColumn.Name = "HeuretstDataGridViewTextBoxColumn"
        '
        'DatetstDataGridViewTextBoxColumn
        '
        Me.DatetstDataGridViewTextBoxColumn.DataPropertyName = "date_tst"
        Me.DatetstDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DatetstDataGridViewTextBoxColumn.Name = "DatetstDataGridViewTextBoxColumn"
        '
        'NumtypeDataGridViewTextBoxColumn
        '
        Me.NumtypeDataGridViewTextBoxColumn.DataPropertyName = "num_type"
        Me.NumtypeDataGridViewTextBoxColumn.HeaderText = "num_type"
        Me.NumtypeDataGridViewTextBoxColumn.Name = "NumtypeDataGridViewTextBoxColumn"
        Me.NumtypeDataGridViewTextBoxColumn.Visible = False
        '
        'NumptfDataGridViewTextBoxColumn1
        '
        Me.NumptfDataGridViewTextBoxColumn1.DataPropertyName = "num_ptf"
        Me.NumptfDataGridViewTextBoxColumn1.HeaderText = "num_ptf"
        Me.NumptfDataGridViewTextBoxColumn1.Name = "NumptfDataGridViewTextBoxColumn1"
        Me.NumptfDataGridViewTextBoxColumn1.Visible = False
        '
        'Opération
        '
        Me.Opération.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Opération.HeaderText = "Détails"
        Me.Opération.Name = "Opération"
        Me.Opération.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Opération.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Opération.Text = "Détails"
        Me.Opération.UseColumnTextForButtonValue = True
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "transactions"
        Me.TransactionsBindingSource.DataSource = Me.Transac
        '
        'Transac
        '
        Me.Transac.DataSetName = "transac"
        Me.Transac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNomPtf
        '
        Me.lblNomPtf.AutoSize = True
        Me.lblNomPtf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNomPtf.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.lblNomPtf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblNomPtf.Location = New System.Drawing.Point(21, 10)
        Me.lblNomPtf.Name = "lblNomPtf"
        Me.lblNomPtf.Size = New System.Drawing.Size(257, 37)
        Me.lblNomPtf.TabIndex = 23
        Me.lblNomPtf.Text = "NOM PORTEFEUILLE"
        '
        'lblDateHeure
        '
        Me.lblDateHeure.AutoSize = True
        Me.lblDateHeure.BackColor = System.Drawing.Color.Transparent
        Me.lblDateHeure.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.lblDateHeure.ForeColor = System.Drawing.Color.Black
        Me.lblDateHeure.Location = New System.Drawing.Point(903, 10)
        Me.lblDateHeure.Name = "lblDateHeure"
        Me.lblDateHeure.Size = New System.Drawing.Size(63, 13)
        Me.lblDateHeure.TabIndex = 22
        Me.lblDateHeure.Text = "00/00/0000"
        '
        'lblSolde
        '
        Me.lblSolde.AutoEllipsis = True
        Me.lblSolde.AutoSize = True
        Me.lblSolde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSolde.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblSolde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblSolde.Location = New System.Drawing.Point(22, 53)
        Me.lblSolde.Name = "lblSolde"
        Me.lblSolde.Size = New System.Drawing.Size(23, 28)
        Me.lblSolde.TabIndex = 4
        Me.lblSolde.Text = "0"
        Me.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblUser.Location = New System.Drawing.Point(23, 94)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(87, 25)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Utilisateur"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBarre
        '
        Me.pnlBarre.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnlBarre.Location = New System.Drawing.Point(684, 43)
        Me.pnlBarre.Name = "pnlBarre"
        Me.pnlBarre.Size = New System.Drawing.Size(2, 510)
        Me.pnlBarre.TabIndex = 0
        '
        'PortefeuillesTableAdapter1
        '
        Me.PortefeuillesTableAdapter1.ClearBeforeFill = True
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(473, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Rechercher"
        Me.Label10.Visible = False
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.boxSearch.Location = New System.Drawing.Point(470, 208)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(281, 18)
        Me.boxSearch.TabIndex = 47
        Me.boxSearch.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(899, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "00/00/0000"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnNew.Image = Global.Picos_Wallet.My.Resources.Resources.plus_32px
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.Location = New System.Drawing.Point(373, 279)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(229, 77)
        Me.btnNew.TabIndex = 44
        Me.btnNew.Text = "NOUVEAU PORTEFEUILLE"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Visible = False
        '
        'btnNew1
        '
        Me.btnNew1.BackColor = System.Drawing.Color.Transparent
        Me.btnNew1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnNew1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.btnNew1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnNew1.Image = Global.Picos_Wallet.My.Resources.Resources.plus_20px
        Me.btnNew1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew1.Location = New System.Drawing.Point(223, 408)
        Me.btnNew1.Name = "btnNew1"
        Me.btnNew1.Size = New System.Drawing.Size(147, 31)
        Me.btnNew1.TabIndex = 46
        Me.btnNew1.Text = "Nouveau portefeuille"
        Me.btnNew1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew1.UseVisualStyleBackColor = False
        Me.btnNew1.Visible = False
        '
        'Picos_walletDataSet1
        '
        Me.Picos_walletDataSet1.DataSetName = "picos_walletDataSet1"
        Me.Picos_walletDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PortefeuillesBindingSource2
        '
        Me.PortefeuillesBindingSource2.DataMember = "portefeuilles"
        Me.PortefeuillesBindingSource2.DataSource = Me.Picos_walletDataSet1
        '
        'PortefeuillesTableAdapter2
        '
        Me.PortefeuillesTableAdapter2.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_ptf"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'NomptfDataGridViewTextBoxColumn
        '
        Me.NomptfDataGridViewTextBoxColumn.DataPropertyName = "nom_ptf"
        Me.NomptfDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomptfDataGridViewTextBoxColumn.Name = "NomptfDataGridViewTextBoxColumn"
        Me.NomptfDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomptfDataGridViewTextBoxColumn.Width = 185
        '
        'devise
        '
        Me.devise.DataPropertyName = "devise"
        Me.devise.HeaderText = "Devise"
        Me.devise.Name = "devise"
        Me.devise.ReadOnly = True
        '
        'solde_ptf
        '
        Me.solde_ptf.DataPropertyName = "solde_ptf"
        Me.solde_ptf.HeaderText = "Solde"
        Me.solde_ptf.Name = "solde_ptf"
        Me.solde_ptf.ReadOnly = True
        '
        'NumuserDataGridViewTextBoxColumn
        '
        Me.NumuserDataGridViewTextBoxColumn.DataPropertyName = "num_user"
        Me.NumuserDataGridViewTextBoxColumn.HeaderText = "num_user"
        Me.NumuserDataGridViewTextBoxColumn.Name = "NumuserDataGridViewTextBoxColumn"
        Me.NumuserDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumuserDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date_fin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "date_fin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Action
        '
        Me.Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "Ouvrir"
        Me.Action.UseColumnTextForButtonValue = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(974, 635)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.barreMenu)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNew1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.barreMenu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(990, 674)
        Me.MinimumSize = New System.Drawing.Size(990, 674)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.barreMenu.ResumeLayout(False)
        Me.barreMenu.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortefeuillesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portefeuilles1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortefeuillesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Portefeuilles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picos_walletDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortefeuillesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Portefeuilles As Picos_Wallet.portefeuilles
    Friend WithEvents PortefeuillesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PortefeuillesTableAdapter As Picos_Wallet.portefeuillesTableAdapters.portefeuillesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlBarre As System.Windows.Forms.Panel
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Portefeuilles1 As Picos_Wallet.portefeuilles1
    Friend WithEvents PortefeuillesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PortefeuillesTableAdapter1 As Picos_Wallet.portefeuilles1TableAdapters.portefeuillesTableAdapter
    Friend WithEvents lblSolde As System.Windows.Forms.Label
    Friend WithEvents lblDateHeure As System.Windows.Forms.Label
    Friend WithEvents lblNomPtf As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents boxComment As System.Windows.Forms.TextBox
    Friend WithEvents boxCat As System.Windows.Forms.TextBox
    Friend WithEvents boxLibelle As System.Windows.Forms.TextBox
    Friend WithEvents boxMontant As System.Windows.Forms.TextBox
    Friend WithEvents Transac As Picos_Wallet.transac
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionsTableAdapter As Picos_Wallet.transacTableAdapters.transactionsTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxHeure As System.Windows.Forms.TextBox
    Friend WithEvents boxDate As System.Windows.Forms.TextBox
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnSupp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents NumtstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommenttstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontanttstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeuretstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatetstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumptfDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Opération As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DeviseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatégorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortefeuilleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortefeuillesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatégoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnPtf As System.Windows.Forms.Button
    Friend WithEvents btnLib As System.Windows.Forms.Button
    Friend WithEvents btnDvs As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnNew1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblInfos As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PortefeuilleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DépensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToutesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Picos_walletDataSet1 As Picos_Wallet.picos_walletDataSet1
    Friend WithEvents PortefeuillesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PortefeuillesTableAdapter2 As Picos_Wallet.picos_walletDataSet1TableAdapters.portefeuillesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomptfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents devise As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents solde_ptf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Action As System.Windows.Forms.DataGridViewButtonColumn
End Class

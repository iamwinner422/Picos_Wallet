Imports MySql.Data.MySqlClient
Public Class MenuPrincipal
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Public num_user = My.Forms.connexion.num_user
    Public nomUser As String = ""
    Public solde As Long
    Public Tdevise As String = ""
    Public num_ptf As String = ""
    Public nom_ptf As String = ""
    Public num_type_transac As Integer
    Public montant As Long
    Public commentaire As String = ""
    Public libelleT As String = ""
    Public num_cat As Integer
    Public nom_cat As String = ""
    Public dateJ As String = ""
    Public heure As String = ""
    Public num_tst As Integer
    Public date_fin As String = ""
    Public date_debut As String = ""
    Public laLigne As Integer
    Public pass_user As String = ""
    Public Enum CaractereType
        Guillemet
        RetourChariot
    End Enum

    Public Function ChangeCaratere(ByVal Valeur As Object, ByVal Caractere As CaractereType) As String

        Select Case Caractere
            Case CaractereType.Guillemet
                ChangeCaratere = Replace(Valeur, "'", "''")
            Case CaractereType.RetourChariot
                ChangeCaratere = Replace(Valeur, vbCrLf, "; ")
            Case Else
                ChangeCaratere = ""
        End Select
    End Function
    Private Sub MenuPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
    End Sub

    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Picos_walletDataSet1.portefeuilles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PortefeuillesTableAdapter2.Fill(Me.Picos_walletDataSet1.portefeuilles)
        'TODO: cette ligne de code charge les données dans la table 'Transac.transactions'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.TransactionsTableAdapter.Fill(Me.Transac.transactions)
        'TODO: cette ligne de code charge les données dans la table 'Transact.transactions'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.TransactionsTableAdapter.Fill(Me.Transact.transactions)
        'TODO: cette ligne de code charge les données dans la table 'Portefeuilles1.portefeuilles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.PortefeuillesTableAdapter1.Fill(Me.Portefeuilles1.portefeuilles)
        'TODO: cette ligne de code charge les données dans la table 'Portefeuilles._portefeuilles'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.PortefeuillesTableAdapter.Fill(Me.Portefeuilles._portefeuilles)
        lblSolde.Text = solde & " " & Tdevise



        lblDateHeure.Text = DateAndTime.Today
        Label11.Text = DateAndTime.Today
        If solde < 0 Then
            lblSolde.ForeColor = Color.Red
        ElseIf solde > 0 Then
            lblSolde.ForeColor = Color.Green
        End If
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adapatateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adapatateur.Fill(dataset, "portefeuilles")
            cmd.Dispose()
            If dataset.Tables("portefeuilles").Rows.Count > 0 Then
                DataGridView1.Visible = True
                DataGridView1.DataSource = dataset.Tables("portefeuilles")
                btnNew.Visible = False
                btnNew1.Visible = True
                Label10.Visible = True

                PortefeuilleToolStripMenuItem1.Visible = False
                EtatToolStripMenuItem.Visible = False

                boxSearch.Visible = True
                num_ptf = Val(dataset.Tables("portefeuilles").Rows(0).Item("num_ptf").ToString)
                'DATE FIN 
                date_fin = dataset.Tables("portefeuilles").Rows(0).Item("date_fin").ToString
                'DATE DEBUT
                date_debut = dataset.Tables("portefeuilles").Rows(0).Item("date_debut").ToString
                'DATE FIN
                Dim ndate_fin = CDate(date_fin)
                Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
                If letoday >= ndate_fin Then
                    lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
                    Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
                    lblInfos.Visible = True
                    Label12.Visible = True
                    DataGridView2.Visible = False
                    btnAjouter.Visible = False
                    TransactionsToolStripMenuItem.Visible = False
                    Label7.Visible = False
                End If
            Else
                btnNew.Visible = True
                PortefeuilleToolStripMenuItem1.Visible = False
                EtatToolStripMenuItem.Visible = False
            End If
            'SELECTION DES INFOS DE L'UTILISATEUR
            Dim reqUser As String = "SELECT * FROM `utilisateurs` WHERE `num_user` = " & num_user
            Dim commmande As New MySqlCommand(reqUser, connexion)
            commmande.ExecuteNonQuery()
            Dim lAdaptateur As New MySqlDataAdapter(commmande)
            Dim leDataset As New DataSet
            lAdaptateur.Fill(leDataset, "utilisateurs")
            commmande.Dispose()
            nomUser = leDataset.Tables("utilisateurs").Rows(0).Item("login_user").ToString
            pass_user = leDataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
            lblUser.Text = nomUser
            'transactions correspondant au portefeuille
            'Dim ligneSelectionnee = DataGridView1.Rows(laLigne)
            'num_ptf = Val(ligneSelectionnee.Cells(0).Value.ToString)
            If (num_ptf <> "") Then
                Dim reqOp As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_ptf
                Dim cmdOp As New MySqlCommand(reqOp, connexion)
                cmdOp.ExecuteNonQuery()
                Dim adaptateurOp As New MySqlDataAdapter(cmdOp)
                Dim datasetOp As New DataSet
                adaptateurOp.Fill(datasetOp, "transactions")
                If datasetOp.Tables("transactions").Rows.Count > 0 Then
                    DataGridView2.DataSource = datasetOp.Tables("transactions")
                Else
                    lblInfos.Visible = True
                    Label7.Visible = False
                    Label12.Visible = True
                    DataGridView2.Visible = False
                    EtatToolStripMenuItem.Visible = False

                End If
                cmdOp.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        newPtf.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim num_ligne As Integer
        num_ligne = e.RowIndex
        laLigne = e.RowIndex
        Dim ligneSelectionnee = DataGridView1.Rows(num_ligne)
        nom_ptf = ligneSelectionnee.Cells(1).Value.ToString
        Tdevise = ligneSelectionnee.Cells(2).Value.ToString
        solde = ligneSelectionnee.Cells(3).Value.ToString
        num_ptf = Val(ligneSelectionnee.Cells(0).Value.ToString)
        date_fin = ligneSelectionnee.Cells(5).Value.ToString
        lblNomPtf.Text = nom_ptf
        If solde < 0 Then
            lblSolde.ForeColor = Color.Red
        ElseIf solde > 0 Then
            lblSolde.ForeColor = Color.Green
        End If
        lblSolde.Text = solde & " " & Tdevise
        pnlMenu.Visible = True
        PortefeuilleToolStripMenuItem1.Text = nom_ptf
        PortefeuilleToolStripMenuItem1.Visible = True
        EtatToolStripMenuItem.Visible = True

        'DATE FIN

        Dim ndate_fin = CDate(date_fin)
        Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
        If letoday >= ndate_fin Then
            lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
            Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
            lblInfos.Visible = True
            Label12.Visible = True
            DataGridView2.Visible = False
            btnAjouter.Visible = False
            TransactionsToolStripMenuItem.Visible = False

        End If
        Try
            connexion.Open()
            'rafraîchissement de la table TRANSACTION
            If (num_ptf <> "") Then
                Dim reqOp As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_ptf
                Dim cmdOp As New MySqlCommand(reqOp, connexion)
                cmdOp.ExecuteNonQuery()
                Dim adaptateurOp As New MySqlDataAdapter(cmdOp)
                Dim datasetOp As New DataSet
                adaptateurOp.Fill(datasetOp, "transactions")
                If datasetOp.Tables("transactions").Rows.Count > 0 Then
                    DataGridView2.DataSource = datasetOp.Tables("transactions")
                Else
                    lblInfos.Visible = True
                    Label7.Visible = False
                    Label12.Visible = True
                    DataGridView2.Visible = False
                    EtatToolStripMenuItem.Visible = False
                End If
                cmdOp.Dispose()
            End If
        Catch ex As Exception

        End Try
        connexion.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If DataGridView2.RowCount = 0 Then

        Else
            Dim num_ligne As Integer
            num_ligne = e.RowIndex
            Dim ligneSelectionnee = DataGridView2.Rows(num_ligne)
            num_tst = Val(ligneSelectionnee.Cells(0).Value.ToString)
            montant = ligneSelectionnee.Cells(2).Value.ToString
            commentaire = ligneSelectionnee.Cells(1).Value.ToString
            dateJ = ligneSelectionnee.Cells(4).Value.ToString
            heure = ligneSelectionnee.Cells(3).Value.ToString
            num_type_transac = Val(ligneSelectionnee.Cells(5).Value.ToString) 'type transaction
            boxHeure.Text = heure
            boxDate.Text = dateJ
            boxMontant.Text = montant

            boxComment.Text = commentaire
            boxCat.Visible = True
            boxComment.Visible = True
            boxLibelle.Visible = True
            boxMontant.Visible = True
            boxHeure.Visible = True
            boxDate.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            btnModif.Visible = True
            btnSupp.Visible = True
            Try
                connexion.Open()
                Dim reqTrans As String = "SELECT `libelle_type`, `num_cat` FROM `type_transac` WHERE num_type = " & num_type_transac
                Dim cmd As New MySqlCommand(reqTrans, connexion)
                cmd.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmd)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "type_transac")
                libelleT = dataset.Tables("type_transac").Rows(0).Item("libelle_type").ToString
                boxLibelle.Text = libelleT
                num_cat = Val(dataset.Tables("type_transac").Rows(0).Item("num_cat").ToString)
                cmd.Dispose()
                Dim reqCat As String = "SELECT `nom_cat` FROM `categories` WHERE num_cat = " & num_cat
                Dim laCmd As New MySqlCommand(reqCat, connexion)
                laCmd.ExecuteNonQuery()
                Dim adaptateur1 As New MySqlDataAdapter(laCmd)
                Dim dataset1 As New DataSet
                adaptateur1.Fill(dataset1, "categories")
                nom_cat = dataset1.Tables("categories").Rows(0).Item("nom_cat").ToString
                boxCat.Text = nom_cat
                If nom_cat = "Revenus" Then
                    boxMontant.Text = montant
                    boxMontant.ForeColor = Color.Green
                ElseIf nom_cat = "Dépenses" Then
                    boxMontant.Text = montant
                    boxMontant.ForeColor = Color.Red
                End If
                laCmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        newTst.ShowDialog()
    End Sub

    Private Sub DeviseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviseToolStripMenuItem.Click
        newDevise.ShowDialog()
    End Sub

    Private Sub CatégorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatégorieToolStripMenuItem.Click
        newTypeTrans.ShowDialog()
    End Sub

    Private Sub PortefeuilleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortefeuilleToolStripMenuItem.Click
        newPtf.ShowDialog()
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.Click
        newTst.ShowDialog()
    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        If boxMontant.Text = "" Or boxComment.Text = "" Or boxHeure.Text = "" Or boxDate.Text = "" Then
            MsgBox("Erreur! Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(boxMontant.Text) Then
            MsgBox("Erreur! Le montant saisi n'est pas numérique.", MsgBoxStyle.Critical)
        ElseIf Not IsDate(boxDate.Text) Then
            MsgBox("Erreur! La date saisie n'est pas correcte.", MsgBoxStyle.Critical)
            'ElseIf boxHeure.Text <> DateFormat.ShortTime.ToString Then
            'MsgBox("Erreur! L'heure saisie n'est pas correcte.", MsgBoxStyle.Critical)
        Else
            commentaire = boxComment.Text
            heure = boxHeure.Text
            dateJ = boxDate.Text
            montant = Val(boxMontant.Text)
            Try
                connexion.Open()
                Dim rUpdate As String = "UPDATE `transactions` SET `comment_tst` = '" & ChangeCaratere(commentaire, CaractereType.Guillemet) & "', `montant_tst` = '" & montant & "', `heure_tst` = '" & heure & "', `date_tst` = '" & dateJ & "' WHERE `num_tst` = " & num_tst
                Dim cmd As New MySqlCommand(rUpdate, connexion)
                Dim vraie = cmd.ExecuteNonQuery
                If vraie Then
                    Dim rUpdate1 As String = ""
                    'MISE A JOUR DU SOLDE DU PORTEFEUILLE EN FONCTION DE LA CATEGORIE
                    If boxCat.Text = "Revenus" Then
                        rUpdate1 = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` + '" & montant & "' WHERE `num_ptf` = " & num_ptf
                    Else
                        rUpdate1 = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` - '" & montant & " 'WHERE `num_ptf` = " & num_ptf
                    End If
                    Dim laCmd As New MySqlCommand(rUpdate1, connexion)
                    laCmd.ExecuteNonQuery()
                    laCmd.Dispose()
                    MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                    cmd.Dispose()
                    boxCat.Text = ""
                    boxLibelle.Text = ""
                    boxComment.Text = ""
                    boxDate.Text = ""
                    boxHeure.Text = ""
                    boxMontant.Text = ""
                    'rafraîchissement de la table TRANSACTION
                    If (num_ptf <> "") Then
                        Dim reqOp As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_ptf
                        Dim cmdOp As New MySqlCommand(reqOp, connexion)
                        cmdOp.ExecuteNonQuery()
                        Dim adaptateurOp As New MySqlDataAdapter(cmdOp)
                        Dim datasetOp As New DataSet
                        adaptateurOp.Fill(datasetOp, "transactions")
                        If datasetOp.Tables("transactions").Rows.Count > 0 Then
                            DataGridView2.DataSource = datasetOp.Tables("transactions")
                        Else
                            lblInfos.Visible = True
                            Label7.Visible = False
                            Label12.Visible = True
                            DataGridView2.Visible = False
                            EtatToolStripMenuItem.Visible = False
                        End If
                        cmdOp.Dispose()
                    End If
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
            If solde < 0 Then
                lblSolde.ForeColor = Color.Red
            ElseIf solde > 0 Then
                lblSolde.ForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub btnSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupp.Click
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "DELETE FROM `transactions` WHERE `num_tst` = " & num_tst
            Dim Cmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = Cmd.ExecuteNonQuery
            If (vraie) Then
                Dim rUpdate1 As String = ""
                'MISE A JOUR DU SOLDE DU PORTEFEUILLE EN FONCTION DE LA CATEGORIE
                If boxCat.Text = "Revenus" Then
                    rUpdate1 = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` - '" & montant & "' WHERE `num_ptf` = " & num_ptf
                Else
                    rUpdate1 = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` + '" & montant & " 'WHERE `num_ptf` = " & num_ptf
                End If
                Dim laCmd As New MySqlCommand(rUpdate1, connexion)
                laCmd.ExecuteNonQuery()
                laCmd.Dispose()
                MsgBox("L'enrégistrement a été bien supprimer!", MsgBoxStyle.Information)
                Cmd.Dispose()
                boxCat.Text = ""
                boxLibelle.Text = ""
                boxComment.Text = ""
                boxDate.Text = ""
                boxHeure.Text = ""
                boxMontant.Text = ""
                'ACTUALISATION DU LABEL SOLDE
                Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
                Dim laCom As New MySqlCommand(rSelect, connexion)
                laCom.ExecuteNonQuery()
                Dim adapatateur As New MySqlDataAdapter(laCom)
                Dim dataset As New DataSet
                adapatateur.Fill(dataset, "portefeuilles")
                Dim solde = Val(dataset.Tables("portefeuilles").Rows(0).Item("solde_ptf").ToString)
                lblSolde.Text = solde & " " & Tdevise
                laCom.Dispose()
                'rafraîchissement de la table TRANSACTION
                Dim reqOp As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_ptf
                Dim cmdOp As New MySqlCommand(reqOp, connexion)
                cmdOp.ExecuteNonQuery()
                Dim adaptateurOp As New MySqlDataAdapter(cmdOp)
                Dim datasetOp As New DataSet
                adaptateurOp.Fill(datasetOp, "transactions")
                If datasetOp.Tables("transactions").Rows.Count > 0 Then
                    DataGridView2.DataSource = datasetOp.Tables("transactions")
                Else
                    lblInfos.Visible = True
                    Label7.Visible = False
                    Label12.Visible = True
                    EtatToolStripMenuItem.Visible = False
                    DataGridView2.Visible = False
                    MsgBox("Bienvenue cher utilisateur! Commencer par ajouter une trancation au portefeuille.", MsgBoxStyle.Information)
                End If
                cmdOp.Dispose()
            Else
                MsgBox("Erreur!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnPtf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPtf.Click
        pnlMenu.Visible = False
        DataGridView2.Visible = True
        PortefeuilleToolStripMenuItem1.Visible = False
        EtatToolStripMenuItem.Visible = False
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adapatateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adapatateur.Fill(dataset, "portefeuilles")
            cmd.Dispose()
            If dataset.Tables("portefeuilles").Rows.Count > 0 Then
                DataGridView1.Visible = True
                DataGridView1.DataSource = dataset.Tables("portefeuilles")
                btnNew.Visible = False
                btnNew1.Visible = True
                Label10.Visible = True
                PortefeuilleToolStripMenuItem1.Visible = False
                boxSearch.Visible = True
                num_ptf = Val(dataset.Tables("portefeuilles").Rows(0).Item("num_ptf").ToString)
                'DATE FIN 
                date_fin = dataset.Tables("portefeuilles").Rows(0).Item("date_fin").ToString

                'DATE FIN
                Dim ndate_fin = CDate(date_fin)
                Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
                If letoday >= ndate_fin Then
                    lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
                    Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
                    lblInfos.Visible = True
                    Label12.Visible = True
                    DataGridView2.Visible = False
                    btnAjouter.Visible = False
                    TransactionsToolStripMenuItem.Visible = False
                    Label7.Visible = False
                End If
            Else
                EtatToolStripMenuItem.Visible = False
                btnNew.Visible = True
            End If
        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnLib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLib.Click
        listeLib.ShowDialog()
    End Sub

    Private Sub boxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.TextChanged
        Dim recherche As String = boxSearch.Text
        Try
            connexion.Open()
            Dim laRequette = "SELECT * FROM `portefeuilles` WHERE(`nom_ptf` LIKE '%" & recherche & "%' OR `devise` LIKE '%" & recherche & "%');"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery()
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim dataSet As New DataSet
                adaptateur.Fill(dataSet, "portefeuilles")
                DataGridView1.DataSource = dataSet.Tables("portefeuilles")
                laCmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub boxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Click
        Label10.Visible = False
    End Sub

    Private Sub boxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Leave
        Label10.Visible = True
    End Sub

    Private Sub btnNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew1.Click
        newPtf.ShowDialog()
    End Sub

    Private Sub btnDvs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDvs.Click
        listDvs.ShowDialog()
    End Sub

    Private Sub CatégoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatégoriesToolStripMenuItem.Click
        listeLib.ShowDialog()
    End Sub

    Private Sub QuitterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem1.Click
        Form1.Close()
    End Sub

    Private Sub EditerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditerToolStripMenuItem.Click
        listePtf.Text = nom_ptf
        listePtf.boxNom.Text = nom_ptf
        listePtf.ComboBox1.SelectedValue = Tdevise
        listePtf.ShowDialog()

    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        Try
            connexion.Open()
            'SUPPRESSION DES TRANSACTION DU PORTEFEUILLES
            Dim rqute As String = "DELETE FROM `transactions` WHERE `num_ptf` = " & num_ptf
            Dim com As New MySqlCommand(rqute, connexion)
            Dim vraie = com.ExecuteNonQuery
            If vraie Then
                rqute = "DELETE FROM `portefeuilles` WHERE `num_ptf` = " & num_ptf
                Dim cmd As New MySqlCommand(rqute, connexion)
                Dim ok = cmd.ExecuteNonQuery()
                If ok Then
                    MsgBox("Portefeuille supprimé avec succès!", MsgBoxStyle.Information)
                    'ACTUALISATION DU DATAGRIDVIEW
                    Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
                    Dim lacmd As New MySqlCommand(rSelect, connexion)
                    lacmd.ExecuteNonQuery()
                    Dim adapatateur As New MySqlDataAdapter(lacmd)
                    Dim dataset As New DataSet
                    adapatateur.Fill(dataset, "portefeuilles")
                    cmd.Dispose()
                    If dataset.Tables("portefeuilles").Rows.Count > 0 Then
                        DataGridView1.Visible = True
                        DataGridView1.DataSource = dataset.Tables("portefeuilles")
                        btnNew.Visible = False
                        btnNew1.Visible = True
                        Label10.Visible = True
                        PortefeuilleToolStripMenuItem1.Visible = False
                        boxSearch.Visible = True
                        num_ptf = Val(dataset.Tables("portefeuilles").Rows(0).Item("num_ptf").ToString)
                        'DATE FIN 
                        date_fin = dataset.Tables("portefeuilles").Rows(0).Item("date_fin").ToString
                        'DATE FIN
                        Dim ndate_fin = CDate(date_fin)
                        Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
                        If letoday >= ndate_fin Then
                            lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
                            Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
                            lblInfos.Visible = True
                            Label12.Visible = True
                            DataGridView2.Visible = False
                            btnAjouter.Visible = False
                            TransactionsToolStripMenuItem.Visible = False
                            Label7.Visible = False
                        End If
                    Else
                        DataGridView1.Visible = False
                        btnNew.Visible = True
                        btnNew1.Visible = False
                        Label10.Visible = False
                        boxSearch.Visible = False
                        EtatToolStripMenuItem.Visible = False

                    End If
                End If
            Else 'AU CAS OU IL N'Y A PAS DE TRANSACTION DANS LE PORTEFEUILLE
                rqute = "DELETE FROM `portefeuilles` WHERE `num_ptf` = " & num_ptf
                Dim cmd As New MySqlCommand(rqute, connexion)
                Dim ok = cmd.ExecuteNonQuery()
                If ok Then
                    MsgBox("Portefeuille supprimé avec succès!", MsgBoxStyle.Information)
                    'ACTUALISATION
                    Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
                    Dim lacmd As New MySqlCommand(rSelect, connexion)
                    lacmd.ExecuteNonQuery()
                    Dim adapatateur As New MySqlDataAdapter(lacmd)
                    Dim dataset As New DataSet
                    adapatateur.Fill(dataset, "portefeuilles")
                    cmd.Dispose()
                    If dataset.Tables("portefeuilles").Rows.Count > 0 Then
                        DataGridView1.Visible = True
                        DataGridView1.DataSource = dataset.Tables("portefeuilles")
                        btnNew.Visible = False
                        btnNew1.Visible = True
                        Label10.Visible = True
                        PortefeuilleToolStripMenuItem1.Visible = False
                        boxSearch.Visible = True
                        num_ptf = Val(dataset.Tables("portefeuilles").Rows(0).Item("num_ptf").ToString)
                        'DATE FIN 
                        date_fin = dataset.Tables("portefeuilles").Rows(0).Item("date_fin").ToString

                        'DATE FIN
                        Dim ndate_fin = CDate(date_fin)
                        Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
                        If letoday >= ndate_fin Then
                            lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
                            Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
                            lblInfos.Visible = True
                            Label12.Visible = True
                            DataGridView2.Visible = False
                            btnAjouter.Visible = False
                            TransactionsToolStripMenuItem.Visible = False
                            Label7.Visible = False
                        End If
                    Else
                        DataGridView1.Visible = False
                        btnNew.Visible = True
                        btnNew1.Visible = False
                        Label10.Visible = False
                        boxSearch.Visible = False
                        EtatToolStripMenuItem.Visible = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        pnlMenu.Visible = False
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        edituser.ShowDialog()
    End Sub

    Private Sub PortefeuillesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortefeuillesToolStripMenuItem.Click
        pnlMenu.Visible = False
        DataGridView2.Visible = True
        PortefeuilleToolStripMenuItem1.Visible = False
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adapatateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adapatateur.Fill(dataset, "portefeuilles")
            cmd.Dispose()
            If dataset.Tables("portefeuilles").Rows.Count > 0 Then
                DataGridView1.Visible = True
                DataGridView1.DataSource = dataset.Tables("portefeuilles")
                btnNew.Visible = False
                btnNew1.Visible = True
                Label10.Visible = True
                PortefeuilleToolStripMenuItem1.Visible = False
                boxSearch.Visible = True
                num_ptf = Val(dataset.Tables("portefeuilles").Rows(0).Item("num_ptf").ToString)
                'DATE FIN 
                date_fin = dataset.Tables("portefeuilles").Rows(0).Item("date_fin").ToString

                'DATE FIN
                Dim ndate_fin = CDate(date_fin)
                Dim letoday = CDate(Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString)
                If letoday >= ndate_fin Then
                    lblInfos.Text = "Vous êtes arrivé au terme du suivi du portefeuille."
                    Label12.Text = "Veuillez imprimer vos bilans dans le menu «Etats»."
                    lblInfos.Visible = True
                    Label12.Visible = True
                    DataGridView2.Visible = False
                    btnAjouter.Visible = False
                    TransactionsToolStripMenuItem.Visible = False
                    Label7.Visible = False
                End If
            Else
                btnNew.Visible = True
                EtatToolStripMenuItem.Visible = False
            End If
        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub DeviseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviseToolStripMenuItem1.Click
        listDvs.ShowDialog()
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DépensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DépensesToolStripMenuItem.Click
        fdepenses.ShowDialog()
    End Sub

    Private Sub RevenusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevenusToolStripMenuItem.Click
        frevenus.ShowDialog()
    End Sub

    Private Sub ToutesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToutesToolStripMenuItem.Click
        ftoutes.ShowDialog()
    End Sub
End Class
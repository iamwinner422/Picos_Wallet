Imports MySql.Data.MySqlClient
Public Class newPtf
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Dim num_user As Integer = My.Forms.connexion.num_user
    Public num_du_port As String = ""
    Public nom_du_port As String = ""

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxNom.Text = ""
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxNom.Text = "" Or listeDevise.Text = "" Then
            MsgBox("Erreur!Veuillez remplir tous les champs", MsgBoxStyle.Critical)
        ElseIf DateTimePicker1.Value = Today Then
            MsgBox("Veuillez choisir une date ultérieure à la date d'aujourd'hui!", MsgBoxStyle.Critical)
        Else
            Dim nom = boxNom.Text
            Dim devise = listeDevise.SelectedValue.ToString
            Dim date_fin As String = DateTimePicker1.Value.Day.ToString + "/" + DateTimePicker1.Value.Month.ToString + "/" + DateTimePicker1.Value.Year.ToString
            Dim date_debut = Today.Day.ToString + "/" + Today.Month.ToString + "/" + Today.Year.ToString
            Try
                connexion.Open()
                'VERIFICATION DE L'EXISTANCE DU PORTEFEUILLE
                Dim rSel As String = "SELECT * FROM `portefeuilles` WHERE `nom_ptf` = '" & nom & "' AND `devise` = '" & devise & "'"
                Dim sCom As New MySqlCommand(rSel, connexion)
                sCom.ExecuteNonQuery()
                Dim sAdapter As New MySqlDataAdapter(sCom)
                Dim sDataset As New DataSet
                sAdapter.Fill(sDataset, "portefeuilles")
                If sDataset.Tables("portefeuilles").Rows.Count Then
                    MsgBox("Un portefeuille du même nom et de la même devise existe déjà!", MsgBoxStyle.Critical)
                    sCom.Dispose()
                Else
                    Dim rInsert As String = "INSERT INTO `portefeuilles`(nom_ptf, devise, num_user, date_debut, date_fin) VALUES('" & nom & "', '" & devise & "', '" & num_user & "', '" & date_debut & "', '" & date_fin & "')"
                    Dim laCmd As New MySqlCommand(rInsert, connexion)
                    Dim vraie = laCmd.ExecuteNonQuery
                    If (vraie) Then
                        MsgBox("Portefeuille crée avec succès!", MsgBoxStyle.Information)
                        boxNom.Text = ""
                        laCmd.Dispose()
                        'SELECTION DU DERNIER NUMERO DU PORTEFEUILLE CREE PAR LE USER
                        Dim req As String = "SELECT MAX(num_ptf) AS `dernier` FROM `portefeuilles` WHERE `num_user` = " & num_user
                        Dim theCom As New MySqlCommand(req, connexion)
                        theCom.ExecuteNonQuery()
                        Dim theAdapter As New MySqlDataAdapter(theCom)
                        Dim theDataset As New DataSet
                        theAdapter.Fill(theDataset, "portefeuilles")
                        num_du_port = theDataset.Tables("portefeuilles").Rows(0).Item("dernier").ToString
                        'SELECTION DU NOM DU PORTEFEUILLE
                        Dim reqOp As String = "SELECT `nom_ptf` FROM `portefeuilles` WHERE `num_ptf` = " & num_du_port
                        Dim comOp As New MySqlCommand(reqOp, connexion)
                        comOp.ExecuteNonQuery()
                        Dim datasetOp As New DataSet
                        Dim adapterOp As New MySqlDataAdapter(comOp)
                        adapterOp.Fill(datasetOp, "portefeuilles")
                        nom_du_port = datasetOp.Tables("portefeuilles").Rows(0).Item("nom_ptf").ToString
                        'nom du potefeuille
                        MenuPrincipal.PortefeuilleToolStripMenuItem1.Text = nom_du_port
                        MenuPrincipal.PortefeuilleToolStripMenuItem1.Visible = True
                        MenuPrincipal.EtatToolStripMenuItem.Visible = True
                        MenuPrincipal.num_ptf = num_du_port
                        MenuPrincipal.lblNomPtf.Text = nom_du_port
                        If MenuPrincipal.solde < 0 Then
                            MenuPrincipal.lblSolde.ForeColor = Color.Red
                        ElseIf MenuPrincipal.solde > 0 Then
                            MenuPrincipal.lblSolde.ForeColor = Color.Green
                        End If
                        'AFFECTATION 
                        MenuPrincipal.lblSolde.Text = MenuPrincipal.solde & " " & MenuPrincipal.Tdevise
                        MenuPrincipal.pnlMenu.Visible = True
                        MenuPrincipal.btnNew.Visible = False

                        ''AFFI
                        Dim reqP As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_du_port
                        Dim cmdP As New MySqlCommand(reqP, connexion)
                        cmdP.ExecuteNonQuery()
                        Dim adaptateurP As New MySqlDataAdapter(cmdP)
                        Dim datasetP As New DataSet
                        adaptateurP.Fill(datasetP, "transactions")
                        If datasetP.Tables("transactions").Rows.Count > 0 Then
                            MenuPrincipal.DataGridView2.DataSource = datasetOp.Tables("transactions")
                        Else
                            MenuPrincipal.lblInfos.Visible = True
                            MenuPrincipal.Label7.Visible = False
                            MenuPrincipal.Label12.Visible = True
                            MenuPrincipal.DataGridView2.Visible = False

                        End If
                        cmdP.Dispose()

                        MenuPrincipal.Show()
                        Me.Hide()
                    Else
                        MsgBox("Erreur!", MsgBoxStyle.Critical)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub newPtf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Devises._devises'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DevisesTableAdapter.Fill(Me.Devises._devises)
        DateTimePicker1.MinDate = Today

    End Sub

    Private Sub newPtf_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '    Try
        '        connexion.Open()
        '        Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user` = " & num_user
        '        Dim cmd As New MySqlCommand(rSelect, connexion)
        '        cmd.ExecuteNonQuery()
        '        Dim adapatateur As New MySqlDataAdapter(cmd)
        '        Dim dataset As New DataSet
        '        adapatateur.Fill(dataset, "portefeuilles")
        '        If dataset.Tables("portefeuilles").Rows.Count > 0 Then
        '            MenuPrincipal.DataGridView1.Visible = True
        '            MenuPrincipal.DataGridView1.DataSource = dataset.Tables("portefeuilles")
        '            MenuPrincipal.btnNew.Visible = False
        '        Else
        '            MenuPrincipal.btnNew.Visible = True
        '        End If

        '    Catch ex As Exception
        '        MsgBox(ex.ToString, MsgBoxStyle.Critical)
        '    End Try
        '    connexion.Close()
    End Sub
End Class
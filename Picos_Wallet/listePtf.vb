Imports MySql.Data.MySqlClient
Public Class listePtf
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Public nom_du_port As String = ""
    'My.Forms.connexion.num_user

    Private Sub listePtf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Picos_walletDataSet.devises'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DevisesTableAdapter.Fill(Me.Picos_walletDataSet.devises)
        DateTimePicker1.MinDate = Today
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxNom.Text = "" Then
            MsgBox("Veuillez remplir tous les champs!", MsgBoxStyle.Critical)
        ElseIf DateTimePicker1.Value = Today Then
            MsgBox("Veuillez choisir une date ultérieure à la date d'aujourd'hui!", MsgBoxStyle.Critical)
        Else
            Dim nom = boxNom.Text
            Dim devise = ComboBox1.Text
            Dim ladatefin = DateTimePicker1.Value.Day.ToString + "/" + DateTimePicker1.Value.Month.ToString + "/" + DateTimePicker1.Value.Year.ToString
            Try
                connexion.Open()
                Dim requete As String = "UPDATE `portefeuilles` SET `nom_ptf` = '" & nom & "', devise = '" & devise & "', date_fin = '" & ladatefin & "' WHERE `num_ptf` = " & MenuPrincipal.num_ptf
                Dim com As New MySqlCommand(requete, connexion)
                Dim vraie = com.ExecuteNonQuery()
                If vraie Then
                    'SELECTION DES NOUVELLES INFOS DU PORTEFEUILLE
                    Dim reqOp As String = "SELECT * FROM `portefeuilles` WHERE `num_ptf` = " & MenuPrincipal.num_ptf
                    Dim comOp As New MySqlCommand(reqOp, connexion)
                    comOp.ExecuteNonQuery()
                    Dim datasetOp As New DataSet
                    Dim adapterOp As New MySqlDataAdapter(comOp)
                    adapterOp.Fill(datasetOp, "portefeuilles")
                    nom_du_port = datasetOp.Tables("portefeuilles").Rows(0).Item("nom_ptf").ToString
                    MenuPrincipal.Tdevise = datasetOp.Tables("portefeuilles").Rows(0).Item("devise").ToString
                    MenuPrincipal.lblNomPtf.Text = nom_du_port
                    If MenuPrincipal.solde < 0 Then
                        MenuPrincipal.lblSolde.ForeColor = Color.Red
                    ElseIf MenuPrincipal.solde > 0 Then
                        MenuPrincipal.lblSolde.ForeColor = Color.Green
                    End If
                    'AFFECTATION 
                    MenuPrincipal.PortefeuilleToolStripMenuItem1.Text = nom_du_port
                    MenuPrincipal.lblSolde.Text = MenuPrincipal.solde & " " & MenuPrincipal.Tdevise
                    MessageBox.Show("Portefeuille modifié avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub
End Class
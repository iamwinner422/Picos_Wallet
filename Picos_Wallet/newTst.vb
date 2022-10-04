Imports MySql.Data.MySqlClient
Public Class newTst
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Public num_cat As Integer
    Dim num_type As Integer
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


    'Dans ta requête
    'sqlRequete = "select * from Table where Colonne = '" & ChangeCaratere("D'habitude", Guillemet) & "'"
    Private Sub newTst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Libelle.type_transac'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Type_transacTableAdapter.Fill(Me.Libelle.type_transac)
        'TODO: cette ligne de code charge les données dans la table 'Categories._categories'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CategoriesTableAdapter.Fill(Me.Categories._categories)
        Dim nom_cat = listeCat.SelectedValue.ToString
        Try
            connexion.Open()
            Dim reqNum = "SELECT `num_cat` FROM `categories` WHERE `nom_cat` = '" & nom_cat & "'"
            Dim cmdNum As New MySqlCommand(reqNum, connexion)
            cmdNum.ExecuteNonQuery()
            Dim adaptateurNum As New MySqlDataAdapter(cmdNum)
            Dim datasetNum As New DataSet
            adaptateurNum.Fill(datasetNum, "categories")
            num_cat = Val(datasetNum.Tables("categories").Rows(0).Item("num_cat").ToString)
            cmdNum.Dispose()
            'changement du type en fonction de la categorie
            Dim rSelect As String = "SELECT * FROM `type_transac` WHERE `num_cat` = " & num_cat
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "type_transac")
            listeLib.DataSource = dataset.Tables("type_transac")
            num_type = Val(dataset.Tables("type_transac").Rows(0).Item("num_type").ToString)
            cmd.Dispose()
            If nom_cat = "Revenus" Then
                boxMontant.ForeColor = Color.Green
            ElseIf nom_cat = "Dépenses" Then
                boxMontant.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub listeCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listeCat.SelectedIndexChanged

    End Sub

    Private Sub listeCat_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listeCat.SelectionChangeCommitted
        Dim nom_cat = listeCat.SelectedValue.ToString
        Try
            connexion.Open()
            Dim reqNum = "SELECT `num_cat` FROM `categories` WHERE `nom_cat` = '" & nom_cat & "'"
            Dim cmdNum As New MySqlCommand(reqNum, connexion)
            cmdNum.ExecuteNonQuery()
            Dim adaptateurNum As New MySqlDataAdapter(cmdNum)
            Dim datasetNum As New DataSet
            adaptateurNum.Fill(datasetNum, "categories")
            num_cat = Val(datasetNum.Tables("categories").Rows(0).Item("num_cat").ToString)
            cmdNum.Dispose()
            'changement du type en fonction de la categorie
            Dim rSelect As String = "SELECT * FROM `type_transac` WHERE `num_cat` = " & num_cat
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "type_transac")
            listeLib.DataSource = dataset.Tables("type_transac")
            num_type = Val(dataset.Tables("type_transac").Rows(0).Item("num_type").ToString)
            cmd.Dispose()
            If nom_cat = "Revenus" Then
                boxMontant.ForeColor = Color.Green
            ElseIf nom_cat = "Dépenses" Then
                boxMontant.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxComment.Text = ""
        boxMontant.Text = ""
    End Sub

    Private Sub listeLib_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listeLib.SelectedIndexChanged

    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim num_ptf = Val(My.Forms.MenuPrincipal.num_ptf)
        If boxMontant.Text = "" Then
            MsgBox("Erreur! Veuillez renseigner le montant.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(boxMontant.Text) Then
            MsgBox("Erreur! Le montant saisi n'est pas numérique.", MsgBoxStyle.Critical)
        Else
            Try
                connexion.Open()
                Dim commentaire As String = boxComment.Text
                Dim montant = Val(boxMontant.Text)
                If boxComment.Text = "" Then
                    commentaire = "Sans commentaire"
                Else
                    commentaire = boxComment.Text
                End If
                Dim heure As String = DateTimePicker1.Value.Hour.ToString & ":" & DateTimePicker1.Value.Minute.ToString
                Dim dateJ As String = DateTimePicker1.Value.Day.ToString & "/" & DateTimePicker1.Value.Month.ToString & "/" & DateTimePicker1.Value.Year.ToString
                Dim rInsert As String = "INSERT INTO `transactions`(comment_tst, montant_tst, heure_tst, date_tst, num_type, num_ptf) VALUES('" & ChangeCaratere(commentaire, CaractereType.Guillemet) & "','" & montant & "','" & heure & "','" & dateJ & "','" & num_type & "', '" & num_ptf & "')"
                Dim cmd As New MySqlCommand(rInsert, connexion)
                Dim vraie = cmd.ExecuteNonQuery()
                If vraie Then
                    Dim nom_cat = listeCat.SelectedValue.ToString
                    Dim rUpdate As String = ""
                    'MISE A JOUR DU SOLDE DU PORTEFEUILLE EN FONCTION DE LA CATEGORIE
                    If nom_cat = "Revenus" Then
                        rUpdate = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` + '" & montant & "' WHERE `num_ptf` = " & num_ptf
                    Else
                        rUpdate = "UPDATE `portefeuilles` SET `solde_ptf` = `solde_ptf` - '" & montant & " 'WHERE `num_ptf` = " & num_ptf
                    End If
                    Dim laCmd As New MySqlCommand(rUpdate, connexion)
                    laCmd.ExecuteNonQuery()
                    laCmd.Dispose()
                    MsgBox("Transaction ajoutée avec succès!", MsgBoxStyle.Information)
                    boxComment.Text = ""
                    boxMontant.Text = ""
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub newTst_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim num_user = MenuPrincipal.num_user
        Try
            connexion.Open()
            'ACTUALISATION DU LABEL SOLDE
            Dim rSelect As String = "SELECT * FROM `portefeuilles` WHERE `num_user`= " & num_user & " AND  `num_ptf`= " & MenuPrincipal.num_ptf
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adapatateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adapatateur.Fill(dataset, "portefeuilles")
            Dim solde = Val(dataset.Tables("portefeuilles").Rows(0).Item("solde_ptf").ToString)
            MenuPrincipal.lblSolde.Text = solde & " " & MenuPrincipal.Tdevise
            cmd.Dispose()
            Dim num_ptf = MenuPrincipal.num_ptf
            Dim reqOp As String = "SELECT * FROM `transactions` WHERE `num_ptf` = " & num_ptf
            Dim cmdOp As New MySqlCommand(reqOp, connexion)
            cmdOp.ExecuteNonQuery()
            Dim adaptateurOp As New MySqlDataAdapter(cmdOp)
            Dim datasetOp As New DataSet
            adaptateurOp.Fill(datasetOp, "transactions")
            If datasetOp.Tables("transactions").Rows.Count > 0 Then
                MenuPrincipal.DataGridView2.DataSource = datasetOp.Tables("transactions")
                MenuPrincipal.DataGridView2.Visible = True
                MenuPrincipal.lblInfos.Visible = False
                MenuPrincipal.Label12.Visible = False
            Else
                MenuPrincipal.lblInfos.Visible = True
                MenuPrincipal.Label12.Visible = True
                MsgBox("Bienvenue cher utilisateur! Commençons avec un nouveau portefeuille.", MsgBoxStyle.Information)
            End If
            cmdOp.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        If MenuPrincipal.solde < 0 Then
            MenuPrincipal.lblSolde.ForeColor = Color.Red
        ElseIf MenuPrincipal.solde > 0 Then
            MenuPrincipal.lblSolde.ForeColor = Color.Green
        End If
    End Sub

    Private Sub listeLib_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listeLib.SelectionChangeCommitted
        Dim libelle = listeLib.SelectedValue.ToString
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT `num_type` FROM `type_transac` WHERE `libelle_type` = '" & libelle & "'"
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "type_transac")
            'listeLib.DataSource = dataset.Tables("type_transac")
            num_type = Val(dataset.Tables("type_transac").Rows(0).Item("num_type").ToString)
            cmd.Dispose()
            Dim nom_cat = listeCat.SelectedValue.ToString
            If nom_cat = "Revenus" Then
                boxMontant.ForeColor = Color.Green
            ElseIf nom_cat = "Dépenses" Then
                boxMontant.ForeColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class listDvs
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Public code As String = ""
    Public Description As String = ""
    Public num_dvs As Integer
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
    Private Sub listDvs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Dvs.devises'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DevisesTableAdapter.Fill(Me.Dvs.devises)

    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxCode.Text = "" Or boxDesc.Text = "" Then
            MsgBox("Erreur! Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        Else
            code = boxCode.Text
            Description = boxDesc.Text
            connexion.Open()
            If btnAjouter.Text = "Modifier" Then
                Try
                    Dim rUpdate As String = "UPDATE `devises` SET `code_dvs` = '" & ChangeCaratere(code, CaractereType.Guillemet) & "', `description` = '" & ChangeCaratere(Description, CaractereType.Guillemet) & "' WHERE `num_dvs` = " & num_dvs
                    Dim cmd As New MySqlCommand(rUpdate, connexion)
                    Dim vraie = cmd.ExecuteNonQuery()
                    If vraie Then
                        MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                        boxDesc.Text = ""
                        boxCode.Text = ""
                    Else
                        MsgBox("Erreur!", MsgBoxStyle.Critical)
                    End If
                    'rafraîchissement du datagridview
                    Dim rSelect As String = "SELECT * FROM `devises`"
                    Dim cmdN As New MySqlCommand(rSelect, connexion)
                    cmdN.ExecuteNonQuery()
                    Dim adaptateur As New MySqlDataAdapter(cmdN)
                    Dim dataset As New DataSet
                    adaptateur.Fill(dataset, "devises")
                    DataGridView1.DataSource = dataset.Tables("devises")

                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
            Else
                Try
                    Dim code As String = boxCode.Text
                    Dim description As String = boxDesc.Text
                    Dim requete As String = "SELECT * FROM `devises` WHERE `code_dvs` = '" & code & "'"
                    Dim laCmd As New MySqlCommand(requete, connexion)
                    laCmd.ExecuteNonQuery()
                    Dim adaptateur1 As New MySqlDataAdapter(laCmd)
                    Dim dataset1 As New DataSet
                    laCmd.Dispose()
                    adaptateur1.Fill(dataset1, "devises")
                    If dataset1.Tables("devises").Rows.Count <= 0 Then
                        Dim rInsert As String = "INSERT INTO `devises`(code_dvs, description) VALUES('" & code & "', '" & description & "')"
                        Dim laCom As New MySqlCommand(rInsert, connexion)
                        Dim vraie = laCom.ExecuteNonQuery
                        If (vraie) Then
                            MsgBox("La devise a été ajoutée avec succès!", MsgBoxStyle.Information)
                            boxCode.Text = ""
                            boxDesc.Text = ""
                            laCom.Dispose()
                            'rafraîchissement du datagridview
                            Dim rSelect As String = "SELECT * FROM `devises`"
                            Dim cmdN As New MySqlCommand(rSelect, connexion)
                            cmdN.ExecuteNonQuery()
                            Dim adaptateur As New MySqlDataAdapter(cmdN)
                            Dim dataset As New DataSet
                            adaptateur.Fill(dataset, "devises")
                            DataGridView1.DataSource = dataset.Tables("devises")
                        Else
                            MsgBox("Erreur!", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("La devise existe déjà!", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                connexion.Close()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneselectionnee = DataGridView1.Rows(numLigne)
        num_dvs = Val(ligneselectionnee.Cells(0).Value.ToString)
        code = ligneselectionnee.Cells(1).Value.ToString
        Description = ligneselectionnee.Cells(2).Value.ToString
        boxCode.Text = code
        boxDesc.Text = Description
        btnAjouter.Text = "Modifier"
        btnEffacer.Text = "Supprimer"
    End Sub

    Private Sub boxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.TextChanged
        Try
            connexion.Open()
            Dim recherche = boxSearch.Text
            Dim rSearch As String = "SELECT * FROM `devises` WHERE(`num_dvs` LIKE '%" & ChangeCaratere(recherche, CaractereType.Guillemet) & "%' OR `code_dvs` LIKE '%" & ChangeCaratere(recherche, CaractereType.Guillemet) & "%'  OR `description` LIKE '%" & ChangeCaratere(recherche, CaractereType.Guillemet) & "%');"
            Dim cmd As New MySqlCommand(rSearch, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "devises")
            DataGridView1.DataSource = dataset.Tables("devises")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub boxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Leave
        Label7.Visible = True
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Label7.Visible = False
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        If btnEffacer.Text = "Supprimer" Then
            Try
                connexion.Open()
                Dim rDelete As String = "DELETE FROM `devises` WHERE `num_dvs` = " & num_dvs
                Dim cmd As New MySqlCommand(rDelete, connexion)
                Dim vraie = cmd.ExecuteNonQuery()
                If vraie Then
                    MsgBox("L'enregistrement a été supprimé avec succès!", MsgBoxStyle.Information)
                    boxDesc.Text = ""
                    boxCode.Text = ""
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If
                'rafraichissement du datagrid
                Dim rSelect As String = "SELECT * FROM `devises`"
                Dim cmdN As New MySqlCommand(rSelect, connexion)
                cmdN.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmdN)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "devises")
                DataGridView1.DataSource = dataset.Tables("devises")
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        Else
            boxCode.Text = ""
            boxDesc.Text = ""
        End If
    End Sub

    Private Sub boxSearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Enter
        Label7.Visible = False
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class newDevise
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxCode.Text = "" Or boxDesc.Text = "" Then
            MsgBox("Erreur!Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        Else
            Try
                connexion.Open()
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
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxCode.Text = ""
        boxDesc.Text = ""
    End Sub

    Private Sub newDevise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
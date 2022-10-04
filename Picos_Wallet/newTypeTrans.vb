Imports MySql.Data.MySqlClient
Public Class newTypeTrans
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Private Sub newTypeTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Cat1.categories'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CategoriesTableAdapter.Fill(Me.Cat1.categories)

    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxNom.Text = "" Then
            MsgBox("Erreur!Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        Else
            Try
                connexion.Open()
                Dim nom As String = boxNom.Text
                Dim nom_cat = listeCat.SelectedValue.ToString
                Dim rSelect As String = "SELECT `num_cat` FROM `categories` WHERE `nom_cat` = '" & nom_cat & "'"
                Dim cmd As New MySqlCommand(rSelect, connexion)
                cmd.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmd)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "categories")
                Dim num_cat = Val(dataset.Tables("categories").Rows(0).Item("num_cat").ToString)
                cmd.ExecuteNonQuery()
                Dim requete As String = "SELECT * FROM `type_transac` WHERE `libelle_type` = '" & nom & "'"
                Dim laCmd As New MySqlCommand(requete, connexion)
                laCmd.ExecuteNonQuery()
                Dim adaptateur1 As New MySqlDataAdapter(laCmd)
                Dim dataset1 As New DataSet
                laCmd.Dispose()
                adaptateur1.Fill(dataset1, "type_transac")
                If dataset1.Tables("type_transac").Rows.Count <= 0 Then
                    Dim rInsert As String = "INSERT INTO `type_transac`(libelle_type, num_cat) VALUES('" & nom & "', '" & num_cat & "')"
                    Dim laCom As New MySqlCommand(rInsert, connexion)
                    Dim vraie = laCom.ExecuteNonQuery
                    If (vraie) Then
                        MsgBox("La catégorie a été ajoutée!", MsgBoxStyle.Information)
                        boxNom.Text = ""

                        laCom.Dispose()
                    Else
                        MsgBox("Erreur!", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("La catégorie existe déjà!", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxNom.Text = ""
    End Sub

    Private Sub listeCat_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listeCat.SelectionChangeCommitted

    End Sub
End Class
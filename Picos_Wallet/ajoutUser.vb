Imports MySql.Data.MySqlClient
Public Class ajoutUser
    Public mode As String = ""
    Public num_user As Integer
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Private Sub ajoutUser_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click

        If boxLogin.Text = "" Or boxPass.Text = "" Then
            MsgBox("Erreur!Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        Else
            Try
                connexion.Open()
                Dim login_user As String = boxLogin.Text
                Dim pass_user As String = boxPass.Text
                'VERIFICATION DE L'EXISTANCE DU USER
                Dim rSelect As String = "SELECT * FROM `utilisateurs` WHERE login_user= '" & login_user & "' AND pass_user = '" & pass_user & "'"
                Dim theCmd As New MySqlCommand(rSelect, connexion)
                theCmd.ExecuteNonQuery()
                Dim theAdaptater As New MySqlDataAdapter(theCmd)
                Dim theDataset As New DataSet
                theAdaptater.Fill(theDataset, "utilisateurs")
                If theDataset.Tables("utilisateurs").Rows.Count > 0 Then
                    MsgBox("Erreur! L'utilisateur existe déjà.", MsgBoxStyle.Critical)
                Else
                    Dim rInsert As String = "INSERT INTO `utilisateurs`(login_user, pass_user) VALUES('" & login_user & "', '" & pass_user & "')"
                    Dim laCmd As New MySqlCommand(rInsert, connexion)
                    Dim vraie = laCmd.ExecuteNonQuery
                    If (vraie) Then
                        MsgBox("Utilisateur ajouté avec succès!", MsgBoxStyle.Information)
                        Dim rSelecte As String = "SELECT `num_user` FROM `utilisateurs` WHERE `login_user` = '" & login_user & "'"
                        Dim cmd As New MySqlCommand(rSelecte, connexion)
                        cmd.ExecuteNonQuery()
                        Dim adaptateur As New MySqlDataAdapter(cmd)
                        Dim dataset As New DataSet
                        adaptateur.Fill(dataset, "utilisateurs")
                        num_user = Val(dataset.Tables("utilisateurs").Rows(0).Item("num_user").ToString)
                        My.Forms.connexion.Show()
                        Me.Close()
                        cmd.Dispose()
                        boxLogin.Text = ""
                        boxPass.Text = ""
                        laCmd.Dispose()
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

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxLogin.Text = ""
        boxPass.Text = ""
    End Sub

    Private Sub ajoutUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub ajoutUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
    End Sub
End Class
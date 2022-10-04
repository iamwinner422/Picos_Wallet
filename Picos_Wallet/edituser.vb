Imports MySql.Data.MySqlClient
Public Class edituser
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxLogin.Text = ""
        boxPass.Text = ""
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxLogin.Text = "" Or boxPass.Text = "" Then
            MsgBox("Veuillez remplir tous les champs!")
        Else
            Dim login = boxLogin.Text
            Dim pass = boxPass.Text
            Try
                connexion.Open()
                Dim req As String = "UPDATE `utilisateurs` SET `login_user` = '" & login & "', `pass_user` = '" & pass & "' WHERE `num_user` = " & MenuPrincipal.num_user
                Dim lacom As New MySqlCommand(req, connexion)
                Dim vrai = lacom.ExecuteNonQuery
                If vrai Then
                    'SELECTION DES INFOS DE L'UTILISATEUR
                    Dim reqUser As String = "SELECT * FROM `utilisateurs` WHERE `num_user` = " & MenuPrincipal.num_user
                    Dim commmande As New MySqlCommand(reqUser, connexion)
                    commmande.ExecuteNonQuery()
                    Dim lAdaptateur As New MySqlDataAdapter(commmande)
                    Dim leDataset As New DataSet
                    lAdaptateur.Fill(leDataset, "utilisateurs")
                    commmande.Dispose()
                    MenuPrincipal.nomUser = leDataset.Tables("utilisateurs").Rows(0).Item("login_user").ToString
                    MenuPrincipal.pass_user = leDataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
                    MenuPrincipal.lblUser.Text = MenuPrincipal.nomUser
                    MsgBox("Compte modifié avec succès!", MsgBoxStyle.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub edituser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boxLogin.Text = MenuPrincipal.nomUser
        boxPass.Text = MenuPrincipal.pass_user
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        MenuPrincipal.Close()
        Try
            connexion.Open()
            Dim rqute = "DELETE FROM `portefeuilles` WHERE `num_user` = " & MenuPrincipal.num_user
            Dim cmd As New MySqlCommand(rqute, connexion)
            Dim ok = cmd.ExecuteNonQuery()
            If ok Then
                Dim req As String = "DELETE FROM `utilisateurs` WHERE `num_user` = " & MenuPrincipal.num_user
                Dim lacom As New MySqlCommand(req, connexion)
                Dim nice = lacom.ExecuteNonQuery
                If nice Then
                    MenuPrincipal.Close()
                    Form1.Show()
                    Me.Close()
                Else
                    MsgBox("erreur " + MenuPrincipal.num_user)
                End If
            Else 'AU CAS OU IL N'Y A PAS DE PORTEFEUILLE
                rqute = "DELETE FROM `utilisateurs` WHERE `num_user` = " & MenuPrincipal.num_user
                Dim cmdA As New MySqlCommand(rqute, connexion)
                Dim oka = cmd.ExecuteNonQuery()
                If oka Then
                    Form1.Show()
                    Me.Close()
                Else
                    MsgBox("erreur " + MenuPrincipal.num_user)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub
End Class
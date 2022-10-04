Imports MySql.Data.MySqlClient
Public Class connexion
    Public num_user As String
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Function Verification(ByRef lenom As String, ByRef lemot As String) As Boolean

        If lenom = "" And lemot = "" Then
            MsgBox("Erreur!Veuillez saisir le nom d'utilisateur et le mot de passe", MsgBoxStyle.Critical)
            Return False
        ElseIf lenom <> "" And lemot = "" Then
            MsgBox("Erreur!Veuillez saisir le mot de passe", MsgBoxStyle.Critical)
            Return False
        ElseIf lenom = "" And lemot <> "" Then
            MsgBox("Erreur!Veuillez saisir le nom d'utilisateur", MsgBoxStyle.Critical)
            Return False
            'ElseIf lenom <> "Admin" And lemot <> "@dmin" Then
            '   MsgBox("Erreur!le nom d'utilisateur et le mot de passe sont incorrects", MsgBoxStyle.Critical)
            '  Return False
            'ElseIf (lemot = "Admin" And lenom <> "@dmin") Or (lenom = "Admin" And lemot <> "@dmin") Then
            '   MsgBox("Erreur!le nom d'utilisateur ou le mot de passe est incorrect", MsgBoxStyle.Critical)
            '  Return False
        Else
            Return True
        End If
    End Function
    Private Sub connexion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxPassword.Text = ""
        boxUser.Text = ""
    End Sub

    Private Sub btnConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnexion.Click
         if Verification(boxUser.Text, boxPassword.Text) Then
        Dim login As String = boxUser.Text
        Dim password As String = boxPassword.Text

        Try
            connexion.Open()
            Dim requete As String = "SELECT * FROM `utilisateurs` WHERE `login_user` = '" & login & "' AND `pass_user` = '" & password & "'"
            Dim cmd As New MySqlCommand(requete, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "utilisateurs")
            If dataset.Tables("utilisateurs").Rows.Count > 0 Then
                num_user = dataset.Tables("utilisateurs").Rows(0).Item("num_user").ToString
                boxPassword.Text = ""
                boxUser.Text = ""
                boxNum.Text = num_user
                MenuPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("Erreur!Nom d'utilisateur ou mot de passe incorrect.", MsgBoxStyle.Critical)
                'boxPassword.Text = ""
                'boxUser.Text = ""
            End If
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        End If
    End Sub

    Private Sub connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
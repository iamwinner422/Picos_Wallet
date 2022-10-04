Imports MySql.Data.MySqlClient
Public Class listeLib
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Public libelle As String
    Public num_lib As Integer
    Public num_cat As Integer
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
    Private Sub listeLib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Libelles.type_transac'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Type_transacTableAdapter.Fill(Me.Libelles.type_transac)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneselectionnee = DataGridView1.Rows(numLigne)
        num_lib = Val(ligneselectionnee.Cells(0).Value.ToString)
        libelle = ligneselectionnee.Cells(1).Value.ToString
        num_cat = Val(ligneselectionnee.Cells(2).Value.ToString)
        boxCat.Text = num_cat
        boxLib.Text = libelle
    End Sub

    Private Sub boxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Leave
        Label7.Visible = True
    End Sub

    Private Sub boxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Click
        Label7.Visible = False
    End Sub

    Private Sub boxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.TextChanged
        Try
            connexion.Open()
            Dim recherche = boxSearch.Text
            Dim rSearch As String = "SELECT * FROM `type_transac` WHERE(`libelle_type` LIKE '%" & ChangeCaratere(recherche, CaractereType.Guillemet) & "%');"
            Dim cmd As New MySqlCommand(rSearch, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "type_transac")
            DataGridView1.DataSource = dataset.Tables("type_transac")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If boxCat.Text = "" Or boxLib.Text = "" Then
            MsgBox("Erreur! Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(boxCat.Text) Then
            MsgBox("Erreur! Le numéro de la catégorie n'est pas valide.", MsgBoxStyle.Critical)
        ElseIf Val(boxCat.Text) <= 0 Or Val(boxCat.Text) > 2 Then
            MsgBox("Erreur! Le numéro de la catégorie n'est pas valide.", MsgBoxStyle.Critical)
            MsgBox("Le numéro de la catégorie est soit '1' pour 'Revenus ou '2' pour 'Dépenses'", MsgBoxStyle.Information)
        Else
            libelle = boxLib.Text
            num_cat = Val(boxCat.Text)
            Try
                connexion.Open()
                Dim rUpdate As String = "UPDATE `type_transac` SET `libelle_type` = '" & ChangeCaratere(libelle, CaractereType.Guillemet) & "', `num_cat` = '" & num_cat & "' WHERE `num_type` = " & num_lib
                Dim cmd As New MySqlCommand(rUpdate, connexion)
                Dim vraie = cmd.ExecuteNonQuery()
                If vraie Then
                    MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                    boxCat.Text = ""
                    boxLib.Text = ""
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If
                'rafraîchissement du datagridview
                Dim rSelect As String = "SELECT * FROM `type_transac`"
                Dim cmdN As New MySqlCommand(rSelect, connexion)
                cmdN.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmdN)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "type_transac")
                DataGridView1.DataSource = dataset.Tables("type_transac")

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        Try
            connexion.Open()
            Dim rDelete As String = "DELETE FROM `type_transac` WHERE `num_type` = " & num_lib
            Dim cmd As New MySqlCommand(rDelete, connexion)
            Dim vraie = cmd.ExecuteNonQuery()
            If vraie Then
                MsgBox("L'enregistrement a été supprimé avec succès!", MsgBoxStyle.Information)
                boxLib.Text = ""
                boxCat.Text = ""
            Else
                MsgBox("Erreur!", MsgBoxStyle.Critical)
            End If
            'rafraichissement du datagrid
            Dim rSelect As String = "SELECT * FROM `type_transac`"
            Dim cmdN As New MySqlCommand(rSelect, connexion)
            cmdN.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmdN)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "type_transac")
            DataGridView1.DataSource = dataset.Tables("type_transac")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub
End Class
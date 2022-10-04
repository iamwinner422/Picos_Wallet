Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class fdepenses

    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=picos_wallet")
    Private Sub fdepenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generationRapport()
        'Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub generationRapport()
        Dim dataTable As New DataTable
        Dim con As String = "server=localhost;User Id=root;database=picos_wallet"
        Dim connexion As New MySqlConnection(con)

        Try
            connexion.Open()
            Dim adaptateur As New MySqlDataAdapter("SELECT  comment_tst, montant_tst, heure_tst, date_tst, libelle_type FROM utilisateurs U, transactions T, type_transac R, portefeuilles P WHERE P.num_user = U.num_user AND T.num_ptf = P.num_ptf AND R.num_type = T.num_type AND T.num_ptf = P.num_ptf AND R.num_cat = 2 AND P.num_ptf = " & MenuPrincipal.num_ptf & " AND U.num_user = " & MenuPrincipal.num_user & " ORDER BY T.num_tst DESC", connexion)
            adaptateur.Fill(dataTable)
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Dim rpt As New ReportDataSource("DataSet1", dataTable)
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

        
    End Sub
End Class
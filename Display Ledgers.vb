Imports System
Imports System.Data.Odbc
Public Class Display_Ledgers
    Public Sub con()
        Dim MyConString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection As New OdbcConnection(MyConString)
        Dim MyCommand As New OdbcCommand
        MyCommand.Connection = MyConnection
        Dim adapter As New OdbcDataAdapter
        Dim ds As New DataSet
        Dim qry As String
        qry = ("select * from l_new where select_head= '" & Cb_head.Text & "'")
        Try
            MyConnection.Open()
            adapter.SelectCommand = New OdbcCommand(qry, MyConnection)
            adapter.Fill(ds, "l_new")
            MyConnection.Close()
            If (ds.Tables(0).Rows.Count > 0) Then
                Me.DataGridView1.DataSource = ds.Tables(0)
            Else
                MsgBox("No record to display")
                Me.DataGridView1.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_ShowLedger_Click(sender As Object, e As EventArgs) Handles Btn_ShowLedger.Click
        Call con()
    End Sub
    Private Sub Display_Ledgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyConString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection As New OdbcConnection(MyConString)
        Dim MyCommand As New OdbcCommand
        MyCommand.Connection = MyConnection
        Dim adapter As New OdbcDataAdapter
        Dim ds As New DataSet
        Try
            MyConnection.Open()
            Dim qry As String
            qry = "select * from under_head"
            adapter.SelectCommand = New OdbcCommand(qry, MyConnection)
            Dim cb As New OdbcCommandBuilder(adapter)
            adapter.Fill(ds, "under_head1")
            Cb_head.DataSource = ds.Tables("under_head1")
            Cb_head.DisplayMember = ds.Tables("under_head1").Columns("Name").ToString()
            Cb_head.ValueMember = ds.Tables("under_head1").Columns("Id").ToString()
            adapter.Update(ds, "under_head1")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyConnection.Close()
    End Sub
End Class
Imports System
Imports System.Data.Odbc
Public Class Report1
    Public Sub con()
        Dim MyConString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection As New OdbcConnection(MyConString)
        Dim MyCommand As New OdbcCommand
        MyCommand.Connection = MyConnection
        Dim adapter As New OdbcDataAdapter
        Dim ds As New DataSet
        Dim qry As String
        qry = ("select * from voucher_entry where voucher_date= '" & Dtp_Date1.Text & "'")
        Try
            MyConnection.Open()
            adapter.SelectCommand = New OdbcCommand(qry, MyConnection)
            adapter.Fill(ds, "voucher_entry")
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

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click
        Call con()
    End Sub
End Class


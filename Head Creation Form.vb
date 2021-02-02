Imports System
Imports System.Data.Odbc
Public Class Head_Creation
    Public Sub con()
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
            adapter.Fill(ds, "under_head")
            MyConnection.Close()

            Dim row As DataRow = ds.Tables("under_head").NewRow
            row("ID") = Txt_Id.Text
            row("Name") = Txt_Name.Text
            ds.Tables("under_head").Rows.Add(row)

            adapter.Update(ds, "under_head")
            MsgBox("Head will be created")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        MyConnection.Close()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Call con()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub


    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Txt_Id.Clear()
        Txt_Name.Clear()
    End Sub
End Class
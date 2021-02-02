Imports System
Imports System.Data.Odbc
Public Class Ledger_Creation
    Public Sub con()
        Dim MyConString1 As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection1 As New OdbcConnection(MyConString1)
        Dim MyCommand2 As New OdbcCommand
        MyCommand2.Connection = MyConnection1
        Dim adapterN As New OdbcDataAdapter
        Dim ds3 As New DataSet
        Try
            MyConnection1.Open()
            Dim qry1 As String
            qry1 = "select * from l_new"
            adapterN.SelectCommand = New OdbcCommand(qry1, MyConnection1)
            Dim cb As New OdbcCommandBuilder(adapterN)
            adapterN.Fill(ds3, "l_new")
            MyConnection1.Close()

            Dim row1 As DataRow = ds3.Tables("l_new").NewRow
            row1("Ledger_ID") = Txt_Id.Text
            row1("Name") = Txt_Name.Text
            row1("Select_Head") = Cb_Head.Text
            ds3.Tables("l_New").Rows.Add(row1)

            adapterN.Update(ds3, "l_new")
            MsgBox("Ledger will be created")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyConnection1.Close()
    End Sub
    Private Sub Ledger_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Cb_Head.DataSource = ds.Tables("under_head1")
            Cb_Head.DisplayMember = ds.Tables("under_head1").Columns("Name").ToString()
            Cb_Head.ValueMember = ds.Tables("under_head1").Columns("Id").ToString()


            adapter.Update(ds, "under_head1")
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
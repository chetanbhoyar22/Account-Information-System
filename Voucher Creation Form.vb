Imports System
Imports System.Data.Odbc
Public Class Voucher_Creation
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
            qry1 = "select * from Voucher_Entry"
            adapterN.SelectCommand = New OdbcCommand(qry1, MyConnection1)
            Dim cb As New OdbcCommandBuilder(adapterN)
            adapterN.Fill(ds3, "Voucher_Entry")
            MyConnection1.Close()

            Dim row1 As DataRow = ds3.Tables("Voucher_Entry").NewRow
            row1("Voucher_Id") = Txt_Id.Text
            row1("Voucher_Date") = Dtp_Date.Text
            row1("Select_Ledger") = Cb_Ledger.Text
            row1("Amount") = Txt_Ammount.Text
            ds3.Tables("Voucher_Entry").Rows.Add(row1)

            adapterN.Update(ds3, "Voucher_Entry")
            MsgBox("Voucher entry successful")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyConnection1.Close()
    End Sub
    Private Sub Voucher_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyConString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection As New OdbcConnection(MyConString)
        Dim MyCommand As New OdbcCommand
        MyCommand.Connection = MyConnection
        Dim adapter As New OdbcDataAdapter
        Dim ds As New DataSet
        Try
            MyConnection.Open()
            Dim qry As String
            qry = "select * from l_new"
            adapter.SelectCommand = New OdbcCommand(qry, MyConnection)
            Dim cb As New OdbcCommandBuilder(adapter)
            adapter.Fill(ds, "l_new")
            Cb_Ledger.DataSource = ds.Tables("l_new")
            Cb_Ledger.DisplayMember = ds.Tables("l_new").Columns("Name").ToString()


            adapter.Update(ds, "l_new")
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
        Txt_Ammount.Clear()

    End Sub
End Class
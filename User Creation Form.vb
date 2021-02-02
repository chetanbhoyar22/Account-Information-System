Imports System
Imports System.Data.Odbc
Public Class User_Creation
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
            qry = "select * from user"
            adapter.SelectCommand = New OdbcCommand(qry, MyConnection)
            Dim cb As New OdbcCommandBuilder(adapter)
            adapter.Fill(ds, "user")
            MyConnection.Close()

            Dim row As DataRow = ds.Tables("user").NewRow
            row("name") = Txt_Name.Text
            row("address") = Txt_Address.Text
            row("user_name") = Txt_UserName.Text
            row("password") = Txt_Password.Text
            ds.Tables("user").Rows.Add(row)

            adapter.Update(ds, "user")
            MsgBox("User will be created")
            Login_Form.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        MyConnection.Close()
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If Txt_Password.Text = Txt_ConfirmPass.Text Then
            Call con()
        Else
            MsgBox("Password combination are not match ")
        End If
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Txt_Name.Clear()
        Txt_Address.Clear()
        Txt_UserName.Clear()
        Txt_Password.Clear()
    End Sub
End Class

Imports System
Imports System.Data.Odbc
Public Class Login_Form
    Public Sub con()
        Dim MyConString As String = "DRIVER={MySQL ODBC 8.0 ANSI Driver}; Data source=DSN_SystemAccount;" & "UID=root;" & "PASSWORD=12345;" & "DATABASE=SAIS;"
        Dim MyConnection As New OdbcConnection(MyConString)
        Dim MyCommand As New OdbcCommand
        MyCommand.Connection = MyConnection
        Dim Reader As OdbcDataReader
        Try
            MyConnection.Open()
            Dim qry As String
            qry = "select * from user where user_name='" & Txt_UserName.Text & "' and password='" & Txt_Password.Text & "' "
            MyCommand = New OdbcCommand(qry, MyConnection)
            Reader = MyCommand.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login successfully")
                Home_Page.Show()
                Me.Hide()
            Else
                MessageBox.Show("Enter valid user name and password")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MyConnection.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Call con()
    End Sub
End Class




Imports System.Windows.Forms

Public Class Home_Page

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private m_ChildFormNumber As Integer

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Head_Creation.MdiParent = Me
        Head_Creation.Show()
    End Sub

    Private Sub VoucherEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherEntryToolStripMenuItem.Click
        Voucher_Creation.MdiParent = Me
        Voucher_Creation.Show()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Ledger_Creation.MdiParent = Me
        Ledger_Creation.Show()
    End Sub
    Private Sub DisplayNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayNewToolStripMenuItem.Click
        Display_Head.MdiParent = Me
        Display_Head.Show()
    End Sub

    Private Sub DisplayLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayLedgerToolStripMenuItem.Click
        Display_Ledgers.MdiParent = Me
        Display_Ledgers.Show()
    End Sub

    Private Sub DateWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateWiseToolStripMenuItem.Click
        Report1.MdiParent = Me
        Report1.Show()
    End Sub

    Private Sub DateWiseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DateWiseToolStripMenuItem1.Click
        Report2.MdiParent = Me
        Report2.Show()
    End Sub
    Private Sub Home_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim message As String = "Do you want to exit application?"
        Dim caption As String = "Exit"
        Dim icon As Integer = MessageBoxIcon.Question
        Dim button As Integer = MessageBoxButtons.YesNo
        Dim result As DialogResult
        result = MessageBox.Show(Me, message, caption, button, icon)
        If result = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        About_Us.Show()
    End Sub
End Class

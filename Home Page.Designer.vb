<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Create_HeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoucherEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateWiseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Create_HeadToolStripMenuItem, Me.LedgerToolStripMenuItem, Me.VoucherEntryToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1007, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "Ledger"
        '
        'Create_HeadToolStripMenuItem
        '
        Me.Create_HeadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DisplayNewToolStripMenuItem})
        Me.Create_HeadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Create_HeadToolStripMenuItem.Name = "Create_HeadToolStripMenuItem"
        Me.Create_HeadToolStripMenuItem.Size = New System.Drawing.Size(127, 27)
        Me.Create_HeadToolStripMenuItem.Text = "&Create Head"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(192, 28)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'DisplayNewToolStripMenuItem
        '
        Me.DisplayNewToolStripMenuItem.Name = "DisplayNewToolStripMenuItem"
        Me.DisplayNewToolStripMenuItem.Size = New System.Drawing.Size(192, 28)
        Me.DisplayNewToolStripMenuItem.Text = "Display Head"
        '
        'LedgerToolStripMenuItem
        '
        Me.LedgerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.DisplayLedgerToolStripMenuItem})
        Me.LedgerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LedgerToolStripMenuItem.Name = "LedgerToolStripMenuItem"
        Me.LedgerToolStripMenuItem.Size = New System.Drawing.Size(80, 27)
        Me.LedgerToolStripMenuItem.Text = "&Ledger"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(205, 28)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'DisplayLedgerToolStripMenuItem
        '
        Me.DisplayLedgerToolStripMenuItem.Name = "DisplayLedgerToolStripMenuItem"
        Me.DisplayLedgerToolStripMenuItem.Size = New System.Drawing.Size(205, 28)
        Me.DisplayLedgerToolStripMenuItem.Text = "Display Ledger"
        '
        'VoucherEntryToolStripMenuItem
        '
        Me.VoucherEntryToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoucherEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.VoucherEntryToolStripMenuItem.Name = "VoucherEntryToolStripMenuItem"
        Me.VoucherEntryToolStripMenuItem.Size = New System.Drawing.Size(142, 27)
        Me.VoucherEntryToolStripMenuItem.Text = "&Voucher Entry"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateWiseToolStripMenuItem, Me.DateWiseToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(86, 27)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'DateWiseToolStripMenuItem
        '
        Me.DateWiseToolStripMenuItem.Name = "DateWiseToolStripMenuItem"
        Me.DateWiseToolStripMenuItem.Size = New System.Drawing.Size(164, 28)
        Me.DateWiseToolStripMenuItem.Text = "Day Wise"
        '
        'DateWiseToolStripMenuItem1
        '
        Me.DateWiseToolStripMenuItem1.Name = "DateWiseToolStripMenuItem1"
        Me.DateWiseToolStripMenuItem1.Size = New System.Drawing.Size(164, 28)
        Me.DateWiseToolStripMenuItem1.Text = "Date Wise"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 27)
        Me.ExitToolStripMenuItem.Text = "&About Us"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(57, 27)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1007, 571)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home_Page"
        Me.Text = "Home Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Create_HeadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateWiseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

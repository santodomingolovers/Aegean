<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aegean
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aegean))
        Me.TextReturn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextDestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Xmr_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_timeout2 = New System.Windows.Forms.Label()
        Me.Label_countdown = New System.Windows.Forms.Label()
        Me.Label_timeout1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProxyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextReturn
        '
        Me.TextReturn.BackColor = System.Drawing.Color.Black
        Me.TextReturn.ForeColor = System.Drawing.Color.White
        Me.TextReturn.Location = New System.Drawing.Point(87, 170)
        Me.TextReturn.Name = "TextReturn"
        Me.TextReturn.Size = New System.Drawing.Size(258, 20)
        Me.TextReturn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(86, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BTC Return Address"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(199, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextDestination
        '
        Me.TextDestination.BackColor = System.Drawing.Color.Black
        Me.TextDestination.ForeColor = System.Drawing.Color.White
        Me.TextDestination.Location = New System.Drawing.Point(87, 50)
        Me.TextDestination.Name = "TextDestination"
        Me.TextDestination.Size = New System.Drawing.Size(258, 20)
        Me.TextDestination.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(84, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Destination BTC Address"
        '
        'TextAmount
        '
        Me.TextAmount.BackColor = System.Drawing.Color.Black
        Me.TextAmount.ForeColor = System.Drawing.Color.White
        Me.TextAmount.Location = New System.Drawing.Point(88, 109)
        Me.TextAmount.Name = "TextAmount"
        Me.TextAmount.Size = New System.Drawing.Size(100, 20)
        Me.TextAmount.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(85, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "BTC Amount"
        '
        'Xmr_timer
        '
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Deposit Address:"
        Me.Label15.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(483, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 140)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(92, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "- - -"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(92, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "- - -"
        Me.Label13.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Deposit Amount:"
        Me.Label3.Visible = False
        '
        'Label_timeout2
        '
        Me.Label_timeout2.AutoSize = True
        Me.Label_timeout2.ForeColor = System.Drawing.Color.White
        Me.Label_timeout2.Location = New System.Drawing.Point(640, 268)
        Me.Label_timeout2.Name = "Label_timeout2"
        Me.Label_timeout2.Size = New System.Drawing.Size(98, 13)
        Me.Label_timeout2.TabIndex = 17
        Me.Label_timeout2.Text = "Seconds till timeout"
        Me.Label_timeout2.Visible = False
        '
        'Label_countdown
        '
        Me.Label_countdown.AutoSize = True
        Me.Label_countdown.Font = New System.Drawing.Font("Corbel", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_countdown.ForeColor = System.Drawing.Color.White
        Me.Label_countdown.Location = New System.Drawing.Point(651, 223)
        Me.Label_countdown.Name = "Label_countdown"
        Me.Label_countdown.Size = New System.Drawing.Size(163, 45)
        Me.Label_countdown.TabIndex = 15
        Me.Label_countdown.Text = "Label_cd"
        Me.Label_countdown.Visible = False
        '
        'Label_timeout1
        '
        Me.Label_timeout1.AutoSize = True
        Me.Label_timeout1.ForeColor = System.Drawing.Color.White
        Me.Label_timeout1.Location = New System.Drawing.Point(641, 210)
        Me.Label_timeout1.Name = "Label_timeout1"
        Me.Label_timeout1.Size = New System.Drawing.Size(79, 13)
        Me.Label_timeout1.TabIndex = 16
        Me.Label_timeout1.Text = "Label_timeout1"
        Me.Label_timeout1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProxyToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ExitToolStripMenuItem.Text = "Options"
        '
        'ProxyToolStripMenuItem
        '
        Me.ProxyToolStripMenuItem.Name = "ProxyToolStripMenuItem"
        Me.ProxyToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ProxyToolStripMenuItem.Text = "Proxy"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Aegean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(847, 303)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label_timeout1)
        Me.Controls.Add(Me.Label_timeout2)
        Me.Controls.Add(Me.Label_countdown)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextDestination)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextReturn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Aegean"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aegean"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextReturn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextDestination As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Xmr_timer As Timer
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_timeout2 As Label
    Friend WithEvents Label_countdown As Label
    Friend WithEvents Label_timeout1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProxyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
End Class

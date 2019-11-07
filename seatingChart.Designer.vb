<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seatingChart
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
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lstRows = New System.Windows.Forms.ListBox()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(270, 372)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(20, 20)
        Me.txtF.TabIndex = 31
        Me.txtF.Text = "-"
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtE
        '
        Me.txtE.Location = New System.Drawing.Point(230, 372)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(20, 20)
        Me.txtE.TabIndex = 30
        Me.txtE.Text = "-"
        Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(194, 372)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(20, 20)
        Me.txtD.TabIndex = 29
        Me.txtD.Text = "-"
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(151, 372)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(20, 20)
        Me.txtC.TabIndex = 28
        Me.txtC.Text = "-"
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(112, 372)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(20, 20)
        Me.txtB.TabIndex = 27
        Me.txtB.Text = "-"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(72, 372)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(20, 20)
        Me.txtA.TabIndex = 26
        Me.txtA.Text = "-"
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "F"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "E"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "C"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Row"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 61)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(120, 31)
        Me.btnDisplay.TabIndex = 18
        Me.btnDisplay.Text = "Display Stats"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 98)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(120, 82)
        Me.lstDisplay.TabIndex = 17
        '
        'lstRows
        '
        Me.lstRows.FormattingEnabled = True
        Me.lstRows.Location = New System.Drawing.Point(215, 13)
        Me.lstRows.Name = "lstRows"
        Me.lstRows.Size = New System.Drawing.Size(100, 329)
        Me.lstRows.TabIndex = 16
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(14, 373)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.Size = New System.Drawing.Size(20, 20)
        Me.txtRow.TabIndex = 32
        Me.txtRow.Text = "-"
        Me.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 374)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(9, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "|"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 360)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 388)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "|"
        '
        'seatingChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 409)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lstRows)
        Me.Name = "seatingChart"
        Me.Text = "seatingChart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtF As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents lstRows As ListBox
    Friend WithEvents txtRow As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class

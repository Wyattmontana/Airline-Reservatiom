﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assignFlyer
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
        Me.fName = New System.Windows.Forms.TextBox()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.fFlyer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fName
        '
        Me.fName.Location = New System.Drawing.Point(61, 24)
        Me.fName.Margin = New System.Windows.Forms.Padding(2)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(120, 20)
        Me.fName.TabIndex = 0
        '
        'lName
        '
        Me.lName.Location = New System.Drawing.Point(61, 62)
        Me.lName.Margin = New System.Windows.Forms.Padding(2)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(120, 20)
        Me.lName.TabIndex = 1
        '
        'fFlyer
        '
        Me.fFlyer.Location = New System.Drawing.Point(62, 99)
        Me.fFlyer.Margin = New System.Windows.Forms.Padding(2)
        Me.fFlyer.Name = "fFlyer"
        Me.fFlyer.Size = New System.Drawing.Size(120, 20)
        Me.fFlyer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Frequent Flyers Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Purchase Seat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(61, 164)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Nevermind"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'assignFlyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 207)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fFlyer)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.fName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "assignFlyer"
        Me.Text = "assignFlyer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fName As TextBox
    Friend WithEvents lName As TextBox
    Friend WithEvents fFlyer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
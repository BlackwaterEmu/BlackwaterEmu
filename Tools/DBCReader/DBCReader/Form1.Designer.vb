﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.DBCData = New System.Windows.Forms.ListView
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(2, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(670, 20)
        Me.txtFile.TabIndex = 1
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(678, 6)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(89, 20)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'DBCData
        '
        Me.DBCData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DBCData.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.DBCData.FullRowSelect = True
        Me.DBCData.GridLines = True
        Me.DBCData.Location = New System.Drawing.Point(2, 31)
        Me.DBCData.Name = "DBCData"
        Me.DBCData.Size = New System.Drawing.Size(765, 407)
        Me.DBCData.TabIndex = 3
        Me.DBCData.UseCompatibleStateImageBehavior = False
        Me.DBCData.View = System.Windows.Forms.View.Details
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(2, 441)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(764, 20)
        Me.ProgressBar.Step = 2
        Me.ProgressBar.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 462)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.DBCData)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFile)
        Me.Name = "Form1"
        Me.Text = "DBC Reader by UniX"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents DBCData As System.Windows.Forms.ListView
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource

End Class

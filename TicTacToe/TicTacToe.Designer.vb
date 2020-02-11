<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicTacToe
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
        Me.components = New System.ComponentModel.Container()
        Me.btnRow0Column0 = New System.Windows.Forms.Button()
        Me.btnRow0Column1 = New System.Windows.Forms.Button()
        Me.btnRow0Column2 = New System.Windows.Forms.Button()
        Me.lblGameStatus = New System.Windows.Forms.Label()
        Me.btnRow1Column2 = New System.Windows.Forms.Button()
        Me.btnRow1Column1 = New System.Windows.Forms.Button()
        Me.btnRow1Column0 = New System.Windows.Forms.Button()
        Me.btnRow2Column2 = New System.Windows.Forms.Button()
        Me.btnRow2Column1 = New System.Windows.Forms.Button()
        Me.btnRow2Column0 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ttpTipTacToe = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnRow0Column0
        '
        Me.btnRow0Column0.Location = New System.Drawing.Point(12, 50)
        Me.btnRow0Column0.Name = "btnRow0Column0"
        Me.btnRow0Column0.Size = New System.Drawing.Size(50, 50)
        Me.btnRow0Column0.TabIndex = 0
        Me.btnRow0Column0.UseVisualStyleBackColor = True
        '
        'btnRow0Column1
        '
        Me.btnRow0Column1.Location = New System.Drawing.Point(69, 50)
        Me.btnRow0Column1.Name = "btnRow0Column1"
        Me.btnRow0Column1.Size = New System.Drawing.Size(50, 50)
        Me.btnRow0Column1.TabIndex = 1
        Me.btnRow0Column1.UseVisualStyleBackColor = True
        '
        'btnRow0Column2
        '
        Me.btnRow0Column2.Location = New System.Drawing.Point(126, 50)
        Me.btnRow0Column2.Name = "btnRow0Column2"
        Me.btnRow0Column2.Size = New System.Drawing.Size(50, 50)
        Me.btnRow0Column2.TabIndex = 2
        Me.btnRow0Column2.UseVisualStyleBackColor = True
        '
        'lblGameStatus
        '
        Me.lblGameStatus.Location = New System.Drawing.Point(12, 24)
        Me.lblGameStatus.Name = "lblGameStatus"
        Me.lblGameStatus.Size = New System.Drawing.Size(164, 23)
        Me.lblGameStatus.TabIndex = 3
        Me.lblGameStatus.Text = "X's Turn"
        Me.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRow1Column2
        '
        Me.btnRow1Column2.Location = New System.Drawing.Point(126, 106)
        Me.btnRow1Column2.Name = "btnRow1Column2"
        Me.btnRow1Column2.Size = New System.Drawing.Size(50, 50)
        Me.btnRow1Column2.TabIndex = 6
        Me.btnRow1Column2.UseVisualStyleBackColor = True
        '
        'btnRow1Column1
        '
        Me.btnRow1Column1.Location = New System.Drawing.Point(69, 106)
        Me.btnRow1Column1.Name = "btnRow1Column1"
        Me.btnRow1Column1.Size = New System.Drawing.Size(50, 50)
        Me.btnRow1Column1.TabIndex = 5
        Me.btnRow1Column1.UseVisualStyleBackColor = True
        '
        'btnRow1Column0
        '
        Me.btnRow1Column0.Location = New System.Drawing.Point(12, 106)
        Me.btnRow1Column0.Name = "btnRow1Column0"
        Me.btnRow1Column0.Size = New System.Drawing.Size(50, 50)
        Me.btnRow1Column0.TabIndex = 4
        Me.btnRow1Column0.UseVisualStyleBackColor = True
        '
        'btnRow2Column2
        '
        Me.btnRow2Column2.Location = New System.Drawing.Point(126, 162)
        Me.btnRow2Column2.Name = "btnRow2Column2"
        Me.btnRow2Column2.Size = New System.Drawing.Size(50, 50)
        Me.btnRow2Column2.TabIndex = 9
        Me.btnRow2Column2.UseVisualStyleBackColor = True
        '
        'btnRow2Column1
        '
        Me.btnRow2Column1.Location = New System.Drawing.Point(69, 162)
        Me.btnRow2Column1.Name = "btnRow2Column1"
        Me.btnRow2Column1.Size = New System.Drawing.Size(50, 50)
        Me.btnRow2Column1.TabIndex = 8
        Me.btnRow2Column1.UseVisualStyleBackColor = True
        '
        'btnRow2Column0
        '
        Me.btnRow2Column0.Location = New System.Drawing.Point(12, 162)
        Me.btnRow2Column0.Name = "btnRow2Column0"
        Me.btnRow2Column0.Size = New System.Drawing.Size(50, 50)
        Me.btnRow2Column0.TabIndex = 7
        Me.btnRow2Column0.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(12, 228)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(164, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset Game"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmTicTacToe
        '
        Me.AcceptButton = Me.btnRow1Column1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(192, 283)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRow2Column2)
        Me.Controls.Add(Me.btnRow2Column1)
        Me.Controls.Add(Me.btnRow2Column0)
        Me.Controls.Add(Me.btnRow1Column2)
        Me.Controls.Add(Me.btnRow1Column1)
        Me.Controls.Add(Me.btnRow1Column0)
        Me.Controls.Add(Me.lblGameStatus)
        Me.Controls.Add(Me.btnRow0Column2)
        Me.Controls.Add(Me.btnRow0Column1)
        Me.Controls.Add(Me.btnRow0Column0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicTacToe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRow0Column0 As Button
    Friend WithEvents btnRow0Column1 As Button
    Friend WithEvents btnRow0Column2 As Button
    Friend WithEvents lblGameStatus As Label
    Friend WithEvents btnRow1Column2 As Button
    Friend WithEvents btnRow1Column1 As Button
    Friend WithEvents btnRow1Column0 As Button
    Friend WithEvents btnRow2Column2 As Button
    Friend WithEvents btnRow2Column1 As Button
    Friend WithEvents btnRow2Column0 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ttpTipTacToe As ToolTip
End Class

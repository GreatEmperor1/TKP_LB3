<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TxtOp1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOp2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Bt_Late = New System.Windows.Forms.Button()
        Me.Bt_ID = New System.Windows.Forms.Button()
        Me.Bt_vtbl = New System.Windows.Forms.Button()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtOp1
        '
        Me.TxtOp1.Location = New System.Drawing.Point(12, 75)
        Me.TxtOp1.Name = "TxtOp1"
        Me.TxtOp1.Size = New System.Drawing.Size(119, 20)
        Me.TxtOp1.TabIndex = 0
        Me.TxtOp1.Text = "5"
        Me.TxtOp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Операнд №1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(161, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Операнд №2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOp2
        '
        Me.txtOp2.Location = New System.Drawing.Point(161, 75)
        Me.txtOp2.Name = "txtOp2"
        Me.txtOp2.Size = New System.Drawing.Size(119, 20)
        Me.txtOp2.TabIndex = 2
        Me.txtOp2.Text = "10"
        Me.txtOp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(308, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Результат"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(308, 75)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(119, 20)
        Me.txtResult.TabIndex = 4
        Me.txtResult.Text = "txtResult"
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bt_Late
        '
        Me.Bt_Late.Location = New System.Drawing.Point(12, 200)
        Me.Bt_Late.Name = "Bt_Late"
        Me.Bt_Late.Size = New System.Drawing.Size(119, 31)
        Me.Bt_Late.TabIndex = 6
        Me.Bt_Late.Text = "Late Binding"
        Me.Bt_Late.UseVisualStyleBackColor = True
        '
        'Bt_ID
        '
        Me.Bt_ID.Location = New System.Drawing.Point(161, 200)
        Me.Bt_ID.Name = "Bt_ID"
        Me.Bt_ID.Size = New System.Drawing.Size(119, 31)
        Me.Bt_ID.TabIndex = 7
        Me.Bt_ID.Text = "ID Binding"
        Me.Bt_ID.UseVisualStyleBackColor = True
        '
        'Bt_vtbl
        '
        Me.Bt_vtbl.Location = New System.Drawing.Point(308, 200)
        Me.Bt_vtbl.Name = "Bt_vtbl"
        Me.Bt_vtbl.Size = New System.Drawing.Size(119, 31)
        Me.Bt_vtbl.TabIndex = 8
        Me.Bt_vtbl.Text = "VTBL Binding"
        Me.Bt_vtbl.UseVisualStyleBackColor = True
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(12, 159)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(119, 20)
        Me.txtTime1.TabIndex = 9
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(161, 159)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(119, 20)
        Me.txtTime2.TabIndex = 10
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(308, 159)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(119, 20)
        Me.txtTime3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Time1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(161, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Time2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(311, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Time3"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 270)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.Bt_vtbl)
        Me.Controls.Add(Me.Bt_ID)
        Me.Controls.Add(Me.Bt_Late)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOp2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOp1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOp2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Bt_Late As Button
    Friend WithEvents Bt_ID As Button
    Friend WithEvents Bt_vtbl As Button
    Friend WithEvents txtTime1 As TextBox
    Friend WithEvents txtTime2 As TextBox
    Friend WithEvents txtTime3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

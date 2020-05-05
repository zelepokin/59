<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.B1 = New System.Windows.Forms.Button()
        Me.TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ts = New System.Windows.Forms.TextBox()
        Me.Tk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(373, 277)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(131, 73)
        Me.B1.TabIndex = 0
        Me.B1.Text = "Обчислити"
        Me.B1.UseVisualStyleBackColor = True
        '
        'TB
        '
        Me.TB.Location = New System.Drawing.Point(47, 170)
        Me.TB.Multiline = True
        Me.TB.Name = "TB"
        Me.TB.Size = New System.Drawing.Size(245, 23)
        Me.TB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "k"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "S"
        '
        'Ts
        '
        Me.Ts.Location = New System.Drawing.Point(573, 70)
        Me.Ts.Multiline = True
        Me.Ts.Name = "Ts"
        Me.Ts.Size = New System.Drawing.Size(157, 48)
        Me.Ts.TabIndex = 2
        '
        'Tk
        '
        Me.Tk.Location = New System.Drawing.Point(573, 145)
        Me.Tk.Multiline = True
        Me.Tk.Name = "Tk"
        Me.Tk.Size = New System.Drawing.Size(157, 48)
        Me.Tk.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Введіть число "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tk)
        Me.Controls.Add(Me.Ts)
        Me.Controls.Add(Me.TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ts As TextBox
    Friend WithEvents Tk As TextBox
    Friend WithEvents Label3 As Label
End Class

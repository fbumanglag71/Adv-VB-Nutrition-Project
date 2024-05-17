<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nutrition
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Food:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calories per serving"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grams of fat per serving"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(198, 47)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(100, 20)
        Me.txtFood.TabIndex = 3
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(235, 101)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(63, 20)
        Me.txtCalories.TabIndex = 4
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(235, 146)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(63, 20)
        Me.txtFat.TabIndex = 5
        '
        'txtResults
        '
        Me.txtResults.Enabled = False
        Me.txtResults.Location = New System.Drawing.Point(94, 270)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(219, 62)
        Me.txtResults.TabIndex = 7
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(94, 213)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(204, 23)
        Me.btnCompute.TabIndex = 8
        Me.btnCompute.Text = "Compute % Calories from Fat"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFood As TextBox
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnCompute As Button
End Class

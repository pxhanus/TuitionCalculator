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
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.lblCreditHours = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.AutoSize = True
        Me.lblCourseLevelList.Location = New System.Drawing.Point(12, 18)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(72, 13)
        Me.lblCourseLevelList.TabIndex = 0
        Me.lblCourseLevelList.Text = "Course Level:"
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(15, 34)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(120, 56)
        Me.lstCourseLevels.TabIndex = 1
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(12, 105)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(218, 34)
        Me.lblTuition.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(155, 67)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboCreditHours.Location = New System.Drawing.Point(155, 34)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(65, 21)
        Me.cboCreditHours.TabIndex = 4
        '
        'lblCreditHours
        '
        Me.lblCreditHours.AutoSize = True
        Me.lblCreditHours.Location = New System.Drawing.Point(152, 18)
        Me.lblCreditHours.Name = "lblCreditHours"
        Me.lblCreditHours.Size = New System.Drawing.Size(68, 13)
        Me.lblCreditHours.TabIndex = 5
        Me.lblCreditHours.Text = "Credit Hours:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 148)
        Me.Controls.Add(Me.lblCreditHours)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTuition)
        Me.Controls.Add(Me.lstCourseLevels)
        Me.Controls.Add(Me.lblCourseLevelList)
        Me.Name = "Form1"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents lblTuition As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox
    Friend WithEvents lblCreditHours As System.Windows.Forms.Label

End Class

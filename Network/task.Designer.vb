<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class task
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtTaskContainer = New System.Windows.Forms.Label()
        Me.txtPriority = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.Label()
        Me.lblTaskInTask = New System.Windows.Forms.Label()
        Me.lblSetDate = New System.Windows.Forms.Label()
        Me.lblDeadline = New System.Windows.Forms.Label()
        Me.lblTaskList = New System.Windows.Forms.Label()
        Me.lblTaskId = New System.Windows.Forms.Label()
        Me.lblPriorityInNumber = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblSetTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtTaskContainer
        '
        Me.txtTaskContainer.AutoSize = True
        Me.txtTaskContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaskContainer.Location = New System.Drawing.Point(3, 6)
        Me.txtTaskContainer.Name = "txtTaskContainer"
        Me.txtTaskContainer.Size = New System.Drawing.Size(21, 15)
        Me.txtTaskContainer.TabIndex = 3
        Me.txtTaskContainer.Text = "he"
        Me.ToolTip1.SetToolTip(Me.txtTaskContainer, "Task Title")
        '
        'txtPriority
        '
        Me.txtPriority.AutoSize = True
        Me.txtPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPriority.Location = New System.Drawing.Point(119, 6)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(17, 15)
        Me.txtPriority.TabIndex = 4
        Me.txtPriority.Text = "D"
        Me.ToolTip1.SetToolTip(Me.txtPriority, "Priority Level")
        '
        'txtTimer
        '
        Me.txtTimer.AutoSize = True
        Me.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimer.Location = New System.Drawing.Point(139, 6)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(41, 15)
        Me.txtTimer.TabIndex = 5
        Me.txtTimer.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.txtTimer, "Time left: Days Hours:Minutes:Seconds")
        '
        'lblTaskInTask
        '
        Me.lblTaskInTask.AutoSize = True
        Me.lblTaskInTask.Location = New System.Drawing.Point(3, 41)
        Me.lblTaskInTask.Name = "lblTaskInTask"
        Me.lblTaskInTask.Size = New System.Drawing.Size(31, 13)
        Me.lblTaskInTask.TabIndex = 6
        Me.lblTaskInTask.Text = "Task"
        '
        'lblSetDate
        '
        Me.lblSetDate.AutoSize = True
        Me.lblSetDate.Location = New System.Drawing.Point(3, 64)
        Me.lblSetDate.Name = "lblSetDate"
        Me.lblSetDate.Size = New System.Drawing.Size(45, 13)
        Me.lblSetDate.TabIndex = 7
        Me.lblSetDate.Text = "set date"
        '
        'lblDeadline
        '
        Me.lblDeadline.AutoSize = True
        Me.lblDeadline.Location = New System.Drawing.Point(3, 87)
        Me.lblDeadline.Name = "lblDeadline"
        Me.lblDeadline.Size = New System.Drawing.Size(47, 13)
        Me.lblDeadline.TabIndex = 8
        Me.lblDeadline.Text = "deadline"
        '
        'lblTaskList
        '
        Me.lblTaskList.AutoSize = True
        Me.lblTaskList.Location = New System.Drawing.Point(3, 109)
        Me.lblTaskList.Name = "lblTaskList"
        Me.lblTaskList.Size = New System.Drawing.Size(39, 13)
        Me.lblTaskList.TabIndex = 9
        Me.lblTaskList.Text = "tasklist"
        '
        'lblTaskId
        '
        Me.lblTaskId.AutoSize = True
        Me.lblTaskId.Location = New System.Drawing.Point(3, 196)
        Me.lblTaskId.Name = "lblTaskId"
        Me.lblTaskId.Size = New System.Drawing.Size(45, 13)
        Me.lblTaskId.TabIndex = 10
        Me.lblTaskId.Text = "Task ID"
        Me.lblTaskId.Visible = False
        '
        'lblPriorityInNumber
        '
        Me.lblPriorityInNumber.AutoSize = True
        Me.lblPriorityInNumber.Location = New System.Drawing.Point(3, 173)
        Me.lblPriorityInNumber.Name = "lblPriorityInNumber"
        Me.lblPriorityInNumber.Size = New System.Drawing.Size(38, 13)
        Me.lblPriorityInNumber.TabIndex = 11
        Me.lblPriorityInNumber.Text = "Priority"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(3, 133)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(47, 13)
        Me.lblEndTime.TabIndex = 12
        Me.lblEndTime.Text = "end time"
        '
        'lblSetTime
        '
        Me.lblSetTime.AutoSize = True
        Me.lblSetTime.Location = New System.Drawing.Point(5, 151)
        Me.lblSetTime.Name = "lblSetTime"
        Me.lblSetTime.Size = New System.Drawing.Size(43, 13)
        Me.lblSetTime.TabIndex = 13
        Me.lblSetTime.Text = "set time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblSetTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblPriorityInNumber)
        Me.Controls.Add(Me.lblTaskId)
        Me.Controls.Add(Me.lblTaskList)
        Me.Controls.Add(Me.lblDeadline)
        Me.Controls.Add(Me.lblSetDate)
        Me.Controls.Add(Me.lblTaskInTask)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.txtTaskContainer)
        Me.Name = "task"
        Me.Size = New System.Drawing.Size(209, 28)
        Me.ToolTip1.SetToolTip(Me, "Task, Priority Level between A-E, Time left: Days Hours:Minutes:Seconds")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTaskContainer As System.Windows.Forms.Label
    Friend WithEvents txtPriority As System.Windows.Forms.Label
    Friend WithEvents txtTimer As System.Windows.Forms.Label
    Friend WithEvents lblTaskInTask As System.Windows.Forms.Label
    Friend WithEvents lblSetDate As System.Windows.Forms.Label
    Friend WithEvents lblDeadline As System.Windows.Forms.Label
    Friend WithEvents lblTaskList As System.Windows.Forms.Label
    Friend WithEvents lblTaskId As System.Windows.Forms.Label
    Friend WithEvents lblPriorityInNumber As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblSetTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

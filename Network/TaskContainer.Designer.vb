<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskContainer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTaskInBrother = New System.Windows.Forms.TextBox()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPEndTimeInBrother = New System.Windows.Forms.DateTimePicker()
        Me.DTPSetTimeInBrother = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPDeadlineInBrother = New System.Windows.Forms.DateTimePicker()
        Me.DTPSetDateInBrother = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxAssignedTo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTaskListInBrother = New System.Windows.Forms.TextBox()
        Me.ComboBoxTaskListInBrother = New System.Windows.Forms.ComboBox()
        Me.txtPriorityInBrother = New System.Windows.Forms.TextBox()
        Me.lblPriorityInBrother = New System.Windows.Forms.Label()
        Me.sliderPriority = New System.Windows.Forms.TrackBar()
        Me.lblTaskId = New System.Windows.Forms.Label()
        Me.txtTaskListInBrother2 = New System.Windows.Forms.TextBox()
        Me.txtTitleInBrother = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdAmendTask = New System.Windows.Forms.Button()
        Me.cmdDeleteTask = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sliderPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Task List:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Priority:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Set Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Deadline:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(682, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Time-left:"
        '
        'txtTaskInBrother
        '
        Me.txtTaskInBrother.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskInBrother.Location = New System.Drawing.Point(14, 444)
        Me.txtTaskInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTaskInBrother.Multiline = True
        Me.txtTaskInBrother.Name = "txtTaskInBrother"
        Me.txtTaskInBrother.Size = New System.Drawing.Size(1250, 400)
        Me.txtTaskInBrother.TabIndex = 32
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.BackColor = System.Drawing.Color.White
        Me.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(812, 287)
        Me.lblTimeLeft.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(209, 31)
        Me.lblTimeLeft.TabIndex = 12
        Me.lblTimeLeft.Text = "I'm a Priority Level"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTPEndTimeInBrother)
        Me.GroupBox1.Controls.Add(Me.DTPSetTimeInBrother)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DTPDeadlineInBrother)
        Me.GroupBox1.Controls.Add(Me.DTPSetDateInBrother)
        Me.GroupBox1.Controls.Add(Me.ComboBoxAssignedTo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTaskListInBrother)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTaskListInBrother)
        Me.GroupBox1.Controls.Add(Me.txtPriorityInBrother)
        Me.GroupBox1.Controls.Add(Me.lblPriorityInBrother)
        Me.GroupBox1.Controls.Add(Me.sliderPriority)
        Me.GroupBox1.Controls.Add(Me.lblTaskId)
        Me.GroupBox1.Controls.Add(Me.txtTaskListInBrother2)
        Me.GroupBox1.Controls.Add(Me.txtTitleInBrother)
        Me.GroupBox1.Controls.Add(Me.lblTimeLeft)
        Me.GroupBox1.Controls.Add(Me.txtTaskInBrother)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(1278, 860)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'DTPEndTimeInBrother
        '
        Me.DTPEndTimeInBrother.CustomFormat = "HH:mm"
        Me.DTPEndTimeInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPEndTimeInBrother.Location = New System.Drawing.Point(472, 348)
        Me.DTPEndTimeInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DTPEndTimeInBrother.Name = "DTPEndTimeInBrother"
        Me.DTPEndTimeInBrother.ShowUpDown = True
        Me.DTPEndTimeInBrother.Size = New System.Drawing.Size(190, 31)
        Me.DTPEndTimeInBrother.TabIndex = 36
        '
        'DTPSetTimeInBrother
        '
        Me.DTPSetTimeInBrother.CustomFormat = "HH:mm"
        Me.DTPSetTimeInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSetTimeInBrother.Location = New System.Drawing.Point(134, 348)
        Me.DTPSetTimeInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DTPSetTimeInBrother.MaxDate = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.DTPSetTimeInBrother.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTPSetTimeInBrother.Name = "DTPSetTimeInBrother"
        Me.DTPSetTimeInBrother.ShowUpDown = True
        Me.DTPSetTimeInBrother.Size = New System.Drawing.Size(188, 31)
        Me.DTPSetTimeInBrother.TabIndex = 35
        Me.DTPSetTimeInBrother.Value = New Date(2012, 4, 19, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(338, 354)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 29)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "End Time:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 352)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 29)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Set Time:"
        '
        'DTPDeadlineInBrother
        '
        Me.DTPDeadlineInBrother.CustomFormat = "dd/MM/yyyy"
        Me.DTPDeadlineInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDeadlineInBrother.Location = New System.Drawing.Point(472, 285)
        Me.DTPDeadlineInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DTPDeadlineInBrother.Name = "DTPDeadlineInBrother"
        Me.DTPDeadlineInBrother.Size = New System.Drawing.Size(190, 31)
        Me.DTPDeadlineInBrother.TabIndex = 31
        '
        'DTPSetDateInBrother
        '
        Me.DTPSetDateInBrother.CustomFormat = "dd/MM/yyyy"
        Me.DTPSetDateInBrother.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSetDateInBrother.Location = New System.Drawing.Point(134, 285)
        Me.DTPSetDateInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DTPSetDateInBrother.MaxDate = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.DTPSetDateInBrother.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTPSetDateInBrother.Name = "DTPSetDateInBrother"
        Me.DTPSetDateInBrother.Size = New System.Drawing.Size(188, 31)
        Me.DTPSetDateInBrother.TabIndex = 30
        Me.DTPSetDateInBrother.Value = New Date(2012, 4, 19, 0, 0, 0, 0)
        '
        'ComboBoxAssignedTo
        '
        Me.ComboBoxAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAssignedTo.FormattingEnabled = True
        Me.ComboBoxAssignedTo.Location = New System.Drawing.Point(174, 42)
        Me.ComboBoxAssignedTo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBoxAssignedTo.Name = "ComboBoxAssignedTo"
        Me.ComboBoxAssignedTo.Size = New System.Drawing.Size(554, 33)
        Me.ComboBoxAssignedTo.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Assigned To:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 410)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 29)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Task:"
        '
        'txtTaskListInBrother
        '
        Me.txtTaskListInBrother.Enabled = False
        Me.txtTaskListInBrother.Location = New System.Drawing.Point(1006, 15)
        Me.txtTaskListInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTaskListInBrother.MaxLength = 20
        Me.txtTaskListInBrother.Name = "txtTaskListInBrother"
        Me.txtTaskListInBrother.Size = New System.Drawing.Size(74, 31)
        Me.txtTaskListInBrother.TabIndex = 23
        Me.txtTaskListInBrother.Visible = False
        '
        'ComboBoxTaskListInBrother
        '
        Me.ComboBoxTaskListInBrother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTaskListInBrother.FormattingEnabled = True
        Me.ComboBoxTaskListInBrother.Location = New System.Drawing.Point(174, 154)
        Me.ComboBoxTaskListInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBoxTaskListInBrother.Name = "ComboBoxTaskListInBrother"
        Me.ComboBoxTaskListInBrother.Size = New System.Drawing.Size(554, 33)
        Me.ComboBoxTaskListInBrother.TabIndex = 28
        '
        'txtPriorityInBrother
        '
        Me.txtPriorityInBrother.Location = New System.Drawing.Point(902, 17)
        Me.txtPriorityInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPriorityInBrother.Name = "txtPriorityInBrother"
        Me.txtPriorityInBrother.Size = New System.Drawing.Size(60, 31)
        Me.txtPriorityInBrother.TabIndex = 21
        Me.txtPriorityInBrother.Visible = False
        '
        'lblPriorityInBrother
        '
        Me.lblPriorityInBrother.AutoSize = True
        Me.lblPriorityInBrother.BackColor = System.Drawing.Color.White
        Me.lblPriorityInBrother.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriorityInBrother.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriorityInBrother.Location = New System.Drawing.Point(688, 210)
        Me.lblPriorityInBrother.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPriorityInBrother.Name = "lblPriorityInBrother"
        Me.lblPriorityInBrother.Size = New System.Drawing.Size(40, 39)
        Me.lblPriorityInBrother.TabIndex = 20
        Me.lblPriorityInBrother.Text = "E"
        '
        'sliderPriority
        '
        Me.sliderPriority.Location = New System.Drawing.Point(156, 202)
        Me.sliderPriority.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.sliderPriority.Maximum = 100
        Me.sliderPriority.Name = "sliderPriority"
        Me.sliderPriority.Size = New System.Drawing.Size(532, 90)
        Me.sliderPriority.TabIndex = 29
        '
        'lblTaskId
        '
        Me.lblTaskId.AutoSize = True
        Me.lblTaskId.Location = New System.Drawing.Point(762, 23)
        Me.lblTaskId.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTaskId.Name = "lblTaskId"
        Me.lblTaskId.Size = New System.Drawing.Size(79, 25)
        Me.lblTaskId.TabIndex = 18
        Me.lblTaskId.Text = "TaskID"
        Me.lblTaskId.Visible = False
        '
        'txtTaskListInBrother2
        '
        Me.txtTaskListInBrother2.Enabled = False
        Me.txtTaskListInBrother2.Location = New System.Drawing.Point(444, 154)
        Me.txtTaskListInBrother2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTaskListInBrother2.MaxLength = 20
        Me.txtTaskListInBrother2.Name = "txtTaskListInBrother2"
        Me.txtTaskListInBrother2.Size = New System.Drawing.Size(284, 31)
        Me.txtTaskListInBrother2.TabIndex = 7
        '
        'txtTitleInBrother
        '
        Me.txtTitleInBrother.Location = New System.Drawing.Point(174, 94)
        Me.txtTitleInBrother.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTitleInBrother.MaxLength = 255
        Me.txtTitleInBrother.Name = "txtTitleInBrother"
        Me.txtTitleInBrother.Size = New System.Drawing.Size(554, 31)
        Me.txtTitleInBrother.TabIndex = 27
        Me.txtTitleInBrother.Text = "I'm a Title"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(1184, 894)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(182, 69)
        Me.cmdCancel.TabIndex = 35
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(796, 894)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(182, 69)
        Me.cmdOK.TabIndex = 33
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdAmendTask
        '
        Me.cmdAmendTask.Location = New System.Drawing.Point(990, 894)
        Me.cmdAmendTask.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdAmendTask.Name = "cmdAmendTask"
        Me.cmdAmendTask.Size = New System.Drawing.Size(182, 69)
        Me.cmdAmendTask.TabIndex = 34
        Me.cmdAmendTask.Text = "Amend Task"
        Me.cmdAmendTask.UseVisualStyleBackColor = True
        '
        'cmdDeleteTask
        '
        Me.cmdDeleteTask.Location = New System.Drawing.Point(602, 894)
        Me.cmdDeleteTask.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdDeleteTask.Name = "cmdDeleteTask"
        Me.cmdDeleteTask.Size = New System.Drawing.Size(182, 69)
        Me.cmdDeleteTask.TabIndex = 36
        Me.cmdDeleteTask.Text = "Delete Task"
        Me.cmdDeleteTask.UseVisualStyleBackColor = True
        '
        'TaskContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(1484, 987)
        Me.Controls.Add(Me.cmdDeleteTask)
        Me.Controls.Add(Me.cmdAmendTask)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "TaskContainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Task"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sliderPriority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTaskInBrother As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTaskListInBrother2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTitleInBrother As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTaskId As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents sliderPriority As System.Windows.Forms.TrackBar
    Friend WithEvents lblPriorityInBrother As System.Windows.Forms.Label
    Friend WithEvents txtPriorityInBrother As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTaskListInBrother As System.Windows.Forms.ComboBox
    Friend WithEvents txtTaskListInBrother As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxAssignedTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DTPDeadlineInBrother As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSetDateInBrother As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAmendTask As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteTask As System.Windows.Forms.Button
    Friend WithEvents DTPEndTimeInBrother As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPSetTimeInBrother As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class

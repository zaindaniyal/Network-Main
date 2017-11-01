<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskList
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDeleteTaskList = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblToDoListID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-1, 39)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(220, 161)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Business"
        Me.ToolTip1.SetToolTip(Me.Label1, "Name of Tasklist")
        '
        'cmdDeleteTaskList
        '
        Me.cmdDeleteTaskList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdDeleteTaskList.FlatAppearance.BorderSize = 0
        Me.cmdDeleteTaskList.Location = New System.Drawing.Point(184, 10)
        Me.cmdDeleteTaskList.Name = "cmdDeleteTaskList"
        Me.cmdDeleteTaskList.Size = New System.Drawing.Size(27, 23)
        Me.cmdDeleteTaskList.TabIndex = 1
        Me.cmdDeleteTaskList.Tag = ""
        Me.cmdDeleteTaskList.Text = "x"
        Me.ToolTip1.SetToolTip(Me.cmdDeleteTaskList, "Click here to delete the task list")
        Me.cmdDeleteTaskList.UseVisualStyleBackColor = False
        '
        'lblToDoListID
        '
        Me.lblToDoListID.AutoSize = True
        Me.lblToDoListID.Location = New System.Drawing.Point(144, 20)
        Me.lblToDoListID.Name = "lblToDoListID"
        Me.lblToDoListID.Size = New System.Drawing.Size(71, 13)
        Me.lblToDoListID.TabIndex = 2
        Me.lblToDoListID.Text = "lblToDoListID"
        Me.lblToDoListID.Visible = False
        '
        'TaskList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblToDoListID)
        Me.Controls.Add(Me.cmdDeleteTaskList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "TaskList"
        Me.Size = New System.Drawing.Size(218, 198)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteTaskList As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblToDoListID As System.Windows.Forms.Label

End Class

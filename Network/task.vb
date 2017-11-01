Public Class task
    'Dim parent As Network
    Dim brother As TaskContainer
    'a datetime control is declared.
    Dim datetime1 As DateTime
    'a timespan control is declared.
    Dim timespan1 As TimeSpan

    ' This is a constructor
    Public Sub New(ByVal caller As TaskContainer)
        InitializeComponent()
        brother = caller
    End Sub

    'This is another constructor
    Public Sub New(ByVal caller As Network)
        InitializeComponent()
        parent = caller
    End Sub

    'This is another constructor
    Sub New()
        ' TODO: Complete member initialization 
        InitializeComponent()
    End Sub

    'this sub will run when Task button is clicked.
    Private Sub task_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        'calling another sub.
        OpenTask()
    End Sub

    'this sub runs when taskContainer textbox is clicked.
    Private Sub txtTaskContainer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaskContainer.Click
        'calling another sub.
        OpenTask()
    End Sub

    'this sub runs when Priority textbox is clicked.
    Private Sub txtPriority_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPriority.Click
        'calling another sub.
        OpenTask()
    End Sub

    'this sub runs when timer textbox is clicked.
    Private Sub txtTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimer.Click
        'calling another sub.
        OpenTask()
    End Sub

    'this sub is called from other places.
    Private Sub OpenTask()
        'declaring a new object
        brother = New TaskContainer(False)
        'show the new object.
        brother.Show()
        'put the information from the task object into the TaskContainer object.
        brother.txtTaskInBrother.Text = lblTaskInTask.Text
        brother.txtTaskListInBrother2.Text = lblTaskList.Text
        brother.txtTitleInBrother.Text = txtTaskContainer.Text
        brother.DTPDeadlineInBrother.Text = lblDeadline.Text
        brother.lblPriorityInBrother.Text = txtPriority.Text
        brother.DTPSetDateInBrother.Text = lblSetDate.Text

        brother.DTPSetTimeInBrother.Text = lblSetTime.Text
        brother.DTPEndTimeInBrother.Text = lblEndTime.Text
        brother.lblTaskId.Text = lblTaskId.Text
        brother.sliderPriority.Value = lblPriorityInNumber.Text
        'making the slider disappear.
        brother.sliderPriority.Visible = False
        'setting the position of the piority textbox.. to 87
        brother.lblPriorityInBrother.Left = 87
        'calling another sub.
        MakeTextboxesReadOnly()
        brother.ComboBoxTaskListInBrother.DropDownStyle = ComboBoxStyle.DropDown
        brother.ComboBoxTaskListInBrother.Text = lblTaskList.Text
        brother.ComboBoxAssignedTo.DropDownStyle = ComboBoxStyle.DropDown
        brother.ComboBoxAssignedTo.Text = "Myself..."
    End Sub

    'this sub makes the text boxes un-editable. This sub is called from other places.
    Private Sub MakeTextboxesReadOnly()
        'setting the textboxes to readonly and disabled.
        brother.txtTitleInBrother.ReadOnly = True
        brother.txtTaskInBrother.ReadOnly = True
        brother.DTPSetDateInBrother.Enabled = False
        brother.txtTaskListInBrother2.ReadOnly = True
        brother.DTPDeadlineInBrother.Enabled = False
        brother.ComboBoxAssignedTo.Enabled = False
        brother.ComboBoxTaskListInBrother.Enabled = False
        brother.DTPEndTimeInBrother.Enabled = False
        brother.DTPSetDateInBrother.Enabled = False
    End Sub

    'this sub runs each time the timer ticks
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'datetime1 is given a value of a date and time.
        datetime1 = lblDeadline.Text & " " & lblEndTime.Text
        'the difference between teh current datetime and the deadline is worked out.
        timespan1 = datetime1.Subtract(Now)
        'the differen is shown in the txt timer.
        txtTimer.Text = timespan1.Days & " " & timespan1.Hours & ":" & timespan1.Minutes & ":" & timespan1.Seconds
    End Sub
End Class

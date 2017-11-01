Imports System.Data.OleDb
Public Class TaskContainer
    'Network is referred to as mom.
    Dim mom As Network
    'a new data table is declared in memmory.
    Dim dt As New DataTable
    'a boolean is declared.
    Dim isnew As Boolean
    'a datetime control is declared.
    Dim datetime1 As DateTime
    'a timespace control is declared.
    Dim timespan1 As TimeSpan

    'this is a constructor
    Public Sub New(ByVal caller As Network)
        InitializeComponent()
    End Sub

    'this a constructor
    Sub New(ByVal isThisANewRecord As Boolean)
        InitializeComponent()
        isnew = isThisANewRecord
    End Sub

    'this sub is called from other places.
    Public Sub MakeTextboxesEditable()
        'the following bit of code makes the necessary textboxes editable
        DTPDeadlineInBrother.Enabled = True
        DTPSetDateInBrother.Enabled = True
        DTPSetTimeInBrother.Enabled = True
        DTPEndTimeInBrother.Enabled = True
        txtTaskInBrother.ReadOnly = False
        txtTaskListInBrother2.ReadOnly = False
        txtTitleInBrother.ReadOnly = False
    End Sub

    'this sub runs when OK button is pressed.
    Public Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        'if the isnew boolean is true, the followbit of code will run.
        If isnew = True Then
            ''the following code means that make sure that all the text boxes are filled in before the user can insert a new task.
            If txtTaskListInBrother.Text = "" Or txtTaskInBrother.Text = "" Or txtTitleInBrother.Text = "" Or ComboBoxAssignedTo.Text = "" Or txtTaskListInBrother.Text = "New..." Then
                MsgBox("Please fill all the textboxes.")
            Else
                'if no text box is left empty, insert the task into the database.
                If isnew = True Then
                    'different subs are called for inserting a new task and refreshing the form so that the new task appears in the right place.
                    Network.PutTasksIntoDataBase()
                    Network.SignOutResembles()
                    Network.RetrieveTasks()
                    Network.OtherNecessaryStuff()
                    Me.Close()
                Else
                End If
            End If
            'the following code if isnew boolean is false. The following code follows the same structure.
        ElseIf cmdAmendTask.Enabled = False Then
            If txtTaskListInBrother.Text = "" Or txtTaskInBrother.Text = "" Or txtTitleInBrother.Text = "" Or ComboBoxAssignedTo.Text = "" Then
                MsgBox("Please fill all the textboxes.")
            Else
                UpdatePersonalTasks()
                Network.SignOutResembles()
                Network.RetrieveTasks()
                Network.OtherNecessaryStuff()
                Me.Close()
            End If
        Else
            Me.Close()
        End If



    End Sub

    'this sub is called from other places.
    Public Sub EmptyTextBoxes()
        'the following code empties all the textboxes.
        ComboBoxAssignedTo.Text = ""
        ComboBoxTaskListInBrother.Text = ""
        sliderPriority.Value = 0
        txtTaskListInBrother2.Clear()
        lblPriorityInBrother.Text = ""
        txtTaskInBrother.Clear()
        txtTitleInBrother.Clear()
        lblTimeLeft.Text = ""
        txtTaskListInBrother.Clear()
    End Sub

    'this sub is called from other places.
    Private Sub UpdatePersonalTasks()
        'this sub updates a task. It changes its contents
        'try-catch block
        Try
            'thsi string the sql statement for updating a task.
            Dim sqlString As String = "Update " & Network.Label10.Text & _
                        " set Priority = " & txtPriorityInBrother.Text & _
                        ", SetDate = '" & DTPSetDateInBrother.Text & _
                        "', DeadLine = '" & DTPDeadlineInBrother.Text & _
                        "', Subject = '" & txtTitleInBrother.Text & _
                        "', Task = '" & txtTaskInBrother.Text & _
                        "', ToDoList = '" & txtTaskListInBrother.Text & _
                        "' where ID = " & lblTaskId.Text
            Network.cn.Open()
            Network.da = New OleDbDataAdapter(sqlString, Network.cn)
            Network.cmd = New OleDbCommandBuilder(Network.da)
            dt.Clear()
            dt.Rows.Clear()
            dt.Columns.Clear()
            Network.da.Fill(dt)
            MsgBox("Task has been updated.")
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Network.cn.Close()
        End Try
    End Sub

    'This sub runs when Cancel button is pressed.
    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'this closes the taskContainer object
        Me.Close()
    End Sub

    'this sub runs when the value of the trackbar is changed.
    Private Sub sliderPriority_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sliderPriority.Scroll
        'the text property of the priority textbox equals the value of the priority trackbar.
        txtPriorityInBrother.Text = Val(sliderPriority.Value)
        'the text property of the priority label equals the value of the priority trackbar.
        lblPriorityInBrother.Text = Val(sliderPriority.Value)
        'the following if statement changes the text of the lblpriority Label depending on the
        'the value of the trackbar.
        If lblPriorityInBrother.Text >= 80 Then
            lblPriorityInBrother.Text = "A"
        ElseIf lblPriorityInBrother.Text >= 60 Then
            lblPriorityInBrother.Text = "B"
        ElseIf lblPriorityInBrother.Text >= 40 Then
            lblPriorityInBrother.Text = "C"
        ElseIf lblPriorityInBrother.Text >= 20 Then
            lblPriorityInBrother.Text = "D"
        Else
            lblPriorityInBrother.Text = "E"
        End If
    End Sub

    'this sub runs when task list combo box's text is changed.
    Private Sub ComboBoxTaskListInBrother_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTaskListInBrother.TextChanged
        If Not ComboBoxTaskListInBrother.Text = "" Then
            If ComboBoxTaskListInBrother.Text = "New..." Then
                txtTaskListInBrother.Text = txtTaskListInBrother2.Text
                txtTaskListInBrother2.Enabled = True
                ComboBoxTaskListInBrother.Width = 127
            Else
                txtTaskListInBrother2.Enabled = False
                ComboBoxTaskListInBrother.Width = 279
            End If
        End If
        txtTaskListInBrother.Text = ComboBoxTaskListInBrother.Text
    End Sub

    'this sub runs when task list text box's text is changed.
    Private Sub txtTaskListInBrother2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaskListInBrother2.TextChanged
        txtTaskListInBrother.Text = txtTaskListInBrother2.Text
    End Sub

    'this sub runs when this object loads.
    Private Sub TaskContainer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'change the format of datebtimepickers.
        DTPDeadlineInBrother.CustomFormat = "dd/MM/yyyy"
        DTPSetDateInBrother.CustomFormat = "dd/MM/yyyy"
        DTPSetTimeInBrother.CustomFormat = "HH:mm"
        DTPEndTimeInBrother.CustomFormat = "HH:mm"
        'the minimum date of the deadline is the set date.
        'DTPDeadlineInBrother.MinDate = DTPSetDateInBrother.Text
        txtPriorityInBrother.Text = "1"
        DTPSetDateInBrother.Text = Now.Date
        DTPSetTimeInBrother.Text = Now.Hour & ":" & Now.Minute

        If isnew = True Then
            ComboBoxTaskListInBrother.Enabled = False
            cmdAmendTask.Enabled = False
        End If
    End Sub

    'this sub runs when a date is changed in the set date datetime picker.
    Private Sub DTPSetDateInBrother_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPSetDateInBrother.TextChanged
        If isnew = True Then
            DTPDeadlineInBrother.MinDate = DTPSetDateInBrother.Text
        End If
    End Sub

    'this sub runs when Assigned to combobox's text is changed.
    Private Sub ComboBoxAssignedTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAssignedTo.TextChanged
        If cmdAmendTask.Enabled = False Or isnew = True Then
            If ComboBoxAssignedTo.Text = "Myself..." Then
                ComboBoxTaskListInBrother.DropDownStyle = ComboBoxStyle.DropDownList
                ComboBoxTaskListInBrother.Items.Clear()
                For b = 0 To Network.LstTaskBox.Items.Count - 1
                    ComboBoxTaskListInBrother.Items.Add(Network.LstTaskBox.Items(b))
                Next
                ComboBoxTaskListInBrother.Items.Add("New...")
                ComboBoxTaskListInBrother.Enabled = True
                Try
                    Network.cn.Open()
                    Network.da = New OleDbDataAdapter("Select * from " & Network.Label10.Text & " Order by ID", Network.cn)
                    dt.Clear()
                    dt.Rows.Clear()
                    dt.Columns.Clear()
                    Network.da.Fill(dt)
                Catch ex As OleDbException
                    MsgBox(ex.Message)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Network.cn.Close()
                End Try
                Dim max As Integer = 0
                For x = 1 To dt.Rows.Count
                    If dt.Rows(x - 1)(0) > max Then
                        max = dt.Rows(x - 1)(0)
                    End If
                Next
                max = max + 1
                lblTaskId.Text = max
            Else
                ComboBoxTaskListInBrother.DropDownStyle = ComboBoxStyle.DropDown
                ComboBoxTaskListInBrother.Enabled = False
                ComboBoxTaskListInBrother.Text = "Work Desk"
                Try
                    Network.cn.Open()
                    Network.da = New OleDbDataAdapter("Select * from " & ComboBoxAssignedTo.Text & " Order by ID", Network.cn)
                    dt.Clear()
                    dt.Rows.Clear()
                    dt.Columns.Clear()
                    Network.da.Fill(dt)
                Catch ex As OleDbException
                    MsgBox(ex.Message)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Network.cn.Close()
                End Try
                Dim max As Integer = 0
                For x = 1 To dt.Rows.Count
                    If dt.Rows(x - 1)(0) > max Then
                        max = dt.Rows(x - 1)(0)
                    End If
                Next
                max = max + 1
                lblTaskId.Text = max
            End If
        End If
    End Sub

    'this sub runs when Amend Task button is clicked.
    Private Sub cmdAmendTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAmendTask.Click
        'enable the text boxes so that a task can be amended.
        txtTaskInBrother.Enabled = True
        ComboBoxTaskListInBrother.Enabled = True
        sliderPriority.Enabled = True
        sliderPriority.Visible = True
        lblPriorityInBrother.Left = 344
        DTPDeadlineInBrother.Enabled = True
        DTPSetDateInBrother.Enabled = True
        txtTitleInBrother.ReadOnly = False
        txtTaskInBrother.ReadOnly = False
        cmdAmendTask.Enabled = False
        ComboBoxAssignedTo.Text = "Myself..."
        For b = 0 To Network.LstTaskBox.Items.Count - 1
            ComboBoxTaskListInBrother.Items.Add(Network.LstTaskBox.Items(b))
        Next
        ComboBoxTaskListInBrother.Items.Add("New...")
    End Sub

    'this sub runs when Delete Task button is clicked.
    Private Sub cmdDeleteTask_Click(sender As System.Object, e As System.EventArgs) Handles cmdDeleteTask.Click
        If isnew = False Then
            'a msgbox carrying a yes, no and a question.
            Dim result1 As DialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Important Question", MessageBoxButtons.YesNo)
            'if the result is yes, a sql statement is sent to delete the desired task.
            If result1 = DialogResult.Yes Then
                'try-catch block
                Try
                    Network.cn.Open()
                    Network.da = New OleDbDataAdapter("Delete from Daniyal where ID = " & lblTaskId.Text, Network.cn)
                    Network.cmd = New OleDbCommandBuilder(Network.da)
                    dt.Clear()
                    dt.Rows.Clear()
                    dt.Columns.Clear()
                    Network.da.Fill(dt)
                Catch ex As OleDbException
                    MsgBox(ex.Message)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Network.cn.Close()
                End Try
                Network.SignOutResembles()
                Network.RetrieveTasks()
                Network.OtherNecessaryStuff()
                Me.Close()
            End If
        Else
            MsgBox("You cannot delete an un-saved task.")
        End If

    End Sub

    'this sub is called whenever the timer ticks
    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        'this sub calls another sub.
        CalculateDateDifference()
    End Sub

    'this sub is called from different places..
    Private Sub CalculateDateDifference()
        'the variable datetime1 is set a value.
        datetime1 = DTPDeadlineInBrother.Text & " " & DTPEndTimeInBrother.Text
        'a calculation is carried out in order to determine difference between computer's current date the deadline date and time.
        timespan1 = datetime1.Subtract(Now)
        'the difference in date is now showing as the text property of Time left label.
        lblTimeLeft.Text = timespan1.Days & " Days " & timespan1.Hours & " Hours " & timespan1.Minutes & " Minutes "
        If timespan1.Days <= 0 Then
            lblTimeLeft.BackColor = Color.Red
        Else
            lblTimeLeft.BackColor = Color.WhiteSmoke
        End If
    End Sub

    'this sub runs whenever text property of endtime datetimepicker is changed.
    Private Sub DTPEndTimeInBrother_TextChanged(sender As Object, e As System.EventArgs) Handles DTPEndTimeInBrother.TextChanged
        'this calls another sub.
        CalculateDateDifference()
    End Sub

    'this sub runs whenever the text property of deadline datetimepickeris changed.
    Private Sub DTPDeadlineInBrother_TextChanged(sender As Object, e As System.EventArgs) Handles DTPDeadlineInBrother.TextChanged
        'this calls another sub.
        CalculateDateDifference()
    End Sub
End Class
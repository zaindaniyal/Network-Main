'this is the oledb library.
Imports System.Data.OleDb
'this is console library.
Imports System.Console
'this is the text library.
Imports System.Text
'this is the math library.
Imports System.Math
'this is the main class.
Public Class Network
    'Public cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Customers.accdb;")
    'Public cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Customers.accdb;Jet OLEDB:Database Password=dfdfdfffd4")
    'the connection to connect to the database using SQL. This connection is declared public so that other classes can access it.
    Public cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Customers.mdb;Jet OLEDB:Database Password=dfdfdfffd4")
    'declaring command builder
    Public cmd As OleDbCommandBuilder
    'declaring command to be used in the connection.
    Public cmdd As OleDbCommand
    'declaring data adapter
    Public da As OleDbDataAdapter
    'declaring the data table
    Dim dt As New DataTable
    'declaring another data table
    Dim dt2 As New DataTable
    'declaring an integer
    Public nextLine As Integer = 0
    'assigns a name to a class. The object doesn't yet exist.
    Dim son As TaskContainer
    'assigns a name to a class. The object doesn't yet exist.
    Dim TaskList As TaskList
    'declaring an integer
    Dim PageNumber As Integer = 1
    'declaring a constant
    Const k As Integer = 31
    'declaring a constant
    Const l As Integer = 1160

    'constructor makes the object exist out of that  class which its in.
    Public Sub New(ByVal caller As TaskContainer)
        InitializeComponent()
        son = caller
    End Sub

    'constructor.
    Sub New()
        InitializeComponent()
    End Sub

    'this sub runs when the main form loads
    Private Sub Network_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'this sets the back colour of the form to Biege
        Me.BackColor = Color.Beige
        'This calls the named sub.
        RetrieveUserInformation()
        'this sets the text of the label with the name of lblInterfaceID to "1"
        lblInterfaceID.Text = 1
        'this calls the named sub.
        RefreshInterface()
        'this is a loop. It runs from 1937 to 2005 and in each run it add the text to a combo box.
        For x = 1937 To 2005
            ComboBoxYearOfBirth.Items.Add(x)
        Next
    End Sub

    'this sub is called from other places.
    Public Sub RetrieveTasks()
        'this code is in the try, catch block. 
        Try
            'this is opening the connection.
            cn.Open()
            'this is sending the instructions through data adapter.
            da = New OleDbDataAdapter("Select * from " & Label10.Text & " Order by ID", cn)
            'this clears the datatable.
            dt.Clear()
            'this clears the rows.
            dt.Rows.Clear()
            'this clears the columns.
            dt.Columns.Clear()
            'this fills the data table with the data coming from the database.
            da.Fill(dt)
            'if an exception is thrown by the anything related to the connection, it will get caught 
        Catch ex As OleDbException
            'this displays the error message.
            MsgBox(ex.Message)
            'if any other exception is throw, it will get caught here.
        Catch ex As Exception
            'this displays the error message.
            MsgBox(ex.Message)
            'this bit of code runs after the whole try-catch block has ran.
        Finally
            'closing the connection.
            cn.Close()
            'closing the Try-catch block
        End Try
    End Sub

    'this sub is called from other places.
    Private Sub RetrieveUserInformation()
        'this a try-catch block
        Try
            cn.Open()
            da = New OleDbDataAdapter("Select * from Users Order by ID", cn)
            dt2.Clear()
            dt2.Rows.Clear()
            dt2.Columns.Clear()
            da.Fill(dt2)
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
        'declaring an integer and giving it a value of 0
        Dim max As Integer = 0
        'running a loop 
        For x = 1 To dt2.Rows.Count
            'this is saying that if a certain position at datatable is more than max, max should equal that value.
            If dt2.Rows(x - 1)(5) > max Then
                max = dt2.Rows(x - 1)(5)
            End If
        Next
        'whatever max was, add 1 to it.
        max = max + 1
        'this label should have the value of max
        lblUserID.Text = max
    End Sub

    'this sub is called from other places.
    Private Sub CreateTable()
        Try
            'this string contains the instructions for creating a table.
            Dim SQL As String = "CREATE TABLE " & txtLastName.Text & " ([ID] NUMBER, [Priority] TEXT(3), [SetDate] TEXT(10), [DeadLine] TEXT(10), [Subject] TEXT(255), [Task] MEMO, [ToDoList] TEXT(20), [SetTime] TEXT(5), [EndTime] TEXT(5))"
            cn.Open()
            'oledb command is carrying the instructions to create the table.
            cmdd = New OleDbCommand(SQL, cn)
            'executing the query
            cmdd.ExecuteNonQuery()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'this sub is called from other places.
    Public Sub OtherNecessaryStuff()
        'runs a loop from 0 to the number of rows in the database - 1
        For x = 0 To dt.Rows.Count - 1
            'this is saying that if the item we are trying to add is not in the list box, add it.
            If Not LstTaskBox.Items.Contains(dt.Rows(x)(6)) Then
                LstTaskBox.Items.Add(dt.Rows(x)(6))
            End If
        Next
        'assigning a name to a class.
        Dim newTask As task
        'running a loop from 0 to the number of items in the list box.
        For x = 0 To LstTaskBox.Items.Count - 1
            'creating a new object from the tasklist class.
            Dim TaskList As New TaskList(Me)
            'naming the tasklist.
            TaskList.Name = LstTaskBox.Items(x)
            'setting the text property of the label in the task list.
            TaskList.Label1.Text = LstTaskBox.Items(x)
            'adding the task list into the main flow layout panel.
            FloLayTaskListContainer.Controls.Add(TaskList)
        Next
        'running a loop from 0 to number of items in the database.
        For f = 0 To dt.Rows.Count - 1
            'running another loop. this will run for each task list which was added to the main flow layout panel.
            For Each TaskList In FloLayTaskListContainer.Controls
                'if the tasklist's name property matches the row we are looking at, set the label's text as the ID of the most recent task
                If TaskList.Name = dt.Rows(f)(6) Then
                    TaskList.lblToDoListID.Text = dt.Rows(f)(0)
                End If
                'if the task list's name property matches the row we are looking at and dt.rows(f)(1) is not empty, run the following code.
                If TaskList.Name = dt.Rows(f)(6) And Not dt.Rows(f)(1) Is DBNull.Value Then
                    'creating a new object.
                    newTask = New task(Me)
                    'if the value we are looking at is bigger or equal to 80, priority.text = "A"
                    If dt.Rows(f)(1) >= 80 Then
                        newTask.txtPriority.Text = "A"
                        'if the value we are looking at is bigger or equal to 60, priority.text = "B"
                    ElseIf dt.Rows(f)(1) >= 60 Then
                        newTask.txtPriority.Text = "B"
                        'if the value we are looking at is bigger or equal to 40, priority.text = "C"
                    ElseIf dt.Rows(f)(1) >= 40 Then
                        newTask.txtPriority.Text = "C"
                        'if the value we are looking at is bigger or equal to 20, priority.text = "D"
                    ElseIf dt.Rows(f)(1) >= 20 Then
                        newTask.txtPriority.Text = "D"
                    Else
                        'if the value we are looking at is smaller or equal to 19, priority.text = "E"
                        newTask.txtPriority.Text = "E"
                    End If
                    'the task container text box should have the text of dt.rows(f)(4)
                    newTask.txtTaskContainer.Text = dt.Rows(f)(4)
                    'the task text box should have the text of dt.rows(f)(5)
                    newTask.lblTaskInTask.Text = dt.Rows(f)(5)
                    'the set date text box should have the text of dt.rows(f)(2)
                    newTask.lblSetDate.Text = dt.Rows(f)(2)
                    'the deadline text box should have the text of dt.rows(f)(3)
                    newTask.lblDeadline.Text = dt.Rows(f)(3)
                    'the tasklist text box should have the text of dt.rows(f)(6)
                    newTask.lblTaskList.Text = dt.Rows(f)(6)
                    'the task ID text box should have the value of dt.rows(f)(0)
                    newTask.lblTaskId.Text = dt.Rows(f)(0)
                    'the priority text box should have the value of dt.rows(f)(1)
                    newTask.lblPriorityInNumber.Text = dt.Rows(f)(1)
                    'the set time textbox should have the value of dt.rows(f)(7)
                    newTask.lblSetTime.Text = dt.Rows(f)(7)
                    'the end time text box should have the values of dt.rows(f)(8)
                    newTask.lblEndTime.Text = dt.Rows(f)(8)
                    'declaring a new date and giving it a value.
                    Dim date1 As DateTime = dt.Rows(f)(3) & " " & dt.Rows(f)(8)
                    'declaring time space
                    'Dim timespan1 As TimeSpan
                    Dim timespan2 As TimeSpan
                    'declaring an integer
                    Dim isNumberofDays As Integer
                    'working out the difference in the current date and the deadline.
                    'timespan1 = date1.Subtract(Now.Date)
                    timespan2 = date1.Subtract(Now)
                    'the value of integer = days worked from the time span.
                    isNumberofDays = timespan2.Days
                    'if the task is expired, show the task as red.
                    If timespan2.Days <= 0 Then
                        newTask.BackColor = Color.Red
                    End If
                    'MsgBox(timespan2.Days & " " & timespan2.Hours & ":" & timespan2.Minutes)
                    'timer text box = the value of isNumberofDays
                    newTask.txtTimer.Text = isNumberofDays
                    'Add the task into the task list.
                    addTask(newTask, TaskList.FlowLayoutPanel1)
                Else
                End If
            Next
        Next
    End Sub

    'this sub is called from other places.
    Public Sub UpdatePersonalTasks()
        'try-catch block
        Try
            'string containing the update instructions.
            Dim sqlString As String = "Update " & Label10.Text & _
                        " set Priority = " & son.txtPriorityInBrother.Text & _
                        ", SetDate = '" & son.DTPSetDateInBrother.Text & _
                        "', DeadLine = '" & son.DTPDeadlineInBrother.Text & _
                        "', Subject = '" & son.txtTitleInBrother.Text & _
                        "', Task = '" & son.txtTaskInBrother.Text & _
                        "', ToDoList = '" & son.txtTaskListInBrother.Text & _
                        "' where ID = " & son.lblTaskId.Text
            cn.Open()
            'declaring a new oledb data adapter. this adapter is carring the sqlString
            da = New OleDbDataAdapter(sqlString, cn)
            'declaring a new oledb command builder
            cmd = New OleDbCommandBuilder(da)
            'clearing the data table.
            dt.Clear()
            dt.Rows.Clear()
            dt.Columns.Clear()
            da.Fill(dt)
            MsgBox("Task has been updated.")
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'this sub adds the the task into the database.
    Public Sub addTask(ByVal newTask As task, ByVal newGroup As FlowLayoutPanel)
        'this line adds the task into the flowlayout.
        newGroup.Controls.Add(newTask)
        'newTask.Top = nextLine
        'nextLine = nextLine + newTask.Height
        'newTask.Text = nextLine
    End Sub

    'this sub runs when NewTask is clicked.
    Private Sub cmdNewTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewTask.Click
        CreateNewTask()
    End Sub

    Private Sub CreateNewTask()
        'new son object is created.
        son = New TaskContainer(True)
        'objects opens.
        son.Show()
        'a sub of that object is called.
        son.MakeTextboxesEditable()
        'calls another sub.
        RetrieveTasks()
        'declaring another sub
        Dim max As Integer = 0
        'starting a loop
        For x = 1 To dt.Rows.Count
            'if max is less than the ID number, let max= ID number
            If dt.Rows(x - 1)(0) > max Then
                max = dt.Rows(x - 1)(0)
            End If
        Next
        'whatever max is, add 1 to it.
        max = max + 1
        'taskID textbox = max
        son.lblTaskId.Text = max
        'calling a sub in another class.
        son.EmptyTextBoxes()
        'priority label is set to equal "E"
        son.lblPriorityInBrother.Text = "E"
        'slider value is set to "1"
        son.sliderPriority.Value = 1
        'running a loop.
        For b = 0 To LstTaskBox.Items.Count - 1
            'adding the different todolists into the combo box.
            son.ComboBoxTaskListInBrother.Items.Add(LstTaskBox.Items(b))
        Next
        'adding another item to the todolists combo box
        son.ComboBoxTaskListInBrother.Items.Add("New...")
        'calling another sub.
        RetrieveUserInformation()
        'running a loop...
        For n = 0 To dt2.Rows.Count - 1
            'adding different users into the assign to combo box
            son.ComboBoxAssignedTo.Items.Add(dt2.Rows(n)(1))
        Next
        ''adding another item into the assign to combo box.
        son.ComboBoxAssignedTo.Items.Add("Myself...")
        'removing the text property of label 10 that appears in the assign to combo box.
        son.ComboBoxAssignedTo.Items.Remove(Label10.Text)
    End Sub

    'a sub to saving tasks into database.
    Public Sub PutTasksIntoDataBase()
        'declaring a string
        Dim str1 As String
        'if assign to combo box contains the text = Myself... then str1 should equal to the text property of label10,
        'otherwise it should equal to the text of combo box assign to.
        If son.ComboBoxAssignedTo.Text = "Myself..." Then
            str1 = Label10.Text
        Else
            str1 = son.ComboBoxAssignedTo.Text
        End If
        'try-catch block
        Try
            'string caring the sql statement that inserts new tasks into the database.
            Dim sqlStringAddingTasks As String = "Insert into " & str1 & _
                " values(" & son.lblTaskId.Text & "," & son.txtPriorityInBrother.Text & ",'" _
                & son.DTPSetDateInBrother.Text & "','" & son.DTPDeadlineInBrother.Text & "','" _
                & son.txtTitleInBrother.Text & "','" & son.txtTaskInBrother.Text & "','" _
                & son.txtTaskListInBrother.Text & "','" & son.DTPSetTimeInBrother.Text & "','" _
                & son.DTPEndTimeInBrother.Text & "')"
            cn.Open()
            da = New OleDbDataAdapter(sqlStringAddingTasks, cn)
            cmd = New OleDbCommandBuilder(da)
            dt.Clear()
            dt.Rows.Clear()
            dt.Columns.Clear()
            da.Fill(dt)
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            'calling another sub.
            RetrieveTasks()
            'calling another sub.
            OtherNecessaryStuff()
        End Try
    End Sub

    'this sub runs when Create new Tasklist is pressed. This sub inserts an empty tasklist into the database.
    Private Sub cmdCreateNewTaskList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateNewTaskList.Click
        If Not txtNewTaskListName.Text = "" Then
            'calling another sub.
            RetrieveTasks()
            'declaring an integer
            Dim max As Integer = 0
            ''running a loop to determine te highest ID number.
            For x = 1 To dt.Rows.Count
                If dt.Rows(x - 1)(0) > max Then
                    max = dt.Rows(x - 1)(0)
                End If
            Next
            'adding 1 to whatever the previous value of max was.
            max = max + 1
            'a new tasklist object is created. (it only exists in memory right now)
            Dim TaskList As New TaskList(Me)
            'it is added to the main flow layout panel.
            FloLayTaskListContainer.Controls.Add(TaskList)
            'setting the name of the task list.
            TaskList.Name = txtNewTaskListName.Text
            'setting the text property of the label in the tasklist object.
            TaskList.Label1.Text = txtNewTaskListName.Text
            'clearing the new task list text box for later use.
            txtNewTaskListName.Clear()
            'todolist ID number = max
            TaskList.lblToDoListID.Text = max
            'Create new task list's visibility is set to false
            BoxCreateNewTaskList.Visible = False
            'try-catch block
            Try
                'string caring the sql statement carring the instructions to insert an empty task list
                Dim sqlStringForTaskLists As String = "Insert into " & Label10.Text & " values(" & TaskList.lblToDoListID.Text & "," & "Null" & "," & "Null" & "," & "Null" & "," & "Null" & "," & "Null" & ",'" & TaskList.Label1.Text & "', Null" & ", Null" & ")"
                'opening the connection
                cn.Open()
                'an adapter is carring the the sqlString
                da = New OleDbDataAdapter(sqlStringForTaskLists, cn)
                'command builder is carring the adapter
                cmd = New OleDbCommandBuilder(da)
                dt.Clear()
                dt.Rows.Clear()
                dt.Columns.Clear()
                da.Fill(dt)
            Catch ex As OleDbException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
            SignOutResembles()
            RetrieveTasks()
            OtherNecessaryStuff()
        Else
            MsgBox("You cannot create a tasklist with no name.")
        End If
    End Sub

    'this sub puts user into database.
    Private Sub PutUserIntoDataBase()
        Try
            'string carring the sql statament to insert user into the users table.
            Dim sqlStringAddingTasks As String = "Insert into Users values('" & txtFirstName.Text & "','" & txtLastName.Text & "'," & ComboBoxYearOfBirth.Text & _
                                ",'" & txtPasswordRegister.Text & "','" & txtEmailAddressRegister.Text & "'," & lblUserID.Text & ")"
            cn.Open()
            da = New OleDbDataAdapter(sqlStringAddingTasks, cn)
            cmd = New OleDbCommandBuilder(da)
            dt.Clear()
            dt.Rows.Clear()
            dt.Columns.Clear()
            da.Fill(dt)
            MsgBox("Registration Successful. Please Sign in now.")
        Catch ex As OleDbException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'whne email address textbox changes, this sub runs.
    Private Sub txtEmailAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailAddress.KeyPress
        'this bit of code doesn't allow aphostrophies and quote marks to be entered.
        If e.KeyChar = """" Or e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    'this functions runs when it is called. This function checks for the right user and returns true or false.
    Private Function ask()
        'running a loop.
        For j = 0 To dt2.Rows.Count - 1
            'running another loop
            For Each datarow In dt2.Rows
                ' if email address and password match, return true, write the name of the person in the main form and write his last name in another label.
                If txtEmailAddress.Text = dt2.Rows(j)(4) And txtPassword.Text = dt2.Rows(j)(3) Then
                    Label9.Text = dt2.Rows(j)(0) & " " & dt2.Rows(j)(1)
                    Label10.Text = dt2.Rows(j)(1)
                    Label9.Visible = True
                    Return True
                End If
            Next
        Next
        'return false if its email address or password do not match.
        Return False
    End Function

    'this sub runs when log in button is pressed.
    Private Sub cmdLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogIn.Click
        ' if the ask function returns true, tasks are retrived, they're put into their right places, the right group box appears.
        If ask() = True Then
            RetrieveTasks()
            OtherNecessaryStuff()
            lblInterfaceID.Text = 2
            RefreshInterface()
            txtEmailAddress.Clear()
            txtPassword.Clear()
        Else
            'if the function doesn't return true, this message below appears.
            MsgBox("Sign-in Unsuccessful. Your Email Address or Password or both are invalid. Please register if you haven't.")
        End If
    End Sub

    'this sub is called from other places. this sub is responsible for showing the right groupbox.
    Private Sub RefreshInterface()
        'the pagenumber integer = user Id text box
        PageNumber = lblInterfaceID.Text
        'Selet Case statement...
        Select Case PageNumber
            Case Is = 1
                SignInBox.Left = k
                GroupBox1.Left = l
            Case Is = 2
                SignInBox.Left = l
                GroupBox1.Left = k
        End Select
    End Sub

    'this sub runs when Regitser button is pressed.
    Private Sub cmdRegsiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegsiter.Click
        'another sub is called.
        CreateTable()
        'another sub is called.
        PutUserIntoDataBase()
        'textboxes are cleared away for the next user.
        txtFirstName.Clear()
        txtLastName.Clear()
        'putting the email address and password into the sign in textboxes.
        txtEmailAddress.Text = txtEmailAddressRegister.Text
        txtPassword.Text = txtPasswordRegister.Text
        'clearng away the text boxes.
        ComboBoxYearOfBirth.Text = ""
        txtEmailAddressRegister.Clear()
        txtPasswordRegister.Clear()
        ComboBoxYearOfBirth.Text = ""
        'unabling the register button.
        cmdRegsiter.Enabled = False
        'calling another sub.
        RetrieveUserInformation()
    End Sub

    'this sub runs when a key is pressed in the email address register textbox
    Private Sub txtEmailAddressRegister_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailAddressRegister.KeyPress
        'this bit of code doesn't allow aphostrophies and quotation marks to be typed into the text box.
        If e.KeyChar = """" Or e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    'this sub runs when a key is pressed in the txtFirstName text box
    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        'this says that controlling keys should be allowed.
        If Char.IsControl(e.KeyChar) Then
            'this says that if a controlling key is pressed, then allow it
            e.Handled = False
        End If
        'this says that no punctuation mark should be allowed in.
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
        'this makes sure that no number is allowd in.
        If (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    'this sub runs when a key is pressed in the txtLastName text box
    Private Sub txtLastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        'this says that controlling keys should be allowed.
        If Char.IsControl(e.KeyChar) Then
            'this says that if a controlling key is pressed, then allow it
            e.Handled = False
        End If
        'this says that no punctuation mark should be allowed in.
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
        'this code doesn't allow any number to be typed into the text box.
        If (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ''this sub runs when a key is pressed in the txtPassword text box
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        'this sub doesn't allow quotations marks and aphostrophies to be typed into the textbox
        If e.KeyChar = """" Or e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    'this sub runs when a key is pressed in the txtPasswordRegister text box
    Private Sub txtPasswordRegister_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPasswordRegister.KeyPress
        'this sub doesn't allow quotations marks and aphostrophies to be typed into the textbox
        If e.KeyChar = """" Or e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    'this sub runs when about button is pressed.
    Private Sub AboutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem2.Click
        'about form shows up.
        About.Show()
    End Sub

    'this sub runs when the exit button is pressed from the menu bar.
    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        'this ends the whole programme.
        End
    End Sub

    'this sub runs when the sign-out button is pressed.
    Private Sub SignOutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem2.Click
        'another sub is called.
        SignOutResembles()
        ''interface ID is given a value.
        lblInterfaceID.Text = 1
        'another sub is called.
        RefreshInterface()
        'the labels containing the name of the person is emptied.
        Label9.Text = ""
        Label10.Text = "Label10"
        'disposing any open taskContainers
        'TaskContainer.ActiveForm.Dispose()
    End Sub

    'this sub is run when it is called.
    Public Sub SignOutResembles()
        'this loop disposes all the tasks and tasklists
        For Each TaskList In FloLayTaskListContainer.Controls
            FloLayTaskListContainer.Controls.Clear()
            TaskList.Dispose()
        Next
        'this empties tasklist box.
        LstTaskBox.Items.Clear()
    End Sub

    'this sub runs when Cancel button is pressed.
    Private Sub cmdCancelInCreateNewTasListBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelInCreateNewTasListBox.Click
        'the textbox is cleared away
        txtNewTaskListName.Clear()
        'groupbox disappears.
        BoxCreateNewTaskList.Visible = False
    End Sub

    'this sub runs when New Task List button is pressed in the main Window.
    Private Sub cmdLaunchBoxNewTaskList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLaunchBoxNewTaskList.Click
        'the groupbox is made visible.
        BoxCreateNewTaskList.Visible = True
    End Sub

    'this sub runs when the FirstName textbox loses focus.
    Private Sub txtFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        'this makes the first letter capital.
        txtFirstName.Text = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
    End Sub

    'this sub runs when the LastName textbox loses focus.
    Private Sub txtLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        'this makes the first letter of the word capital
        txtLastName.Text = StrConv(txtLastName.Text, VbStrConv.ProperCase)
    End Sub

    'this sub runs when the NewTaskListName textbox loses focus.
    Private Sub txtNewTaskListName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNewTaskListName.Validating
        'this makes the first letter capital of the name.
        txtNewTaskListName.Text = StrConv(txtNewTaskListName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub NewTaskToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles NewTaskToolStripMenuItem2.Click
        CreateNewTask()
    End Sub

    Private Sub NewTaskListToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles NewTaskListToolStripMenuItem2.Click
        BoxCreateNewTaskList.Visible = True
    End Sub
End Class

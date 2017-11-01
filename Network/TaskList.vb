Imports System.Data.OleDb
Public Class TaskList
    Dim parent As Network
    Dim dt As New DataTable

    'this is a constructor.
    Public Sub New(ByVal parent As Network)

        ' This call is required by the designer.
        InitializeComponent()
        Me.parent = parent
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'this code runs when the delete button is clicked.
    Private Sub cmdDeleteTaskList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteTaskList.Click
        'this varible contains a msgbox with a yes, no button and a question
        Dim result1 As DialogResult = MessageBox.Show("Are you sure you want to delete this task list?", "Important Question", MessageBoxButtons.YesNo)
        'Dim task As task

        'Network.SignOutResembles()
        'Try
        '    parent.cn.Open()
        '    parent.da = New OleDbDataAdapter("Select * from " & parent.Label10.Text & " Order by ID", parent.cn)
        '    dt.Clear()
        '    dt.Rows.Clear()
        '    dt.Columns.Clear()
        '    parent.da.Fill(dt)
        'Catch ex As OleDbException
        '    MsgBox(ex.Message)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    parent.cn.Close()
        'End Try
        ''For Each TaskList In parent.FloLayTaskListContainer.Controls
        'For j = 0 To dt.Rows.Count - 1
        '    MsgBox(dt.Rows(j)(6) & " " & Label1.Text)
        '    MsgBox(dt.Rows(j)(6) = Label1.Text)
        '    If dt.Rows(j)(6) = Label1.Text And Not dt.Rows(j)(1) Is DBNull.Value Then
        '        MsgBox(1)
        '''if the result is yes, the task is deleted.
        If result1 = DialogResult.Yes Then
            '            For Each task In FlowLayoutPanel1.Controls

            Try
                parent.cn.Open()
                parent.da = New OleDbDataAdapter("Delete from Daniyal where ToDoList = '" & Label1.Text & "'", parent.cn)
                parent.cmd = New OleDbCommandBuilder(parent.da)
                dt.Clear()
                dt.Rows.Clear()
                dt.Columns.Clear()
                parent.da.Fill(dt)
            Catch ex As OleDbException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                parent.cn.Close()
            End Try
            '            Next
            '        Else
            '        End If
        End If
        'Next
        'For j = 0 To dt.Rows.Count - 1
        '    If dt.Rows(j)(6) = Label1.Text And dt.Rows(j)(1) Is DBNull.Value Then
        '        MsgBox(2)
        '        If result1 = DialogResult.Yes Then
        '            Try
        '                parent.cn.Open()
        '                parent.da = New OleDbDataAdapter("Delete from Daniyal where ID = " & lblToDoListID.Text, parent.cn)
        '                parent.cmd = New OleDbCommandBuilder(Network.da)
        '                dt.Clear()
        '                dt.Rows.Clear()
        '                dt.Columns.Clear()
        '                parent.da.Fill(dt)
        '            Catch ex As OleDbException
        '                MsgBox(ex.Message)
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '            Finally
        '                parent.cn.Close()
        '            End Try
        '        Else
        '        End If
        '    End If
        'Next
        ''Next


        parent.SignOutResembles()
        parent.RetrieveTasks()
        parent.OtherNecessaryStuff()
    End Sub

    'this sub runs when mouse is hovering over the delete button
    Private Sub cmdDeleteTaskList_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteTaskList.MouseHover
        'this code makes the button red when the mouse hovers over it.
        cmdDeleteTaskList.BackColor = Color.Red
    End Sub

    'this sub runs when mouse leaves the delete button.
    Private Sub cmdDeleteTaskList_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteTaskList.MouseLeave
        'this will change the colour back to normal when the mouse leaves the button.
        cmdDeleteTaskList.BackColor = Color.WhiteSmoke
    End Sub
End Class

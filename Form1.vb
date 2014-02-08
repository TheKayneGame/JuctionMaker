Public Class Form1
    Dim File As String
    Dim link As String
    Dim linktype As String




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Insert(0, "Making Temporary File")
        ListBox1.Items.Insert(0, "Starting Creating Link")
        ListBox1.Items.Insert(0, "Waiting for response...")
        Dim response = MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Junction Creator")
        If response = MsgBoxResult.Yes Then
            ListBox1.Items.Insert(0, "Receiving Response Response = YES")
            ListBox1.Items.Insert(0, "Checking If " & link & " Exists")
            If System.IO.Directory.Exists(link) Then
                ListBox1.Items.Insert(0, link & " Does Exist")
                ListBox1.Items.Insert(0, "Checking If it's Empty")
                Dim dirs() = System.IO.Directory.GetDirectories(link)
                Dim Files() = System.IO.Directory.GetFiles(link)
                Dim DirLeeg As Boolean
                DirLeeg = (dirs.Length = 0 & Files.Length = 0)
                If DirLeeg = False Then
                    ListBox1.Items.Insert(0, link & " Is Empty")
                    My.Computer.FileSystem.DeleteDirectory(link, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    ListBox1.Items.Insert(0, "Deleting " & link & " /Tempotary File")
                Else
                    ListBox1.Items.Insert(0, link & " Is not Empty")
                End If
            End If
            ListBox1.Items.Insert(0, "Checking If " & link & " Exists")
            If My.Computer.FileSystem.FileExists(link) Then
                MsgBox("Couldn't Create Link" & vbCrLf & "Reason: File Already Exists")
            Else
                ListBox1.Items.Insert(0, link & " Didn't Exist")
                ListBox1.Items.Insert(0, "Generating Shell Command")
                Dim process As New Process

                process.StartInfo.FileName = "cmd.exe"
                process.StartInfo.Arguments = "/c mklink /j " & Chr(34) & link & "\" & Chr(34) & " " & Chr(34) & File & "\" & Chr(34)
                process.StartInfo.WorkingDirectory = "C:\"
                ListBox1.Items.Insert(0, "Executing Shell Command")
                process.Start()
                ListBox1.Items.Insert(0, "Succes")
                link = ""
                File = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Insert(0, "Choosing Actual file location")
        ActualFile.ShowDialog()
        File = ActualFile.SelectedPath()
        TextBox2.Text = File
        ListBox1.Items.Insert(0, "Set Actual File Location To" & File)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Insert(0, "Choosing Link Location")
        LinkPath.ShowDialog()
        link = LinkPath.SelectedPath
        TextBox1.Text() = link
        ListBox1.Items.Insert(0, "Set Link Location To" & link)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MsgBox("/c mklink /j " & linktype & "" & Chr(34) & link & Chr(34) & " " & Chr(34) & File & Chr(34))
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ListBox1.Items.Insert(0, "Edited Actual File Location To " & File)
        File = TextBox2.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Insert(0, "Edited Link Path To " & link)
        link = TextBox1.Text

    End Sub

    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox1.Items.Insert(0, "Cleared Log")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Settings.Show()
        ListBox1.Text.Insert(0, "Opened Settings")

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Enabled = False Then
            ListBox1.Items.Clear()
        End If
    End Sub
End Class

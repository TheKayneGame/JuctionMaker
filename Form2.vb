Public Class Settings
    Dim WindowOpacity As Integer




    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)




    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        TextBox1.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ListBox1.Text.Insert(0, "Applying Changes")
        Form1.TopMost = CheckBox1.Checked
        Form1.BackColor = ColorDialog1.Color
        Form1.ListBox1.Visible = CheckBox2.Checked
        Form1.Button4.Visible = CheckBox2.Checked
        If CheckBox2.Checked = False Then
            Form1.Width = 352
        Else
            Form1.Width = 583
            Form1.ListBox1.Text.Insert(0, "Turned  On Log And Changed Width To 583")
        End If
        Form1.UseWaitCursor = CheckBox3.Checked

        Me.TopMost = CheckBox1.Checked
        Me.BackColor = ColorDialog1.Color
        Me.UseWaitCursor = CheckBox3.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorDialog1.Color = Color.Silver
        TextBox1.BackColor = Color.Silver
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.Color = Color.Silver
        TextBox1.BackColor = Color.Silver
    End Sub
End Class
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database13DataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.Database13DataSet1.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew() 'Add student info

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Database13DataSet.Table1) 'Update, edit student info 
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table1TableAdapter.Search(Me.Database13DataSet.Table1)  'Search student info
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1TableAdapter.Search(Database13DataSet.Table1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.RemoveCurrent() 'Remove student info
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()         'Attach picture file 
        TextBox4.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Table1BindingSource.MovePrevious()    'MovePrevious
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.MoveNext()         'MoveNext
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Table1BindingSource.MoveFirst()         'MoveFirst
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Table1BindingSource.MoveLast()          ''Move last
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Close()                                   'Exit 
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If (System.IO.File.Exists(TextBox4.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox4.Text)
        End If
        If TextBox4.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If



    End Sub
End Class

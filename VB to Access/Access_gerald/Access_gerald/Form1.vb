Imports System.Data.OleDb

Public Class Form1
    Dim connString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gerald\Documents\Accesss.accdb"
    Dim connection As New OleDbConnection(connString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Me.GeraldTableAdapter.Fill(Me.AccesssDataSet.gerald)


    End Sub
    Private Sub LoadData()
        Dim adapter As New OleDbDataAdapter()
        Dim dataTable As New DataTable()

        Try
            connection.Open()
            Dim sql As String = "SELECT * FROM gerald"
            adapter.SelectCommand = New OleDbCommand(sql, connection)
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim sql As String = "INSERT INTO gerald (Lastname, Firstname, Age, Address, Gender) 
            VALUES (@Lastname, @Firstname, @Age, @Address, @Gender)"
            Dim command As New OleDbCommand(sql, connection)
            command.Parameters.AddWithValue("@Lastname", TextBox1.Text)
            command.Parameters.AddWithValue("@Firstname", TextBox2.Text)
            command.Parameters.AddWithValue("@Age", TextBox3.Text)
            command.Parameters.AddWithValue("@Address", TextBox4.Text)
            command.Parameters.AddWithValue("@Gender", ComboBox1.Text)
            command.ExecuteNonQuery()

            MessageBox.Show("Record added successfully!")


        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New OleDbConnection(connString)

        Try
            connection.Open()
            Dim sql As String = "DELETE FROM gerald WHERE Lastname = @Lastname"
            Dim command As New OleDbCommand(sql, connection)
            command.Parameters.AddWithValue("@Lastname", TextBox1.Text)
            command.ExecuteNonQuery()

            MessageBox.Show("Record delete successfully!")

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            TextBox1.Text = selectedRow.Cells("Lastname").Value.ToString()
            TextBox2.Text = selectedRow.Cells("Firstname").Value.ToString()
            TextBox3.Text = selectedRow.Cells("Age").Value.ToString()
            TextBox4.Text = selectedRow.Cells("Address").Value.ToString()
            ComboBox1.Text = selectedRow.Cells("Gender").Value.ToString()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadData()
    End Sub
End Class

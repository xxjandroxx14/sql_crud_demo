Imports MySql.Data.MySqlClient


Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=crud_demo_db;"
        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCreat_Click(sender As Object, e As EventArgs) Handles ButtonCreat.Click
        Dim query As String = "  INSERT INTO `crud_demo_db`.`students_tbl` ( `name`, `age`, `email`) VALUES (@name, @age, @email);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextBoxAge.Text))
                    cmd.Parameters.AddWithValue("@email", (TextBoxEmail.Text))

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record Inserted Successfully")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()


                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM crud_demo_db.students_tbl WHERE is_deleted = 0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=crud_demo_db;")

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                    DataGridView1.Columns("id").Visible = False
                    DataGridView1.Columns("is_deleted").Visible = False

                End Using
            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBoxName.Text = selectRow.Cells("name").Value.ToString()
            TextBoxAge.Text = selectRow.Cells("age").Value.ToString()
            TextBoxEmail.Text = selectRow.Cells("email").Value.ToString()
            TextBoxHiddenId.Text = selectRow.Cells("id").Value.ToString()


        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim query As String = "UPDATE `crud_demo_db`.`students_tbl`
                                                SET `name` = @name,
                                                `age` = @age,
                                               `email` = @email
                                                WHERE (`id` = @id)"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", CInt(TextBoxAge.Text))
                    cmd.Parameters.AddWithValue("@email", (TextBoxEmail.Text))
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Inserted Successfully")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()
                    TextBoxHiddenId.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' Dim query As String = " DELETE FROM `crud_demo_db`.`students_tbl` WHERE (`id` = '3');"
        Dim query As String = " UPDATE `crud_demo_db`.`students_tbl` 
                            SET is_deleted = 1 
                            WHERE (`id` = @id);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record Inserted Successfully")
                    TextBoxName.Clear()
                    TextBoxAge.Clear()
                    TextBoxEmail.Clear()
                    TextBoxHiddenId.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

Imports System.Data.SqlClient

Public Class Login

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles closelbl.Click

    End Sub

    Private Sub closelbl_MouseHover(sender As Object, e As EventArgs) Handles closelbl.MouseHover
        closelbl.ForeColor = Color.White
        closelbl.BackColor = Color.Red

    End Sub

    Private Sub closelbl_MouseLeave(sender As Object, e As EventArgs) Handles closelbl.MouseLeave
        closelbl.ForeColor = Color.Black
        closelbl.BackColor = Color.White
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim da As SqlDataAdapter

        'Dim command As New SqlCommand("Select usertype from UserAccount where username=@Username and password=@Password", conn)
        Dim command As New SqlCommand("Select usertype from UserAccount where username='" & txtUser.Text & "' and password='" & txtPass.Text & "'", conn)
        'command.Parameters.AddWithValue("@Username", txtUser.Text)
        'command.Parameters.AddWithValue("@Password", txtPass.Text)
        connect()

        Dim usertype As String = command.ExecuteScalar()

        Try

            If usertype IsNot Nothing Then
                ' Login successful, open the appropriate form based on the user's role
                Select Case usertype
                    Case "admin"
                        ' Admin has full access
                        Dim form As New POSVIew()
                        form.Show()
                        Me.Hide()
                    Case "manager"
                        ' Manager can update and delete
                        Dim form As New Sales()
                        form.Show()
                        Me.Hide()
                    Case "employee"
                        ' Employee can only update
                        Dim form As New Food_Ingredients()
                        form.Show()
                        Me.Hide()
                    Case Else
                        ' Unknown role
                        MessageBox.Show("Unknown role: " & usertype)
                End Select
            Else
                ' Login failed
                MessageBox.Show("Invalid username or password.")
            End If
        Catch ex As Exception

        End Try

        conn.Close()


    End Sub

End Class
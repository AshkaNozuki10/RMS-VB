Imports System.Data.SqlClient

Public Class Login

    'Close login window
    Private Sub closelbl_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Application.Exit()
    End Sub

    'Login lbl close UI color 
    Private Sub closelbl_MouseHover(sender As Object, e As EventArgs) Handles closelbl.MouseHover
        closelbl.ForeColor = Color.White
        closelbl.BackColor = Color.Red
    End Sub

    Private Sub closelbl_MouseLeave(sender As Object, e As EventArgs) Handles closelbl.MouseLeave
        closelbl.ForeColor = Color.Black
        closelbl.BackColor = Color.White
    End Sub

    'Login user access
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim command As New SqlCommand("Select usertype from UserAccount where username=@Username and password=@Password", conn)
        'Dim command As New SqlCommand("Select usertype from UserAccount where username='" & txtUser.Text & "' and password='" & txtPass.Text & "'", conn)
        command.Parameters.AddWithValue("@Username", txtUser.Text)
        command.Parameters.AddWithValue("@Password", txtPass.Text)

        'opening db connection
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
            ' Log the exception or show a message to the user
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        'closing db connection
        disconnect()
    End Sub
End Class
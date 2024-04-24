Imports System.Data.SqlClient

Public Class Login

    Dim da As SqlDataAdapter

    Dim dset As New DataSet


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles closelbl.Click
        Me.Close()
    End Sub

    Private Sub closelbl_MouseHover(sender As Object, e As EventArgs) Handles closelbl.MouseHover
        closelbl.ForeColor = Color.White
        closelbl.BackColor = Color.Red

    End Sub

    Private Sub closelbl_MouseLeave(sender As Object, e As EventArgs) Handles closelbl.MouseLeave
        closelbl.ForeColor = Color.Black
        closelbl.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        da = New SqlDataAdapter("Select * from UserAccount where username='" & txtUser.Text & "' and password='" & txtPass.Text & "' 
        and usertype ='""'", conn)

        dset = New DataSet
        da.Fill(dset, "")


    End Sub
End Class
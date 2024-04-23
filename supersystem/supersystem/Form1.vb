
Imports System.Drawing.Drawing2D
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to make the buttons have rounded corners
        SetRoundButton(Button1)
        SetRoundButton(Button2)
        SetRoundButton(Button3)
    End Sub

    ' Method to make the button have rounded corners
    Private Sub SetRoundButton(button As Button)
        ' Set the flat style
        button.FlatStyle = FlatStyle.Flat
        ' Remove the button border
        button.FlatAppearance.BorderSize = 0
        ' Set the background color
        button.BackColor = Color.LightGray
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label2.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label4.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label5.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label6.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        ' Change cursor to hand when mouse enters label
        Label7.Cursor = Cursors.Hand
    End Sub
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        ' Revert cursor to default when mouse leaves label
        Label1.Cursor = Cursors.Default
        Label2.Cursor = Cursors.Default
        Label3.Cursor = Cursors.Default
        Label4.Cursor = Cursors.Default
        Label5.Cursor = Cursors.Default
        Label6.Cursor = Cursors.Default
        Label7.Cursor = Cursors.Default
    End Sub
    ' Override the OnPaint method to draw rounded corners
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        ' Call the base class method
        MyBase.OnPaint(e)
        ' Draw rounded corners for each button
        DrawRoundedCorners(Button1)
        DrawRoundedCorners(Button2)
        DrawRoundedCorners(Button3)
    End Sub

    ' Method to draw rounded corners for the button
    Private Sub DrawRoundedCorners(button As Button)
        Using path As GraphicsPath = New GraphicsPath()
            ' Define the shape of the rounded corners
            Dim rect As Rectangle = button.ClientRectangle
            path.AddArc(rect.X, rect.Y, 10, 10, 180, 90) ' Top left corner
            path.AddArc(rect.X + rect.Width - 10, rect.Y, 10, 10, 270, 90) ' Top right corner
            path.AddArc(rect.X + rect.Width - 10, rect.Y + rect.Height - 10, 10, 10, 0, 90) ' Bottom right corner
            path.AddArc(rect.X, rect.Y + rect.Height - 10, 10, 10, 90, 90) ' Bottom left corner
            path.CloseFigure()

            ' Set the region for the button
            button.Region = New Region(path)
        End Using
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim newForm As New Form1()

        ' Show the new form
        newForm.Show()

        ' Close the current form
        Me.Close()
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.pnlCategory = New System.Windows.Forms.Panel()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlCategory.SuspendLayout()
        Me.pnlItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pnlItems)
        Me.Panel1.Controls.Add(Me.pnlCategory)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 680)
        Me.Panel1.TabIndex = 1
        '
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(26, 30)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(112, 30)
        Me.btnCategory.TabIndex = 1
        Me.btnCategory.Text = "+ Add Category"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.Location = New System.Drawing.Point(26, 33)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(89, 30)
        Me.btnItems.TabIndex = 1
        Me.btnItems.Text = "+ Add Items"
        Me.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'pnlCategory
        '
        Me.pnlCategory.Controls.Add(Me.btnCategory)
        Me.pnlCategory.Location = New System.Drawing.Point(63, 71)
        Me.pnlCategory.Name = "pnlCategory"
        Me.pnlCategory.Size = New System.Drawing.Size(747, 210)
        Me.pnlCategory.TabIndex = 2
        '
        'pnlItems
        '
        Me.pnlItems.Controls.Add(Me.btnItems)
        Me.pnlItems.Location = New System.Drawing.Point(63, 329)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(747, 288)
        Me.pnlItems.TabIndex = 3
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 680)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sales"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.pnlCategory.ResumeLayout(False)
        Me.pnlItems.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnItems As Button
    Friend WithEvents pnlCategory As Panel
    Friend WithEvents btnCategory As Button
    Friend WithEvents pnlItems As Panel
End Class

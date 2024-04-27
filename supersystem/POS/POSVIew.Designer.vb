<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSVIew
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
        Me.btnMinimized = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnIngredients = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNnM = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlPOS = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinimized
        '
        Me.btnMinimized.AllowDrop = True
        Me.btnMinimized.BackColor = System.Drawing.Color.Orange
        Me.btnMinimized.Location = New System.Drawing.Point(8, 9)
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(25, 23)
        Me.btnMinimized.TabIndex = 0
        Me.btnMinimized.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.AllowDrop = True
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Location = New System.Drawing.Point(70, 9)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(25, 23)
        Me.btnexit.TabIndex = 0
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.btnSales)
        Me.pnlMenu.Controls.Add(Me.btnIngredients)
        Me.pnlMenu.Controls.Add(Me.Panel3)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlMenu.Location = New System.Drawing.Point(0, 42)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(194, 678)
        Me.pnlMenu.TabIndex = 1
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(194, 30)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Location = New System.Drawing.Point(0, 30)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(194, 30)
        Me.btnSales.TabIndex = 0
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnIngredients
        '
        Me.btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngredients.Location = New System.Drawing.Point(0, 60)
        Me.btnIngredients.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIngredients.Name = "btnIngredients"
        Me.btnIngredients.Size = New System.Drawing.Size(194, 30)
        Me.btnIngredients.TabIndex = 0
        Me.btnIngredients.Text = "Ingredients"
        Me.btnIngredients.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 582)
        Me.Panel3.TabIndex = 1
        '
        'btnNnM
        '
        Me.btnNnM.BackColor = System.Drawing.Color.Green
        Me.btnNnM.Location = New System.Drawing.Point(39, 9)
        Me.btnNnM.Name = "btnNnM"
        Me.btnNnM.Size = New System.Drawing.Size(25, 23)
        Me.btnNnM.TabIndex = 0
        Me.btnNnM.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Orange
        Me.pnlHeader.Controls.Add(Me.Panel1)
        Me.pnlHeader.Controls.Add(Me.Panel2)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1080, 42)
        Me.pnlHeader.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 39)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnMinimized)
        Me.Panel2.Controls.Add(Me.btnNnM)
        Me.Panel2.Location = New System.Drawing.Point(972, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(103, 39)
        Me.Panel2.TabIndex = 1
        '
        'pnlPOS
        '
        Me.pnlPOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPOS.Location = New System.Drawing.Point(194, 42)
        Me.pnlPOS.Name = "pnlPOS"
        Me.pnlPOS.Size = New System.Drawing.Size(886, 678)
        Me.pnlPOS.TabIndex = 3
        '
        'POSVIew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.pnlPOS)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POSVIew"
        Me.Text = "POSVIew"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As FlowLayoutPanel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnIngredients As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnMinimized As Button
    Friend WithEvents btnNnM As Button
    Friend WithEvents pnlHeader As FlowLayoutPanel
    Friend WithEvents pnlPOS As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnModifyStaff = New System.Windows.Forms.Button()
        Me.btnRemoveStaff = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnRemoveMovie = New System.Windows.Forms.Button()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.btnModifyMovie = New System.Windows.Forms.Button()
        Me.btnMovie = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 93)
        Me.Panel1.TabIndex = 1
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.Color.LightGray
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(1137, 23)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(97, 47)
        Me.btnSignOut.TabIndex = 1
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btn)
        Me.Panel2.Location = New System.Drawing.Point(240, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 92)
        Me.Panel2.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 92)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Report"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 92)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.Silver
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(0, 91)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(200, 92)
        Me.btn.TabIndex = 1
        Me.btn.Text = "Report"
        Me.btn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnModifyStaff)
        Me.Panel3.Controls.Add(Me.btnRemoveStaff)
        Me.Panel3.Controls.Add(Me.btnAddStaff)
        Me.Panel3.Controls.Add(Me.btnStaff)
        Me.Panel3.Location = New System.Drawing.Point(528, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 92)
        Me.Panel3.TabIndex = 3
        '
        'btnModifyStaff
        '
        Me.btnModifyStaff.BackColor = System.Drawing.Color.Silver
        Me.btnModifyStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyStaff.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnModifyStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnModifyStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnModifyStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyStaff.Location = New System.Drawing.Point(0, 182)
        Me.btnModifyStaff.Name = "btnModifyStaff"
        Me.btnModifyStaff.Size = New System.Drawing.Size(200, 92)
        Me.btnModifyStaff.TabIndex = 4
        Me.btnModifyStaff.Text = "Modify Staff"
        Me.btnModifyStaff.UseVisualStyleBackColor = False
        '
        'btnRemoveStaff
        '
        Me.btnRemoveStaff.BackColor = System.Drawing.Color.Silver
        Me.btnRemoveStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveStaff.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveStaff.Location = New System.Drawing.Point(0, 273)
        Me.btnRemoveStaff.Name = "btnRemoveStaff"
        Me.btnRemoveStaff.Size = New System.Drawing.Size(200, 92)
        Me.btnRemoveStaff.TabIndex = 3
        Me.btnRemoveStaff.Text = "Remove Staff"
        Me.btnRemoveStaff.UseVisualStyleBackColor = False
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.Silver
        Me.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(0, 91)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddStaff.Size = New System.Drawing.Size(200, 92)
        Me.btnAddStaff.TabIndex = 2
        Me.btnAddStaff.Text = "Add Staff"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Silver
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(0, 0)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(200, 92)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnRemoveMovie)
        Me.Panel4.Controls.Add(Me.btnAddMovie)
        Me.Panel4.Controls.Add(Me.btnModifyMovie)
        Me.Panel4.Controls.Add(Me.btnMovie)
        Me.Panel4.Location = New System.Drawing.Point(824, 201)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 92)
        Me.Panel4.TabIndex = 3
        '
        'btnRemoveMovie
        '
        Me.btnRemoveMovie.BackColor = System.Drawing.Color.Silver
        Me.btnRemoveMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveMovie.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveMovie.Location = New System.Drawing.Point(0, 273)
        Me.btnRemoveMovie.Name = "btnRemoveMovie"
        Me.btnRemoveMovie.Size = New System.Drawing.Size(200, 92)
        Me.btnRemoveMovie.TabIndex = 7
        Me.btnRemoveMovie.Text = "Remove Movie"
        Me.btnRemoveMovie.UseVisualStyleBackColor = False
        '
        'btnAddMovie
        '
        Me.btnAddMovie.BackColor = System.Drawing.Color.Silver
        Me.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAddMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMovie.Location = New System.Drawing.Point(0, 91)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(200, 92)
        Me.btnAddMovie.TabIndex = 8
        Me.btnAddMovie.Text = "Add Movie"
        Me.btnAddMovie.UseVisualStyleBackColor = False
        '
        'btnModifyMovie
        '
        Me.btnModifyMovie.BackColor = System.Drawing.Color.Silver
        Me.btnModifyMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyMovie.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnModifyMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnModifyMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnModifyMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyMovie.Location = New System.Drawing.Point(0, 182)
        Me.btnModifyMovie.Name = "btnModifyMovie"
        Me.btnModifyMovie.Size = New System.Drawing.Size(200, 92)
        Me.btnModifyMovie.TabIndex = 6
        Me.btnModifyMovie.Text = "Modify Movie"
        Me.btnModifyMovie.UseVisualStyleBackColor = False
        '
        'btnMovie
        '
        Me.btnMovie.BackColor = System.Drawing.Color.Silver
        Me.btnMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMovie.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovie.Location = New System.Drawing.Point(0, 0)
        Me.btnMovie.Name = "btnMovie"
        Me.btnMovie.Size = New System.Drawing.Size(200, 92)
        Me.btnMovie.TabIndex = 5
        Me.btnMovie.Text = "Movie"
        Me.btnMovie.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Silver
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(240, 201)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(200, 92)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome, Admin"
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Astronomia"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn As Button
    Friend WithEvents btnModifyStaff As Button
    Friend WithEvents btnRemoveStaff As Button
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnRemoveMovie As Button
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents btnModifyMovie As Button
    Friend WithEvents btnMovie As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
End Class

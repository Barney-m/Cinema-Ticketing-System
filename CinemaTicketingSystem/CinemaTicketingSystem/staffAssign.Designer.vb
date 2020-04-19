<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffAssign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffAssign))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DTdob = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._AstronomiaDb__1_DataSet = New CinemaTicketingSystem._AstronomiaDb__1_DataSet()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.EmployeesTableAdapter = New CinemaTicketingSystem._AstronomiaDb__1_DataSetTableAdapters.EmployeesTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._AstronomiaDb__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 93)
        Me.Panel1.TabIndex = 2
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.DTdob)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.CbStatus)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Location = New System.Drawing.Point(45, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 378)
        Me.Panel2.TabIndex = 2
        '
        'DTdob
        '
        Me.DTdob.Location = New System.Drawing.Point(137, 79)
        Me.DTdob.Name = "DTdob"
        Me.DTdob.Size = New System.Drawing.Size(253, 20)
        Me.DTdob.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(137, 196)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(253, 25)
        Me.txtEmail.TabIndex = 19
        '
        'CbStatus
        '
        Me.CbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Items.AddRange(New Object() {"In", "Out"})
        Me.CbStatus.Location = New System.Drawing.Point(137, 242)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(253, 24)
        Me.CbStatus.TabIndex = 17
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(137, 281)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(253, 25)
        Me.txtPassword.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(137, 159)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(253, 25)
        Me.txtAddress.TabIndex = 11
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(137, 119)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(253, 25)
        Me.txtPhone.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(137, 36)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(253, 25)
        Me.txtName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Birth Date :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(38, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(79, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name :"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me._AstronomiaDb__1_DataSet
        '
        '_AstronomiaDb__1_DataSet
        '
        Me._AstronomiaDb__1_DataSet.DataSetName = "_AstronomiaDb__1_DataSet"
        Me._AstronomiaDb__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv)
        Me.Panel3.Location = New System.Drawing.Point(504, 135)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 349)
        Me.Panel3.TabIndex = 3
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(730, 346)
        Me.dgv.TabIndex = 0
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(504, 490)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(585, 490)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'staffAssign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "staffAssign"
        Me.Text = "staffAssign"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._AstronomiaDb__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents _AstronomiaDb__1_DataSet As _AstronomiaDb__1_DataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As _AstronomiaDb__1_DataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents DTdob As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class

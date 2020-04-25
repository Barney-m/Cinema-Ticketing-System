<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyMovie))
        Me.TextMid = New System.Windows.Forms.TextBox()
        Me.MovieID = New System.Windows.Forms.Label()
        Me.PicMovie = New System.Windows.Forms.PictureBox()
        Me.TextMname = New System.Windows.Forms.TextBox()
        Me.TextMgenre = New System.Windows.Forms.TextBox()
        Me.TextMdesc = New System.Windows.Forms.TextBox()
        Me.TextMrating = New System.Windows.Forms.TextBox()
        Me.TextMlength = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.ChangeIMG = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.CheckStatuss = New System.Windows.Forms.CheckBox()
        Me.schedule = New System.Windows.Forms.DataGridView()
        Me.AddSchedule = New System.Windows.Forms.Button()
        Me.addSchedule1 = New System.Windows.Forms.Button()
        Me.txtScheduleID = New System.Windows.Forms.TextBox()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblHintTime = New System.Windows.Forms.Label()
        Me.txtHall = New System.Windows.Forms.TextBox()
        Me.lblHall = New System.Windows.Forms.Label()
        Me.lblHintHall = New System.Windows.Forms.Label()
        Me.DTSchedule = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ModifySchedule = New System.Windows.Forms.Button()
        CType(Me.PicMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextMid
        '
        Me.TextMid.Location = New System.Drawing.Point(287, 59)
        Me.TextMid.Name = "TextMid"
        Me.TextMid.Size = New System.Drawing.Size(204, 20)
        Me.TextMid.TabIndex = 0
        '
        'MovieID
        '
        Me.MovieID.AutoSize = True
        Me.MovieID.Location = New System.Drawing.Point(231, 63)
        Me.MovieID.Name = "MovieID"
        Me.MovieID.Size = New System.Drawing.Size(50, 13)
        Me.MovieID.TabIndex = 1
        Me.MovieID.Text = "Movie ID"
        '
        'PicMovie
        '
        Me.PicMovie.Location = New System.Drawing.Point(101, 105)
        Me.PicMovie.Name = "PicMovie"
        Me.PicMovie.Size = New System.Drawing.Size(143, 153)
        Me.PicMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMovie.TabIndex = 2
        Me.PicMovie.TabStop = False
        '
        'TextMname
        '
        Me.TextMname.Location = New System.Drawing.Point(360, 109)
        Me.TextMname.Name = "TextMname"
        Me.TextMname.Size = New System.Drawing.Size(100, 20)
        Me.TextMname.TabIndex = 3
        '
        'TextMgenre
        '
        Me.TextMgenre.Location = New System.Drawing.Point(360, 148)
        Me.TextMgenre.Name = "TextMgenre"
        Me.TextMgenre.Size = New System.Drawing.Size(100, 20)
        Me.TextMgenre.TabIndex = 5
        '
        'TextMdesc
        '
        Me.TextMdesc.Location = New System.Drawing.Point(360, 222)
        Me.TextMdesc.Name = "TextMdesc"
        Me.TextMdesc.Size = New System.Drawing.Size(282, 20)
        Me.TextMdesc.TabIndex = 6
        '
        'TextMrating
        '
        Me.TextMrating.Location = New System.Drawing.Point(542, 109)
        Me.TextMrating.Name = "TextMrating"
        Me.TextMrating.Size = New System.Drawing.Size(100, 20)
        Me.TextMrating.TabIndex = 8
        '
        'TextMlength
        '
        Me.TextMlength.Location = New System.Drawing.Point(360, 185)
        Me.TextMlength.Name = "TextMlength"
        Me.TextMlength.Size = New System.Drawing.Size(100, 20)
        Me.TextMlength.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rating"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Duration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Genre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Description"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(506, 59)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(104, 23)
        Me.Search.TabIndex = 17
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'ChangeIMG
        '
        Me.ChangeIMG.Location = New System.Drawing.Point(131, 268)
        Me.ChangeIMG.Name = "ChangeIMG"
        Me.ChangeIMG.Size = New System.Drawing.Size(79, 23)
        Me.ChangeIMG.TabIndex = 18
        Me.ChangeIMG.Text = "Change img"
        Me.ChangeIMG.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(593, 306)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(142, 120)
        Me.Modify.TabIndex = 19
        Me.Modify.Text = "Modify"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'CheckStatuss
        '
        Me.CheckStatuss.AutoSize = True
        Me.CheckStatuss.Location = New System.Drawing.Point(542, 148)
        Me.CheckStatuss.Name = "CheckStatuss"
        Me.CheckStatuss.Size = New System.Drawing.Size(40, 17)
        Me.CheckStatuss.TabIndex = 20
        Me.CheckStatuss.Text = "Up"
        Me.CheckStatuss.UseVisualStyleBackColor = True
        '
        'schedule
        '
        Me.schedule.AllowUserToOrderColumns = True
        Me.schedule.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.schedule.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.schedule.Location = New System.Drawing.Point(31, 306)
        Me.schedule.Name = "schedule"
        Me.schedule.Size = New System.Drawing.Size(540, 120)
        Me.schedule.TabIndex = 22
        '
        'AddSchedule
        '
        Me.AddSchedule.Location = New System.Drawing.Point(345, 268)
        Me.AddSchedule.Name = "AddSchedule"
        Me.AddSchedule.Size = New System.Drawing.Size(110, 23)
        Me.AddSchedule.TabIndex = 23
        Me.AddSchedule.Text = "Add Schedule"
        Me.AddSchedule.UseVisualStyleBackColor = True
        '
        'addSchedule1
        '
        Me.addSchedule1.Location = New System.Drawing.Point(327, 306)
        Me.addSchedule1.Name = "addSchedule1"
        Me.addSchedule1.Size = New System.Drawing.Size(110, 99)
        Me.addSchedule1.TabIndex = 24
        Me.addSchedule1.Text = "Add Schedule"
        Me.addSchedule1.UseVisualStyleBackColor = True
        '
        'txtScheduleID
        '
        Me.txtScheduleID.Enabled = False
        Me.txtScheduleID.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtScheduleID.Location = New System.Drawing.Point(310, 105)
        Me.txtScheduleID.Name = "txtScheduleID"
        Me.txtScheduleID.Size = New System.Drawing.Size(204, 20)
        Me.txtScheduleID.TabIndex = 25
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(238, 109)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(66, 13)
        Me.lblSchedule.TabIndex = 26
        Me.lblSchedule.Text = "Schedule ID"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(360, 142)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(110, 20)
        Me.txtTime.TabIndex = 27
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(324, 145)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "Time"
        '
        'lblHintTime
        '
        Me.lblHintTime.AutoSize = True
        Me.lblHintTime.ForeColor = System.Drawing.Color.Red
        Me.lblHintTime.Location = New System.Drawing.Point(360, 169)
        Me.lblHintTime.Name = "lblHintTime"
        Me.lblHintTime.Size = New System.Drawing.Size(143, 13)
        Me.lblHintTime.TabIndex = 29
        Me.lblHintTime.Text = "*With 24hours Format: hhmm"
        '
        'txtHall
        '
        Me.txtHall.Location = New System.Drawing.Point(363, 196)
        Me.txtHall.Name = "txtHall"
        Me.txtHall.Size = New System.Drawing.Size(68, 20)
        Me.txtHall.TabIndex = 30
        '
        'lblHall
        '
        Me.lblHall.AutoSize = True
        Me.lblHall.Location = New System.Drawing.Point(319, 199)
        Me.lblHall.Name = "lblHall"
        Me.lblHall.Size = New System.Drawing.Size(39, 13)
        Me.lblHall.TabIndex = 31
        Me.lblHall.Text = "Hall ID"
        '
        'lblHintHall
        '
        Me.lblHintHall.AutoSize = True
        Me.lblHintHall.ForeColor = System.Drawing.Color.Red
        Me.lblHintHall.Location = New System.Drawing.Point(361, 219)
        Me.lblHintHall.Name = "lblHintHall"
        Me.lblHintHall.Size = New System.Drawing.Size(25, 13)
        Me.lblHintHall.TabIndex = 32
        Me.lblHintHall.Text = "*H?"
        '
        'DTSchedule
        '
        Me.DTSchedule.Location = New System.Drawing.Point(360, 242)
        Me.DTSchedule.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DTSchedule.Name = "DTSchedule"
        Me.DTSchedule.Size = New System.Drawing.Size(191, 20)
        Me.DTSchedule.TabIndex = 33
        Me.DTSchedule.Value = New Date(2020, 4, 25, 0, 18, 32, 0)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(324, 245)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Date"
        '
        'ModifySchedule
        '
        Me.ModifySchedule.Location = New System.Drawing.Point(381, 306)
        Me.ModifySchedule.Name = "ModifySchedule"
        Me.ModifySchedule.Size = New System.Drawing.Size(110, 99)
        Me.ModifySchedule.TabIndex = 35
        Me.ModifySchedule.Text = "ModifySchedule"
        Me.ModifySchedule.UseVisualStyleBackColor = True
        '
        'ModifyMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ModifySchedule)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.DTSchedule)
        Me.Controls.Add(Me.lblHintHall)
        Me.Controls.Add(Me.lblHall)
        Me.Controls.Add(Me.txtHall)
        Me.Controls.Add(Me.lblHintTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.txtScheduleID)
        Me.Controls.Add(Me.addSchedule1)
        Me.Controls.Add(Me.AddSchedule)
        Me.Controls.Add(Me.schedule)
        Me.Controls.Add(Me.CheckStatuss)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.ChangeIMG)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextMlength)
        Me.Controls.Add(Me.TextMrating)
        Me.Controls.Add(Me.TextMdesc)
        Me.Controls.Add(Me.TextMgenre)
        Me.Controls.Add(Me.TextMname)
        Me.Controls.Add(Me.PicMovie)
        Me.Controls.Add(Me.MovieID)
        Me.Controls.Add(Me.TextMid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModifyMovie"
        Me.Text = "Astronomia"
        CType(Me.PicMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextMid As TextBox
    Friend WithEvents MovieID As Label
    Friend WithEvents PicMovie As PictureBox
    Friend WithEvents TextMname As TextBox
    Friend WithEvents TextMgenre As TextBox
    Friend WithEvents TextMdesc As TextBox
    Friend WithEvents TextMrating As TextBox
    Friend WithEvents TextMlength As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Search As Button
    Friend WithEvents ChangeIMG As Button
    Friend WithEvents Modify As Button
    Friend WithEvents CheckStatuss As CheckBox
    Friend WithEvents schedule As DataGridView
    Friend WithEvents AddSchedule As Button
    Friend WithEvents addSchedule1 As Button
    Friend WithEvents txtScheduleID As TextBox
    Friend WithEvents lblSchedule As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblHintTime As Label
    Friend WithEvents txtHall As TextBox
    Friend WithEvents lblHall As Label
    Friend WithEvents lblHintHall As Label
    Friend WithEvents DTSchedule As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents ModifySchedule As Button
End Class

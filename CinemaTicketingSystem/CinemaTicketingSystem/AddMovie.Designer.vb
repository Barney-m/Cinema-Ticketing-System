<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMovie))
        Me.MovieIMG = New System.Windows.Forms.PictureBox()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextLength = New System.Windows.Forms.TextBox()
        Me.TextGenre = New System.Windows.Forms.TextBox()
        Me.TextRating = New System.Windows.Forms.TextBox()
        Me.TextDesc = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelLength = New System.Windows.Forms.Label()
        Me.LabelRating = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.ChooseIMG = New System.Windows.Forms.Button()
        Me.AddIMG = New System.Windows.Forms.Button()
        Me.CheckStatus = New System.Windows.Forms.CheckBox()
        Me.DTSchedule1 = New System.Windows.Forms.DateTimePicker()
        Me.sid1 = New System.Windows.Forms.TextBox()
        Me.stime1 = New System.Windows.Forms.TextBox()
        Me.hid1 = New System.Windows.Forms.TextBox()
        Me.scheduleID = New System.Windows.Forms.Label()
        Me.hallID = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.scheduleDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MovieIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovieIMG
        '
        Me.MovieIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MovieIMG.Location = New System.Drawing.Point(101, 85)
        Me.MovieIMG.Name = "MovieIMG"
        Me.MovieIMG.Size = New System.Drawing.Size(161, 188)
        Me.MovieIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MovieIMG.TabIndex = 0
        Me.MovieIMG.TabStop = False
        '
        'TextID
        '
        Me.TextID.Enabled = False
        Me.TextID.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextID.Location = New System.Drawing.Point(361, 85)
        Me.TextID.Name = "TextID"
        Me.TextID.ReadOnly = True
        Me.TextID.Size = New System.Drawing.Size(100, 20)
        Me.TextID.TabIndex = 1
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(361, 131)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(176, 20)
        Me.TextName.TabIndex = 2
        '
        'TextLength
        '
        Me.TextLength.Location = New System.Drawing.Point(361, 170)
        Me.TextLength.Name = "TextLength"
        Me.TextLength.Size = New System.Drawing.Size(100, 20)
        Me.TextLength.TabIndex = 3
        '
        'TextGenre
        '
        Me.TextGenre.Location = New System.Drawing.Point(361, 213)
        Me.TextGenre.Name = "TextGenre"
        Me.TextGenre.Size = New System.Drawing.Size(100, 20)
        Me.TextGenre.TabIndex = 4
        '
        'TextRating
        '
        Me.TextRating.Location = New System.Drawing.Point(546, 170)
        Me.TextRating.Name = "TextRating"
        Me.TextRating.Size = New System.Drawing.Size(100, 20)
        Me.TextRating.TabIndex = 5
        '
        'TextDesc
        '
        Me.TextDesc.Location = New System.Drawing.Point(361, 257)
        Me.TextDesc.Name = "TextDesc"
        Me.TextDesc.Size = New System.Drawing.Size(294, 20)
        Me.TextDesc.TabIndex = 7
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(305, 88)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(50, 13)
        Me.LabelID.TabIndex = 8
        Me.LabelID.Text = "Movie ID"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(288, 131)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(67, 13)
        Me.LabelName.TabIndex = 9
        Me.LabelName.Text = "Movie Name"
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(308, 173)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(47, 13)
        Me.LabelLength.TabIndex = 10
        Me.LabelLength.Text = "Duration"
        '
        'LabelRating
        '
        Me.LabelRating.AutoSize = True
        Me.LabelRating.Location = New System.Drawing.Point(502, 173)
        Me.LabelRating.Name = "LabelRating"
        Me.LabelRating.Size = New System.Drawing.Size(38, 13)
        Me.LabelRating.TabIndex = 11
        Me.LabelRating.Text = "Rating"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Genre"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(503, 216)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelStatus.TabIndex = 13
        Me.LabelStatus.Text = "Status"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Location = New System.Drawing.Point(295, 260)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(60, 13)
        Me.LabelDesc.TabIndex = 14
        Me.LabelDesc.Text = "Description"
        '
        'ChooseIMG
        '
        Me.ChooseIMG.Location = New System.Drawing.Point(118, 292)
        Me.ChooseIMG.Name = "ChooseIMG"
        Me.ChooseIMG.Size = New System.Drawing.Size(126, 23)
        Me.ChooseIMG.TabIndex = 15
        Me.ChooseIMG.Text = "Choose Image"
        Me.ChooseIMG.UseVisualStyleBackColor = True
        '
        'AddIMG
        '
        Me.AddIMG.Location = New System.Drawing.Point(561, 325)
        Me.AddIMG.Name = "AddIMG"
        Me.AddIMG.Size = New System.Drawing.Size(165, 97)
        Me.AddIMG.TabIndex = 16
        Me.AddIMG.Text = "ADD"
        Me.AddIMG.UseVisualStyleBackColor = True
        '
        'CheckStatus
        '
        Me.CheckStatus.AutoSize = True
        Me.CheckStatus.Checked = True
        Me.CheckStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckStatus.Location = New System.Drawing.Point(575, 216)
        Me.CheckStatus.Name = "CheckStatus"
        Me.CheckStatus.Size = New System.Drawing.Size(40, 17)
        Me.CheckStatus.TabIndex = 17
        Me.CheckStatus.Text = "Up"
        Me.CheckStatus.UseVisualStyleBackColor = True
        '
        'DTSchedule1
        '
        Me.DTSchedule1.Location = New System.Drawing.Point(156, 384)
        Me.DTSchedule1.Name = "DTSchedule1"
        Me.DTSchedule1.Size = New System.Drawing.Size(191, 20)
        Me.DTSchedule1.TabIndex = 21
        '
        'sid1
        '
        Me.sid1.Enabled = False
        Me.sid1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.sid1.Location = New System.Drawing.Point(156, 345)
        Me.sid1.Name = "sid1"
        Me.sid1.ReadOnly = True
        Me.sid1.Size = New System.Drawing.Size(138, 20)
        Me.sid1.TabIndex = 22
        '
        'stime1
        '
        Me.stime1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.stime1.Location = New System.Drawing.Point(420, 386)
        Me.stime1.Name = "stime1"
        Me.stime1.Size = New System.Drawing.Size(117, 20)
        Me.stime1.TabIndex = 23
        '
        'hid1
        '
        Me.hid1.Location = New System.Drawing.Point(420, 348)
        Me.hid1.Name = "hid1"
        Me.hid1.Size = New System.Drawing.Size(54, 20)
        Me.hid1.TabIndex = 24
        '
        'scheduleID
        '
        Me.scheduleID.AutoSize = True
        Me.scheduleID.Location = New System.Drawing.Point(84, 351)
        Me.scheduleID.Name = "scheduleID"
        Me.scheduleID.Size = New System.Drawing.Size(66, 13)
        Me.scheduleID.TabIndex = 25
        Me.scheduleID.Text = "Schedule ID"
        '
        'hallID
        '
        Me.hallID.AutoSize = True
        Me.hallID.Location = New System.Drawing.Point(375, 352)
        Me.hallID.Name = "hallID"
        Me.hallID.Size = New System.Drawing.Size(39, 13)
        Me.hallID.TabIndex = 26
        Me.hallID.Text = "Hall ID"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(384, 390)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(30, 13)
        Me.time.TabIndex = 27
        Me.time.Text = "Time"
        '
        'scheduleDate
        '
        Me.scheduleDate.AutoSize = True
        Me.scheduleDate.Location = New System.Drawing.Point(115, 386)
        Me.scheduleDate.Name = "scheduleDate"
        Me.scheduleDate.Size = New System.Drawing.Size(30, 13)
        Me.scheduleDate.TabIndex = 28
        Me.scheduleDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(397, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "*With 24hours Format: hhmm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(480, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "*H?"
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scheduleDate)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.hallID)
        Me.Controls.Add(Me.scheduleID)
        Me.Controls.Add(Me.hid1)
        Me.Controls.Add(Me.stime1)
        Me.Controls.Add(Me.sid1)
        Me.Controls.Add(Me.DTSchedule1)
        Me.Controls.Add(Me.CheckStatus)
        Me.Controls.Add(Me.AddIMG)
        Me.Controls.Add(Me.ChooseIMG)
        Me.Controls.Add(Me.LabelDesc)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelRating)
        Me.Controls.Add(Me.LabelLength)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TextDesc)
        Me.Controls.Add(Me.TextRating)
        Me.Controls.Add(Me.TextGenre)
        Me.Controls.Add(Me.TextLength)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.MovieIMG)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddMovie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Astronomia"
        CType(Me.MovieIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovieIMG As PictureBox
    Friend WithEvents TextID As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextLength As TextBox
    Friend WithEvents TextGenre As TextBox
    Friend WithEvents TextRating As TextBox
    Friend WithEvents TextDesc As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelLength As Label
    Friend WithEvents LabelRating As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelDesc As Label
    Friend WithEvents ChooseIMG As Button
    Friend WithEvents AddIMG As Button
    Friend WithEvents CheckStatus As CheckBox
    Friend WithEvents DTSchedule1 As DateTimePicker
    Friend WithEvents sid1 As TextBox
    Friend WithEvents stime1 As TextBox
    Friend WithEvents hid1 As TextBox
    Friend WithEvents scheduleID As Label
    Friend WithEvents hallID As Label
    Friend WithEvents time As Label
    Friend WithEvents scheduleDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

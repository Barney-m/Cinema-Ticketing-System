<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextMid = New System.Windows.Forms.TextBox()
        Me.MovieID = New System.Windows.Forms.Label()
        Me.PicMovie = New System.Windows.Forms.PictureBox()
        Me.TextMname = New System.Windows.Forms.TextBox()
        Me.TextMstatus = New System.Windows.Forms.TextBox()
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
        CType(Me.PicMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextMid
        '
        Me.TextMid.Location = New System.Drawing.Point(287, 63)
        Me.TextMid.Name = "TextMid"
        Me.TextMid.Size = New System.Drawing.Size(204, 20)
        Me.TextMid.TabIndex = 0
        '
        'MovieID
        '
        Me.MovieID.AutoSize = True
        Me.MovieID.Location = New System.Drawing.Point(231, 66)
        Me.MovieID.Name = "MovieID"
        Me.MovieID.Size = New System.Drawing.Size(50, 13)
        Me.MovieID.TabIndex = 1
        Me.MovieID.Text = "Movie ID"
        '
        'PicMovie
        '
        Me.PicMovie.Location = New System.Drawing.Point(89, 138)
        Me.PicMovie.Name = "PicMovie"
        Me.PicMovie.Size = New System.Drawing.Size(143, 153)
        Me.PicMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMovie.TabIndex = 2
        Me.PicMovie.TabStop = False
        '
        'TextMname
        '
        Me.TextMname.Location = New System.Drawing.Point(360, 145)
        Me.TextMname.Name = "TextMname"
        Me.TextMname.Size = New System.Drawing.Size(100, 20)
        Me.TextMname.TabIndex = 3
        '
        'TextMstatus
        '
        Me.TextMstatus.Location = New System.Drawing.Point(360, 186)
        Me.TextMstatus.Name = "TextMstatus"
        Me.TextMstatus.Size = New System.Drawing.Size(100, 20)
        Me.TextMstatus.TabIndex = 4
        '
        'TextMgenre
        '
        Me.TextMgenre.Location = New System.Drawing.Point(360, 224)
        Me.TextMgenre.Name = "TextMgenre"
        Me.TextMgenre.Size = New System.Drawing.Size(100, 20)
        Me.TextMgenre.TabIndex = 5
        '
        'TextMdesc
        '
        Me.TextMdesc.Location = New System.Drawing.Point(360, 260)
        Me.TextMdesc.Name = "TextMdesc"
        Me.TextMdesc.Size = New System.Drawing.Size(282, 20)
        Me.TextMdesc.TabIndex = 6
        '
        'TextMrating
        '
        Me.TextMrating.Location = New System.Drawing.Point(527, 186)
        Me.TextMrating.Name = "TextMrating"
        Me.TextMrating.Size = New System.Drawing.Size(100, 20)
        Me.TextMrating.TabIndex = 8
        '
        'TextMlength
        '
        Me.TextMlength.Location = New System.Drawing.Point(527, 148)
        Me.TextMlength.Name = "TextMlength"
        Me.TextMlength.Size = New System.Drawing.Size(100, 20)
        Me.TextMlength.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rating"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Duration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Genre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Description"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(497, 63)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(104, 23)
        Me.Search.TabIndex = 17
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'ChangeIMG
        '
        Me.ChangeIMG.Location = New System.Drawing.Point(122, 297)
        Me.ChangeIMG.Name = "ChangeIMG"
        Me.ChangeIMG.Size = New System.Drawing.Size(79, 23)
        Me.ChangeIMG.TabIndex = 18
        Me.ChangeIMG.Text = "Change img"
        Me.ChangeIMG.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(371, 367)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(170, 43)
        Me.Modify.TabIndex = 19
        Me.Modify.Text = "Modify"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'ModifyMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.TextMstatus)
        Me.Controls.Add(Me.TextMname)
        Me.Controls.Add(Me.PicMovie)
        Me.Controls.Add(Me.MovieID)
        Me.Controls.Add(Me.TextMid)
        Me.Name = "ModifyMovie"
        Me.Text = "ModifyMovie"
        CType(Me.PicMovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextMid As TextBox
    Friend WithEvents MovieID As Label
    Friend WithEvents PicMovie As PictureBox
    Friend WithEvents TextMname As TextBox
    Friend WithEvents TextMstatus As TextBox
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
End Class

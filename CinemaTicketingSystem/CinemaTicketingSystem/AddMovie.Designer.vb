<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Me.MovieIMG = New System.Windows.Forms.PictureBox()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextLength = New System.Windows.Forms.TextBox()
        Me.TextGenre = New System.Windows.Forms.TextBox()
        Me.TextRating = New System.Windows.Forms.TextBox()
        Me.TextStatus = New System.Windows.Forms.TextBox()
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
        Me.TextID.Location = New System.Drawing.Point(361, 85)
        Me.TextID.Name = "TextID"
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
        'TextStatus
        '
        Me.TextStatus.Location = New System.Drawing.Point(546, 213)
        Me.TextStatus.Name = "TextStatus"
        Me.TextStatus.Size = New System.Drawing.Size(100, 20)
        Me.TextStatus.TabIndex = 6
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
        Me.AddIMG.Location = New System.Drawing.Point(308, 354)
        Me.AddIMG.Name = "AddIMG"
        Me.AddIMG.Size = New System.Drawing.Size(174, 45)
        Me.AddIMG.TabIndex = 16
        Me.AddIMG.Text = "ADD"
        Me.AddIMG.UseVisualStyleBackColor = True
        '
        'AddMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.TextStatus)
        Me.Controls.Add(Me.TextRating)
        Me.Controls.Add(Me.TextGenre)
        Me.Controls.Add(Me.TextLength)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.MovieIMG)
        Me.Name = "AddMovie"
        Me.Text = "AddMovie"
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
    Friend WithEvents TextStatus As TextBox
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
End Class

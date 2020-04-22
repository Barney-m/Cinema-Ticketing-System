<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveMovie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoveMovie))
        Me.DeleteMovieID = New System.Windows.Forms.TextBox()
        Me.RMovieIMG = New System.Windows.Forms.PictureBox()
        Me.MovieIDD = New System.Windows.Forms.Label()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.MovieNamee = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.RMovieIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteMovieID
        '
        Me.DeleteMovieID.Location = New System.Drawing.Point(326, 89)
        Me.DeleteMovieID.Name = "DeleteMovieID"
        Me.DeleteMovieID.Size = New System.Drawing.Size(129, 20)
        Me.DeleteMovieID.TabIndex = 0
        '
        'RMovieIMG
        '
        Me.RMovieIMG.Location = New System.Drawing.Point(221, 166)
        Me.RMovieIMG.Name = "RMovieIMG"
        Me.RMovieIMG.Size = New System.Drawing.Size(100, 106)
        Me.RMovieIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RMovieIMG.TabIndex = 2
        Me.RMovieIMG.TabStop = False
        '
        'MovieIDD
        '
        Me.MovieIDD.AutoSize = True
        Me.MovieIDD.Location = New System.Drawing.Point(258, 92)
        Me.MovieIDD.Name = "MovieIDD"
        Me.MovieIDD.Size = New System.Drawing.Size(50, 13)
        Me.MovieIDD.TabIndex = 3
        Me.MovieIDD.Text = "Movie ID"
        '
        'RemoveBtn
        '
        Me.RemoveBtn.Location = New System.Drawing.Point(308, 327)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(111, 42)
        Me.RemoveBtn.TabIndex = 4
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = True
        '
        'MovieNamee
        '
        Me.MovieNamee.AutoSize = True
        Me.MovieNamee.Location = New System.Drawing.Point(352, 209)
        Me.MovieNamee.Name = "MovieNamee"
        Me.MovieNamee.Size = New System.Drawing.Size(76, 13)
        Me.MovieNamee.TabIndex = 5
        Me.MovieNamee.Text = "Movie Name : "
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(461, 87)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 6
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(450, 209)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Label1"
        '
        'RemoveMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.MovieNamee)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.MovieIDD)
        Me.Controls.Add(Me.RMovieIMG)
        Me.Controls.Add(Me.DeleteMovieID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoveMovie"
        Me.Text = "Astronomia"
        CType(Me.RMovieIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeleteMovieID As TextBox
    Friend WithEvents RMovieIMG As PictureBox
    Friend WithEvents MovieIDD As Label
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents MovieNamee As Label
    Friend WithEvents Search As Button
    Friend WithEvents lblName As Label
End Class

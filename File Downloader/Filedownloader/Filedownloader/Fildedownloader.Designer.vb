<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fildedownloader
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
        Me.LabelUrl = New System.Windows.Forms.Label()
        Me.LabelFileLocation = New System.Windows.Forms.Label()
        Me.TextBoxUrl = New System.Windows.Forms.TextBox()
        Me.TextBoxLocation = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.ProgressBarPercentageDownload = New System.Windows.Forms.ProgressBar()
        Me.ButtonPaste = New System.Windows.Forms.Button()
        Me.TextBoxFilename = New System.Windows.Forms.TextBox()
        Me.labelFilename = New System.Windows.Forms.Label()
        Me.LabelPercentage = New System.Windows.Forms.Label()
        Me.updater1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelUrl
        '
        Me.LabelUrl.AutoSize = True
        Me.LabelUrl.Location = New System.Drawing.Point(72, 59)
        Me.LabelUrl.Name = "LabelUrl"
        Me.LabelUrl.Size = New System.Drawing.Size(28, 15)
        Me.LabelUrl.TabIndex = 0
        Me.LabelUrl.Text = "URL"
        '
        'LabelFileLocation
        '
        Me.LabelFileLocation.AutoSize = True
        Me.LabelFileLocation.Location = New System.Drawing.Point(12, 104)
        Me.LabelFileLocation.Name = "LabelFileLocation"
        Me.LabelFileLocation.Size = New System.Drawing.Size(88, 15)
        Me.LabelFileLocation.TabIndex = 1
        Me.LabelFileLocation.Text = "FILE LOCATION"
        '
        'TextBoxUrl
        '
        Me.TextBoxUrl.Location = New System.Drawing.Point(106, 51)
        Me.TextBoxUrl.Name = "TextBoxUrl"
        Me.TextBoxUrl.Size = New System.Drawing.Size(290, 23)
        Me.TextBoxUrl.TabIndex = 2
        '
        'TextBoxLocation
        '
        Me.TextBoxLocation.Location = New System.Drawing.Point(106, 95)
        Me.TextBoxLocation.Name = "TextBoxLocation"
        Me.TextBoxLocation.Size = New System.Drawing.Size(290, 23)
        Me.TextBoxLocation.TabIndex = 3
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.ForeColor = System.Drawing.Color.Black
        Me.ButtonBrowse.Location = New System.Drawing.Point(418, 95)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 4
        Me.ButtonBrowse.Text = "BROWSE"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'ButtonDownload
        '
        Me.ButtonDownload.ForeColor = System.Drawing.Color.Black
        Me.ButtonDownload.Location = New System.Drawing.Point(106, 172)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(87, 23)
        Me.ButtonDownload.TabIndex = 5
        Me.ButtonDownload.Text = "DOWNLOAD"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        Me.ButtonDownload.Visible = False
        '
        'ProgressBarPercentageDownload
        '
        Me.ProgressBarPercentageDownload.Location = New System.Drawing.Point(210, 172)
        Me.ProgressBarPercentageDownload.Name = "ProgressBarPercentageDownload"
        Me.ProgressBarPercentageDownload.Size = New System.Drawing.Size(283, 23)
        Me.ProgressBarPercentageDownload.TabIndex = 6
        Me.ProgressBarPercentageDownload.Visible = False
        '
        'ButtonPaste
        '
        Me.ButtonPaste.ForeColor = System.Drawing.Color.Black
        Me.ButtonPaste.Location = New System.Drawing.Point(418, 50)
        Me.ButtonPaste.Name = "ButtonPaste"
        Me.ButtonPaste.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPaste.TabIndex = 7
        Me.ButtonPaste.Text = "PASTE"
        Me.ButtonPaste.UseVisualStyleBackColor = True
        '
        'TextBoxFilename
        '
        Me.TextBoxFilename.Location = New System.Drawing.Point(106, 134)
        Me.TextBoxFilename.Name = "TextBoxFilename"
        Me.TextBoxFilename.Size = New System.Drawing.Size(290, 23)
        Me.TextBoxFilename.TabIndex = 8
        '
        'labelFilename
        '
        Me.labelFilename.AutoSize = True
        Me.labelFilename.Location = New System.Drawing.Point(17, 137)
        Me.labelFilename.Name = "labelFilename"
        Me.labelFilename.Size = New System.Drawing.Size(55, 15)
        Me.labelFilename.TabIndex = 9
        Me.labelFilename.Text = "Filename"
        '
        'LabelPercentage
        '
        Me.LabelPercentage.AutoSize = True
        Me.LabelPercentage.Location = New System.Drawing.Point(330, 211)
        Me.LabelPercentage.Name = "LabelPercentage"
        Me.LabelPercentage.Size = New System.Drawing.Size(66, 15)
        Me.LabelPercentage.TabIndex = 10
        Me.LabelPercentage.Text = "Percentage"
        '
        'updater1
        '
        Me.updater1.Enabled = True
        '
        'Fildedownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 258)
        Me.Controls.Add(Me.LabelPercentage)
        Me.Controls.Add(Me.labelFilename)
        Me.Controls.Add(Me.TextBoxFilename)
        Me.Controls.Add(Me.ButtonPaste)
        Me.Controls.Add(Me.ProgressBarPercentageDownload)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.TextBoxLocation)
        Me.Controls.Add(Me.TextBoxUrl)
        Me.Controls.Add(Me.LabelFileLocation)
        Me.Controls.Add(Me.LabelUrl)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Fildedownloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileDownloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUrl As Label
    Friend WithEvents LabelFileLocation As Label
    Friend WithEvents TextBoxUrl As TextBox
    Friend WithEvents TextBoxLocation As TextBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents ProgressBarPercentageDownload As ProgressBar
    Friend WithEvents ButtonPaste As Button
    Friend WithEvents TextBoxFilename As TextBox
    Friend WithEvents labelFilename As Label
    Friend WithEvents LabelPercentage As Label
    Friend WithEvents updater1 As Timer
End Class

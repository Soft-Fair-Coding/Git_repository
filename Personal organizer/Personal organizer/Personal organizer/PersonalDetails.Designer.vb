<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblFirtsName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblPhoneHome = New System.Windows.Forms.Label()
        Me.lblPhoneMobile = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhoneHome = New System.Windows.Forms.TextBox()
        Me.txtPhoneMobile = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblFavorites = New System.Windows.Forms.Label()
        Me.txtFavorites = New System.Windows.Forms.TextBox()
        Me.lblGiftCategories = New System.Windows.Forms.Label()
        Me.chkBooks = New System.Windows.Forms.CheckBox()
        Me.chkToys = New System.Windows.Forms.CheckBox()
        Me.chkVideos = New System.Windows.Forms.CheckBox()
        Me.chkVideoGames = New System.Windows.Forms.CheckBox()
        Me.chkMusic = New System.Windows.Forms.CheckBox()
        Me.chkApparel = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblFirtsName
        '
        Me.lblFirtsName.AutoSize = True
        Me.lblFirtsName.Location = New System.Drawing.Point(3, 6)
        Me.lblFirtsName.Name = "lblFirtsName"
        Me.lblFirtsName.Size = New System.Drawing.Size(55, 13)
        Me.lblFirtsName.TabIndex = 0
        Me.lblFirtsName.Text = "First name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(90, 3)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(140, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(270, 6)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(56, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last name"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(3, 117)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(45, 13)
        Me.lblDateOfBirth.TabIndex = 10
        Me.lblDateOfBirth.Text = "Birthday"
        '
        'lblPhoneHome
        '
        Me.lblPhoneHome.AutoSize = True
        Me.lblPhoneHome.Location = New System.Drawing.Point(3, 30)
        Me.lblPhoneHome.Name = "lblPhoneHome"
        Me.lblPhoneHome.Size = New System.Drawing.Size(38, 13)
        Me.lblPhoneHome.TabIndex = 4
        Me.lblPhoneHome.Text = "Phone"
        '
        'lblPhoneMobile
        '
        Me.lblPhoneMobile.AutoSize = True
        Me.lblPhoneMobile.Location = New System.Drawing.Point(270, 30)
        Me.lblPhoneMobile.Name = "lblPhoneMobile"
        Me.lblPhoneMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblPhoneMobile.TabIndex = 6
        Me.lblPhoneMobile.Text = "Mobile"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.Location = New System.Drawing.Point(350, 3)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(140, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtPhoneHome
        '
        Me.txtPhoneHome.Location = New System.Drawing.Point(90, 29)
        Me.txtPhoneHome.Name = "txtPhoneHome"
        Me.txtPhoneHome.Size = New System.Drawing.Size(140, 20)
        Me.txtPhoneHome.TabIndex = 5
        '
        'txtPhoneMobile
        '
        Me.txtPhoneMobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneMobile.Location = New System.Drawing.Point(350, 28)
        Me.txtPhoneMobile.Name = "txtPhoneMobile"
        Me.txtPhoneMobile.Size = New System.Drawing.Size(140, 20)
        Me.txtPhoneMobile.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(90, 55)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(400, 60)
        Me.txtAddress.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(90, 147)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(400, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(90, 245)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(400, 60)
        Me.txtNotes.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(3, 54)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(3, 146)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(3, 246)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(30, 13)
        Me.lblNote.TabIndex = 14
        Me.lblNote.Text = "Note"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(90, 121)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(140, 20)
        Me.dtpDateOfBirth.TabIndex = 11
        '
        'lblFavorites
        '
        Me.lblFavorites.AutoSize = True
        Me.lblFavorites.Location = New System.Drawing.Point(3, 172)
        Me.lblFavorites.Name = "lblFavorites"
        Me.lblFavorites.Size = New System.Drawing.Size(50, 13)
        Me.lblFavorites.TabIndex = 16
        Me.lblFavorites.Text = "Favorites"
        '
        'txtFavorites
        '
        Me.txtFavorites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFavorites.Location = New System.Drawing.Point(90, 173)
        Me.txtFavorites.Name = "txtFavorites"
        Me.txtFavorites.Size = New System.Drawing.Size(400, 20)
        Me.txtFavorites.TabIndex = 17
        '
        'lblGiftCategories
        '
        Me.lblGiftCategories.AutoSize = True
        Me.lblGiftCategories.Location = New System.Drawing.Point(3, 197)
        Me.lblGiftCategories.Name = "lblGiftCategories"
        Me.lblGiftCategories.Size = New System.Drawing.Size(75, 13)
        Me.lblGiftCategories.TabIndex = 18
        Me.lblGiftCategories.Text = "Gitf categories"
        '
        'chkBooks
        '
        Me.chkBooks.AutoSize = True
        Me.chkBooks.Location = New System.Drawing.Point(90, 199)
        Me.chkBooks.Name = "chkBooks"
        Me.chkBooks.Size = New System.Drawing.Size(56, 17)
        Me.chkBooks.TabIndex = 19
        Me.chkBooks.Text = "Books"
        Me.chkBooks.UseVisualStyleBackColor = True
        '
        'chkToys
        '
        Me.chkToys.AutoSize = True
        Me.chkToys.Location = New System.Drawing.Point(90, 222)
        Me.chkToys.Name = "chkToys"
        Me.chkToys.Size = New System.Drawing.Size(49, 17)
        Me.chkToys.TabIndex = 20
        Me.chkToys.Text = "Toys"
        Me.chkToys.UseVisualStyleBackColor = True
        '
        'chkVideos
        '
        Me.chkVideos.AutoSize = True
        Me.chkVideos.Location = New System.Drawing.Point(190, 199)
        Me.chkVideos.Name = "chkVideos"
        Me.chkVideos.Size = New System.Drawing.Size(58, 17)
        Me.chkVideos.TabIndex = 22
        Me.chkVideos.Text = "Videos"
        Me.chkVideos.UseVisualStyleBackColor = True
        '
        'chkVideoGames
        '
        Me.chkVideoGames.AutoSize = True
        Me.chkVideoGames.Location = New System.Drawing.Point(190, 222)
        Me.chkVideoGames.Name = "chkVideoGames"
        Me.chkVideoGames.Size = New System.Drawing.Size(87, 17)
        Me.chkVideoGames.TabIndex = 24
        Me.chkVideoGames.Text = "Video games"
        Me.chkVideoGames.UseVisualStyleBackColor = True
        '
        'chkMusic
        '
        Me.chkMusic.AutoSize = True
        Me.chkMusic.Location = New System.Drawing.Point(320, 199)
        Me.chkMusic.Name = "chkMusic"
        Me.chkMusic.Size = New System.Drawing.Size(54, 17)
        Me.chkMusic.TabIndex = 26
        Me.chkMusic.Text = "Music"
        Me.chkMusic.UseVisualStyleBackColor = True
        '
        'chkApparel
        '
        Me.chkApparel.AutoSize = True
        Me.chkApparel.Location = New System.Drawing.Point(320, 222)
        Me.chkApparel.Name = "chkApparel"
        Me.chkApparel.Size = New System.Drawing.Size(62, 17)
        Me.chkApparel.TabIndex = 28
        Me.chkApparel.Text = "Apparel"
        Me.chkApparel.UseVisualStyleBackColor = True
        '
        'PersonalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkApparel)
        Me.Controls.Add(Me.chkMusic)
        Me.Controls.Add(Me.chkVideoGames)
        Me.Controls.Add(Me.chkVideos)
        Me.Controls.Add(Me.chkToys)
        Me.Controls.Add(Me.chkBooks)
        Me.Controls.Add(Me.lblGiftCategories)
        Me.Controls.Add(Me.txtFavorites)
        Me.Controls.Add(Me.lblFavorites)
        Me.Controls.Add(Me.dtpDateOfBirth)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhoneMobile)
        Me.Controls.Add(Me.txtPhoneHome)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblPhoneMobile)
        Me.Controls.Add(Me.lblPhoneHome)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirtsName)
        Me.Name = "PersonalDetails"
        Me.Size = New System.Drawing.Size(494, 309)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirtsName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblPhoneHome As Label
    Friend WithEvents lblPhoneMobile As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhoneHome As TextBox
    Friend WithEvents txtPhoneMobile As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents lblFavorites As Label
    Friend WithEvents txtFavorites As TextBox
    Friend WithEvents lblGiftCategories As System.Windows.Forms.Label
    Friend WithEvents chkBooks As System.Windows.Forms.CheckBox
    Friend WithEvents chkToys As System.Windows.Forms.CheckBox
    Friend WithEvents chkVideos As System.Windows.Forms.CheckBox
    Friend WithEvents chkVideoGames As System.Windows.Forms.CheckBox
    Friend WithEvents chkMusic As System.Windows.Forms.CheckBox
    Friend WithEvents chkApparel As System.Windows.Forms.CheckBox
End Class

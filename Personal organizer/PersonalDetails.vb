Public Class PersonalDetails

    Public Event ButtonClicked(ByVal intButtonType As Integer)

    Private mPerson As PersonClass
    Private m_blnAddMode As Boolean

    Private Enum CategoryValues
        Apparel = 1
        Books = 2
        Music = 4
        Toys = 8
        Videos = 16
        VideoGames = 32
    End Enum

    Public Property AddMode() As Boolean

        Get
            Return m_blnAddMode
        End Get

        Set(ByVal value As Boolean)
            m_blnAddMode = value

            If m_blnAddMode = True Then
                subSetupButtons()
            Else
                subRemoveButtons()
            End If

        End Set

    End Property

    Public Property Person() As PersonClass

        Get

            With mPerson

                .FirstName = txtFirstName.Text
                .LastName = txtLastName.Text
                .BirthDay = dtpDateOfBirth.Value
                .HomePhone = txtPhoneHome.Text
                .MobilePhone = txtPhoneMobile.Text
                .Address = txtAddress.Text
                .Email = txtEmail.Text
                .Favorites = txtFavorites.Text
                .Notes = txtNotes.Text

                Dim intGiftCategorySetting As Integer = 0
                If chkApparel.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.Apparel
                If chkBooks.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.Books
                If chkMusic.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.Music
                If chkToys.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.Toys
                If chkVideos.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.Videos
                If chkVideoGames.Checked Then intGiftCategorySetting = intGiftCategorySetting Or CategoryValues.VideoGames
                .GiftCategories = intGiftCategorySetting

            End With

            Return mPerson

        End Get

        Set(ByVal value As PersonClass)

            mPerson = value

            txtFirstName.Text = mPerson.FirstName
            txtLastName.Text = mPerson.LastName

            'dtpDateOfBirth.Value = mPerson.BirthDay            '? error
            dtpDateOfBirth.Value = CType(IIf(mPerson.BirthDay < dtpDateOfBirth.MinDate, Now.Date, mPerson.BirthDay), Date)

            txtPhoneHome.Text = mPerson.HomePhone
            txtPhoneMobile.Text = mPerson.MobilePhone
            txtAddress.Text = mPerson.Address
            txtEmail.Text = mPerson.Email
            txtFavorites.Text = mPerson.Favorites
            txtNotes.Text = mPerson.Notes

            chkApparel.Checked = (mPerson.GiftCategories And CategoryValues.Apparel) <> 0
            chkBooks.Checked = (mPerson.GiftCategories And CategoryValues.Books) <> 0
            chkMusic.Checked = (mPerson.GiftCategories And CategoryValues.Music) <> 0
            chkToys.Checked = (mPerson.GiftCategories And CategoryValues.Toys) <> 0
            chkVideos.Checked = (mPerson.GiftCategories And CategoryValues.Videos) <> 0
            chkVideoGames.Checked = (mPerson.GiftCategories And CategoryValues.VideoGames) <> 0

        End Set

    End Property

    Public Sub subResetFields()

        txtFirstName.Text = vbNullString
        txtLastName.Text = vbNullString
        dtpDateOfBirth.Value = Now
        txtPhoneHome.Text = vbNullString
        txtPhoneMobile.Text = vbNullString
        txtAddress.Text = vbNullString
        txtEmail.Text = vbNullString
        txtFavorites.Text = vbNullString
        txtNotes.Text = vbNullString

        chkApparel.Checked = False
        chkBooks.Checked = False
        chkMusic.Checked = False
        chkToys.Checked = False
        chkVideos.Checked = False
        chkVideoGames.Checked = False

        mPerson = New PersonClass

    End Sub

    Private Sub subSetupButtons()

        Dim m_objSaveButton As New Button
        Me.Controls.Add(m_objSaveButton)

        With m_objSaveButton

            .Name = "btnSave"
            .Text = "&Save"
            .Anchor = CType(AnchorStyles.Bottom + AnchorStyles.Right, AnchorStyles)

            .Top = Me.Height - (.Height + 5)
            .Left = Me.Width - (.Width + 5)

        End With

        Dim m_objCancelButton As New Button
        Me.Controls.Add(m_objCancelButton)

        With m_objCancelButton

            .Name = "btnCancel"
            .Text = "&Cancel"
            .Anchor = CType(AnchorStyles.Bottom + AnchorStyles.Right, AnchorStyles)

            .Top = m_objSaveButton.Top
            .Left = m_objSaveButton.Left - (.Width + 5)

        End With

        With txtNotes
            .Height = m_objSaveButton.Top - (.Top + 5)
        End With

        AddHandler m_objSaveButton.Click, AddressOf subButtonClickedHandler
        AddHandler m_objCancelButton.Click, AddressOf subButtonClickedHandler

    End Sub

    Public Sub subRemoveButtons()

        With Me.Controls

            For intCount As Integer = 0 To .Count - 1
                If .Item(intCount).Name = "btnSave" Then
                    .Remove(.Item(intCount))
                    Exit For
                End If
            Next

            For intCount As Integer = 0 To .Count - 1
                If .Item(intCount).Name = "btnCancel" Then
                    .Remove(.Item(intCount))
                    Exit For
                End If
            Next

            With txtNotes
                .Height = Me.Height - (.Top + 5)
            End With

        End With

    End Sub

    Private Sub subButtonClickedHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btnSender As Button = CType(sender, Button)

        If btnSender.Name = "btnSave" Then
            'remove message
            'MessageBox.Show(text:="Save was clicked", caption:="Button clicked", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            RaiseEvent ButtonClicked(1)
        ElseIf btnSender.Name = "btnCancel" Then
            'removemessage
            'MessageBox.Show(text:="Cancel was clicked", caption:="Button clicked", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
            RaiseEvent ButtonClicked(2)
        End If

    End Sub

End Class

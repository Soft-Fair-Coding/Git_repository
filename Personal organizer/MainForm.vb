Public Class frmMain

    Private WithEvents objPersonList As PersonList
    Private WithEvents objPersonalDetails As PersonalDetails

    Private Sub btnShowList_Click(sender As Object, e As EventArgs) Handles btnShowList.Click

        'PersonalDetails Object has to be removed before PersonList Is added

        objPersonList = New PersonList

        'If objPersonalDetails IsNot Nothing Then
        If pnlMain.Controls.Contains(objPersonalDetails) Then

            pnlMain.Controls.Remove(objPersonalDetails)
            objPersonalDetails = Nothing

        ElseIf pnlMain.Controls.Count > 0 Then
            pnlMain.Controls.RemoveAt(pnlMain.Controls.Count - 1)
        End If

        pnlMain.Controls.Add(objPersonList)

        objPersonList.Dock = DockStyle.Fill

    End Sub

    Private Sub btnAddPerson_Click(sender As Object, e As EventArgs) Handles btnAddPerson.Click

        objPersonalDetails = New PersonalDetails
        'Dim objPerson As New PersonClass("Martin", "Janda")

        'With objPerson

        '    .BirthDay = CType("24/10/1972", Date)           '? book does not have ctype
        '    .Address = "some adrress, some town"
        '    .HomePhone = "7791 682 056"

        'End With

        'objPersonalDetails.Person = objPerson

        'Me.Text = "Personal organizer - Viewing " & objPersonalDetails.Person.DisplayName

        'added start
        Dim objPerson As New PersonClass
        objPersonalDetails.Person = objPerson

        Me.Text = "Personal Organizer - Viewing " & objPersonalDetails.Person.DisplayName
        objPersonalDetails.AddMode = True
        'added finish

        If pnlMain.Controls.Contains(objPersonList) Then

            pnlMain.Controls.Remove(objPersonList)
            objPersonList = Nothing

        ElseIf pnlMain.Controls.Count > 0 Then
            pnlMain.Controls.RemoveAt(pnlMain.Controls.Count - 1)
        End If

        'objPersonalDetails.AddMode = True

        pnlMain.Controls.Add(objPersonalDetails)

        objPersonalDetails.Dock = DockStyle.Fill

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click, NewToolStripMenuItem.Click

        If objPersonalDetails IsNot Nothing Then

            objPersonalDetails.subResetFields()
            Me.Text = "Personal organizer"

        End If

    End Sub

    Private Sub objPersonList_ShowPersonDetails(ByVal PersonID As Integer) Handles objPersonList.ShowPersonDetails

        Dim objPersonalDetails = New PersonalDetails            '?

        Dim objPerson As PersonClass = fcGetPerson(PersonID)
        objPersonalDetails.Person = objPerson
        objPersonalDetails.AddMode = False

        Me.Text = "Personal organizer - Viewing " & objPersonalDetails.Person.DisplayName

        If pnlMain.Controls.Contains(objPersonList) Then
            pnlMain.Controls.Remove(objPersonList)
            objPersonList = Nothing
        End If

        pnlMain.Controls.Add(objPersonalDetails)
        objPersonalDetails.Dock = DockStyle.Fill

    End Sub

    Private Sub objPersonalDetails_ButtonClicked(ByVal intButtonType As Integer) Handles objPersonalDetails.ButtonClicked
        'MessageBox.Show("A button was clicked: " & intButtonType.ToString)

        Select Case intButtonType
            Case 1
                If fcAddPerson(1, objPersonalDetails.Person) Then

                    objPersonList = New PersonList

                    If objPersonalDetails IsNot Nothing Then
                        pnlMain.Controls.Remove(objPersonalDetails)
                        objPersonalDetails = Nothing
                    End If

                    pnlMain.Controls.Add(objPersonList)
                    objPersonList.Dock = DockStyle.Fill

                Else
                    MessageBox.Show("Person WAS NOT added successfully.")
                End If

            Case 2      ' cancel
                If objPersonalDetails IsNot Nothing Then
                    pnlMain.Controls.Remove(objPersonalDetails)
                    objPersonalDetails = Nothing
                End If

        End Select

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

        If objPersonalDetails IsNot Nothing Then
            If objPersonalDetails.AddMode = True Then

                If fcAddPerson(1, objPersonalDetails.Person) Then
                    MessageBox.Show("Person WAS added successfully")
                    objPersonList = New PersonList

                    If objPersonalDetails IsNot Nothing Then
                        pnlMain.Controls.Remove(objPersonalDetails)
                        objPersonalDetails = Nothing
                    End If

                    pnlMain.Controls.Add(objPersonList)
                    objPersonList.Dock = DockStyle.Fill

                Else
                    MessageBox.Show("Person WAS NOT added succesfully.")
                End If

            Else

                If fcUpdatePerson(1, objPersonalDetails.Person) Then
                    MessageBox.Show("Person WAS updated successfully.")
                Else
                    MessageBox.Show("Person WAS NOT updated successfully.")
                End If

            End If
        End If

    End Sub

End Class
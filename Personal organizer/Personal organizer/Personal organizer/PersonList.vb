Public Class PersonList

    Private m_intUserID As Integer

    Public Event ShowPersonDetails(ByVal PersonID As Integer)

    Public Property UserID() As Integer

        Get
            Return m_intUserID
        End Get

        Set(ByVal value As Integer)
            m_intUserID = value
        End Set

    End Property

    Private Sub PersonList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TblPersonTableAdapter.Fill(PO_Data_DataSet.tblPerson)

        subLoadListBox()

    End Sub

    Private Sub subLoadListBox()

        Dim PersonList_TableAdapter As New PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
        Dim PersonList_Table As New PO_Data_DataSet.tblPerson_DataTable
        PersonList_TableAdapter.Fill(PersonList_Table)

        With lstPersons

            .Items.Clear()

            .DisplayMember = "DisplayName"

            For Each CurrentRow As PO_Data_DataSet.tblPersonRow In PersonList_Table.Rows

                If CurrentRow.POUserID = m_intUserID Then

                    Dim objCurrentPerson As New PersonClass(CurrentRow.NameFirst, CurrentRow.NameLast)
                    objCurrentPerson.ID = CurrentRow.Id

                    .Items.Add(objCurrentPerson)
                    .DisplayMember = "DisplayName"

                End If

            Next

        End With

    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click

        If lstPersons.SelectedItems.Count = 0 Then

            MessageBox.Show(text:="You have not selected any people to remove.", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
            Exit Sub

        End If

        'code to delete row
        Dim DeletePerson_TableAdapter As New PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
        Dim DeletePerson_Table As New PO_Data_DataSet.tblPerson_DataTable
        DeletePerson_TableAdapter.Fill(DeletePerson_Table)

        For Each CurrentPersonRow As PO_Data_DataSet.tblPersonRow In DeletePerson_Table.Rows
            For Each objPerson As PersonClass In lstPersons.SelectedItems
                If CurrentPersonRow.Id = objPerson.ID Then
                    CurrentPersonRow.Delete()
                    Exit For
                End If
            Next
        Next

        DeletePerson_TableAdapter.Update(DeletePerson_Table)
        subLoadListBox()

    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click

        Dim strText As String = ""
        Dim strCaption As String = ""
        
        Select Case lstPersons.SelectedItems.Count
            Case 0
                strText = "You must select entry to display the details."
                strCaption = "Input error"
            Case 1

                Dim objSelectedPerson As PersonClass = CType(lstPersons.SelectedItems.Item(0), PersonClass)
                RaiseEvent ShowPersonDetails(objSelectedPerson.ID)

                Exit Sub

            Case Is > 1
                strText = "You have too many people selected." & vbNewLine &
                          "Select one only."
                strCaption = "Input error"
        End Select

        MessageBox.Show(text:=strText, caption:=strCaption, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
        
    End Sub

End Class

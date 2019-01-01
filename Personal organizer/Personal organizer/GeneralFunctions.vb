Imports System.Data

Module GeneralFunctions

    Public Function fcGetPerson(ByVal PersonID As Integer) As PersonClass

        Dim GetPerson_TableAdapter As New PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
        Dim GetPerson_Table As New PO_Data_DataSet.tblPerson_DataTable

        GetPerson_TableAdapter.Fill(GetPerson_Table)

        Dim Person_DataView As DataView = GetPerson_Table.DefaultView
        Person_DataView.RowFilter = "ID=" + PersonID.ToString

        With Person_DataView

            If .Count > 0 Then

                Dim objPerson As New PersonClass

                With .Item(0)

                    objPerson.ID = CType(.Item("ID"), Integer)
                    objPerson.FirstName = .Item("NameFirst").ToString.Trim
                    objPerson.LastName = .Item("NameLast").ToString.Trim
                    objPerson.HomePhone = .Item("PhoneHome").ToString.Trim
                    objPerson.MobilePhone = .Item("PhoneMobile").ToString.Trim
                    objPerson.Address = .Item("Address").ToString.Trim
                    objPerson.BirthDay = CType(.Item("DateOfBirth"), Date)
                    objPerson.Email = .Item("Email").ToString.Trim
                    objPerson.Favorites = .Item("Favorites").ToString.Trim
                    objPerson.GiftCategories = CType(IsDBNull(.Item("GiftCategories")), Integer)        '?
                    objPerson.Notes = .Item("Notes").ToString.Trim

                End With

                Return objPerson

            Else
                Return Nothing
            End If

        End With

    End Function

    Public Function fcAddPerson(ByVal UserID As Integer, ByVal NewPerson As PersonClass) As Boolean

        Dim AddPerson_TableAdapter As New PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
        Dim AddPerson_Table As New PO_Data_DataSet.tblPerson_DataTable
        AddPerson_TableAdapter.Fill(AddPerson_Table)

        Dim GetUser_TableAdapter As New PO_Data_DataSetTableAdapters.tblPOUser_TableAdapter
        Dim GetUser_Table As New PO_Data_DataSet.tblPOUser_DataTable
        GetUser_TableAdapter.Fill(GetUser_Table)

        Dim MyRows() As PO_Data_DataSet.tblPOUserRow = CType(GetUser_Table.Select("ID=" & UserID.ToString), PO_Data_DataSet.tblPOUserRow())

        If MyRows.Length > 0 Then

            With NewPerson
                AddPerson_Table.AddtblPersonRow(MyRows(0), .FirstName, .LastName, .BirthDay, .HomePhone, .MobilePhone, .Address, .Email, .Favorites, .GiftCategories, .Notes)
            End With

            AddPerson_TableAdapter.Update(AddPerson_Table)

        Else
            Return False
        End If

        Return True

    End Function

    Public Function fcUpdatePerson(ByVal UserID As Integer, ByVal UpdatedPerson As PersonClass) As Boolean

        Dim UpdatePerson_TableAdapter As New PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
        Dim UpdatePerson_Table As New PO_Data_DataSet.tblPerson_DataTable
        UpdatePerson_TableAdapter.Fill(UpdatePerson_Table)

        Dim MyRows() As PO_Data_DataSet.tblPersonRow = CType(UpdatePerson_Table.Select("ID=" & UpdatedPerson.ID.ToString), PO_Data_DataSet.tblPersonRow())

        If MyRows.Length > 0 Then

            With MyRows(0)

                .BeginEdit()

                .NameFirst = UpdatedPerson.FirstName
                .NameLast = UpdatedPerson.LastName
                .DateOfBirth = UpdatedPerson.BirthDay
                .PhoneHome = UpdatedPerson.HomePhone
                .PhoneMobile = UpdatedPerson.MobilePhone
                .Address = UpdatedPerson.Address
                .Email = UpdatedPerson.Email
                .Favorites = UpdatedPerson.Favorites
                .GiftCategories = UpdatedPerson.GiftCategories
                .Notes = UpdatedPerson.Notes

                .EndEdit()

            End With

            UpdatePerson_TableAdapter.Update(UpdatePerson_Table)

            'Return True         '?

        End If

        Return True

    End Function

End Module

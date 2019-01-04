Public Class frmLogin

    Private m_blnNewUser As Boolean

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strMessage As String = ""
        Dim strCaption As String = "Login instruction"
        Dim intButtons As Integer = MessageBoxButtons.OK
        Dim intIcon As Integer = MessageBoxIcon.Warning

        If My.User.IsAuthenticated Then             ' when somebody is logged in windows

            'txtUser.Text = My.User.Name
            Dim strCurrentUser As String = Mid(My.User.Name, InStr(My.User.Name, "\") + 1)
            txtUser.Text = strCurrentUser

            'If fcUserExists(My.User.Name) Then
            If fcUserExists(strCurrentUser) Then

                'Login
                txtPassword.Focus()

            Else
                'New user
                m_blnNewUser = True

                strMessage = "You are new to the system" & vbNewLine &
                            "Please enter your password." & vbNewLine & vbNewLine &
                            "Note: Password will be saved for future use" & vbNewLine &
                            "to the database."
                MessageBox.Show(text:=strMessage, caption:=strCaption, buttons:=CType(intButtons, MessageBoxButtons), icon:=CType(intIcon, MessageBoxIcon))

            End If

        Else

            strMessage = "Sorry, you are not authorized" & vbNewLine &
                        "and cannot use this program."
            MessageBox.Show(text:=strMessage, caption:=strCaption, buttons:=CType(intButtons, MessageBoxButtons), icon:=CType(intIcon, MessageBoxIcon))

        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim blnOK_Continue As Boolean = False

        Dim strMessage As String = ""
        Dim strCaption As String = "Login instruction"
        Dim intButtons As Integer = MessageBoxButtons.OK
        Dim intIcon As Integer = MessageBoxIcon.Warning

        strMessage = "Password doesn't match." & vbNewLine &
                    "Re-enter password."


        If m_blnNewUser Then

            fcCreateUser(txtUser.Text, txtPassword.Text)
            blnOK_Continue = True

        Else

            If fcUserPasswordMatches(strUserName:=txtUser.Text, strPassword:=txtPassword.Text) Then
                blnOK_Continue = True
            Else

                MessageBox.Show(text:=strMessage, caption:=strCaption, buttons:=CType(intButtons, MessageBoxButtons), icon:=CType(intIcon, MessageBoxIcon))
                txtPassword.Text = vbNullString
                txtPassword.Focus()

            End If

        End If

        If blnOK_Continue = True Then

            Dim objMainForm As New frmMain
            objMainForm.CurrentUserID = fcGetUserID(txtUser.Text)           ' ?
            objMainForm.Show()
            Me.Dispose()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

End Class
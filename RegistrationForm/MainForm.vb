Public Class mainForm
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        regPanel.Visible = False
        Guna2Transition1.HideSync(regPanel)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        regPanel.Visible = True
        Guna2Transition1.ShowSync(regPanel)

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If Not String.IsNullOrEmpty(UsernameTxt.Text) And
                Not String.IsNullOrEmpty(PasswordTxt.Text) Then

            Dim SQL As String = String.Empty
            SQL &= "SELECT *FROM UserLogin "
            SQL &= "WHERE Username = '" & UsernameTxt.Text & "' "
            SQL &= "AND Password = '" & PasswordTxt.Text & "' "

            Dim UserData As DataTable = ExecuteSQL(SQL)

            If UserData.Rows.Count > 0 Then

                UsernameTxt.Clear()
                PasswordTxt.Clear()
                ShowPasswordToggle.Checked = False

                Me.Hide()

                Dim formMain As New mainForm()
                formMain.ShowDialog()
                formMain = Nothing

                Me.Show()
                Me.UsernameTxt.Select()

            Else
                MsgBox("The Username or Password is Incorrect, Try Again.", MsgBoxStyle.Critical, "Login Form")
                UsernameTxt.Focus()
                UsernameTxt.SelectAll()
            End If

        Else
            MsgBox("Please enter Username and Password", MsgBoxStyle.Critical, "Login Form")
            UsernameTxt.Select()
        End If

    End Sub

    Private Sub ShowPasswordToggle_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordToggle.CheckedChanged
        With ShowPasswordToggle

            If .Checked Then
                PasswordTxt.UseSystemPasswordChar = False
            Else
                PasswordTxt.UseSystemPasswordChar = True
            End If

        End With

    End Sub

    Private Sub CreateAccountBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountBtn.Click

        Dim btn As MessageBoxButtons = MessageBoxButtons.OK
        Dim ico As MessageBoxIcon = MessageBoxIcon.Information
        Dim caption As String = "Account Resgistered"

        If String.IsNullOrEmpty(NameTxt.Text) Then
            MessageBox.Show("Please enter Name.", caption, btn, ico)
            NameTxt.Select()
            Return
        End If

        If String.IsNullOrEmpty(UsernameRegTxt.Text) Then
            MessageBox.Show("Please enter Username.", caption, btn, ico)
            UsernameRegTxt.Select()
            Return
        End If

        If String.IsNullOrEmpty(PasswordRegTxt.Text) Then
            MessageBox.Show("Please enter Password.", caption, btn, ico)
            PasswordRegTxt.Select()
            Return
        End If

        If String.IsNullOrEmpty(ConfirmPasswordTxt.Text) Then
            MessageBox.Show("Please enter Confirmation Password.", caption, btn, ico)
            ConfirmPasswordTxt.Select()
            Return
        End If

        If String.IsNullOrEmpty(MailTxt.Text) Then
            MessageBox.Show("Please enter Email.", caption, btn, ico)
            MailTxt.Select()
            Return
        End If

        If PasswordRegTxt.Text <> ConfirmPasswordTxt.Text Then
            MessageBox.Show("Your Password and Confirmation Password do not match.", caption, btn, ico)
            ConfirmPasswordTxt.Select()
        End If

        Dim CheckDuplicates As DataTable = ExecuteSQL("SELECT Username FROM UserLogin WHERE Username = '" & UsernameTxt.Text & "' ")

        If CheckDuplicates.Rows.Count > 0 Then
            MessageBox.Show("The Username already exists. Please try another username.", caption, btn, ico)
            UsernameRegTxt.Focus()
            Return
        End If

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure about the details given?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim mySQL As String = String.Empty

            mySQL &= "INSERT INTO UserLogin (Name, Username, Email, Password) "
            mySQL &= "VALUES ('" & NameTxt.Text & "','" & UsernameRegTxt.Text & "','" & MailTxt.Text & "','" & "','" & PasswordRegTxt.Text & "')"

            ExecuteSQL(mySQL)

            ShowUserData()

        Else
            Return
        End If

    End Sub

    Private Sub ShowUserData()
        MsgBox("Hello " + NameTxt.Text)
    End Sub

End Class

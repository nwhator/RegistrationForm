<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.loginPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.regPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ConfirmPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CreateAccountBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MailTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordRegTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameRegTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowPasswordToggle = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Panel1.SuspendLayout()
        Me.loginPanel.SuspendLayout()
        Me.regPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 41)
        Me.Panel1.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(862, 6)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(35, 35)
        Me.Guna2ControlBox2.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(903, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'loginPanel
        '
        Me.loginPanel.BackColor = System.Drawing.Color.Transparent
        Me.loginPanel.Controls.Add(Me.regPanel)
        Me.loginPanel.Controls.Add(Me.Guna2Button1)
        Me.loginPanel.Controls.Add(Me.LoginButton)
        Me.loginPanel.Controls.Add(Me.Label2)
        Me.loginPanel.Controls.Add(Me.Label3)
        Me.loginPanel.Controls.Add(Me.Label1)
        Me.loginPanel.Controls.Add(Me.ShowPasswordToggle)
        Me.loginPanel.Controls.Add(Me.PasswordTxt)
        Me.loginPanel.Controls.Add(Me.UsernameTxt)
        Me.Guna2Transition1.SetDecoration(Me.loginPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.loginPanel.FillColor = System.Drawing.Color.White
        Me.loginPanel.Location = New System.Drawing.Point(572, 76)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.loginPanel.ShadowDepth = 80
        Me.loginPanel.ShadowShift = 10
        Me.loginPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.loginPanel.Size = New System.Drawing.Size(282, 393)
        Me.loginPanel.TabIndex = 7
        '
        'regPanel
        '
        Me.regPanel.BackColor = System.Drawing.Color.Transparent
        Me.regPanel.Controls.Add(Me.ConfirmPasswordTxt)
        Me.regPanel.Controls.Add(Me.CreateAccountBtn)
        Me.regPanel.Controls.Add(Me.Label4)
        Me.regPanel.Controls.Add(Me.Label5)
        Me.regPanel.Controls.Add(Me.MailTxt)
        Me.regPanel.Controls.Add(Me.PasswordRegTxt)
        Me.regPanel.Controls.Add(Me.UsernameRegTxt)
        Me.regPanel.Controls.Add(Me.NameTxt)
        Me.Guna2Transition1.SetDecoration(Me.regPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.regPanel.FillColor = System.Drawing.Color.White
        Me.regPanel.Location = New System.Drawing.Point(0, 0)
        Me.regPanel.Name = "regPanel"
        Me.regPanel.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.regPanel.ShadowDepth = 80
        Me.regPanel.ShadowShift = 10
        Me.regPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.regPanel.Size = New System.Drawing.Size(282, 393)
        Me.regPanel.TabIndex = 7
        '
        'ConfirmPasswordTxt
        '
        Me.ConfirmPasswordTxt.BorderRadius = 8
        Me.ConfirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.ConfirmPasswordTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ConfirmPasswordTxt.DefaultText = ""
        Me.ConfirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ConfirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordTxt.FocusedState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordTxt.HoverState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.password_127px
        Me.ConfirmPasswordTxt.Location = New System.Drawing.Point(8, 203)
        Me.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt"
        Me.ConfirmPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmPasswordTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.ConfirmPasswordTxt.PlaceholderText = "Confirm Password"
        Me.ConfirmPasswordTxt.SelectedText = ""
        Me.ConfirmPasswordTxt.ShadowDecoration.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.Size = New System.Drawing.Size(240, 35)
        Me.ConfirmPasswordTxt.TabIndex = 13
        Me.ConfirmPasswordTxt.UseSystemPasswordChar = True
        '
        'CreateAccountBtn
        '
        Me.CreateAccountBtn.Animated = True
        Me.CreateAccountBtn.AutoRoundedCorners = True
        Me.CreateAccountBtn.BorderRadius = 21
        Me.CreateAccountBtn.CheckedState.Parent = Me.CreateAccountBtn
        Me.CreateAccountBtn.CustomImages.Parent = Me.CreateAccountBtn
        Me.Guna2Transition1.SetDecoration(Me.CreateAccountBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CreateAccountBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CreateAccountBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.CreateAccountBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccountBtn.ForeColor = System.Drawing.Color.White
        Me.CreateAccountBtn.HoverState.Parent = Me.CreateAccountBtn
        Me.CreateAccountBtn.Location = New System.Drawing.Point(8, 316)
        Me.CreateAccountBtn.Name = "CreateAccountBtn"
        Me.CreateAccountBtn.ShadowDecoration.Parent = Me.CreateAccountBtn
        Me.CreateAccountBtn.Size = New System.Drawing.Size(240, 45)
        Me.CreateAccountBtn.TabIndex = 12
        Me.CreateAccountBtn.Text = "Create Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(183, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Login"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(78, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Register"
        '
        'MailTxt
        '
        Me.MailTxt.BorderRadius = 8
        Me.MailTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.MailTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MailTxt.DefaultText = ""
        Me.MailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MailTxt.DisabledState.Parent = Me.MailTxt
        Me.MailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MailTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.MailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MailTxt.FocusedState.Parent = Me.MailTxt
        Me.MailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MailTxt.HoverState.Parent = Me.MailTxt
        Me.MailTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.email_127px
        Me.MailTxt.Location = New System.Drawing.Point(8, 256)
        Me.MailTxt.Name = "MailTxt"
        Me.MailTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MailTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.MailTxt.PlaceholderText = "Email"
        Me.MailTxt.SelectedText = ""
        Me.MailTxt.ShadowDecoration.Parent = Me.MailTxt
        Me.MailTxt.Size = New System.Drawing.Size(240, 35)
        Me.MailTxt.TabIndex = 6
        '
        'PasswordRegTxt
        '
        Me.PasswordRegTxt.BorderRadius = 8
        Me.PasswordRegTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.PasswordRegTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordRegTxt.DefaultText = ""
        Me.PasswordRegTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordRegTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordRegTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordRegTxt.DisabledState.Parent = Me.PasswordRegTxt
        Me.PasswordRegTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordRegTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PasswordRegTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordRegTxt.FocusedState.Parent = Me.PasswordRegTxt
        Me.PasswordRegTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordRegTxt.HoverState.Parent = Me.PasswordRegTxt
        Me.PasswordRegTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.password_127px
        Me.PasswordRegTxt.Location = New System.Drawing.Point(8, 150)
        Me.PasswordRegTxt.Name = "PasswordRegTxt"
        Me.PasswordRegTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordRegTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.PasswordRegTxt.PlaceholderText = "Password"
        Me.PasswordRegTxt.SelectedText = ""
        Me.PasswordRegTxt.ShadowDecoration.Parent = Me.PasswordRegTxt
        Me.PasswordRegTxt.Size = New System.Drawing.Size(240, 35)
        Me.PasswordRegTxt.TabIndex = 6
        Me.PasswordRegTxt.UseSystemPasswordChar = True
        '
        'UsernameRegTxt
        '
        Me.UsernameRegTxt.BorderRadius = 8
        Me.UsernameRegTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.UsernameRegTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UsernameRegTxt.DefaultText = ""
        Me.UsernameRegTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameRegTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameRegTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameRegTxt.DisabledState.Parent = Me.UsernameRegTxt
        Me.UsernameRegTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameRegTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.UsernameRegTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameRegTxt.FocusedState.Parent = Me.UsernameRegTxt
        Me.UsernameRegTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameRegTxt.HoverState.Parent = Me.UsernameRegTxt
        Me.UsernameRegTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.user_127px
        Me.UsernameRegTxt.Location = New System.Drawing.Point(8, 97)
        Me.UsernameRegTxt.Name = "UsernameRegTxt"
        Me.UsernameRegTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameRegTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.UsernameRegTxt.PlaceholderText = "Username"
        Me.UsernameRegTxt.SelectedText = ""
        Me.UsernameRegTxt.ShadowDecoration.Parent = Me.UsernameRegTxt
        Me.UsernameRegTxt.Size = New System.Drawing.Size(240, 35)
        Me.UsernameRegTxt.TabIndex = 7
        '
        'NameTxt
        '
        Me.NameTxt.BorderRadius = 8
        Me.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NameTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NameTxt.DefaultText = ""
        Me.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.DisabledState.Parent = Me.NameTxt
        Me.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.FocusedState.Parent = Me.NameTxt
        Me.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.HoverState.Parent = Me.NameTxt
        Me.NameTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.name_127px
        Me.NameTxt.Location = New System.Drawing.Point(8, 44)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.NameTxt.PlaceholderText = "Name"
        Me.NameTxt.SelectedText = ""
        Me.NameTxt.ShadowDecoration.Parent = Me.NameTxt
        Me.NameTxt.Size = New System.Drawing.Size(240, 35)
        Me.NameTxt.TabIndex = 7
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.RegistrationForm.My.Resources.Resources.right_127px
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.Location = New System.Drawing.Point(8, 334)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(240, 45)
        Me.Guna2Button1.TabIndex = 13
        Me.Guna2Button1.Text = "Create Account"
        '
        'LoginButton
        '
        Me.LoginButton.Animated = True
        Me.LoginButton.AutoRoundedCorners = True
        Me.LoginButton.BorderRadius = 21
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.Guna2Transition1.SetDecoration(Me.LoginButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(8, 207)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(240, 45)
        Me.LoginButton.TabIndex = 12
        Me.LoginButton.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(44, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Forgot Username or Password?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(64, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "User Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(49, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Show Password"
        '
        'ShowPasswordToggle
        '
        Me.ShowPasswordToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPasswordToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPasswordToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordToggle.CheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPasswordToggle.CheckedState.Parent = Me.ShowPasswordToggle
        Me.Guna2Transition1.SetDecoration(Me.ShowPasswordToggle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowPasswordToggle.Location = New System.Drawing.Point(8, 166)
        Me.ShowPasswordToggle.Name = "ShowPasswordToggle"
        Me.ShowPasswordToggle.ShadowDecoration.Parent = Me.ShowPasswordToggle
        Me.ShowPasswordToggle.Size = New System.Drawing.Size(35, 20)
        Me.ShowPasswordToggle.TabIndex = 8
        Me.ShowPasswordToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordToggle.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPasswordToggle.UncheckedState.Parent = Me.ShowPasswordToggle
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderRadius = 8
        Me.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.PasswordTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordTxt.DefaultText = ""
        Me.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.DisabledState.Parent = Me.PasswordTxt
        Me.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.FocusedState.Parent = Me.PasswordTxt
        Me.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.HoverState.Parent = Me.PasswordTxt
        Me.PasswordTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.password_127px
        Me.PasswordTxt.Location = New System.Drawing.Point(8, 112)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.PasswordTxt.PlaceholderText = "Password"
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(240, 35)
        Me.PasswordTxt.TabIndex = 6
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.BorderRadius = 8
        Me.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.UsernameTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UsernameTxt.DefaultText = ""
        Me.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.DisabledState.Parent = Me.UsernameTxt
        Me.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.FocusedState.Parent = Me.UsernameTxt
        Me.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.HoverState.Parent = Me.UsernameTxt
        Me.UsernameTxt.IconLeft = Global.RegistrationForm.My.Resources.Resources.user_127px
        Me.UsernameTxt.Location = New System.Drawing.Point(8, 58)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxt.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.UsernameTxt.PlaceholderText = "Username"
        Me.UsernameTxt.SelectedText = ""
        Me.UsernameTxt.ShadowDecoration.Parent = Me.UsernameTxt
        Me.UsernameTxt.Size = New System.Drawing.Size(240, 35)
        Me.UsernameTxt.TabIndex = 7
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation2
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.RegistrationForm.My.Resources.Resources.LoginUI
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-20, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(501, 516)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 500
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 500)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.regPanel.ResumeLayout(False)
        Me.regPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents loginPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowPasswordToggle As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsernameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents regPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents CreateAccountBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordRegTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MailTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsernameRegTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents ConfirmPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
End Class

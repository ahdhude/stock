<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.textbox_name = New System.Windows.Forms.TextBox()
        Me.label_username = New Infragistics.Win.Misc.UltraLabel()
        Me.label_password = New Infragistics.Win.Misc.UltraLabel()
        Me.textbox_pass = New System.Windows.Forms.TextBox()
        Me.Button_login = New Infragistics.Win.Misc.UltraButton()
        Me.SuspendLayout()
        '
        'textbox_name
        '
        Me.textbox_name.Location = New System.Drawing.Point(94, 49)
        Me.textbox_name.Name = "textbox_name"
        Me.textbox_name.Size = New System.Drawing.Size(100, 20)
        Me.textbox_name.TabIndex = 0
        '
        'label_username
        '
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.label_username.Appearance = Appearance1
        Me.label_username.Location = New System.Drawing.Point(12, 49)
        Me.label_username.Name = "label_username"
        Me.label_username.Size = New System.Drawing.Size(69, 20)
        Me.label_username.TabIndex = 1
        Me.label_username.Text = "User Name"
        '
        'label_password
        '
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.label_password.Appearance = Appearance2
        Me.label_password.Location = New System.Drawing.Point(12, 97)
        Me.label_password.Name = "label_password"
        Me.label_password.Size = New System.Drawing.Size(69, 20)
        Me.label_password.TabIndex = 1
        Me.label_password.Text = "Password"
        '
        'textbox_pass
        '
        Me.textbox_pass.Location = New System.Drawing.Point(94, 97)
        Me.textbox_pass.Name = "textbox_pass"
        Me.textbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textbox_pass.Size = New System.Drawing.Size(100, 20)
        Me.textbox_pass.TabIndex = 2
        '
        'Button_login
        '
        Me.Button_login.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.Button_login.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button_login.Location = New System.Drawing.Point(94, 139)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(75, 23)
        Me.Button_login.TabIndex = 3
        Me.Button_login.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.textbox_pass)
        Me.Controls.Add(Me.label_password)
        Me.Controls.Add(Me.label_username)
        Me.Controls.Add(Me.textbox_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox_name As TextBox
    Friend WithEvents label_username As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents label_password As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents textbox_pass As TextBox
    Friend WithEvents Button_login As Infragistics.Win.Misc.UltraButton
End Class

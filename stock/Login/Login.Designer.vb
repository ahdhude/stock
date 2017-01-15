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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.textbox_name = New ns1.BunifuMaterialTextbox()
        Me.textbox_pass = New ns1.BunifuMaterialTextbox()
        Me.Button_login = New ns1.BunifuFlatButton()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(43, 72)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(250, 29)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "LBMS STOCK MANAGER"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textbox_name
        '
        Me.textbox_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_name.ForeColor = System.Drawing.Color.White
        Me.textbox_name.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_name.HintText = "User Name"
        Me.textbox_name.isPassword = False
        Me.textbox_name.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.textbox_name.LineIdleColor = System.Drawing.Color.Silver
        Me.textbox_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.textbox_name.LineThickness = 3
        Me.textbox_name.Location = New System.Drawing.Point(90, 153)
        Me.textbox_name.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_name.Name = "textbox_name"
        Me.textbox_name.Size = New System.Drawing.Size(197, 44)
        Me.textbox_name.TabIndex = 9
        Me.textbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox_pass
        '
        Me.textbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_pass.ForeColor = System.Drawing.Color.White
        Me.textbox_pass.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_pass.HintText = "Password"
        Me.textbox_pass.isPassword = True
        Me.textbox_pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.textbox_pass.LineIdleColor = System.Drawing.Color.Silver
        Me.textbox_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.textbox_pass.LineThickness = 3
        Me.textbox_pass.Location = New System.Drawing.Point(90, 222)
        Me.textbox_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_pass.Name = "textbox_pass"
        Me.textbox_pass.Size = New System.Drawing.Size(197, 44)
        Me.textbox_pass.TabIndex = 10
        Me.textbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button_login
        '
        Me.Button_login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_login.BorderRadius = 0
        Me.Button_login.ButtonText = "Sign In"
        Me.Button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_login.DisabledColor = System.Drawing.Color.Gray
        Me.Button_login.Iconcolor = System.Drawing.Color.Transparent
        Me.Button_login.Iconimage = Nothing
        Me.Button_login.Iconimage_right = Nothing
        Me.Button_login.Iconimage_right_Selected = Nothing
        Me.Button_login.Iconimage_Selected = Nothing
        Me.Button_login.IconMarginLeft = 0
        Me.Button_login.IconMarginRight = 0
        Me.Button_login.IconRightVisible = True
        Me.Button_login.IconRightZoom = 0R
        Me.Button_login.IconVisible = True
        Me.Button_login.IconZoom = 90.0R
        Me.Button_login.IsTab = False
        Me.Button_login.Location = New System.Drawing.Point(65, 322)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button_login.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button_login.OnHoverTextColor = System.Drawing.Color.White
        Me.Button_login.selected = False
        Me.Button_login.Size = New System.Drawing.Size(209, 42)
        Me.Button_login.TabIndex = 11
        Me.Button_login.Text = "Sign In"
        Me.Button_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button_login.Textcolor = System.Drawing.Color.White
        Me.Button_login.TextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 3
        Me.BunifuSeparator2.Location = New System.Drawing.Point(2, 454)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(350, 10)
        Me.BunifuSeparator2.TabIndex = 12
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(2, 447)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(350, 10)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 485)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(220, 15)
        Me.BunifuCustomLabel3.TabIndex = 16
        Me.BunifuCustomLabel3.Text = "Ministry of Housing and Infrastructure"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 470)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(281, 15)
        Me.BunifuCustomLabel1.TabIndex = 15
        Me.BunifuCustomLabel1.Text = "Land Building and Municipal Services Department"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.stock.My.Resources.Resources.Password_48px
        Me.PictureBox2.Location = New System.Drawing.Point(42, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.stock.My.Resources.Resources.User_48px
        Me.PictureBox1.Location = New System.Drawing.Point(42, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(303, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(29, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 13
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(334, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.textbox_pass)
        Me.Controls.Add(Me.textbox_name)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Button_login As ns1.BunifuFlatButton
    Friend WithEvents textbox_pass As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_name As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

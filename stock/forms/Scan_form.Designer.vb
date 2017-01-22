<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scan_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scan_form))
        Me.Twain321 = New Saraff.Twain.Twain32(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_scanner = New ns1.BunifuFlatButton()
        Me.btn_scan = New ns1.BunifuFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Twain321
        '
        Me.Twain321.AppProductName = "Saraff.Twain.NET"
        Me.Twain321.Parent = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(42, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 404)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_scanner
        '
        Me.btn_scanner.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_scanner.BorderRadius = 0
        Me.btn_scanner.ButtonText = "Select Scanner"
        Me.btn_scanner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_scanner.DisabledColor = System.Drawing.Color.Gray
        Me.btn_scanner.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_scanner.Iconimage = CType(resources.GetObject("btn_scanner.Iconimage"), System.Drawing.Image)
        Me.btn_scanner.Iconimage_right = Nothing
        Me.btn_scanner.Iconimage_right_Selected = Nothing
        Me.btn_scanner.Iconimage_Selected = Nothing
        Me.btn_scanner.IconMarginLeft = 0
        Me.btn_scanner.IconMarginRight = 0
        Me.btn_scanner.IconRightVisible = True
        Me.btn_scanner.IconRightZoom = 0R
        Me.btn_scanner.IconVisible = True
        Me.btn_scanner.IconZoom = 90.0R
        Me.btn_scanner.IsTab = False
        Me.btn_scanner.Location = New System.Drawing.Point(126, 448)
        Me.btn_scanner.Name = "btn_scanner"
        Me.btn_scanner.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scanner.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_scanner.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_scanner.selected = False
        Me.btn_scanner.Size = New System.Drawing.Size(166, 48)
        Me.btn_scanner.TabIndex = 1
        Me.btn_scanner.Text = "Select Scanner"
        Me.btn_scanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_scanner.Textcolor = System.Drawing.Color.White
        Me.btn_scanner.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_scan
        '
        Me.btn_scan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_scan.BorderRadius = 0
        Me.btn_scan.ButtonText = "Scan"
        Me.btn_scan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_scan.DisabledColor = System.Drawing.Color.Gray
        Me.btn_scan.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_scan.Iconimage = CType(resources.GetObject("btn_scan.Iconimage"), System.Drawing.Image)
        Me.btn_scan.Iconimage_right = Nothing
        Me.btn_scan.Iconimage_right_Selected = Nothing
        Me.btn_scan.Iconimage_Selected = Nothing
        Me.btn_scan.IconMarginLeft = 0
        Me.btn_scan.IconMarginRight = 0
        Me.btn_scan.IconRightVisible = True
        Me.btn_scan.IconRightZoom = 0R
        Me.btn_scan.IconVisible = True
        Me.btn_scan.IconZoom = 90.0R
        Me.btn_scan.IsTab = False
        Me.btn_scan.Location = New System.Drawing.Point(403, 448)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_scan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_scan.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_scan.selected = False
        Me.btn_scan.Size = New System.Drawing.Size(109, 48)
        Me.btn_scan.TabIndex = 1
        Me.btn_scan.Text = "Scan"
        Me.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_scan.Textcolor = System.Drawing.Color.White
        Me.btn_scan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Scan_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 508)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.btn_scanner)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Scan_form"
        Me.Text = "Scan_form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Twain321 As Saraff.Twain.Twain32
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_scanner As ns1.BunifuFlatButton
    Friend WithEvents btn_scan As ns1.BunifuFlatButton
End Class

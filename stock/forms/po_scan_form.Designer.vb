<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class po_scan_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(po_scan_form))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New ns1.BunifuThinButton2()
        Me.Twain321 = New Saraff.Twain.Twain32(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(696, 524)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 471)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 53)
        Me.Panel1.TabIndex = 1
        '
        'btn_close
        '
        Me.btn_close.ActiveBorderThickness = 1
        Me.btn_close.ActiveCornerRadius = 20
        Me.btn_close.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_close.ActiveForecolor = System.Drawing.Color.White
        Me.btn_close.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_close.BackColor = System.Drawing.SystemColors.Control
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.ButtonText = "Close"
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_close.IdleBorderThickness = 1
        Me.btn_close.IdleCornerRadius = 20
        Me.btn_close.IdleFillColor = System.Drawing.Color.White
        Me.btn_close.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_close.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_close.Location = New System.Drawing.Point(250, 6)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(181, 41)
        Me.btn_close.TabIndex = 1
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Twain321
        '
        Me.Twain321.AppProductName = "Saraff.Twain.NET"
        Me.Twain321.Parent = Nothing
        '
        'po_scan_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "po_scan_form"
        Me.Text = "po_scan_form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_close As ns1.BunifuThinButton2
    Friend WithEvents Twain321 As Saraff.Twain.Twain32
End Class

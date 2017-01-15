<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_out
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
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.product_dropdown = New ns1.BunifuDropdown()
        Me.UltraDataChart1 = New Infragistics.Win.DataVisualization.UltraDataChart()
        CType(Me.UltraDataChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'product_dropdown
        '
        Me.product_dropdown.BackColor = System.Drawing.Color.Transparent
        Me.product_dropdown.BorderRadius = 3
        Me.product_dropdown.ForeColor = System.Drawing.Color.White
        Me.product_dropdown.Items = New String(-1) {}
        Me.product_dropdown.Location = New System.Drawing.Point(273, 131)
        Me.product_dropdown.Name = "product_dropdown"
        Me.product_dropdown.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.product_dropdown.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.product_dropdown.selectedIndex = -1
        Me.product_dropdown.Size = New System.Drawing.Size(217, 35)
        Me.product_dropdown.TabIndex = 0
        '
        'UltraDataChart1
        '
        Me.UltraDataChart1.BackColor = System.Drawing.Color.White
        Me.UltraDataChart1.CrosshairPoint = New Infragistics.Win.DataVisualization.Point(Double.NaN, Double.NaN)
        Me.UltraDataChart1.Location = New System.Drawing.Point(232, 144)
        Me.UltraDataChart1.Name = "UltraDataChart1"
        Me.UltraDataChart1.PreviewRect = New Infragistics.Win.DataVisualization.Rectangle(Double.PositiveInfinity, Double.PositiveInfinity, Double.NegativeInfinity, Double.NegativeInfinity)
        Me.UltraDataChart1.Size = New System.Drawing.Size(8, 8)
        Me.UltraDataChart1.TabIndex = 1
        Me.UltraDataChart1.Text = "UltraDataChart1"
        Me.UltraDataChart1.TitleFontSize = 12.0R
        '
        'stock_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 494)
        Me.Controls.Add(Me.UltraDataChart1)
        Me.Controls.Add(Me.product_dropdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_out"
        Me.Text = "stock_out"
        CType(Me.UltraDataChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents UltraDataChart1 As Infragistics.Win.DataVisualization.UltraDataChart
    Friend WithEvents product_dropdown As ns1.BunifuDropdown
End Class

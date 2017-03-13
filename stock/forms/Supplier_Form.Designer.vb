<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtbox_supplier_dhiv_name = New ns1.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_delete = New ns1.BunifuFlatButton()
        Me.btn_update = New ns1.BunifuFlatButton()
        Me.btn_add = New ns1.BunifuFlatButton()
        Me.txtbox_details = New ns1.BunifuMaterialTextbox()
        Me.txtbox_eng_name = New ns1.BunifuMaterialTextbox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGrid_supplier = New ns1.BunifuCustomDataGrid()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGrid_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 48)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(397, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(95, 26)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "SUPPLIER"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtbox_supplier_dhiv_name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Btn_delete)
        Me.Panel2.Controls.Add(Me.btn_update)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.txtbox_details)
        Me.Panel2.Controls.Add(Me.txtbox_eng_name)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 551)
        Me.Panel2.TabIndex = 1
        '
        'txtbox_supplier_dhiv_name
        '
        Me.txtbox_supplier_dhiv_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_supplier_dhiv_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtbox_supplier_dhiv_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_supplier_dhiv_name.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_supplier_dhiv_name.HintText = "ދިވެހި ނަން"
        Me.txtbox_supplier_dhiv_name.isPassword = False
        Me.txtbox_supplier_dhiv_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_supplier_dhiv_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_supplier_dhiv_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_supplier_dhiv_name.LineThickness = 4
        Me.txtbox_supplier_dhiv_name.Location = New System.Drawing.Point(40, 101)
        Me.txtbox_supplier_dhiv_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_supplier_dhiv_name.Name = "txtbox_supplier_dhiv_name"
        Me.txtbox_supplier_dhiv_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbox_supplier_dhiv_name.Size = New System.Drawing.Size(227, 52)
        Me.txtbox_supplier_dhiv_name.TabIndex = 20
        Me.txtbox_supplier_dhiv_name.Text = "Contact #"
        Me.txtbox_supplier_dhiv_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Label1"
        '
        'Btn_delete
        '
        Me.Btn_delete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_delete.BorderRadius = 0
        Me.Btn_delete.ButtonText = "Delete"
        Me.Btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_delete.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_delete.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_delete.Iconimage = Nothing
        Me.Btn_delete.Iconimage_right = Nothing
        Me.Btn_delete.Iconimage_right_Selected = Nothing
        Me.Btn_delete.Iconimage_Selected = Nothing
        Me.Btn_delete.IconMarginLeft = 0
        Me.Btn_delete.IconMarginRight = 0
        Me.Btn_delete.IconRightVisible = True
        Me.Btn_delete.IconRightZoom = 0R
        Me.Btn_delete.IconVisible = True
        Me.Btn_delete.IconZoom = 90.0R
        Me.Btn_delete.IsTab = False
        Me.Btn_delete.Location = New System.Drawing.Point(35, 379)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Btn_delete.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_delete.selected = False
        Me.Btn_delete.Size = New System.Drawing.Size(230, 30)
        Me.Btn_delete.TabIndex = 16
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_delete.Textcolor = System.Drawing.Color.White
        Me.Btn_delete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_update
        '
        Me.btn_update.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.BorderRadius = 0
        Me.btn_update.ButtonText = "Update"
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.DisabledColor = System.Drawing.Color.Gray
        Me.btn_update.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_update.Iconimage = Nothing
        Me.btn_update.Iconimage_right = Nothing
        Me.btn_update.Iconimage_right_Selected = Nothing
        Me.btn_update.Iconimage_Selected = Nothing
        Me.btn_update.IconMarginLeft = 0
        Me.btn_update.IconMarginRight = 0
        Me.btn_update.IconRightVisible = True
        Me.btn_update.IconRightZoom = 0R
        Me.btn_update.IconVisible = True
        Me.btn_update.IconZoom = 90.0R
        Me.btn_update.IsTab = False
        Me.btn_update.Location = New System.Drawing.Point(33, 330)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(232, 32)
        Me.btn_update.TabIndex = 17
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_update.Textcolor = System.Drawing.Color.White
        Me.btn_update.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_add
        '
        Me.btn_add.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.BorderRadius = 0
        Me.btn_add.ButtonText = "Add"
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.DisabledColor = System.Drawing.Color.Gray
        Me.btn_add.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_add.Iconimage = Nothing
        Me.btn_add.Iconimage_right = Nothing
        Me.btn_add.Iconimage_right_Selected = Nothing
        Me.btn_add.Iconimage_Selected = Nothing
        Me.btn_add.IconMarginLeft = 0
        Me.btn_add.IconMarginRight = 0
        Me.btn_add.IconRightVisible = True
        Me.btn_add.IconRightZoom = 0R
        Me.btn_add.IconVisible = True
        Me.btn_add.IconZoom = 90.0R
        Me.btn_add.IsTab = False
        Me.btn_add.Location = New System.Drawing.Point(33, 280)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(232, 33)
        Me.btn_add.TabIndex = 18
        Me.btn_add.Text = "Add"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_add.Textcolor = System.Drawing.Color.White
        Me.btn_add.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtbox_details
        '
        Me.txtbox_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtbox_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_details.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_details.HintText = "Contact #"
        Me.txtbox_details.isPassword = False
        Me.txtbox_details.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_details.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_details.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_details.LineThickness = 4
        Me.txtbox_details.Location = New System.Drawing.Point(35, 163)
        Me.txtbox_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_details.Name = "txtbox_details"
        Me.txtbox_details.Size = New System.Drawing.Size(227, 52)
        Me.txtbox_details.TabIndex = 9
        Me.txtbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_eng_name
        '
        Me.txtbox_eng_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_eng_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_eng_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_eng_name.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_eng_name.HintText = "Suppplier Name"
        Me.txtbox_eng_name.isPassword = False
        Me.txtbox_eng_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_eng_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_eng_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_eng_name.LineThickness = 4
        Me.txtbox_eng_name.Location = New System.Drawing.Point(40, 19)
        Me.txtbox_eng_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_eng_name.Name = "txtbox_eng_name"
        Me.txtbox_eng_name.Size = New System.Drawing.Size(227, 52)
        Me.txtbox_eng_name.TabIndex = 10
        Me.txtbox_eng_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGrid_supplier)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(338, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 551)
        Me.Panel3.TabIndex = 2
        '
        'DataGrid_supplier
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid_supplier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid_supplier.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid_supplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid_supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid_supplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_supplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid_supplier.DoubleBuffered = True
        Me.DataGrid_supplier.EnableHeadersVisualStyles = False
        Me.DataGrid_supplier.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DataGrid_supplier.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid_supplier.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid_supplier.Name = "DataGrid_supplier"
        Me.DataGrid_supplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid_supplier.Size = New System.Drawing.Size(602, 551)
        Me.DataGrid_supplier.TabIndex = 1
        '
        'Supplier_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 599)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier_Form"
        Me.Text = "Supplier_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGrid_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_delete As ns1.BunifuFlatButton
    Friend WithEvents btn_update As ns1.BunifuFlatButton
    Friend WithEvents btn_add As ns1.BunifuFlatButton
    Friend WithEvents txtbox_details As ns1.BunifuMaterialTextbox
    Friend WithEvents txtbox_eng_name As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents DataGrid_supplier As ns1.BunifuCustomDataGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_supplier_dhiv_name As ns1.BunifuMaterialTextbox
End Class

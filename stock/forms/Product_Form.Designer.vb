<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.txtbox_eng_name = New ns1.BunifuMaterialTextbox()
        Me.txtbox_dhiv_name = New ns1.BunifuMaterialTextbox()
        Me.txtbox_details = New ns1.BunifuMaterialTextbox()
        Me.BunifuDropdown1 = New ns1.BunifuDropdown()
        Me.Label_Liyekiyun = New System.Windows.Forms.Label()
        Me.BunifuCheckbox1 = New ns1.BunifuCheckbox()
        Me.BunifuCheckbox2 = New ns1.BunifuCheckbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add = New ns1.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_delete = New ns1.BunifuFlatButton()
        Me.btn_update = New ns1.BunifuFlatButton()
        Me.label_unit = New System.Windows.Forms.Label()
        Me.datagrid_product = New ns1.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.datagrid_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtbox_eng_name
        '
        Me.txtbox_eng_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_eng_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_eng_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_eng_name.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_eng_name.HintText = "Product Name"
        Me.txtbox_eng_name.isPassword = False
        Me.txtbox_eng_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_eng_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_eng_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_eng_name.LineThickness = 4
        Me.txtbox_eng_name.Location = New System.Drawing.Point(40, 28)
        Me.txtbox_eng_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_eng_name.Name = "txtbox_eng_name"
        Me.txtbox_eng_name.Size = New System.Drawing.Size(227, 52)
        Me.txtbox_eng_name.TabIndex = 2
        Me.txtbox_eng_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_dhiv_name
        '
        Me.txtbox_dhiv_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_dhiv_name.Font = New System.Drawing.Font("Faruma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_dhiv_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_dhiv_name.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_dhiv_name.HintText = ""
        Me.txtbox_dhiv_name.isPassword = False
        Me.txtbox_dhiv_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_dhiv_name.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_dhiv_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_dhiv_name.LineThickness = 5
        Me.txtbox_dhiv_name.Location = New System.Drawing.Point(38, 99)
        Me.txtbox_dhiv_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_dhiv_name.Name = "txtbox_dhiv_name"
        Me.txtbox_dhiv_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbox_dhiv_name.Size = New System.Drawing.Size(232, 54)
        Me.txtbox_dhiv_name.TabIndex = 2
        Me.txtbox_dhiv_name.Text = "ދިވެހި ނަން"
        Me.txtbox_dhiv_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_details
        '
        Me.txtbox_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_details.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtbox_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_details.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_details.HintText = ""
        Me.txtbox_details.isPassword = False
        Me.txtbox_details.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_details.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_details.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_details.LineThickness = 4
        Me.txtbox_details.Location = New System.Drawing.Point(40, 172)
        Me.txtbox_details.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_details.Name = "txtbox_details"
        Me.txtbox_details.Size = New System.Drawing.Size(227, 52)
        Me.txtbox_details.TabIndex = 2
        Me.txtbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(103, 251)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(78, 35)
        Me.BunifuDropdown1.TabIndex = 3
        '
        'Label_Liyekiyun
        '
        Me.Label_Liyekiyun.AutoSize = True
        Me.Label_Liyekiyun.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Liyekiyun.Location = New System.Drawing.Point(41, 322)
        Me.Label_Liyekiyun.Name = "Label_Liyekiyun"
        Me.Label_Liyekiyun.Size = New System.Drawing.Size(97, 19)
        Me.Label_Liyekiyun.TabIndex = 4
        Me.Label_Liyekiyun.Text = "Liyekiyumuge"
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox1.Checked = True
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(144, 321)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 5
        '
        'BunifuCheckbox2
        '
        Me.BunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.Checked = True
        Me.BunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox2.Location = New System.Drawing.Point(258, 322)
        Me.BunifuCheckbox2.Name = "BunifuCheckbox2"
        Me.BunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(170, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mudhaluge"
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
        Me.btn_add.Location = New System.Drawing.Point(40, 397)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(232, 33)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_add.Textcolor = System.Drawing.Color.White
        Me.btn_add.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_delete)
        Me.Panel2.Controls.Add(Me.btn_update)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.txtbox_details)
        Me.Panel2.Controls.Add(Me.txtbox_eng_name)
        Me.Panel2.Controls.Add(Me.label_unit)
        Me.Panel2.Controls.Add(Me.Label_Liyekiyun)
        Me.Panel2.Controls.Add(Me.BunifuCheckbox2)
        Me.Panel2.Controls.Add(Me.BunifuDropdown1)
        Me.Panel2.Controls.Add(Me.txtbox_dhiv_name)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BunifuCheckbox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 553)
        Me.Panel2.TabIndex = 8
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
        Me.Btn_delete.Location = New System.Drawing.Point(40, 478)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Btn_delete.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_delete.selected = False
        Me.Btn_delete.Size = New System.Drawing.Size(230, 30)
        Me.Btn_delete.TabIndex = 6
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
        Me.btn_update.Location = New System.Drawing.Point(40, 438)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(232, 32)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_update.Textcolor = System.Drawing.Color.White
        Me.btn_update.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label_unit
        '
        Me.label_unit.AutoSize = True
        Me.label_unit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_unit.Location = New System.Drawing.Point(36, 267)
        Me.label_unit.Name = "label_unit"
        Me.label_unit.Size = New System.Drawing.Size(36, 19)
        Me.label_unit.TabIndex = 4
        Me.label_unit.Text = "Unit"
        '
        'datagrid_product
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid_product.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_product.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datagrid_product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagrid_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid_product.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid_product.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_product.DoubleBuffered = True
        Me.datagrid_product.EnableHeadersVisualStyles = False
        Me.datagrid_product.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.datagrid_product.HeaderForeColor = System.Drawing.Color.Honeydew
        Me.datagrid_product.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_product.Name = "datagrid_product"
        Me.datagrid_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid_product.Size = New System.Drawing.Size(623, 553)
        Me.datagrid_product.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 46)
        Me.Panel1.TabIndex = 9
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(417, 12)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(146, 26)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "ADD PRODUCT "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.datagrid_product)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(317, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(623, 553)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(317, 553)
        Me.Panel4.TabIndex = 11
        '
        'Product_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 599)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product_Form"
        Me.Text = "Product_Form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.datagrid_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents txtbox_eng_name As ns1.BunifuMaterialTextbox
    Friend WithEvents txtbox_dhiv_name As ns1.BunifuMaterialTextbox
    Friend WithEvents txtbox_details As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuDropdown1 As ns1.BunifuDropdown
    Friend WithEvents Label_Liyekiyun As Label
    Friend WithEvents BunifuCheckbox2 As ns1.BunifuCheckbox
    Friend WithEvents BunifuCheckbox1 As ns1.BunifuCheckbox
    Friend WithEvents btn_add As ns1.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_delete As ns1.BunifuFlatButton
    Friend WithEvents btn_update As ns1.BunifuFlatButton
    Friend WithEvents label_unit As Label
    Friend WithEvents datagrid_product As ns1.BunifuCustomDataGrid
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
End Class

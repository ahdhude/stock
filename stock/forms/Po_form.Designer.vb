<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Po_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Po_form))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_process = New ns1.BunifuFlatButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.dropdown_supplier = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.textbox_date = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.textbox_po_num = New ns1.BunifuMaterialTextbox()
        Me.textbox_details = New ns1.BunifuMaterialTextbox()
        Me.combo_product = New System.Windows.Forms.ComboBox()
        Me.textbox_qty_req = New ns1.BunifuMaterialTextbox()
        Me.textbox_qty_giv = New ns1.BunifuMaterialTextbox()
        Me.txtbox_unit_price = New ns1.BunifuMaterialTextbox()
        Me.upload_path = New System.Windows.Forms.LinkLabel()
        Me.btn_upload = New ns1.BunifuFlatButton()
        Me.btn_add = New ns1.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropdown_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textbox_date, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 61)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(936, 218)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 218)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.upload_path)
        Me.GroupBox1.Controls.Add(Me.btn_upload)
        Me.GroupBox1.Controls.Add(Me.textbox_details)
        Me.GroupBox1.Controls.Add(Me.textbox_date)
        Me.GroupBox1.Controls.Add(Me.textbox_po_num)
        Me.GroupBox1.Controls.Add(Me.dropdown_supplier)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbox_unit_price)
        Me.GroupBox2.Controls.Add(Me.textbox_qty_giv)
        Me.GroupBox2.Controls.Add(Me.combo_product)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.textbox_qty_req)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(446, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 218)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 279)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(936, 270)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_process)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 549)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(936, 100)
        Me.Panel5.TabIndex = 3
        '
        'btn_process
        '
        Me.btn_process.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_process.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_process.BorderRadius = 0
        Me.btn_process.ButtonText = "Process"
        Me.btn_process.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_process.DisabledColor = System.Drawing.Color.Gray
        Me.btn_process.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_process.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_process.Iconimage = Nothing
        Me.btn_process.Iconimage_right = Nothing
        Me.btn_process.Iconimage_right_Selected = Nothing
        Me.btn_process.Iconimage_Selected = Nothing
        Me.btn_process.IconMarginLeft = 0
        Me.btn_process.IconMarginRight = 0
        Me.btn_process.IconRightVisible = True
        Me.btn_process.IconRightZoom = 0R
        Me.btn_process.IconVisible = True
        Me.btn_process.IconZoom = 90.0R
        Me.btn_process.IsTab = False
        Me.btn_process.Location = New System.Drawing.Point(0, 0)
        Me.btn_process.Name = "btn_process"
        Me.btn_process.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_process.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_process.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_process.selected = False
        Me.btn_process.Size = New System.Drawing.Size(936, 46)
        Me.btn_process.TabIndex = 8
        Me.btn_process.Text = "Process"
        Me.btn_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_process.Textcolor = System.Drawing.Color.White
        Me.btn_process.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(936, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(326, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(231, 26)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "PURCHASE ORDER FORM"
        '
        'dropdown_supplier
        '
        Me.dropdown_supplier.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.dropdown_supplier.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.dropdown_supplier.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.dropdown_supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.dropdown_supplier.Location = New System.Drawing.Point(277, 31)
        Me.dropdown_supplier.Name = "dropdown_supplier"
        Me.dropdown_supplier.Size = New System.Drawing.Size(154, 26)
        Me.dropdown_supplier.TabIndex = 2
        Me.dropdown_supplier.Text = "Supplier"
        '
        'textbox_date
        '
        Me.textbox_date.DateTime = New Date(2017, 1, 22, 0, 0, 0, 0)
        Me.textbox_date.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013
        Me.textbox_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textbox_date.FormatProvider = New System.Globalization.CultureInfo("en-GB")
        Me.textbox_date.Location = New System.Drawing.Point(14, 82)
        Me.textbox_date.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.textbox_date.MaskInput = "{date}"
        Me.textbox_date.Name = "textbox_date"
        Me.textbox_date.Size = New System.Drawing.Size(154, 26)
        Me.textbox_date.TabIndex = 4
        Me.textbox_date.Value = New Date(2017, 1, 22, 0, 0, 0, 0)
        '
        'textbox_po_num
        '
        Me.textbox_po_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_po_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_po_num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_po_num.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_po_num.HintText = "PO  Number"
        Me.textbox_po_num.isPassword = False
        Me.textbox_po_num.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_po_num.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_po_num.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_po_num.LineThickness = 4
        Me.textbox_po_num.Location = New System.Drawing.Point(14, 21)
        Me.textbox_po_num.Margin = New System.Windows.Forms.Padding(5)
        Me.textbox_po_num.Name = "textbox_po_num"
        Me.textbox_po_num.Padding = New System.Windows.Forms.Padding(3)
        Me.textbox_po_num.Size = New System.Drawing.Size(245, 36)
        Me.textbox_po_num.TabIndex = 5
        Me.textbox_po_num.Text = "PO Number"
        Me.textbox_po_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox_details
        '
        Me.textbox_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.textbox_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_details.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_details.HintText = "Details"
        Me.textbox_details.isPassword = False
        Me.textbox_details.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_details.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_details.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_details.LineThickness = 4
        Me.textbox_details.Location = New System.Drawing.Point(14, 130)
        Me.textbox_details.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_details.Name = "textbox_details"
        Me.textbox_details.Size = New System.Drawing.Size(417, 41)
        Me.textbox_details.TabIndex = 7
        Me.textbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'combo_product
        '
        Me.combo_product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combo_product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.combo_product.FormattingEnabled = True
        Me.combo_product.Location = New System.Drawing.Point(50, 31)
        Me.combo_product.Name = "combo_product"
        Me.combo_product.Size = New System.Drawing.Size(251, 26)
        Me.combo_product.TabIndex = 28
        '
        'textbox_qty_req
        '
        Me.textbox_qty_req.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_qty_req.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.textbox_qty_req.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_qty_req.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_qty_req.HintText = "Quantity Requested"
        Me.textbox_qty_req.isPassword = False
        Me.textbox_qty_req.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_qty_req.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_qty_req.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_qty_req.LineThickness = 3
        Me.textbox_qty_req.Location = New System.Drawing.Point(50, 79)
        Me.textbox_qty_req.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_qty_req.Name = "textbox_qty_req"
        Me.textbox_qty_req.Size = New System.Drawing.Size(212, 44)
        Me.textbox_qty_req.TabIndex = 30
        Me.textbox_qty_req.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox_qty_giv
        '
        Me.textbox_qty_giv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_qty_giv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.textbox_qty_giv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_qty_giv.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_qty_giv.HintText = "Quantity Recieved"
        Me.textbox_qty_giv.isPassword = False
        Me.textbox_qty_giv.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_qty_giv.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_qty_giv.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_qty_giv.LineThickness = 3
        Me.textbox_qty_giv.Location = New System.Drawing.Point(51, 145)
        Me.textbox_qty_giv.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_qty_giv.Name = "textbox_qty_giv"
        Me.textbox_qty_giv.Size = New System.Drawing.Size(211, 44)
        Me.textbox_qty_giv.TabIndex = 29
        Me.textbox_qty_giv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_unit_price
        '
        Me.txtbox_unit_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_unit_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtbox_unit_price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_unit_price.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_unit_price.HintText = "Unit Price"
        Me.txtbox_unit_price.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtbox_unit_price.isPassword = False
        Me.txtbox_unit_price.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_unit_price.LineIdleColor = System.Drawing.Color.Gray
        Me.txtbox_unit_price.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_unit_price.LineThickness = 3
        Me.txtbox_unit_price.Location = New System.Drawing.Point(325, 20)
        Me.txtbox_unit_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_unit_price.Name = "txtbox_unit_price"
        Me.txtbox_unit_price.Size = New System.Drawing.Size(75, 44)
        Me.txtbox_unit_price.TabIndex = 29
        Me.txtbox_unit_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'upload_path
        '
        Me.upload_path.AutoSize = True
        Me.upload_path.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.upload_path.Location = New System.Drawing.Point(354, 89)
        Me.upload_path.Name = "upload_path"
        Me.upload_path.Size = New System.Drawing.Size(67, 17)
        Me.upload_path.TabIndex = 22
        Me.upload_path.TabStop = True
        Me.upload_path.Text = "LinkLabel1"
        '
        'btn_upload
        '
        Me.btn_upload.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_upload.BorderRadius = 0
        Me.btn_upload.ButtonText = "SCAN"
        Me.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_upload.DisabledColor = System.Drawing.Color.Gray
        Me.btn_upload.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_upload.Iconimage = Nothing
        Me.btn_upload.Iconimage_right = Nothing
        Me.btn_upload.Iconimage_right_Selected = Nothing
        Me.btn_upload.Iconimage_Selected = Nothing
        Me.btn_upload.IconMarginLeft = 0
        Me.btn_upload.IconMarginRight = 0
        Me.btn_upload.IconRightVisible = True
        Me.btn_upload.IconRightZoom = 0R
        Me.btn_upload.IconVisible = True
        Me.btn_upload.IconZoom = 90.0R
        Me.btn_upload.IsTab = False
        Me.btn_upload.Location = New System.Drawing.Point(277, 82)
        Me.btn_upload.Margin = New System.Windows.Forms.Padding(250, 3, 3, 3)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_upload.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_upload.selected = False
        Me.btn_upload.Size = New System.Drawing.Size(71, 27)
        Me.btn_upload.TabIndex = 21
        Me.btn_upload.Text = "SCAN"
        Me.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_upload.Textcolor = System.Drawing.Color.White
        Me.btn_upload.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_add
        '
        Me.btn_add.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.BorderRadius = 0
        Me.btn_add.ButtonText = "ADD"
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.DisabledColor = System.Drawing.Color.Gray
        Me.btn_add.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_add.Iconimage = CType(resources.GetObject("btn_add.Iconimage"), System.Drawing.Image)
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
        Me.btn_add.Location = New System.Drawing.Point(325, 149)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(99, 40)
        Me.btn_add.TabIndex = 27
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Textcolor = System.Drawing.Color.White
        Me.btn_add.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Po_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 594)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Po_form"
        Me.Text = "Po_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropdown_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textbox_date, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_process As ns1.BunifuFlatButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents dropdown_supplier As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textbox_date As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents textbox_po_num As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_details As ns1.BunifuMaterialTextbox
    Friend WithEvents combo_product As ComboBox
    Friend WithEvents btn_add As ns1.BunifuFlatButton
    Friend WithEvents textbox_qty_req As ns1.BunifuMaterialTextbox
    Friend WithEvents txtbox_unit_price As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_qty_giv As ns1.BunifuMaterialTextbox
    Friend WithEvents upload_path As LinkLabel
    Friend WithEvents btn_upload As ns1.BunifuFlatButton
End Class

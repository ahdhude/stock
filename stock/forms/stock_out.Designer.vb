<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stock_out
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stock_out))
        Me.DataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.Products = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_req = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_given = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_process = New ns1.BunifuFlatButton()
        Me.textbox_details = New ns1.BunifuMaterialTextbox()
        Me.textbox_grf_num = New ns1.BunifuMaterialTextbox()
        Me.dropdown_emp = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.textbox_date = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_upload = New ns1.BunifuFlatButton()
        Me.Twain321 = New Saraff.Twain.Twain32(Me.components)
        Me.upload_path = New System.Windows.Forms.LinkLabel()
        Me.btn_add = New ns1.BunifuFlatButton()
        Me.combo_product = New System.Windows.Forms.ComboBox()
        Me.textbox_qty_req = New ns1.BunifuMaterialTextbox()
        Me.textbox_qty_giv = New ns1.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuCircleProgressbar1 = New ns1.BunifuCircleProgressbar()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropdown_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textbox_date, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Products, Me.qty_req, Me.qty_given})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.DoubleBuffered = True
        Me.DataGrid1.EnableHeadersVisualStyles = False
        Me.DataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid1.Size = New System.Drawing.Size(936, 232)
        Me.DataGrid1.TabIndex = 3
        '
        'Products
        '
        Me.Products.HeaderText = "Products"
        Me.Products.Name = "Products"
        '
        'qty_req
        '
        Me.qty_req.HeaderText = "Qty Requested"
        Me.qty_req.Name = "qty_req"
        '
        'qty_given
        '
        Me.qty_given.HeaderText = "Qty Given"
        Me.qty_given.Name = "qty_given"
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
        Me.btn_process.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.btn_process.TabIndex = 7
        Me.btn_process.Text = "Process"
        Me.btn_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_process.Textcolor = System.Drawing.Color.White
        Me.btn_process.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'textbox_details
        '
        Me.textbox_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_details.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.textbox_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_details.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_details.HintText = "Details"
        Me.textbox_details.isPassword = False
        Me.textbox_details.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_details.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_details.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_details.LineThickness = 4
        Me.textbox_details.Location = New System.Drawing.Point(27, 156)
        Me.textbox_details.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_details.Name = "textbox_details"
        Me.textbox_details.Size = New System.Drawing.Size(475, 41)
        Me.textbox_details.TabIndex = 6
        Me.textbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox_grf_num
        '
        Me.textbox_grf_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_grf_num.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_grf_num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_grf_num.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_grf_num.HintText = "GRF Number"
        Me.textbox_grf_num.isPassword = False
        Me.textbox_grf_num.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_grf_num.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineThickness = 4
        Me.textbox_grf_num.Location = New System.Drawing.Point(257, 29)
        Me.textbox_grf_num.Margin = New System.Windows.Forms.Padding(5)
        Me.textbox_grf_num.Name = "textbox_grf_num"
        Me.textbox_grf_num.Padding = New System.Windows.Forms.Padding(3)
        Me.textbox_grf_num.Size = New System.Drawing.Size(245, 36)
        Me.textbox_grf_num.TabIndex = 3
        Me.textbox_grf_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dropdown_emp
        '
        Me.dropdown_emp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.dropdown_emp.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.dropdown_emp.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.dropdown_emp.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dropdown_emp.Location = New System.Drawing.Point(27, 38)
        Me.dropdown_emp.Name = "dropdown_emp"
        Me.dropdown_emp.Size = New System.Drawing.Size(206, 27)
        Me.dropdown_emp.TabIndex = 1
        Me.dropdown_emp.Text = "Requested By"
        '
        'textbox_date
        '
        Me.textbox_date.DateTime = New Date(2017, 1, 22, 0, 0, 0, 0)
        Me.textbox_date.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013
        Me.textbox_date.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.textbox_date.FormatProvider = New System.Globalization.CultureInfo("en-GB")
        Me.textbox_date.Location = New System.Drawing.Point(27, 99)
        Me.textbox_date.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.textbox_date.MaskInput = "{date}"
        Me.textbox_date.Name = "textbox_date"
        Me.textbox_date.Size = New System.Drawing.Size(206, 27)
        Me.textbox_date.TabIndex = 2
        Me.textbox_date.Value = New Date(2017, 1, 22, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.btn_process)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 548)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 46)
        Me.Panel1.TabIndex = 13
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = ""
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.stock.My.Resources.Resources.Minus_48px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 60.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(45, 46)
        Me.BunifuFlatButton1.TabIndex = 27
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGrid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 316)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(936, 232)
        Me.Panel2.TabIndex = 14
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(402, 23)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(106, 26)
        Me.BunifuCustomLabel1.TabIndex = 18
        Me.BunifuCustomLabel1.Text = "GRF FORM"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.btn_upload.Location = New System.Drawing.Point(267, 99)
        Me.btn_upload.Margin = New System.Windows.Forms.Padding(250, 3, 3, 3)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_upload.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_upload.selected = False
        Me.btn_upload.Size = New System.Drawing.Size(71, 27)
        Me.btn_upload.TabIndex = 4
        Me.btn_upload.Text = "SCAN"
        Me.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_upload.Textcolor = System.Drawing.Color.White
        Me.btn_upload.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Twain321
        '
        Me.Twain321.AppProductName = "Saraff.Twain.NET"
        Me.Twain321.Parent = Nothing
        '
        'upload_path
        '
        Me.upload_path.AutoSize = True
        Me.upload_path.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.upload_path.Location = New System.Drawing.Point(344, 109)
        Me.upload_path.Name = "upload_path"
        Me.upload_path.Size = New System.Drawing.Size(67, 17)
        Me.upload_path.TabIndex = 20
        Me.upload_path.TabStop = True
        Me.upload_path.Text = "LinkLabel1"
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
        Me.btn_add.Location = New System.Drawing.Point(244, 157)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(98, 40)
        Me.btn_add.TabIndex = 22
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Textcolor = System.Drawing.Color.White
        Me.btn_add.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'combo_product
        '
        Me.combo_product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combo_product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_product.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.combo_product.FormattingEnabled = True
        Me.combo_product.Location = New System.Drawing.Point(40, 37)
        Me.combo_product.Name = "combo_product"
        Me.combo_product.Size = New System.Drawing.Size(251, 28)
        Me.combo_product.TabIndex = 24
        '
        'textbox_qty_req
        '
        Me.textbox_qty_req.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_qty_req.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_qty_req.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_qty_req.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_qty_req.HintText = "Quantity Requested"
        Me.textbox_qty_req.isPassword = False
        Me.textbox_qty_req.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_qty_req.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_qty_req.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_qty_req.LineThickness = 3
        Me.textbox_qty_req.Location = New System.Drawing.Point(40, 82)
        Me.textbox_qty_req.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_qty_req.Name = "textbox_qty_req"
        Me.textbox_qty_req.Size = New System.Drawing.Size(139, 44)
        Me.textbox_qty_req.TabIndex = 26
        Me.textbox_qty_req.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textbox_qty_giv
        '
        Me.textbox_qty_giv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_qty_giv.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_qty_giv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_qty_giv.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_qty_giv.HintText = "Quantity Given"
        Me.textbox_qty_giv.isPassword = False
        Me.textbox_qty_giv.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_qty_giv.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_qty_giv.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_qty_giv.LineThickness = 3
        Me.textbox_qty_giv.Location = New System.Drawing.Point(40, 152)
        Me.textbox_qty_giv.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_qty_giv.Name = "textbox_qty_giv"
        Me.textbox_qty_giv.Size = New System.Drawing.Size(138, 44)
        Me.textbox_qty_giv.TabIndex = 26
        Me.textbox_qty_giv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textbox_date)
        Me.GroupBox1.Controls.Add(Me.textbox_details)
        Me.GroupBox1.Controls.Add(Me.dropdown_emp)
        Me.GroupBox1.Controls.Add(Me.upload_path)
        Me.GroupBox1.Controls.Add(Me.btn_upload)
        Me.GroupBox1.Controls.Add(Me.textbox_grf_num)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 245)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(936, 245)
        Me.Panel3.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.GroupBox2.Controls.Add(Me.textbox_qty_giv)
        Me.GroupBox2.Controls.Add(Me.combo_product)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.textbox_qty_req)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(528, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 245)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = False
        Me.BunifuCircleProgressbar1.animationIterval = 2
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(317, 19)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(65, 65)
        Me.BunifuCircleProgressbar1.TabIndex = 21
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(339, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "00"
        '
        'stock_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(936, 594)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_out"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "stock_out"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropdown_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textbox_date, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents DataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_process As ns1.BunifuFlatButton
    Friend WithEvents textbox_details As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_grf_num As ns1.BunifuMaterialTextbox
    Friend WithEvents dropdown_emp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textbox_date As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_upload As ns1.BunifuFlatButton
    Friend WithEvents Twain321 As Saraff.Twain.Twain32
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents upload_path As LinkLabel
    Friend WithEvents btn_add As ns1.BunifuFlatButton
    Friend WithEvents combo_product As ComboBox
    Friend WithEvents textbox_qty_giv As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_qty_req As ns1.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Products As DataGridViewTextBoxColumn
    Friend WithEvents qty_req As DataGridViewTextBoxColumn
    Friend WithEvents qty_given As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCircleProgressbar1 As ns1.BunifuCircleProgressbar
    Friend WithEvents Label1 As Label
End Class

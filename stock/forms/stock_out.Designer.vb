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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.Product = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Item_requested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_given = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_process = New ns1.BunifuFlatButton()
        Me.textbox_details = New ns1.BunifuMaterialTextbox()
        Me.textbox_grf_num = New ns1.BunifuMaterialTextbox()
        Me.dropdown_emp = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.upload_path = New System.Windows.Forms.LinkLabel()
        Me.lable_scanner = New MetroFramework.Controls.MetroLabel()
        Me.btn_upload = New ns1.BunifuFlatButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Twain321 = New Saraff.Twain.Twain32(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropdown_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Item_requested, Me.item_given})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid1.DoubleBuffered = True
        Me.DataGrid1.EnableHeadersVisualStyles = False
        Me.DataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid1.Size = New System.Drawing.Size(936, 232)
        Me.DataGrid1.TabIndex = 3
        '
        'Product
        '
        Me.Product.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Product.HeaderText = "Product Name"
        Me.Product.Name = "Product"
        Me.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Product.ToolTipText = "ތަކެތި"
        '
        'Item_requested
        '
        Me.Item_requested.HeaderText = "Qty Requested"
        Me.Item_requested.Name = "Item_requested"
        Me.Item_requested.ToolTipText = "އެދުނު"
        '
        'item_given
        '
        Me.item_given.HeaderText = "Qty Given"
        Me.item_given.Name = "item_given"
        Me.item_given.ToolTipText = "ނެގި"
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
        Me.textbox_details.Location = New System.Drawing.Point(50, 26)
        Me.textbox_details.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_details.Name = "textbox_details"
        Me.textbox_details.Size = New System.Drawing.Size(826, 44)
        Me.textbox_details.TabIndex = 9
        Me.textbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox_grf_num
        '
        Me.textbox_grf_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_grf_num.Dock = System.Windows.Forms.DockStyle.Left
        Me.textbox_grf_num.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_grf_num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_grf_num.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_grf_num.HintText = "GRF Number"
        Me.textbox_grf_num.isPassword = False
        Me.textbox_grf_num.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_grf_num.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineThickness = 4
        Me.textbox_grf_num.Location = New System.Drawing.Point(0, 0)
        Me.textbox_grf_num.Margin = New System.Windows.Forms.Padding(5)
        Me.textbox_grf_num.Name = "textbox_grf_num"
        Me.textbox_grf_num.Padding = New System.Windows.Forms.Padding(50, 0, 0, 15)
        Me.textbox_grf_num.Size = New System.Drawing.Size(382, 59)
        Me.textbox_grf_num.TabIndex = 6
        Me.textbox_grf_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dropdown_emp
        '
        Me.dropdown_emp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.dropdown_emp.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.dropdown_emp.BorderStyle = Infragistics.Win.UIElementBorderStyle.Raised
        Me.dropdown_emp.Dock = System.Windows.Forms.DockStyle.Left
        Me.dropdown_emp.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dropdown_emp.Location = New System.Drawing.Point(50, 15)
        Me.dropdown_emp.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.dropdown_emp.Name = "dropdown_emp"
        Me.dropdown_emp.Size = New System.Drawing.Size(332, 27)
        Me.dropdown_emp.TabIndex = 10
        Me.dropdown_emp.Text = "Requested By"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DateTime = New Date(2017, 1, 22, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013
        Me.UltraDateTimeEditor1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraDateTimeEditor1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.UltraDateTimeEditor1.FormatProvider = New System.Globalization.CultureInfo("en-GB")
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(50, 15)
        Me.UltraDateTimeEditor1.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.UltraDateTimeEditor1.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.UltraDateTimeEditor1.MaskInput = "{LOC}dd/mm/yyyy"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(332, 27)
        Me.UltraDateTimeEditor1.TabIndex = 11
        Me.UltraDateTimeEditor1.Value = New Date(2017, 1, 22, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_process)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 548)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 46)
        Me.Panel1.TabIndex = 13
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.textbox_details)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(936, 100)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 157)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(936, 59)
        Me.Panel4.TabIndex = 23
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.upload_path)
        Me.Panel7.Controls.Add(Me.lable_scanner)
        Me.Panel7.Controls.Add(Me.btn_upload)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(494, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Panel7.Size = New System.Drawing.Size(442, 59)
        Me.Panel7.TabIndex = 1
        '
        'upload_path
        '
        Me.upload_path.AutoSize = True
        Me.upload_path.Location = New System.Drawing.Point(207, 25)
        Me.upload_path.Name = "upload_path"
        Me.upload_path.Size = New System.Drawing.Size(59, 13)
        Me.upload_path.TabIndex = 24
        Me.upload_path.TabStop = True
        Me.upload_path.Text = "LinkLabel1"
        '
        'lable_scanner
        '
        Me.lable_scanner.AutoSize = True
        Me.lable_scanner.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lable_scanner.Location = New System.Drawing.Point(362, 40)
        Me.lable_scanner.Name = "lable_scanner"
        Me.lable_scanner.Size = New System.Drawing.Size(80, 19)
        Me.lable_scanner.TabIndex = 23
        Me.lable_scanner.Text = "Use Scanner"
        '
        'btn_upload
        '
        Me.btn_upload.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_upload.BorderRadius = 0
        Me.btn_upload.ButtonText = "UPLOAD"
        Me.btn_upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_upload.DisabledColor = System.Drawing.Color.Gray
        Me.btn_upload.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.btn_upload.Location = New System.Drawing.Point(50, 0)
        Me.btn_upload.Margin = New System.Windows.Forms.Padding(250, 3, 3, 3)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_upload.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_upload.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_upload.selected = False
        Me.btn_upload.Size = New System.Drawing.Size(129, 59)
        Me.btn_upload.TabIndex = 21
        Me.btn_upload.Text = "UPLOAD"
        Me.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_upload.Textcolor = System.Drawing.Color.White
        Me.btn_upload.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.textbox_grf_num)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(494, 59)
        Me.Panel6.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 93)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(936, 64)
        Me.Panel5.TabIndex = 24
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.UltraDateTimeEditor1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(494, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(50, 15, 0, 0)
        Me.Panel9.Size = New System.Drawing.Size(442, 64)
        Me.Panel9.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dropdown_emp)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(50, 15, 0, 0)
        Me.Panel8.Size = New System.Drawing.Size(494, 64)
        Me.Panel8.TabIndex = 0
        '
        'Twain321
        '
        Me.Twain321.AppProductName = "Saraff.Twain.NET"
        Me.Twain321.Parent = Nothing
        '
        'stock_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(936, 594)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "stock_out"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropdown_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents DataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_process As ns1.BunifuFlatButton
    Friend WithEvents textbox_details As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_grf_num As ns1.BunifuMaterialTextbox


    Friend WithEvents Product As DataGridViewComboBoxColumn
    Friend WithEvents Item_requested As DataGridViewTextBoxColumn
    Friend WithEvents item_given As DataGridViewTextBoxColumn
    Friend WithEvents dropdown_emp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_upload As ns1.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lable_scanner As MetroFramework.Controls.MetroLabel
    Friend WithEvents Twain321 As Saraff.Twain.Twain32
    Friend WithEvents upload_path As LinkLabel
End Class

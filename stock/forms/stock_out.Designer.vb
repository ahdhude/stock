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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.LBMSTOCKDataSet = New stock.LBMSTOCKDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New stock.LBMSTOCKDataSetTableAdapters.ProductTableAdapter()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Product = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Item_requested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_given = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuDatepicker1 = New ns1.BunifuDatepicker()
        Me.textbox_grf_num = New ns1.BunifuMaterialTextbox()
        Me.btn_process = New ns1.BunifuFlatButton()
        Me.textbox_details = New ns1.BunifuMaterialTextbox()
        CType(Me.LBMSTOCKDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'LBMSTOCKDataSet
        '
        Me.LBMSTOCKDataSet.DataSetName = "LBMSTOCKDataSet"
        Me.LBMSTOCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.LBMSTOCKDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Item_requested, Me.item_given})
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(736, 199)
        Me.BunifuCustomDataGrid1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 295)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 199)
        Me.Panel1.TabIndex = 4
        '
        'Product
        '
        Me.Product.DataSource = Me.ProductBindingSource
        Me.Product.DisplayMember = "Product_name"
        Me.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Product.HeaderText = "Product Name"
        Me.Product.Name = "Product"
        Me.Product.ToolTipText = "ތަކެތި"
        Me.Product.ValueMember = "Product_id"
        '
        'Item_requested
        '
        Me.Item_requested.HeaderText = "Qty Requested"
        Me.Item_requested.Name = "Item_requested"
        Me.Item_requested.ToolTipText = "ބޭނުންވާ އަދަދު"
        '
        'item_given
        '
        Me.item_given.HeaderText = "Qty Given"
        Me.item_given.Name = "item_given"
        Me.item_given.ToolTipText = "ނެގި"
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(409, 55)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 5
        Me.BunifuDatepicker1.Value = New Date(2017, 1, 17, 18, 21, 20, 355)
        '
        'textbox_grf_num
        '
        Me.textbox_grf_num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_grf_num.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_grf_num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_grf_num.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_grf_num.HintText = "GRF Number"
        Me.textbox_grf_num.isPassword = False
        Me.textbox_grf_num.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_grf_num.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_grf_num.LineThickness = 3
        Me.textbox_grf_num.Location = New System.Drawing.Point(57, 47)
        Me.textbox_grf_num.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_grf_num.Name = "textbox_grf_num"
        Me.textbox_grf_num.Size = New System.Drawing.Size(303, 44)
        Me.textbox_grf_num.TabIndex = 6
        Me.textbox_grf_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btn_process.Location = New System.Drawing.Point(57, 223)
        Me.btn_process.Name = "btn_process"
        Me.btn_process.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_process.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_process.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_process.selected = False
        Me.btn_process.Size = New System.Drawing.Size(137, 48)
        Me.btn_process.TabIndex = 7
        Me.btn_process.Text = "Process"
        Me.btn_process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_process.Textcolor = System.Drawing.Color.White
        Me.btn_process.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'textbox_details
        '
        Me.textbox_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_details.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.textbox_details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textbox_details.HintForeColor = System.Drawing.Color.Empty
        Me.textbox_details.HintText = "Details"
        Me.textbox_details.isPassword = False
        Me.textbox_details.LineFocusedColor = System.Drawing.Color.Blue
        Me.textbox_details.LineIdleColor = System.Drawing.Color.Gray
        Me.textbox_details.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox_details.LineThickness = 3
        Me.textbox_details.Location = New System.Drawing.Point(57, 122)
        Me.textbox_details.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_details.Name = "textbox_details"
        Me.textbox_details.Size = New System.Drawing.Size(655, 44)
        Me.textbox_details.TabIndex = 9
        Me.textbox_details.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'stock_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 494)
        Me.Controls.Add(Me.textbox_details)
        Me.Controls.Add(Me.btn_process)
        Me.Controls.Add(Me.textbox_grf_num)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_out"
        Me.Text = "stock_out"
        CType(Me.LBMSTOCKDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents LBMSTOCKDataSet As LBMSTOCKDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As LBMSTOCKDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Product As DataGridViewComboBoxColumn
    Friend WithEvents Item_requested As DataGridViewTextBoxColumn
    Friend WithEvents item_given As DataGridViewTextBoxColumn
    Friend WithEvents BunifuDatepicker1 As ns1.BunifuDatepicker
    Friend WithEvents btn_process As ns1.BunifuFlatButton
    Friend WithEvents textbox_grf_num As ns1.BunifuMaterialTextbox
    Friend WithEvents textbox_details As ns1.BunifuMaterialTextbox
End Class

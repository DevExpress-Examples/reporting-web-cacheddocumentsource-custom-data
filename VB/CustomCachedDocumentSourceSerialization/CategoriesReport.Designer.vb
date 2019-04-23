Namespace CustomCachedDocumentSourceSerialization
	Partial Public Class CategoriesReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GroupData3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryID"
			table1.Name = "Categories"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CategoryName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "Description"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Picture"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "Categories"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo1.StyleName = "PageInfo"
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.xrPageInfo2.StyleName = "PageInfo"
			Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrPageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' reportHeaderBand1
			' 
			Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.reportHeaderBand1.HeightF = 60F
			Me.reportHeaderBand1.Name = "reportHeaderBand1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.xrLabel1.Multiline = True
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(638F, 25.55338F)
			Me.xrLabel1.StyleName = "Title"
			Me.xrLabel1.Text = "Categories"
			' 
			' groupHeaderBand1
			' 
			Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.groupHeaderBand1.HeightF = 25F
			Me.groupHeaderBand1.Level = 1
			Me.groupHeaderBand1.Name = "groupHeaderBand1"
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Multiline = True
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell1.StyleName = "GroupCaption3"
			Me.xrTableCell1.Text = "CATEGORY ID"
			Me.xrTableCell1.Weight = 0.13239148653470553R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
			Me.xrTableCell2.Multiline = True
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell2.StyleName = "GroupData3"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 0.86760854867788462R
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.xrTableCell2.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.CategoryId_PrintOnPage);
			' 
			' groupHeaderBand2
			' 
			Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel1})
			Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.groupHeaderBand2.HeightF = 48F
			Me.groupHeaderBand2.Level = 2
			Me.groupHeaderBand2.Name = "groupHeaderBand2"
			' 
			' xrPanel1
			' 
			Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.xrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPanel1.Name = "xrPanel1"
			Me.xrPanel1.SizeF = New System.Drawing.SizeF(650F, 48F)
			Me.xrPanel1.StyleName = "DetailCaptionBackground3"
			' 
			' xrTable2
			' 
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 20F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Multiline = True
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell3.StyleName = "DetailCaption3"
			Me.xrTableCell3.Text = "Category Name"
			Me.xrTableCell3.Weight = 0.43489370492788459R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Multiline = True
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell4.StyleName = "DetailCaption3"
			Me.xrTableCell4.Text = "Description"
			Me.xrTableCell4.Weight = 0.33587716909555287R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Multiline = True
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell5.StyleName = "DetailCaption3"
			Me.xrTableCell5.Text = "Picture"
			Me.xrTableCell5.Weight = 0.22922917292668268R
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrTable3})
			Me.detailBand1.HeightF = 267.7083F
			Me.detailBand1.KeepTogether = True
			Me.detailBand1.Name = "detailBand1"
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
			Me.xrPictureBox1.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
			Me.xrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Image", "[Picture]")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(108.9712F, 25F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(415.6656F, 242.7083F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
			' 
			' xrTable3
			' 
			Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable3.Name = "xrTable3"
			Me.xrTable3.OddStyleName = "DetailData3_Odd"
			Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3})
			Me.xrTable3.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.Weight = 11.5R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.xrTableCell6.Multiline = True
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell6.StyleName = "DetailData3"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 0.43489370492788459R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
			Me.xrTableCell7.Multiline = True
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell7.StyleName = "DetailData3"
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.Weight = 0.56510632552871709R
			' 
			' groupFooterBand1
			' 
			Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.groupFooterBand1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
			Me.groupFooterBand1.HeightF = 6F
			Me.groupFooterBand1.Name = "groupFooterBand1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel2.Multiline = True
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(650F, 2.08F)
			Me.xrLabel2.StyleName = "GroupCaption3"
			Me.xrLabel2.StylePriority.UseBorders = False
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Tahoma", 14F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			' 
			' GroupCaption3
			' 
			Me.GroupCaption3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(137)))), (CInt((CByte(137)))))
			Me.GroupCaption3.BorderColor = System.Drawing.Color.White
			Me.GroupCaption3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupCaption3.BorderWidth = 2F
			Me.GroupCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			Me.GroupCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
			Me.GroupCaption3.Name = "GroupCaption3"
			Me.GroupCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GroupData3
			' 
			Me.GroupData3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(137)))), (CInt((CByte(137)))), (CInt((CByte(137)))))
			Me.GroupData3.BorderColor = System.Drawing.Color.White
			Me.GroupData3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GroupData3.BorderWidth = 2F
			Me.GroupData3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			Me.GroupData3.ForeColor = System.Drawing.Color.White
			Me.GroupData3.Name = "GroupData3"
			Me.GroupData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GroupData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaption3
			' 
			Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
			Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
			Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption3.Name = "DetailCaption3"
			Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3
			' 
			Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.DetailData3.ForeColor = System.Drawing.Color.Black
			Me.DetailData3.Name = "DetailData3"
			Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailCaptionBackground3
			' 
			Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
			Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(206)))), (CInt((CByte(206)))), (CInt((CByte(206)))))
			Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
			Me.DetailCaptionBackground3.BorderWidth = 2F
			Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' CategoriesReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.bottomMarginBand1, Me.reportHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.detailBand1, Me.groupFooterBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.ExportOptions.Xls.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFilePageByPage
			Me.ExportOptions.Xlsx.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFilePageByPage
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption3, Me.GroupData3, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
			Me.Version = "18.1"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private detailBand1 As DevExpress.XtraReports.UI.DetailBand
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTable3 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupCaption3 As DevExpress.XtraReports.UI.XRControlStyle
		Private GroupData3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaptionBackground3 As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace

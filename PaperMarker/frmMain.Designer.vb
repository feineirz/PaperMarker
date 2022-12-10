<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.grpPatternType = New System.Windows.Forms.GroupBox()
		Me.pnlGridSettings = New System.Windows.Forms.Panel()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.numGridSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.rdbPatternType_Grid = New System.Windows.Forms.RadioButton()
		Me.pnlCrosshairSettings = New System.Windows.Forms.Panel()
		Me.numCrossSize = New System.Windows.Forms.NumericUpDown()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.numCrossSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.pnlDotSettings = New System.Windows.Forms.Panel()
		Me.numDotSize = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.numDotSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.pnlLineSettings = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.numLineSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.rdbPatternType_Crosshair = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Dot = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Line = New System.Windows.Forms.RadioButton()
		Me.pdcMain = New System.Drawing.Printing.PrintDocument()
		Me.tbxStatus = New System.Windows.Forms.TextBox()
		Me.grpMarkerSettings = New System.Windows.Forms.GroupBox()
		Me.lblMarkerColorPreview = New System.Windows.Forms.Label()
		Me.btnPickMarkerColor = New System.Windows.Forms.Button()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.grpPatternType.SuspendLayout()
		Me.pnlGridSettings.SuspendLayout()
		CType(Me.numGridSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlCrosshairSettings.SuspendLayout()
		CType(Me.numCrossSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numCrossSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDotSettings.SuspendLayout()
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLineSettings.SuspendLayout()
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grpMarkerSettings.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnPrint
		'
		Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnPrint.BackColor = System.Drawing.Color.ForestGreen
		Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Green
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrint.ForeColor = System.Drawing.Color.Honeydew
		Me.btnPrint.Location = New System.Drawing.Point(195, 465)
		Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(117, 40)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "PRINT"
		Me.btnPrint.UseVisualStyleBackColor = False
		'
		'grpPatternType
		'
		Me.grpPatternType.BackColor = System.Drawing.Color.White
		Me.grpPatternType.Controls.Add(Me.pnlGridSettings)
		Me.grpPatternType.Controls.Add(Me.rdbPatternType_Grid)
		Me.grpPatternType.Controls.Add(Me.pnlCrosshairSettings)
		Me.grpPatternType.Controls.Add(Me.pnlDotSettings)
		Me.grpPatternType.Controls.Add(Me.pnlLineSettings)
		Me.grpPatternType.Controls.Add(Me.rdbPatternType_Crosshair)
		Me.grpPatternType.Controls.Add(Me.rdbPatternType_Dot)
		Me.grpPatternType.Controls.Add(Me.rdbPatternType_Line)
		Me.grpPatternType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpPatternType.Location = New System.Drawing.Point(13, 14)
		Me.grpPatternType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.grpPatternType.Name = "grpPatternType"
		Me.grpPatternType.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.grpPatternType.Size = New System.Drawing.Size(299, 377)
		Me.grpPatternType.TabIndex = 3
		Me.grpPatternType.TabStop = False
		Me.grpPatternType.Text = "Pattern Type"
		'
		'pnlGridSettings
		'
		Me.pnlGridSettings.Controls.Add(Me.Label12)
		Me.pnlGridSettings.Controls.Add(Me.numGridSpace)
		Me.pnlGridSettings.Controls.Add(Me.Label13)
		Me.pnlGridSettings.Location = New System.Drawing.Point(47, 292)
		Me.pnlGridSettings.Name = "pnlGridSettings"
		Me.pnlGridSettings.Size = New System.Drawing.Size(220, 30)
		Me.pnlGridSettings.TabIndex = 14
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.ForeColor = System.Drawing.Color.DimGray
		Me.Label12.Location = New System.Drawing.Point(5, 5)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(77, 15)
		Me.Label12.TabIndex = 3
		Me.Label12.Text = "Grid space"
		'
		'numGridSpace
		'
		Me.numGridSpace.DecimalPlaces = 1
		Me.numGridSpace.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.numGridSpace.Location = New System.Drawing.Point(95, 3)
		Me.numGridSpace.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
		Me.numGridSpace.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
		Me.numGridSpace.Name = "numGridSpace"
		Me.numGridSpace.Size = New System.Drawing.Size(89, 23)
		Me.numGridSpace.TabIndex = 4
		Me.numGridSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numGridSpace.Value = New Decimal(New Integer() {25, 0, 0, 65536})
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.ForeColor = System.Drawing.Color.DimGray
		Me.Label13.Location = New System.Drawing.Point(190, 5)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(28, 15)
		Me.Label13.TabIndex = 5
		Me.Label13.Text = "mm."
		'
		'rdbPatternType_Grid
		'
		Me.rdbPatternType_Grid.AutoSize = True
		Me.rdbPatternType_Grid.Location = New System.Drawing.Point(27, 267)
		Me.rdbPatternType_Grid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.rdbPatternType_Grid.Name = "rdbPatternType_Grid"
		Me.rdbPatternType_Grid.Size = New System.Drawing.Size(53, 19)
		Me.rdbPatternType_Grid.TabIndex = 13
		Me.rdbPatternType_Grid.Text = "Grid"
		Me.rdbPatternType_Grid.UseVisualStyleBackColor = True
		'
		'pnlCrosshairSettings
		'
		Me.pnlCrosshairSettings.Controls.Add(Me.numCrossSize)
		Me.pnlCrosshairSettings.Controls.Add(Me.Label7)
		Me.pnlCrosshairSettings.Controls.Add(Me.Label8)
		Me.pnlCrosshairSettings.Controls.Add(Me.numCrossSpace)
		Me.pnlCrosshairSettings.Controls.Add(Me.Label9)
		Me.pnlCrosshairSettings.Controls.Add(Me.Label10)
		Me.pnlCrosshairSettings.Location = New System.Drawing.Point(47, 201)
		Me.pnlCrosshairSettings.Name = "pnlCrosshairSettings"
		Me.pnlCrosshairSettings.Size = New System.Drawing.Size(220, 60)
		Me.pnlCrosshairSettings.TabIndex = 12
		'
		'numCrossSize
		'
		Me.numCrossSize.DecimalPlaces = 1
		Me.numCrossSize.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
		Me.numCrossSize.Location = New System.Drawing.Point(93, 3)
		Me.numCrossSize.Maximum = New Decimal(New Integer() {25, 0, 0, 65536})
		Me.numCrossSize.Minimum = New Decimal(New Integer() {4, 0, 0, 65536})
		Me.numCrossSize.Name = "numCrossSize"
		Me.numCrossSize.Size = New System.Drawing.Size(89, 23)
		Me.numCrossSize.TabIndex = 10
		Me.numCrossSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numCrossSize.Value = New Decimal(New Integer() {4, 0, 0, 65536})
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.ForeColor = System.Drawing.Color.DimGray
		Me.Label7.Location = New System.Drawing.Point(188, 5)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(28, 15)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "mm."
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.ForeColor = System.Drawing.Color.DimGray
		Me.Label8.Location = New System.Drawing.Point(3, 34)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(77, 15)
		Me.Label8.TabIndex = 6
		Me.Label8.Text = "Mark space"
		'
		'numCrossSpace
		'
		Me.numCrossSpace.Location = New System.Drawing.Point(93, 32)
		Me.numCrossSpace.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numCrossSpace.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numCrossSpace.Name = "numCrossSpace"
		Me.numCrossSpace.Size = New System.Drawing.Size(89, 23)
		Me.numCrossSpace.TabIndex = 7
		Me.numCrossSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numCrossSpace.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.ForeColor = System.Drawing.Color.DimGray
		Me.Label9.Location = New System.Drawing.Point(3, 5)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(70, 15)
		Me.Label9.TabIndex = 9
		Me.Label9.Text = "Mark size"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.ForeColor = System.Drawing.Color.DimGray
		Me.Label10.Location = New System.Drawing.Point(188, 34)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(28, 15)
		Me.Label10.TabIndex = 8
		Me.Label10.Text = "mm."
		'
		'pnlDotSettings
		'
		Me.pnlDotSettings.Controls.Add(Me.numDotSize)
		Me.pnlDotSettings.Controls.Add(Me.Label5)
		Me.pnlDotSettings.Controls.Add(Me.Label4)
		Me.pnlDotSettings.Controls.Add(Me.numDotSpace)
		Me.pnlDotSettings.Controls.Add(Me.Label6)
		Me.pnlDotSettings.Controls.Add(Me.Label3)
		Me.pnlDotSettings.Location = New System.Drawing.Point(47, 110)
		Me.pnlDotSettings.Name = "pnlDotSettings"
		Me.pnlDotSettings.Size = New System.Drawing.Size(220, 60)
		Me.pnlDotSettings.TabIndex = 5
		'
		'numDotSize
		'
		Me.numDotSize.DecimalPlaces = 1
		Me.numDotSize.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.numDotSize.Location = New System.Drawing.Point(93, 3)
		Me.numDotSize.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numDotSize.Minimum = New Decimal(New Integer() {2, 0, 0, 65536})
		Me.numDotSize.Name = "numDotSize"
		Me.numDotSize.Size = New System.Drawing.Size(89, 23)
		Me.numDotSize.TabIndex = 10
		Me.numDotSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numDotSize.Value = New Decimal(New Integer() {2, 0, 0, 65536})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.DimGray
		Me.Label5.Location = New System.Drawing.Point(188, 5)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(28, 15)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "mm."
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.ForeColor = System.Drawing.Color.DimGray
		Me.Label4.Location = New System.Drawing.Point(3, 34)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 15)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Dot space"
		'
		'numDotSpace
		'
		Me.numDotSpace.Location = New System.Drawing.Point(93, 32)
		Me.numDotSpace.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numDotSpace.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numDotSpace.Name = "numDotSpace"
		Me.numDotSpace.Size = New System.Drawing.Size(89, 23)
		Me.numDotSpace.TabIndex = 7
		Me.numDotSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numDotSpace.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.Color.DimGray
		Me.Label6.Location = New System.Drawing.Point(3, 5)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(63, 15)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Dot size"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.DimGray
		Me.Label3.Location = New System.Drawing.Point(188, 34)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(28, 15)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "mm."
		'
		'pnlLineSettings
		'
		Me.pnlLineSettings.Controls.Add(Me.Label1)
		Me.pnlLineSettings.Controls.Add(Me.numLineSpace)
		Me.pnlLineSettings.Controls.Add(Me.Label2)
		Me.pnlLineSettings.Location = New System.Drawing.Point(47, 50)
		Me.pnlLineSettings.Name = "pnlLineSettings"
		Me.pnlLineSettings.Size = New System.Drawing.Size(220, 30)
		Me.pnlLineSettings.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.DimGray
		Me.Label1.Location = New System.Drawing.Point(5, 5)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(77, 15)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Line space"
		'
		'numLineSpace
		'
		Me.numLineSpace.Location = New System.Drawing.Point(95, 3)
		Me.numLineSpace.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
		Me.numLineSpace.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
		Me.numLineSpace.Name = "numLineSpace"
		Me.numLineSpace.Size = New System.Drawing.Size(89, 23)
		Me.numLineSpace.TabIndex = 4
		Me.numLineSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numLineSpace.Value = New Decimal(New Integer() {7, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.DimGray
		Me.Label2.Location = New System.Drawing.Point(190, 5)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(28, 15)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "mm."
		'
		'rdbPatternType_Crosshair
		'
		Me.rdbPatternType_Crosshair.AutoSize = True
		Me.rdbPatternType_Crosshair.Location = New System.Drawing.Point(27, 176)
		Me.rdbPatternType_Crosshair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.rdbPatternType_Crosshair.Name = "rdbPatternType_Crosshair"
		Me.rdbPatternType_Crosshair.Size = New System.Drawing.Size(88, 19)
		Me.rdbPatternType_Crosshair.TabIndex = 2
		Me.rdbPatternType_Crosshair.Text = "Crosshair"
		Me.rdbPatternType_Crosshair.UseVisualStyleBackColor = True
		'
		'rdbPatternType_Dot
		'
		Me.rdbPatternType_Dot.AutoSize = True
		Me.rdbPatternType_Dot.Location = New System.Drawing.Point(27, 85)
		Me.rdbPatternType_Dot.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.rdbPatternType_Dot.Name = "rdbPatternType_Dot"
		Me.rdbPatternType_Dot.Size = New System.Drawing.Size(46, 19)
		Me.rdbPatternType_Dot.TabIndex = 1
		Me.rdbPatternType_Dot.Text = "Dot"
		Me.rdbPatternType_Dot.UseVisualStyleBackColor = True
		'
		'rdbPatternType_Line
		'
		Me.rdbPatternType_Line.AutoSize = True
		Me.rdbPatternType_Line.Checked = True
		Me.rdbPatternType_Line.Location = New System.Drawing.Point(27, 25)
		Me.rdbPatternType_Line.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.rdbPatternType_Line.Name = "rdbPatternType_Line"
		Me.rdbPatternType_Line.Size = New System.Drawing.Size(53, 19)
		Me.rdbPatternType_Line.TabIndex = 0
		Me.rdbPatternType_Line.TabStop = True
		Me.rdbPatternType_Line.Text = "Line"
		Me.rdbPatternType_Line.UseVisualStyleBackColor = True
		'
		'pdcMain
		'
		Me.pdcMain.DocumentName = "PaperMaek"
		'
		'tbxStatus
		'
		Me.tbxStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbxStatus.Location = New System.Drawing.Point(319, 22)
		Me.tbxStatus.Multiline = True
		Me.tbxStatus.Name = "tbxStatus"
		Me.tbxStatus.ReadOnly = True
		Me.tbxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.tbxStatus.Size = New System.Drawing.Size(588, 483)
		Me.tbxStatus.TabIndex = 4
		'
		'grpMarkerSettings
		'
		Me.grpMarkerSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.grpMarkerSettings.Controls.Add(Me.lblMarkerColorPreview)
		Me.grpMarkerSettings.Controls.Add(Me.btnPickMarkerColor)
		Me.grpMarkerSettings.Controls.Add(Me.Label11)
		Me.grpMarkerSettings.Location = New System.Drawing.Point(13, 397)
		Me.grpMarkerSettings.Name = "grpMarkerSettings"
		Me.grpMarkerSettings.Size = New System.Drawing.Size(299, 62)
		Me.grpMarkerSettings.TabIndex = 5
		Me.grpMarkerSettings.TabStop = False
		Me.grpMarkerSettings.Text = "Marker"
		'
		'lblMarkerColorPreview
		'
		Me.lblMarkerColorPreview.BackColor = System.Drawing.Color.LightGray
		Me.lblMarkerColorPreview.Location = New System.Drawing.Point(130, 24)
		Me.lblMarkerColorPreview.Name = "lblMarkerColorPreview"
		Me.lblMarkerColorPreview.Size = New System.Drawing.Size(56, 23)
		Me.lblMarkerColorPreview.TabIndex = 2
		'
		'btnPickMarkerColor
		'
		Me.btnPickMarkerColor.Location = New System.Drawing.Point(192, 24)
		Me.btnPickMarkerColor.Name = "btnPickMarkerColor"
		Me.btnPickMarkerColor.Size = New System.Drawing.Size(75, 23)
		Me.btnPickMarkerColor.TabIndex = 1
		Me.btnPickMarkerColor.Text = "Pick"
		Me.btnPickMarkerColor.UseVisualStyleBackColor = True
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(24, 28)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(42, 15)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "Color"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(920, 517)
		Me.Controls.Add(Me.grpMarkerSettings)
		Me.Controls.Add(Me.tbxStatus)
		Me.Controls.Add(Me.grpPatternType)
		Me.Controls.Add(Me.btnPrint)
		Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Paper Marker"
		Me.grpPatternType.ResumeLayout(False)
		Me.grpPatternType.PerformLayout()
		Me.pnlGridSettings.ResumeLayout(False)
		Me.pnlGridSettings.PerformLayout()
		CType(Me.numGridSpace, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlCrosshairSettings.ResumeLayout(False)
		Me.pnlCrosshairSettings.PerformLayout()
		CType(Me.numCrossSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numCrossSpace, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlDotSettings.ResumeLayout(False)
		Me.pnlDotSettings.PerformLayout()
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLineSettings.ResumeLayout(False)
		Me.pnlLineSettings.PerformLayout()
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grpMarkerSettings.ResumeLayout(False)
		Me.grpMarkerSettings.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnPrint As Button
	Friend WithEvents grpPatternType As GroupBox
	Friend WithEvents rdbPatternType_Crosshair As RadioButton
	Friend WithEvents rdbPatternType_Dot As RadioButton
	Friend WithEvents rdbPatternType_Line As RadioButton
	Friend WithEvents pdcMain As Printing.PrintDocument
	Friend WithEvents tbxStatus As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents numLineSpace As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents numDotSize As NumericUpDown
	Friend WithEvents Label6 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents numDotSpace As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents pnlDotSettings As Panel
	Friend WithEvents pnlLineSettings As Panel
	Friend WithEvents pnlCrosshairSettings As Panel
	Friend WithEvents numCrossSize As NumericUpDown
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents numCrossSpace As NumericUpDown
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents grpMarkerSettings As GroupBox
	Friend WithEvents lblMarkerColorPreview As Label
	Friend WithEvents btnPickMarkerColor As Button
	Friend WithEvents Label11 As Label
	Friend WithEvents pnlGridSettings As Panel
	Friend WithEvents Label12 As Label
	Friend WithEvents numGridSpace As NumericUpDown
	Friend WithEvents Label13 As Label
	Friend WithEvents rdbPatternType_Grid As RadioButton
End Class

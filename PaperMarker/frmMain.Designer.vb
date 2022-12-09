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
		Me.Label5 = New System.Windows.Forms.Label()
		Me.numDotSize = New System.Windows.Forms.NumericUpDown()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.numDotSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.numLineSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.rdbPatternType_Crosshair = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Dot = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Line = New System.Windows.Forms.RadioButton()
		Me.pdcMain = New System.Drawing.Printing.PrintDocument()
		Me.tbxStatus = New System.Windows.Forms.TextBox()
		Me.pnlLineSettings = New System.Windows.Forms.Panel()
		Me.pnlDotSettings = New System.Windows.Forms.Panel()
		Me.pnlCrosshairSettings = New System.Windows.Forms.Panel()
		Me.numCrossSize = New System.Windows.Forms.NumericUpDown()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.numCrossSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.grpPatternType.SuspendLayout()
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLineSettings.SuspendLayout()
		Me.pnlDotSettings.SuspendLayout()
		Me.pnlCrosshairSettings.SuspendLayout()
		CType(Me.numCrossSize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numCrossSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnPrint
		'
		Me.btnPrint.BackColor = System.Drawing.Color.ForestGreen
		Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Green
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrint.ForeColor = System.Drawing.Color.Honeydew
		Me.btnPrint.Location = New System.Drawing.Point(692, 298)
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
		Me.grpPatternType.Size = New System.Drawing.Size(299, 324)
		Me.grpPatternType.TabIndex = 3
		Me.grpPatternType.TabStop = False
		Me.grpPatternType.Text = "Pattern Type"
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
		Me.tbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tbxStatus.Location = New System.Drawing.Point(319, 22)
		Me.tbxStatus.Multiline = True
		Me.tbxStatus.Name = "tbxStatus"
		Me.tbxStatus.ReadOnly = True
		Me.tbxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.tbxStatus.Size = New System.Drawing.Size(490, 270)
		Me.tbxStatus.TabIndex = 4
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
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(823, 350)
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
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLineSettings.ResumeLayout(False)
		Me.pnlLineSettings.PerformLayout()
		Me.pnlDotSettings.ResumeLayout(False)
		Me.pnlDotSettings.PerformLayout()
		Me.pnlCrosshairSettings.ResumeLayout(False)
		Me.pnlCrosshairSettings.PerformLayout()
		CType(Me.numCrossSize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numCrossSpace, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class

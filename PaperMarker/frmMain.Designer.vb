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
		Me.rdbPatternType_Crosshair = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Dot = New System.Windows.Forms.RadioButton()
		Me.rdbPatternType_Line = New System.Windows.Forms.RadioButton()
		Me.pdcMain = New System.Drawing.Printing.PrintDocument()
		Me.tbxStatus = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.numLineSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.numDotSpace = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.numDotSize = New System.Windows.Forms.NumericUpDown()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.grpPatternType.SuspendLayout()
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.grpPatternType.Controls.Add(Me.Label5)
		Me.grpPatternType.Controls.Add(Me.numDotSize)
		Me.grpPatternType.Controls.Add(Me.Label6)
		Me.grpPatternType.Controls.Add(Me.Label3)
		Me.grpPatternType.Controls.Add(Me.numDotSpace)
		Me.grpPatternType.Controls.Add(Me.Label4)
		Me.grpPatternType.Controls.Add(Me.Label2)
		Me.grpPatternType.Controls.Add(Me.numLineSpace)
		Me.grpPatternType.Controls.Add(Me.Label1)
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
		'rdbPatternType_Crosshair
		'
		Me.rdbPatternType_Crosshair.AutoSize = True
		Me.rdbPatternType_Crosshair.Location = New System.Drawing.Point(27, 153)
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
		Me.rdbPatternType_Dot.Location = New System.Drawing.Point(27, 74)
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
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.Color.DimGray
		Me.Label1.Location = New System.Drawing.Point(53, 47)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(77, 15)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Line space"
		'
		'numLineSpace
		'
		Me.numLineSpace.Location = New System.Drawing.Point(143, 45)
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
		Me.Label2.Location = New System.Drawing.Point(238, 47)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(28, 15)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "mm."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.ForeColor = System.Drawing.Color.DimGray
		Me.Label3.Location = New System.Drawing.Point(238, 125)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(28, 15)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "mm."
		'
		'numDotSpace
		'
		Me.numDotSpace.Location = New System.Drawing.Point(143, 123)
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
		Me.Label4.Location = New System.Drawing.Point(53, 125)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(70, 15)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Dot space"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.ForeColor = System.Drawing.Color.DimGray
		Me.Label5.Location = New System.Drawing.Point(238, 96)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(28, 15)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "mm."
		'
		'numDotSize
		'
		Me.numDotSize.DecimalPlaces = 1
		Me.numDotSize.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
		Me.numDotSize.Location = New System.Drawing.Point(143, 94)
		Me.numDotSize.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numDotSize.Minimum = New Decimal(New Integer() {2, 0, 0, 65536})
		Me.numDotSize.Name = "numDotSize"
		Me.numDotSize.Size = New System.Drawing.Size(89, 23)
		Me.numDotSize.TabIndex = 10
		Me.numDotSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numDotSize.Value = New Decimal(New Integer() {3, 0, 0, 65536})
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.ForeColor = System.Drawing.Color.DimGray
		Me.Label6.Location = New System.Drawing.Point(53, 96)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(63, 15)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Dot size"
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
		CType(Me.numLineSpace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numDotSpace, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numDotSize, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class

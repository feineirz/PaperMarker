Public Class frmMain

    Private Const factorPixelToMillimeter = 0.264583333
    Private Const factorMillimeterToPixel = 1 / factorPixelToMillimeter
    Private patternType As String

#Region "Moveable Form Code"
    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        Const WM_NCLBUTTONDOWN As Integer = &HA1
        Const HT_CAPTION As Integer = &H2

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

#End Region

    Private Sub pdcMain_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdcMain.PrintPage

        Dim g As Graphics = e.Graphics
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim defaultFont = New Font("Tahoma", 16, FontStyle.Bold)
        Dim defaultPen As New Pen(lblMarkerColorPreview.BackColor, 0.02)
        Dim defaultBrush As New SolidBrush(lblMarkerColorPreview.BackColor)
        Dim defaultFontBrush = New SolidBrush(Color.FromArgb(255, 100, 100, 100))
        Dim defaultDashStyle As Single() = {8, 8}
        Dim defaultDotStyle As Single() = {1, 4}

        Dim paperSize As New SizeF(pdcMain.DefaultPageSettings.PaperSize.Width, pdcMain.DefaultPageSettings.PaperSize.Height) 'pixel
        Dim paperPadding As New SizeF(10 * factorMillimeterToPixel, 10 * factorMillimeterToPixel) 'pixel
        Dim workingArea As New SizeF(paperSize.Width - (2 * paperPadding.Width), paperSize.Height - (2 * paperPadding.Height)) 'pixel
        Dim initPoint As New PointF(paperPadding.Width, paperPadding.Height)

        If patternType = "Line" Then
            Dim lineSpace As Integer = numLineSpace.Value * factorMillimeterToPixel
            Dim lineCount As Integer = Math.Floor(workingArea.Height / lineSpace)
            Dim lineAdjustSpaceY As Integer = (workingArea.Height - (lineCount * lineSpace)) / 2
            Dim lineStart As Integer = 0

            Dim lineTitle As String = tbxLineTitle.Text.Trim()

            If Not tbxLineTitle.Text.Trim() = "" Then
                Dim titleSize = g.MeasureString(lineTitle, defaultFont)
                lineStart = Math.Ceiling(titleSize.Height / lineSpace)
                g.DrawString(
                    lineTitle,
                    defaultFont,
                    defaultBrush,
                    New PointF(initPoint.X, initPoint.Y + lineAdjustSpaceY))
            End If

            If rdbLineStyle_Solid.Checked Then defaultPen.DashStyle = Drawing2D.DashStyle.Solid
            If rdbLineStyle_Dashed.Checked Then defaultPen.DashPattern = defaultDashStyle
            If rdbLineStyle_Dotted.Checked Then defaultPen.DashPattern = defaultDotStyle

            For i = lineStart To lineCount
                g.DrawLine(
                    defaultPen,
                    New PointF(initPoint.X, initPoint.Y + lineAdjustSpaceY + (i * lineSpace)),
                    New PointF(initPoint.X + workingArea.Width, initPoint.Y + lineAdjustSpaceY + (i * lineSpace)))
            Next

        ElseIf patternType = "Dot" Then
            Dim dotSize As Integer = numDotSize.Value * factorMillimeterToPixel
            Dim dotSpace As Integer = numDotSpace.Value * factorMillimeterToPixel
            Dim dotCount As New SizeF(
                Math.Floor(workingArea.Width / dotSpace),
                Math.Floor(workingArea.Height / dotSpace))
            Dim dotAdjustSpace As New SizeF(
                (workingArea.Width - (dotCount.Width * dotSpace)) / 2,
                (workingArea.Height - (dotCount.Height * dotSpace)) / 2)

            For i = 0 To dotCount.Width
                For j = 0 To dotCount.Height
                    g.FillEllipse(
                        defaultBrush,
                        initPoint.X + dotAdjustSpace.Width + (i * dotSpace),
                        initPoint.Y + dotAdjustSpace.Height + (j * dotSpace),
                        dotSize,
                        dotSize)
                Next
            Next

        ElseIf patternType = "Crosshair" Then
            Dim crossSize As Integer = numCrossSize.Value * factorMillimeterToPixel
            Dim crossSpace As Integer = numCrossSpace.Value * factorMillimeterToPixel
            Dim crossCount As New SizeF(
                Math.Floor(workingArea.Width / crossSpace),
                Math.Floor(workingArea.Height / crossSpace))
            Dim crossAdjustSpace As New SizeF(
                (workingArea.Width - (crossCount.Width * crossSpace)) / 2,
                (workingArea.Height - (crossCount.Height * crossSpace)) / 2)

            For i = 0 To crossCount.Width
                For j = 0 To crossCount.Height
                    g.DrawLine(
                        defaultPen,
                        New PointF(initPoint.X + crossAdjustSpace.Width + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (0.5 * crossSize) + (j * crossSpace)),
                        New PointF(initPoint.X + crossAdjustSpace.Width + crossSize + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (0.5 * crossSize) + (j * crossSpace)))
                    g.DrawLine(
                        defaultPen,
                        New PointF(initPoint.X + crossAdjustSpace.Width + (0.5 * crossSize) + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (j * crossSpace)),
                        New PointF(initPoint.X + crossAdjustSpace.Width + (0.5 * crossSize) + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + crossSize + (j * crossSpace)))
                Next
            Next

        ElseIf patternType = "Grid" Then
            Dim gridSpace As Integer = numGridSpace.Value * factorMillimeterToPixel
            Dim gridCount As New SizeF(
                Math.Floor(workingArea.Width / gridSpace),
                Math.Floor(workingArea.Height / gridSpace))
            Dim gridAdjustSpace As New SizeF(
                (workingArea.Width - (gridCount.Width * gridSpace)) / 2,
                (workingArea.Height - (gridCount.Height * gridSpace)) / 2)

            If rdbLineStyle_Solid.Checked Then defaultPen.DashStyle = Drawing2D.DashStyle.Solid
            If rdbLineStyle_Dashed.Checked Then defaultPen.DashPattern = defaultDashStyle
            If rdbLineStyle_Dotted.Checked Then defaultPen.DashPattern = defaultDotStyle

            For i = 0 To gridCount.Width
                For j = 0 To gridCount.Height
                    g.DrawLine(
                        defaultPen,
                        New PointF(initPoint.X + gridAdjustSpace.Width, initPoint.Y + gridAdjustSpace.Height + (j * gridSpace)),
                        New PointF(initPoint.X + gridAdjustSpace.Width + (gridCount.Width * gridSpace), initPoint.Y + gridAdjustSpace.Height + (j * gridSpace)))
                    g.DrawLine(
                        defaultPen,
                        New PointF(initPoint.X + gridAdjustSpace.Width + (i * gridSpace), initPoint.Y + gridAdjustSpace.Height),
                        New PointF(initPoint.X + gridAdjustSpace.Width + (i * gridSpace), initPoint.Y + gridAdjustSpace.Height + (gridCount.Height * gridSpace)))
                Next
            Next

        End If

        e.HasMorePages = False
        g.Dispose()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim dlgPrintSettings As New PrintDialog()
        dlgPrintSettings.Document = pdcMain
        dlgPrintSettings.PrinterSettings = pdcMain.PrinterSettings

        If dlgPrintSettings.ShowDialog = DialogResult.OK Then
            tbxStatus.Text = "Paper Size: " & pdcMain.DefaultPageSettings.PaperSize.ToString() + vbCrLf + tbxStatus.Text
            pdcMain.PrinterSettings = dlgPrintSettings.PrinterSettings
            pdcMain.OriginAtMargins = True
            pdcMain.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
            Try
                pdcMain.Print()
                tbxStatus.Text = "Printing successful." & vbCrLf & tbxStatus.Text
            Catch ex As Exception
                tbxStatus.Text = "Printing fail! (Output file might be in use.)" & vbCrLf & tbxStatus.Text
            End Try
        End If

    End Sub

    Private Sub rdbPatternType_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPatternType_Line.CheckedChanged, rdbPatternType_Dot.CheckedChanged, rdbPatternType_Crosshair.CheckedChanged, rdbPatternType_Grid.CheckedChanged
        Dim rdb As RadioButton = DirectCast(sender, RadioButton)

        pnlLineSettings.Enabled = False
        pnlDotSettings.Enabled = False
        pnlCrosshairSettings.Enabled = False
        pnlGridSettings.Enabled = False

        If rdb.Checked Then
            Select Case rdb.Text
                Case ""
                    patternType = "Line"
                    tbxStatus.Text = "Pattern Type: Line [Line space 7 mm.]" & vbCrLf & tbxStatus.Text
                    pnlLineSettings.Enabled = True
                Case "Line"
                    patternType = "Line"
                    tbxStatus.Text = "Pattern Type: Line [Line space " & numLineSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
                    pnlLineSettings.Enabled = True
                Case "Dot"
                    patternType = "Dot"
                    tbxStatus.Text = "Pattern Type: Dot [Dot size " & numDotSize.Value & " mm., Dot space " & numDotSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
                    pnlDotSettings.Enabled = True
                Case "Crosshair"
                    patternType = "Crosshair"
                    tbxStatus.Text = "Pattern Type: Crosshair [Mark size " & numCrossSize.Value & " mm., Mark space " & numCrossSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
                    pnlCrosshairSettings.Enabled = True
                Case "Grid"
                    patternType = "Grid"
                    tbxStatus.Text = "Pattern Type: Grid [Grid space " & numGridSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
                    pnlGridSettings.Enabled = True
            End Select
        End If
    End Sub

    Private Sub numLineSpace_ValueChanged(sender As Object, e As EventArgs) Handles numLineSpace.ValueChanged
        If rdbPatternType_Line.Checked Then tbxStatus.Text = "Pattern Type: Line [Line space " & numLineSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
    End Sub

    Private Sub numDot_ValueChanged(sender As Object, e As EventArgs) Handles numDotSize.ValueChanged, numDotSpace.ValueChanged
        If rdbPatternType_Dot.Checked Then tbxStatus.Text = "Pattern Type: Dot [Dot size " & numDotSize.Value & " mm., Dot space " & numDotSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
    End Sub

    Private Sub numCross_ValueChanged(sender As Object, e As EventArgs) Handles numCrossSize.ValueChanged, numCrossSpace.ValueChanged
        If rdbPatternType_Crosshair.Checked Then tbxStatus.Text = "Pattern Type: Crosshair [Mark size " & numCrossSize.Value & " mm., Mark space " & numCrossSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
    End Sub

    Private Sub numGridSpace_ValueChanged(sender As Object, e As EventArgs) Handles numGridSpace.ValueChanged
        If rdbPatternType_Grid.Checked Then tbxStatus.Text = "Pattern Type: Grid [Grid space " & numGridSpace.Value & " mm.]" & vbCrLf & tbxStatus.Text
    End Sub

    Private Sub btnPickMarkerColor_Click(sender As Object, e As EventArgs) Handles btnPickMarkerColor.Click

        Dim dlgColorPicker As New ColorDialog
        Dim a, r, g, b, sumRGBValue, avgRGBValue As Integer

        If dlgColorPicker.ShowDialog = DialogResult.OK Then
            pnlHeader.BackColor = dlgColorPicker.Color
            lblMarkerColorPreview.BackColor = dlgColorPicker.Color
            tbxStatus.BackColor = dlgColorPicker.Color
            pnlFooter.BackColor = dlgColorPicker.Color

            a = lblMarkerColorPreview.BackColor.A
            r = lblMarkerColorPreview.BackColor.R
            g = lblMarkerColorPreview.BackColor.G
            b = lblMarkerColorPreview.BackColor.B

            sumRGBValue = r + g + b
            avgRGBValue = 3 * 128 - 30

            If sumRGBValue > avgRGBValue Then
                lblAppTitle.ForeColor = Color.Black
                lblAppVersion.ForeColor = Color.Black
                lblMarkerColorPreview.ForeColor = Color.Black
                tbxStatus.ForeColor = Color.Black
            Else
                lblAppTitle.ForeColor = Color.White
                lblAppVersion.ForeColor = Color.White
                lblMarkerColorPreview.ForeColor = Color.White
                tbxStatus.ForeColor = Color.White
            End If

            lblDebugInfo.Text = "A: " & a & ", R: " & r & ", G: " & g & ", B: " & b
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

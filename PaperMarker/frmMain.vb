Public Class frmMain

    Private Const factorPixelToMillimeter = 0.264583333
    Private Const factorMillimeterToPixel = 1 / factorPixelToMillimeter
    Private patternType As String

    Private Sub pdcMain_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdcMain.PrintPage

        Dim g As Graphics = e.Graphics
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim defaultPen As New Pen(Color.FromArgb(255, 200, 200, 200), 0.2)
        Dim defaultBrush As New SolidBrush(Color.FromArgb(255, 200, 200, 200))

        Dim paperSize As New Size(pdcMain.DefaultPageSettings.PaperSize.Width, pdcMain.DefaultPageSettings.PaperSize.Height) 'pixel
        Dim paperPadding As New Size(10 * factorMillimeterToPixel, 10 * factorMillimeterToPixel) 'pixel
        Dim workingArea As New Size(paperSize.Width - (2 * paperPadding.Width), paperSize.Height - (2 * paperPadding.Height)) 'pixel
        Dim initPoint As New Point(paperPadding.Width, paperPadding.Height)

        If patternType = "Line" Then
            Dim lineSpace As Integer = numLineSpace.Value * factorMillimeterToPixel
            Dim lineCount As Integer = Math.Floor(workingArea.Height / lineSpace)
            Dim lineAdjustSpace As Integer = (workingArea.Height - (lineCount * lineSpace)) / 2

            For i = 0 To lineCount
                g.DrawLine(
                    defaultPen,
                    New Point(initPoint.X, initPoint.Y + lineAdjustSpace + (i * lineSpace)),
                    New Point(initPoint.X + workingArea.Width, initPoint.Y + lineAdjustSpace + (i * lineSpace)))
            Next

        ElseIf patternType = "Dot" Then
            Dim dotSize As Integer = numDotSize.Value * factorMillimeterToPixel
            Dim dotSpace As Integer = numDotSpace.Value * factorMillimeterToPixel
            Dim dotCount As New Size(
                Math.Floor(workingArea.Width / dotSpace),
                Math.Floor(workingArea.Height / dotSpace))
            Dim dotAdjustSpace As New Size(
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
            Dim crossCount As New Size(
                Math.Floor(workingArea.Width / crossSpace),
                Math.Floor(workingArea.Height / crossSpace))
            Dim crossAdjustSpace As New Size(
                (workingArea.Width - (crossCount.Width * crossSpace)) / 2,
                (workingArea.Height - (crossCount.Height * crossSpace)) / 2)

            For i = 0 To crossCount.Width
                For j = 0 To crossCount.Height
                    g.DrawLine(
                        defaultPen,
                        New Point(initPoint.X + crossAdjustSpace.Width + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (0.5 * crossSize) + (j * crossSpace)),
                        New Point(initPoint.X + crossAdjustSpace.Width + crossSize + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (0.5 * crossSize) + (j * crossSpace)))
                    g.DrawLine(
                        defaultPen,
                        New Point(initPoint.X + crossAdjustSpace.Width + (0.5 * crossSize) + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + (j * crossSpace)),
                        New Point(initPoint.X + crossAdjustSpace.Width + (0.5 * crossSize) + (i * crossSpace), initPoint.Y + crossAdjustSpace.Height + crossSize + (j * crossSpace)))
                Next
            Next

        End If

        e.HasMorePages = False
        g.Dispose()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim printDialog As New PrintDialog()
        printDialog.Document = pdcMain
        printDialog.PrinterSettings = pdcMain.PrinterSettings

        If printDialog.ShowDialog = DialogResult.OK Then
            tbxStatus.Text = "Paper Size: " & pdcMain.DefaultPageSettings.PaperSize.ToString() + vbCrLf + tbxStatus.Text
            pdcMain.PrinterSettings = printDialog.PrinterSettings
            Try
                pdcMain.Print()
                tbxStatus.Text = "Printing successful." & vbCrLf & tbxStatus.Text
            Catch ex As Exception
                tbxStatus.Text = "Printing fail! (Output file might be in use.)" & vbCrLf & tbxStatus.Text
            End Try
        End If

    End Sub

    Private Sub rdbPatternType_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPatternType_Line.CheckedChanged, rdbPatternType_Dot.CheckedChanged, rdbPatternType_Crosshair.CheckedChanged
        Dim rdb As RadioButton = DirectCast(sender, RadioButton)

        pnlLineSettings.Enabled = False
        pnlDotSettings.Enabled = False
        pnlCrosshairSettings.Enabled = False

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
End Class

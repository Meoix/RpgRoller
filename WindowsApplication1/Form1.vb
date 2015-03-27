Public Class frmMain

    Const Success As String = "Success"
    Const CritSuccess As String = "Critical Success"
    Const Fail As String = "Failure"
    Const CritFail As String = "Critical Failure"
    Const CloseSuccess As String = "Near Success"
    Const CloseFail As String = "Near Failure"
    Const Close As String = "Close"

    'Used to check in textbox values are integers
    Public Function numeric(ByVal input As String)
        Return IsNumeric(input)
    End Function

    'Heart of Program, parses through formula field, generates two random numbers based on min/max fields and outputs result
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim outcome As Integer
        Dim formula As String
        Dim result As String
        'Check Roll Fields for Validty
        If Not IsNumeric(txtGlance.Text) Or Int(txtGlance.Text) < 0 Or Not IsNumeric(txtCritHit.Text) Or Not IsNumeric(txtCritHit.Text) Or Not IsNumeric(txtMinRoll.Text) Or Not IsNumeric(txtMinRoll.Text) Or Int(txtMinRoll.Text) < 0 Or Int(txtMaxRoll.Text) < Int(txtMinRoll.Text) Or Int(txtMaxRoll.Text) = Int(txtMinRoll.Text) Then
            txtMinRoll.Text = "0"
            txtMaxRoll.Text = "10"
            txtCritFail.Text = "-5"
            txtCritHit.Text = "5"
            txtGlance.Text = "1"
        End If

        If txtFormula.Text = "" Or Not checkStats() Then         'If no formula is used
            Randomize()
            Dim op As String
            txtARoll.Text = Int((Int(txtMaxRoll.Text) * Rnd()) + Int(txtMinRoll.Text))
            txtBRoll.Text = Int((Int(txtMaxRoll.Text) * Rnd()) + Int(txtMinRoll.Text))
            outcome = txtARoll.Text - txtBRoll.Text
            If (outcome >= Int(txtCritHit.Text)) Then
                result = CritSuccess
                op = " >+"
            ElseIf (outcome > Int(txtGlance.Text)) Then
                result = Success
                op = " >"
            ElseIf (outcome > 0) Then
                result = CloseSuccess
                op = " ~"
            ElseIf (outcome = 0) Then
                result = Close
                op = " ="
            ElseIf (outcome >= (Int(txtGlance.Text) * -1)) Then
                result = CloseFail
                op = " ~"
            ElseIf (outcome > Int(txtCritFail.Text)) Then
                result = Fail
                op = " <"
            Else
                result = CritFail
                op = " +<"
            End If
            txtOutcome.Text = result
            lbRolls.Items.Add("Roll " & lbRolls.Items.Count & ": [PartyA = " & txtARoll.Text & op & " PartyB = " & txtBRoll.Text & "] = (" & outcome & ") => " & result)
        Else                'Using a formula
            Try
                formula = parseFormula(outcome)
            Catch ex As Exception
                MsgBox("Arthimetic Error in Formula field.", MsgBoxStyle.Critical, "Formula Error")
            End Try
            txtFrmOut.Text = outcome
            'value > 0 == success, value == 0 == close, value < 0 == failure
            If (outcome >= Int(txtCritHit.Text)) Then
                result = CritSuccess
            ElseIf (outcome > Int(txtGlance.Text)) Then
                result = Success
            ElseIf (outcome > 0) Then
                result = CloseSuccess
            ElseIf (outcome = 0) Then
                result = Close
            ElseIf (outcome >= (Int(txtGlance.Text) * -1)) Then
                result = CloseFail
            ElseIf (outcome > Int(txtCritFail.Text)) Then
                result = Fail
            Else
                result = CritFail
            End If
            txtOutcome.Text = result
            lbRolls.Items.Add("Roll " & lbRolls.Items.Count & ": Formula- [" & formula & "] = (" & txtFrmOut.Text & ") => " & result)
        End If
        lbRolls.TopIndex = lbRolls.Items.Count - 1
        txtOutcomeValue.Text = outcome
    End Sub

    'Parses the formula field to determine a success outcome
    'value > 0 == success, value == 0 == close, value < 0 == failure
    Private Function parseFormula(ByRef outcome)
        Dim formula As String = ""
        formula = txtFormula.Text
        formula = variableParse(formula)
        Dim e As NCalc.Expression = New NCalc.Expression(formula)
        outcome = e.Evaluate()
        Console.WriteLine(outcome)
        Return formula
    End Function

    'Checks to confirm stats are numbers
    Private Function checkStats() As Boolean
        If Not IsNumeric(txtStrA.Text) Then
            txtStrA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtStrB.Text) Then
            txtStrB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtDexA.Text) Then
            txtDexA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtDexB.Text) Then
            txtDexB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtVitA.Text) Then
            txtVitA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtVitB.Text) Then
            txtVitB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtIntA.Text) Then
            txtIntA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtIntB.Text) Then
            txtIntB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtMndA.Text) Then
            txtMndA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtMndB.Text) Then
            txtMndB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtPieA.Text) Then
            txtPieA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtPieB.Text) Then
            txtPieB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtSkBA.Text) Then
            txtSkBA.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtSkBB.Text) Then
            txtSkBB.Text = "0"
            Return False
        End If
        If Not IsNumeric(txtCritHit.Text) Then
            txtCritHit.Text = "5"
            Return False
        End If
        If Not IsNumeric(txtCritFail.Text) Then
            txtCritFail.Text = "-5"
            Return False
        End If
        If Not IsNumeric(txtGlance.Text) Then
            txtGlance.Text = "1"
            Return False
        End If

        Return True
    End Function

    'replaces the formula stat names with the stat values
    Private Function variableParse(ByVal formula)
        formula = LCase(formula)
        Console.WriteLine(formula)
        Dim indexTemp As Integer
        indexTemp = formula.IndexOf("a.str")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.str", txtStrA.Text)
        End If
        indexTemp = formula.IndexOf("b.str")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.str", txtStrB.Text)
        End If
        indexTemp = formula.IndexOf("a.dex")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.dex", txtDexA.Text)
        End If
        indexTemp = formula.IndexOf("b.dex")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.dex", txtDexB.Text)
        End If
        indexTemp = formula.IndexOf("a.vit")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.vit", txtVitA.Text)
        End If
        indexTemp = formula.IndexOf("b.vit")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.vit", txtVitB.Text)
        End If
        indexTemp = formula.IndexOf("a.int")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.int", txtIntA.Text)
        End If
        indexTemp = formula.IndexOf("b.int")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.int", txtIntB.Text)
        End If
        indexTemp = formula.IndexOf("a.mnd")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.mnd", txtMndA.Text)
        End If
        indexTemp = formula.IndexOf("b.mnd")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.mnd", txtMndB.Text)
        End If
        indexTemp = formula.IndexOf("a.pie")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.pie", txtPieA.Text)
        End If
        indexTemp = formula.IndexOf("b.pie")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.pie", txtPieB.Text)
        End If
        indexTemp = formula.IndexOf("a.skb")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "a.skb", txtSkBA.Text)
        End If
        indexTemp = formula.IndexOf("b.skb")
        If (indexTemp <> -1) Then
            formula = Replace(formula, "b.skb", txtSkBB.Text)
        End If
        indexTemp = formula.IndexOf("a.roll")
        If (indexTemp <> -1) Then
            Randomize()
            txtARoll.Text = Int((Int(txtMaxRoll.Text) * Rnd()) + Int(txtMinRoll.Text))
            formula = Replace(formula, "a.roll", txtARoll.Text)
        End If
        indexTemp = formula.IndexOf("b.roll")
        If (indexTemp <> -1) Then
            Randomize()
            txtBRoll.Text = Int((Int(txtMaxRoll.Text) * Rnd()) + Int(txtMinRoll.Text))
            formula = Replace(formula, "b.roll", txtBRoll.Text)
        End If
        Console.WriteLine(formula)
        Return formula
    End Function

#Region "Minor Button Click"
    'Opens About form on About button click
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

    'Sets preset Magick attack in formula text field on Physical attack button
    Private Sub btnMagick_Click(sender As Object, e As EventArgs) Handles btnMagick.Click
        txtFormula.Text = "A.int + A.roll + A.skb - B.dex - B.roll - B.skb"
    End Sub

    'Sets preset Physical attack in formula text field on Magick attack button
    Private Sub btnPhysical_Click(sender As Object, e As EventArgs) Handles btnPhysical.Click
        txtFormula.Text = "A.str + A.roll + A.skb - B.dex - B.roll - B.skb"
    End Sub

    'Clears formula text field on Clear Formula button
    Private Sub btnClearFrm_Click(sender As Object, e As EventArgs) Handles btnClearFrm.Click
        txtFormula.Text = ""
        txtFrmOut.Text = ""
    End Sub

    'Clears entire form on clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStrA.Text = "0"
        txtStrB.Text = "0"
        txtVitA.Text = "0"
        txtVitB.Text = "0"
        txtDexA.Text = "0"
        txtDexB.Text = "0"
        txtIntA.Text = "0"
        txtIntB.Text = "0"
        txtMndA.Text = "0"
        txtMndB.Text = "0"
        txtPieA.Text = "0"
        txtPieB.Text = "0"
        txtSkBA.Text = "0"
        txtSkBB.Text = "0"
        txtFormula.Text = ""
        txtMaxRoll.Text = "10"
        txtMinRoll.Text = "0"
        txtCritHit.Text = "5"
        txtCritFail.Text = "-5"
        txtGlance.Text = "1"
        txtARoll.Text = ""
        txtBRoll.Text = ""
        txtOutcome.Text = ""
        txtFrmOut.Text = ""
        txtOutcomeValue.Text = ""
        lbRolls.Items.Clear()
    End Sub

    'Swaps the stat values between party A and party B
    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        swapText(txtStrA, txtStrB)
        swapText(txtVitA, txtVitB)
        swapText(txtDexA, txtDexB)
        swapText(txtIntA, txtIntB)
        swapText(txtMndA, txtMndB)
        swapText(txtPieA, txtPieB)
        swapText(txtSkBA, txtSkBB)
    End Sub

    'Simple function used by btnSwap to swap the string values of the text fields in two textboxes
    Private Sub swapText(ByRef txtA As TextBox, ByRef txtB As TextBox)
        Dim temp As String
        temp = txtA.Text
        txtA.Text = txtB.Text
        txtB.Text = temp
    End Sub

    Private Sub btnFrmHelp_Click(sender As Object, e As EventArgs) Handles btnFrmHelp.Click
        frmFormula.Show()
    End Sub
#End Region
End Class





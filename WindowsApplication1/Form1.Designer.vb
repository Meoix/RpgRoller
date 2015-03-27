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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStrA = New System.Windows.Forms.TextBox()
        Me.txtDexA = New System.Windows.Forms.TextBox()
        Me.txtVitA = New System.Windows.Forms.TextBox()
        Me.txtIntA = New System.Windows.Forms.TextBox()
        Me.txtMndA = New System.Windows.Forms.TextBox()
        Me.txtPieA = New System.Windows.Forms.TextBox()
        Me.txtSkBA = New System.Windows.Forms.TextBox()
        Me.txtSkBB = New System.Windows.Forms.TextBox()
        Me.txtPieB = New System.Windows.Forms.TextBox()
        Me.txtMndB = New System.Windows.Forms.TextBox()
        Me.txtIntB = New System.Windows.Forms.TextBox()
        Me.txtVitB = New System.Windows.Forms.TextBox()
        Me.txtDexB = New System.Windows.Forms.TextBox()
        Me.txtStrB = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMinRoll = New System.Windows.Forms.TextBox()
        Me.txtMaxRoll = New System.Windows.Forms.TextBox()
        Me.txtOutcome = New System.Windows.Forms.TextBox()
        Me.lblOutcome = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtARoll = New System.Windows.Forms.TextBox()
        Me.txtBRoll = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFormula = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.txtCritHit = New System.Windows.Forms.TextBox()
        Me.txtGlance = New System.Windows.Forms.TextBox()
        Me.txtCritFail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOutcomeValue = New System.Windows.Forms.TextBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnMagick = New System.Windows.Forms.Button()
        Me.btnPhysical = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClearFrm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFrmOut = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbRolls = New System.Windows.Forms.ListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnFrmHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRoll.Location = New System.Drawing.Point(12, 297)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 30
        Me.btnRoll.Text = "Roll"
        Me.ToolTip1.SetToolTip(Me.btnRoll, "Random value between Min and Max")
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Party A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Party B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Strength"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dexterity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Vitality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Intelligence"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Mind"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(414, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Piety"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Skill Bonus"
        Me.ToolTip1.SetToolTip(Me.Label9, "Value to be added on roll")
        '
        'txtStrA
        '
        Me.txtStrA.Location = New System.Drawing.Point(84, 29)
        Me.txtStrA.Name = "txtStrA"
        Me.txtStrA.Size = New System.Drawing.Size(48, 22)
        Me.txtStrA.TabIndex = 10
        Me.txtStrA.Text = "0"
        '
        'txtDexA
        '
        Me.txtDexA.Location = New System.Drawing.Point(152, 29)
        Me.txtDexA.Name = "txtDexA"
        Me.txtDexA.Size = New System.Drawing.Size(48, 22)
        Me.txtDexA.TabIndex = 11
        Me.txtDexA.Text = "0"
        '
        'txtVitA
        '
        Me.txtVitA.Location = New System.Drawing.Point(221, 29)
        Me.txtVitA.Name = "txtVitA"
        Me.txtVitA.Size = New System.Drawing.Size(48, 22)
        Me.txtVitA.TabIndex = 12
        Me.txtVitA.Text = "0"
        '
        'txtIntA
        '
        Me.txtIntA.Location = New System.Drawing.Point(278, 29)
        Me.txtIntA.Name = "txtIntA"
        Me.txtIntA.Size = New System.Drawing.Size(48, 22)
        Me.txtIntA.TabIndex = 13
        Me.txtIntA.Text = "0"
        '
        'txtMndA
        '
        Me.txtMndA.Location = New System.Drawing.Point(363, 29)
        Me.txtMndA.Name = "txtMndA"
        Me.txtMndA.Size = New System.Drawing.Size(48, 22)
        Me.txtMndA.TabIndex = 14
        Me.txtMndA.Text = "0"
        '
        'txtPieA
        '
        Me.txtPieA.Location = New System.Drawing.Point(417, 29)
        Me.txtPieA.Name = "txtPieA"
        Me.txtPieA.Size = New System.Drawing.Size(48, 22)
        Me.txtPieA.TabIndex = 15
        Me.txtPieA.Text = "0"
        '
        'txtSkBA
        '
        Me.txtSkBA.Location = New System.Drawing.Point(471, 29)
        Me.txtSkBA.Name = "txtSkBA"
        Me.txtSkBA.Size = New System.Drawing.Size(48, 22)
        Me.txtSkBA.TabIndex = 16
        Me.txtSkBA.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtSkBA, "Value to be added on roll")
        '
        'txtSkBB
        '
        Me.txtSkBB.Location = New System.Drawing.Point(471, 57)
        Me.txtSkBB.Name = "txtSkBB"
        Me.txtSkBB.Size = New System.Drawing.Size(48, 22)
        Me.txtSkBB.TabIndex = 23
        Me.txtSkBB.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtSkBB, "Value to be added on roll")
        '
        'txtPieB
        '
        Me.txtPieB.Location = New System.Drawing.Point(417, 57)
        Me.txtPieB.Name = "txtPieB"
        Me.txtPieB.Size = New System.Drawing.Size(48, 22)
        Me.txtPieB.TabIndex = 22
        Me.txtPieB.Text = "0"
        '
        'txtMndB
        '
        Me.txtMndB.Location = New System.Drawing.Point(363, 57)
        Me.txtMndB.Name = "txtMndB"
        Me.txtMndB.Size = New System.Drawing.Size(48, 22)
        Me.txtMndB.TabIndex = 21
        Me.txtMndB.Text = "0"
        '
        'txtIntB
        '
        Me.txtIntB.Location = New System.Drawing.Point(278, 57)
        Me.txtIntB.Name = "txtIntB"
        Me.txtIntB.Size = New System.Drawing.Size(48, 22)
        Me.txtIntB.TabIndex = 20
        Me.txtIntB.Text = "0"
        '
        'txtVitB
        '
        Me.txtVitB.Location = New System.Drawing.Point(221, 57)
        Me.txtVitB.Name = "txtVitB"
        Me.txtVitB.Size = New System.Drawing.Size(48, 22)
        Me.txtVitB.TabIndex = 19
        Me.txtVitB.Text = "0"
        '
        'txtDexB
        '
        Me.txtDexB.Location = New System.Drawing.Point(152, 57)
        Me.txtDexB.Name = "txtDexB"
        Me.txtDexB.Size = New System.Drawing.Size(48, 22)
        Me.txtDexB.TabIndex = 18
        Me.txtDexB.Text = "0"
        '
        'txtStrB
        '
        Me.txtStrB.Location = New System.Drawing.Point(84, 57)
        Me.txtStrB.Name = "txtStrB"
        Me.txtStrB.Size = New System.Drawing.Size(48, 22)
        Me.txtStrB.TabIndex = 17
        Me.txtStrB.Text = "0"
        '
        'lblMin
        '
        Me.lblMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(9, 223)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(63, 17)
        Me.lblMin.TabIndex = 24
        Me.lblMin.Text = "Minimum"
        Me.ToolTip1.SetToolTip(Me.lblMin, "Min roll value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(must be less than max and equal or greater than zero)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Maximum"
        Me.ToolTip1.SetToolTip(Me.Label11, "max roll value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(must be greater than min and greater than zero)")
        '
        'txtMinRoll
        '
        Me.txtMinRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMinRoll.Location = New System.Drawing.Point(12, 243)
        Me.txtMinRoll.Name = "txtMinRoll"
        Me.txtMinRoll.Size = New System.Drawing.Size(54, 22)
        Me.txtMinRoll.TabIndex = 29
        Me.txtMinRoll.Text = "0"
        Me.ToolTip1.SetToolTip(Me.txtMinRoll, "Min roll value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(must be less than max and equal or greater than zero)")
        '
        'txtMaxRoll
        '
        Me.txtMaxRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaxRoll.Location = New System.Drawing.Point(78, 243)
        Me.txtMaxRoll.Name = "txtMaxRoll"
        Me.txtMaxRoll.Size = New System.Drawing.Size(54, 22)
        Me.txtMaxRoll.TabIndex = 30
        Me.txtMaxRoll.Text = "10"
        Me.ToolTip1.SetToolTip(Me.txtMaxRoll, "max roll value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(must be greater than min and greater than zero)")
        '
        'txtOutcome
        '
        Me.txtOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOutcome.Location = New System.Drawing.Point(363, 306)
        Me.txtOutcome.Name = "txtOutcome"
        Me.txtOutcome.ReadOnly = True
        Me.txtOutcome.Size = New System.Drawing.Size(102, 22)
        Me.txtOutcome.TabIndex = 28
        Me.txtOutcome.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtOutcome, "Outcome of Party A's action onto Party B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wording")
        '
        'lblOutcome
        '
        Me.lblOutcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOutcome.AutoSize = True
        Me.lblOutcome.Location = New System.Drawing.Point(374, 286)
        Me.lblOutcome.Name = "lblOutcome"
        Me.lblOutcome.Size = New System.Drawing.Size(65, 17)
        Me.lblOutcome.TabIndex = 29
        Me.lblOutcome.Text = "Outcome"
        Me.ToolTip1.SetToolTip(Me.lblOutcome, "Outcome of Party A's action onto Party B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wording" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Party A Roll"
        Me.ToolTip1.SetToolTip(Me.Label10, "Roll value for Party A")
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(179, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Party B Roll"
        Me.ToolTip1.SetToolTip(Me.Label12, "Roll Value for Party B")
        '
        'txtARoll
        '
        Me.txtARoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtARoll.Location = New System.Drawing.Point(93, 306)
        Me.txtARoll.Name = "txtARoll"
        Me.txtARoll.ReadOnly = True
        Me.txtARoll.Size = New System.Drawing.Size(79, 22)
        Me.txtARoll.TabIndex = 32
        Me.txtARoll.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtARoll, "Roll value for Party A")
        '
        'txtBRoll
        '
        Me.txtBRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBRoll.Location = New System.Drawing.Point(182, 306)
        Me.txtBRoll.Name = "txtBRoll"
        Me.txtBRoll.ReadOnly = True
        Me.txtBRoll.Size = New System.Drawing.Size(79, 22)
        Me.txtBRoll.TabIndex = 33
        Me.txtBRoll.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtBRoll, "Roll Value for Party B")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Formula"
        Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        '
        'txtFormula
        '
        Me.txtFormula.Location = New System.Drawing.Point(12, 144)
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.Size = New System.Drawing.Size(418, 22)
        Me.txtFormula.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtFormula, resources.GetString("txtFormula.ToolTip"))
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(12, 77)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(75, 34)
        Me.btnSwap.TabIndex = 24
        Me.btnSwap.Text = "Swap"
        Me.ToolTip1.SetToolTip(Me.btnSwap, "Swaps Party A's and Party B's stats")
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'txtCritHit
        '
        Me.txtCritHit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCritHit.Location = New System.Drawing.Point(148, 243)
        Me.txtCritHit.Name = "txtCritHit"
        Me.txtCritHit.Size = New System.Drawing.Size(54, 22)
        Me.txtCritHit.TabIndex = 46
        Me.txtCritHit.Text = "5"
        Me.ToolTip1.SetToolTip(Me.txtCritHit, "This value or higher for outcome indicates " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critical success")
        '
        'txtGlance
        '
        Me.txtGlance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGlance.Location = New System.Drawing.Point(221, 243)
        Me.txtGlance.Name = "txtGlance"
        Me.txtGlance.Size = New System.Drawing.Size(54, 22)
        Me.txtGlance.TabIndex = 47
        Me.txtGlance.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtGlance, "This value through to it's positive/negative " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "counterpart indicates a near succe" & _
        "ss/fail " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Depending on whether it's positive or negative)")
        '
        'txtCritFail
        '
        Me.txtCritFail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCritFail.Location = New System.Drawing.Point(300, 243)
        Me.txtCritFail.Name = "txtCritFail"
        Me.txtCritFail.Size = New System.Drawing.Size(54, 22)
        Me.txtCritFail.TabIndex = 48
        Me.txtCritFail.Text = "-5"
        Me.ToolTip1.SetToolTip(Me.txtCritFail, "This value or less for outcome indicates a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critical failure")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(146, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 17)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Critical Hit"
        Me.ToolTip1.SetToolTip(Me.Label16, "This value or higher for outcome indicates " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critical success" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(218, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 17)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Close"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label17, "This value through to it's positive/negative " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "counterpart indicates a near succe" & _
        "ss/fail " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Depending on whether it's positive or negative)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(282, 223)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 17)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Critical Fail"
        Me.ToolTip1.SetToolTip(Me.Label18, "This value or less for outcome indicates a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "critical failure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtOutcomeValue
        '
        Me.txtOutcomeValue.Location = New System.Drawing.Point(269, 306)
        Me.txtOutcomeValue.Name = "txtOutcomeValue"
        Me.txtOutcomeValue.ReadOnly = True
        Me.txtOutcomeValue.Size = New System.Drawing.Size(59, 22)
        Me.txtOutcomeValue.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.txtOutcomeValue, "Outcome of Party A's action onto Party B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(PartyA's roll/value - PartyB's roll/va" & _
        "lue)")
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(473, 306)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 32
        Me.btnAbout.Text = "About"
        Me.ToolTip1.SetToolTip(Me.btnAbout, "Open About window")
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnMagick
        '
        Me.btnMagick.Location = New System.Drawing.Point(269, 172)
        Me.btnMagick.Name = "btnMagick"
        Me.btnMagick.Size = New System.Drawing.Size(71, 27)
        Me.btnMagick.TabIndex = 26
        Me.btnMagick.Text = "Magical"
        Me.btnMagick.UseVisualStyleBackColor = True
        '
        'btnPhysical
        '
        Me.btnPhysical.Location = New System.Drawing.Point(346, 172)
        Me.btnPhysical.Name = "btnPhysical"
        Me.btnPhysical.Size = New System.Drawing.Size(84, 27)
        Me.btnPhysical.TabIndex = 27
        Me.btnPhysical.Text = "Physical"
        Me.btnPhysical.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(207, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Presets"
        '
        'btnClearFrm
        '
        Me.btnClearFrm.Location = New System.Drawing.Point(436, 176)
        Me.btnClearFrm.Name = "btnClearFrm"
        Me.btnClearFrm.Size = New System.Drawing.Size(109, 23)
        Me.btnClearFrm.TabIndex = 28
        Me.btnClearFrm.Text = "Clear Formula"
        Me.ToolTip1.SetToolTip(Me.btnClearFrm, "Clear the formula field")
        Me.btnClearFrm.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(473, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear Form"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear all fields and the listbox")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtFrmOut
        '
        Me.txtFrmOut.Location = New System.Drawing.Point(434, 144)
        Me.txtFrmOut.Name = "txtFrmOut"
        Me.txtFrmOut.ReadOnly = True
        Me.txtFrmOut.Size = New System.Drawing.Size(100, 22)
        Me.txtFrmOut.TabIndex = 40
        Me.txtFrmOut.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(433, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 17)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Formula Output"
        '
        'lbRolls
        '
        Me.lbRolls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbRolls.FormattingEnabled = True
        Me.lbRolls.HorizontalScrollbar = True
        Me.lbRolls.ItemHeight = 16
        Me.lbRolls.Location = New System.Drawing.Point(571, 12)
        Me.lbRolls.Name = "lbRolls"
        Me.lbRolls.Size = New System.Drawing.Size(456, 308)
        Me.lbRolls.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(263, 286)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 17)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Outcome Value"
        '
        'btnFrmHelp
        '
        Me.btnFrmHelp.Location = New System.Drawing.Point(12, 171)
        Me.btnFrmHelp.Name = "btnFrmHelp"
        Me.btnFrmHelp.Size = New System.Drawing.Size(120, 28)
        Me.btnFrmHelp.TabIndex = 51
        Me.btnFrmHelp.Text = "Formula Help"
        Me.ToolTip1.SetToolTip(Me.btnFrmHelp, "Open formula help window")
        Me.btnFrmHelp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 341)
        Me.Controls.Add(Me.btnFrmHelp)
        Me.Controls.Add(Me.txtOutcomeValue)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCritFail)
        Me.Controls.Add(Me.txtGlance)
        Me.Controls.Add(Me.txtCritHit)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbRolls)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtFrmOut)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClearFrm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnPhysical)
        Me.Controls.Add(Me.btnMagick)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.txtFormula)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBRoll)
        Me.Controls.Add(Me.txtARoll)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblOutcome)
        Me.Controls.Add(Me.txtOutcome)
        Me.Controls.Add(Me.txtMaxRoll)
        Me.Controls.Add(Me.txtMinRoll)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtSkBB)
        Me.Controls.Add(Me.txtPieB)
        Me.Controls.Add(Me.txtMndB)
        Me.Controls.Add(Me.txtIntB)
        Me.Controls.Add(Me.txtVitB)
        Me.Controls.Add(Me.txtDexB)
        Me.Controls.Add(Me.txtStrB)
        Me.Controls.Add(Me.txtSkBA)
        Me.Controls.Add(Me.txtPieA)
        Me.Controls.Add(Me.txtMndA)
        Me.Controls.Add(Me.txtIntA)
        Me.Controls.Add(Me.txtVitA)
        Me.Controls.Add(Me.txtDexA)
        Me.Controls.Add(Me.txtStrA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRoll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "RPG Formula Roller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStrA As System.Windows.Forms.TextBox
    Friend WithEvents txtDexA As System.Windows.Forms.TextBox
    Friend WithEvents txtVitA As System.Windows.Forms.TextBox
    Friend WithEvents txtIntA As System.Windows.Forms.TextBox
    Friend WithEvents txtMndA As System.Windows.Forms.TextBox
    Friend WithEvents txtPieA As System.Windows.Forms.TextBox
    Friend WithEvents txtSkBA As System.Windows.Forms.TextBox
    Friend WithEvents txtSkBB As System.Windows.Forms.TextBox
    Friend WithEvents txtPieB As System.Windows.Forms.TextBox
    Friend WithEvents txtMndB As System.Windows.Forms.TextBox
    Friend WithEvents txtIntB As System.Windows.Forms.TextBox
    Friend WithEvents txtVitB As System.Windows.Forms.TextBox
    Friend WithEvents txtDexB As System.Windows.Forms.TextBox
    Friend WithEvents txtStrB As System.Windows.Forms.TextBox
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMinRoll As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxRoll As System.Windows.Forms.TextBox
    Friend WithEvents txtOutcome As System.Windows.Forms.TextBox
    Friend WithEvents lblOutcome As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtARoll As System.Windows.Forms.TextBox
    Friend WithEvents txtBRoll As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFormula As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnMagick As System.Windows.Forms.Button
    Friend WithEvents btnPhysical As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnClearFrm As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSwap As System.Windows.Forms.Button
    Friend WithEvents txtFrmOut As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbRolls As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCritHit As System.Windows.Forms.TextBox
    Friend WithEvents txtGlance As System.Windows.Forms.TextBox
    Friend WithEvents txtCritFail As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtOutcomeValue As System.Windows.Forms.TextBox
    Friend WithEvents btnFrmHelp As System.Windows.Forms.Button

End Class

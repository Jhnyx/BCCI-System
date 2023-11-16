<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        employeeNameInput = New TextBox()
        pInput = New FlowLayoutPanel()
        Label2 = New Label()
        companyNameInput = New TextBox()
        Label1 = New Label()
        monthlySalaryInput = New NumericUpDown()
        clearBtn = New Button()
        generateBtn = New Button()
        pOutput = New FlowLayoutPanel()
        Label3 = New Label()
        employeeNameOutput = New TextBox()
        companyNameOutput = New TextBox()
        monthlySalaryOutput = New TextBox()
        incomeTaxOutput = New TextBox()
        pagIbigOutput = New TextBox()
        sssOutput = New TextBox()
        philhealthOutput = New TextBox()
        pInput.SuspendLayout()
        CType(monthlySalaryInput, ComponentModel.ISupportInitialize).BeginInit()
        pOutput.SuspendLayout()
        SuspendLayout()
        ' 
        ' employeeNameInput
        ' 
        employeeNameInput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        employeeNameInput.ForeColor = Color.DarkGray
        employeeNameInput.Location = New Point(50, 100)
        employeeNameInput.Margin = New Padding(0, 50, 0, 0)
        employeeNameInput.Name = "employeeNameInput"
        employeeNameInput.Size = New Size(300, 26)
        employeeNameInput.TabIndex = 0
        employeeNameInput.Text = "Name of Employee"
        employeeNameInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' pInput
        ' 
        pInput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pInput.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pInput.BackColor = Color.Black
        pInput.Controls.Add(Label2)
        pInput.Controls.Add(employeeNameInput)
        pInput.Controls.Add(companyNameInput)
        pInput.Controls.Add(Label1)
        pInput.Controls.Add(monthlySalaryInput)
        pInput.Controls.Add(clearBtn)
        pInput.Controls.Add(generateBtn)
        pInput.Location = New Point(200, 150)
        pInput.Name = "pInput"
        pInput.Padding = New Padding(50, 25, 50, 25)
        pInput.Size = New Size(400, 400)
        pInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(150, 25)
        Label2.Margin = New Padding(100, 0, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 4
        Label2.Text = "INPUT"
        ' 
        ' companyNameInput
        ' 
        companyNameInput.BorderStyle = BorderStyle.FixedSingle
        companyNameInput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        companyNameInput.ForeColor = Color.DarkGray
        companyNameInput.Location = New Point(50, 151)
        companyNameInput.Margin = New Padding(0, 25, 0, 0)
        companyNameInput.Name = "companyNameInput"
        companyNameInput.Size = New Size(300, 26)
        companyNameInput.TabIndex = 1
        companyNameInput.Text = "Name of Company"
        companyNameInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(50, 227)
        Label1.Margin = New Padding(0, 50, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 18)
        Label1.TabIndex = 5
        Label1.Text = "Monthly Salary"
        ' 
        ' monthlySalaryInput
        ' 
        monthlySalaryInput.Location = New Point(50, 260)
        monthlySalaryInput.Margin = New Padding(0, 15, 0, 0)
        monthlySalaryInput.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        monthlySalaryInput.Name = "monthlySalaryInput"
        monthlySalaryInput.Size = New Size(300, 23)
        monthlySalaryInput.TabIndex = 3
        monthlySalaryInput.TextAlign = HorizontalAlignment.Center
        monthlySalaryInput.ThousandsSeparator = True
        ' 
        ' clearBtn
        ' 
        clearBtn.AutoSize = True
        clearBtn.BackColor = Color.IndianRed
        clearBtn.BackgroundImageLayout = ImageLayout.None
        clearBtn.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        clearBtn.ForeColor = Color.White
        clearBtn.Location = New Point(50, 333)
        clearBtn.Margin = New Padding(0, 50, 0, 0)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(137, 35)
        clearBtn.TabIndex = 6
        clearBtn.Text = "CLEAR"
        clearBtn.UseVisualStyleBackColor = False
        ' 
        ' generateBtn
        ' 
        generateBtn.AutoSize = True
        generateBtn.BackColor = Color.IndianRed
        generateBtn.BackgroundImageLayout = ImageLayout.None
        generateBtn.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        generateBtn.ForeColor = Color.White
        generateBtn.Location = New Point(197, 333)
        generateBtn.Margin = New Padding(10, 50, 0, 0)
        generateBtn.Name = "generateBtn"
        generateBtn.Size = New Size(153, 35)
        generateBtn.TabIndex = 7
        generateBtn.Text = "GENERATE"
        generateBtn.UseVisualStyleBackColor = False
        ' 
        ' pOutput
        ' 
        pOutput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pOutput.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pOutput.BackColor = Color.Black
        pOutput.Controls.Add(Label3)
        pOutput.Controls.Add(employeeNameOutput)
        pOutput.Controls.Add(companyNameOutput)
        pOutput.Controls.Add(monthlySalaryOutput)
        pOutput.Controls.Add(incomeTaxOutput)
        pOutput.Controls.Add(pagIbigOutput)
        pOutput.Controls.Add(sssOutput)
        pOutput.Controls.Add(philhealthOutput)
        pOutput.Location = New Point(700, 150)
        pOutput.Name = "pOutput"
        pOutput.Padding = New Padding(50, 25, 50, 25)
        pOutput.Size = New Size(400, 400)
        pOutput.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(150, 25)
        Label3.Margin = New Padding(100, 0, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 25)
        Label3.TabIndex = 4
        Label3.Text = "OUTPUT"
        ' 
        ' employeeNameOutput
        ' 
        employeeNameOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        employeeNameOutput.ForeColor = Color.Black
        employeeNameOutput.Location = New Point(50, 65)
        employeeNameOutput.Margin = New Padding(0, 15, 0, 0)
        employeeNameOutput.Name = "employeeNameOutput"
        employeeNameOutput.ReadOnly = True
        employeeNameOutput.Size = New Size(300, 26)
        employeeNameOutput.TabIndex = 0
        employeeNameOutput.Text = "Name of Employee"
        employeeNameOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' companyNameOutput
        ' 
        companyNameOutput.BorderStyle = BorderStyle.FixedSingle
        companyNameOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        companyNameOutput.ForeColor = Color.Black
        companyNameOutput.Location = New Point(50, 111)
        companyNameOutput.Margin = New Padding(0, 20, 0, 0)
        companyNameOutput.Name = "companyNameOutput"
        companyNameOutput.ReadOnly = True
        companyNameOutput.Size = New Size(300, 26)
        companyNameOutput.TabIndex = 1
        companyNameOutput.Text = "Name of Company"
        companyNameOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' monthlySalaryOutput
        ' 
        monthlySalaryOutput.BorderStyle = BorderStyle.FixedSingle
        monthlySalaryOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        monthlySalaryOutput.ForeColor = Color.Black
        monthlySalaryOutput.Location = New Point(50, 157)
        monthlySalaryOutput.Margin = New Padding(0, 20, 0, 0)
        monthlySalaryOutput.Name = "monthlySalaryOutput"
        monthlySalaryOutput.ReadOnly = True
        monthlySalaryOutput.Size = New Size(300, 26)
        monthlySalaryOutput.TabIndex = 5
        monthlySalaryOutput.Text = "Monthly Salary"
        monthlySalaryOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' incomeTaxOutput
        ' 
        incomeTaxOutput.BorderStyle = BorderStyle.FixedSingle
        incomeTaxOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        incomeTaxOutput.ForeColor = Color.Black
        incomeTaxOutput.Location = New Point(50, 203)
        incomeTaxOutput.Margin = New Padding(0, 20, 0, 0)
        incomeTaxOutput.Name = "incomeTaxOutput"
        incomeTaxOutput.ReadOnly = True
        incomeTaxOutput.Size = New Size(300, 26)
        incomeTaxOutput.TabIndex = 6
        incomeTaxOutput.Text = "Income Tax"
        incomeTaxOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' pagIbigOutput
        ' 
        pagIbigOutput.BorderStyle = BorderStyle.FixedSingle
        pagIbigOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        pagIbigOutput.ForeColor = Color.Black
        pagIbigOutput.Location = New Point(50, 249)
        pagIbigOutput.Margin = New Padding(0, 20, 0, 0)
        pagIbigOutput.Name = "pagIbigOutput"
        pagIbigOutput.ReadOnly = True
        pagIbigOutput.Size = New Size(300, 26)
        pagIbigOutput.TabIndex = 7
        pagIbigOutput.Text = "Pag-Ibig"
        pagIbigOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' sssOutput
        ' 
        sssOutput.BorderStyle = BorderStyle.FixedSingle
        sssOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        sssOutput.ForeColor = Color.Black
        sssOutput.Location = New Point(50, 295)
        sssOutput.Margin = New Padding(0, 20, 0, 0)
        sssOutput.Name = "sssOutput"
        sssOutput.ReadOnly = True
        sssOutput.Size = New Size(300, 26)
        sssOutput.TabIndex = 8
        sssOutput.Text = "SSS"
        sssOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' philhealthOutput
        ' 
        philhealthOutput.BorderStyle = BorderStyle.FixedSingle
        philhealthOutput.Font = New Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        philhealthOutput.ForeColor = Color.Black
        philhealthOutput.Location = New Point(50, 341)
        philhealthOutput.Margin = New Padding(0, 20, 0, 0)
        philhealthOutput.Name = "philhealthOutput"
        philhealthOutput.ReadOnly = True
        philhealthOutput.Size = New Size(300, 26)
        philhealthOutput.TabIndex = 9
        philhealthOutput.Text = "Philhealth"
        philhealthOutput.TextAlign = HorizontalAlignment.Center
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1264, 681)
        Controls.Add(pInput)
        Controls.Add(pOutput)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BCCI System"
        pInput.ResumeLayout(False)
        pInput.PerformLayout()
        CType(monthlySalaryInput, ComponentModel.ISupportInitialize).EndInit()
        pOutput.ResumeLayout(False)
        pOutput.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents employeeNameInput As TextBox
    Friend WithEvents pInput As FlowLayoutPanel
    Friend WithEvents companyNameInput As TextBox
    Friend WithEvents monthlySalaryInput As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clearBtn As Button
    Friend WithEvents pOutput As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents employeeNameOutput As TextBox
    Friend WithEvents companyNameOutput As TextBox
    Friend WithEvents monthlySalaryOutput As TextBox
    Friend WithEvents incomeTaxOutput As TextBox
    Friend WithEvents pagIbigOutput As TextBox
    Friend WithEvents sssOutput As TextBox
    Friend WithEvents philhealthOutput As TextBox
    Friend WithEvents generateBtn As Button
End Class

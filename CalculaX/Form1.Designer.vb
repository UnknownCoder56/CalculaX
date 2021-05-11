<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonPercentage = New System.Windows.Forms.Button()
        Me.ButtonModulo = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonIntDiv = New System.Windows.Forms.Button()
        Me.ButtonExponent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CalculaX"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonAdd.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(6, 19)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(141, 46)
        Me.ButtonAdd.TabIndex = 29
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonSubtract.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubtract.Location = New System.Drawing.Point(164, 19)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(141, 46)
        Me.ButtonSubtract.TabIndex = 30
        Me.ButtonSubtract.Text = "Subtract"
        Me.ButtonSubtract.UseVisualStyleBackColor = False
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonMultiply.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.Location = New System.Drawing.Point(6, 71)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(141, 46)
        Me.ButtonMultiply.TabIndex = 31
        Me.ButtonMultiply.Text = "Multiply"
        Me.ButtonMultiply.UseVisualStyleBackColor = False
        '
        'ButtonDivide
        '
        Me.ButtonDivide.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonDivide.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(164, 71)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(141, 46)
        Me.ButtonDivide.TabIndex = 32
        Me.ButtonDivide.Text = "Divide"
        Me.ButtonDivide.UseVisualStyleBackColor = False
        '
        'ButtonPercentage
        '
        Me.ButtonPercentage.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonPercentage.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPercentage.Location = New System.Drawing.Point(6, 123)
        Me.ButtonPercentage.Name = "ButtonPercentage"
        Me.ButtonPercentage.Size = New System.Drawing.Size(141, 46)
        Me.ButtonPercentage.TabIndex = 33
        Me.ButtonPercentage.Text = "Percentage"
        Me.ButtonPercentage.UseVisualStyleBackColor = False
        '
        'ButtonModulo
        '
        Me.ButtonModulo.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonModulo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModulo.Location = New System.Drawing.Point(164, 123)
        Me.ButtonModulo.Name = "ButtonModulo"
        Me.ButtonModulo.Size = New System.Drawing.Size(141, 46)
        Me.ButtonModulo.TabIndex = 34
        Me.ButtonModulo.Text = "Modulo"
        Me.ButtonModulo.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonClear.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(6, 227)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(141, 46)
        Me.ButtonClear.TabIndex = 35
        Me.ButtonClear.Text = "Clear All"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonExit.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(164, 227)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(141, 46)
        Me.ButtonExit.TabIndex = 36
        Me.ButtonExit.Text = "Exit CalculaX"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'ButtonIntDiv
        '
        Me.ButtonIntDiv.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonIntDiv.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIntDiv.Location = New System.Drawing.Point(6, 175)
        Me.ButtonIntDiv.Name = "ButtonIntDiv"
        Me.ButtonIntDiv.Size = New System.Drawing.Size(141, 46)
        Me.ButtonIntDiv.TabIndex = 38
        Me.ButtonIntDiv.Text = "Integer Division"
        Me.ButtonIntDiv.UseVisualStyleBackColor = False
        '
        'ButtonExponent
        '
        Me.ButtonExponent.BackColor = System.Drawing.SystemColors.Desktop
        Me.ButtonExponent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExponent.Location = New System.Drawing.Point(164, 175)
        Me.ButtonExponent.Name = "ButtonExponent"
        Me.ButtonExponent.Size = New System.Drawing.Size(141, 46)
        Me.ButtonExponent.TabIndex = 39
        Me.ButtonExponent.Text = "Exponent"
        Me.ButtonExponent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Number 1 -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Number 2 -"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(85, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 23)
        Me.TextBox1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.Location = New System.Drawing.Point(85, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 23)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox3.Location = New System.Drawing.Point(85, 78)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(220, 38)
        Me.TextBox3.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Answer   -"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 122)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonExponent)
        Me.GroupBox2.Controls.Add(Me.ButtonIntDiv)
        Me.GroupBox2.Controls.Add(Me.ButtonExit)
        Me.GroupBox2.Controls.Add(Me.ButtonModulo)
        Me.GroupBox2.Controls.Add(Me.ButtonClear)
        Me.GroupBox2.Controls.Add(Me.ButtonPercentage)
        Me.GroupBox2.Controls.Add(Me.ButtonDivide)
        Me.GroupBox2.Controls.Add(Me.ButtonMultiply)
        Me.GroupBox2.Controls.Add(Me.ButtonSubtract)
        Me.GroupBox2.Controls.Add(Me.ButtonAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 280)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Functions"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(331, 466)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 75
        Me.LineShape1.Y1 = 30
        Me.LineShape1.Y2 = 30
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(331, 466)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalculaX"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSubtract As System.Windows.Forms.Button
    Friend WithEvents ButtonMultiply As System.Windows.Forms.Button
    Friend WithEvents ButtonDivide As System.Windows.Forms.Button
    Friend WithEvents ButtonPercentage As System.Windows.Forms.Button
    Friend WithEvents ButtonModulo As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonIntDiv As System.Windows.Forms.Button
    Friend WithEvents ButtonExponent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class

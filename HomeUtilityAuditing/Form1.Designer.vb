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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbappliance = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpower = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstAppliance = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoGallon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGallonCost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(1, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost/KwH (Dollars/Cents):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(155, 36)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(59, 20)
        Me.txtcost.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Home Appliance:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbappliance
        '
        Me.cbappliance.FormattingEnabled = True
        Me.cbappliance.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Laundry Washer"})
        Me.cbappliance.Location = New System.Drawing.Point(155, 9)
        Me.cbappliance.Name = "cbappliance"
        Me.cbappliance.Size = New System.Drawing.Size(121, 21)
        Me.cbappliance.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(1, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Power Needed (Kw):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtpower
        '
        Me.txtpower.Location = New System.Drawing.Point(155, 62)
        Me.txtpower.Name = "txtpower"
        Me.txtpower.Size = New System.Drawing.Size(59, 20)
        Me.txtpower.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No of Hours/Day:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(155, 88)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(59, 20)
        Me.txthours.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add to List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstAppliance
        '
        Me.lstAppliance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstAppliance.Location = New System.Drawing.Point(12, 202)
        Me.lstAppliance.Name = "lstAppliance"
        Me.lstAppliance.Size = New System.Drawing.Size(255, 124)
        Me.lstAppliance.TabIndex = 12
        Me.lstAppliance.UseCompatibleStateImageBehavior = False
        Me.lstAppliance.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Appliance Name"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No of Hrs/Day"
        Me.ColumnHeader2.Width = 69
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cost"
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblCost.Location = New System.Drawing.Point(164, 331)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(79, 20)
        Me.lblCost.TabIndex = 14
        Me.lblCost.Text = "0.00"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Cost for Operating:"
        '
        'txtNoGallon
        '
        Me.txtNoGallon.Location = New System.Drawing.Point(155, 140)
        Me.txtNoGallon.Name = "txtNoGallon"
        Me.txtNoGallon.Size = New System.Drawing.Size(59, 20)
        Me.txtNoGallon.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "No of Gallon per Hour:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGallonCost
        '
        Me.txtGallonCost.Location = New System.Drawing.Point(155, 114)
        Me.txtGallonCost.Name = "txtGallonCost"
        Me.txtGallonCost.Size = New System.Drawing.Size(59, 20)
        Me.txtGallonCost.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cost per Gallon:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 357)
        Me.Controls.Add(Me.txtNoGallon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGallonCost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstAppliance)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpower)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbappliance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Enhanced Home Utility Auditing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbappliance As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpower As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txthours As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lstAppliance As System.Windows.Forms.ListView
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNoGallon As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGallonCost As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class

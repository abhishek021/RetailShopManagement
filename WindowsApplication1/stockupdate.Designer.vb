<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockupdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockupdate))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.ProductBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lb = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IdBox = New System.Windows.Forms.TextBox()
        Me.BrandBox = New System.Windows.Forms.TextBox()
        Me.QBox = New System.Windows.Forms.TextBox()
        Me.RateBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LimeGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(952, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Update Stock Details"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.SystemColors.Highlight
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(108, 132)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(210, 41)
        Me.ID.TabIndex = 8
        Me.ID.Text = "Product Id"
        Me.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'la
        '
        Me.la.BackColor = System.Drawing.SystemColors.Highlight
        Me.la.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.Location = New System.Drawing.Point(108, 57)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(210, 41)
        Me.la.TabIndex = 7
        Me.la.Text = "Product Name"
        Me.la.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductBox
        '
        Me.ProductBox.Location = New System.Drawing.Point(369, 57)
        Me.ProductBox.Multiline = True
        Me.ProductBox.Name = "ProductBox"
        Me.ProductBox.Size = New System.Drawing.Size(343, 41)
        Me.ProductBox.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(762, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 48)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(762, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 49)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(762, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 49)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lb
        '
        Me.lb.BackColor = System.Drawing.SystemColors.Highlight
        Me.lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(108, 200)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(210, 41)
        Me.lb.TabIndex = 52
        Me.lb.Text = "Brand"
        Me.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Quantity
        '
        Me.Quantity.BackColor = System.Drawing.SystemColors.Highlight
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(108, 266)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(210, 41)
        Me.Quantity.TabIndex = 53
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 41)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Rate"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdBox
        '
        Me.IdBox.Location = New System.Drawing.Point(369, 132)
        Me.IdBox.Multiline = True
        Me.IdBox.Name = "IdBox"
        Me.IdBox.Size = New System.Drawing.Size(343, 41)
        Me.IdBox.TabIndex = 55
        '
        'BrandBox
        '
        Me.BrandBox.Location = New System.Drawing.Point(369, 200)
        Me.BrandBox.Multiline = True
        Me.BrandBox.Name = "BrandBox"
        Me.BrandBox.Size = New System.Drawing.Size(343, 41)
        Me.BrandBox.TabIndex = 56
        '
        'QBox
        '
        Me.QBox.Location = New System.Drawing.Point(369, 266)
        Me.QBox.Multiline = True
        Me.QBox.Name = "QBox"
        Me.QBox.Size = New System.Drawing.Size(343, 41)
        Me.QBox.TabIndex = 57
        '
        'RateBox
        '
        Me.RateBox.Location = New System.Drawing.Point(369, 339)
        Me.RateBox.Multiline = True
        Me.RateBox.Name = "RateBox"
        Me.RateBox.Size = New System.Drawing.Size(343, 41)
        Me.RateBox.TabIndex = 58
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(762, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 49)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(762, 132)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 48)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'stockupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RateBox)
        Me.Controls.Add(Me.QBox)
        Me.Controls.Add(Me.BrandBox)
        Me.Controls.Add(Me.IdBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProductBox)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.Label6)
        Me.Name = "stockupdate"
        Me.Text = "stockupdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ID As Label
    Friend WithEvents la As Label
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lb As Label
    Friend WithEvents Quantity As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IdBox As TextBox
    Friend WithEvents BrandBox As TextBox
    Friend WithEvents QBox As TextBox
    Friend WithEvents RateBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class

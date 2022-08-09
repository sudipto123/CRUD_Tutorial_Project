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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtDesign = New System.Windows.Forms.TextBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.rbAllowedWt = New System.Windows.Forms.RadioButton()
        Me.rbNotAllowedWt = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.dtpItemDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Warranty Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Design"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Item Name"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(193, 40)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(220, 22)
        Me.txtProductId.TabIndex = 6
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(193, 70)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(220, 22)
        Me.txtItemName.TabIndex = 7
        '
        'txtDesign
        '
        Me.txtDesign.Location = New System.Drawing.Point(193, 101)
        Me.txtDesign.Name = "txtDesign"
        Me.txtDesign.Size = New System.Drawing.Size(220, 22)
        Me.txtDesign.TabIndex = 8
        '
        'cmbColor
        '
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"Black", "White", "Grey", "Blue"})
        Me.cmbColor.Location = New System.Drawing.Point(193, 130)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(220, 24)
        Me.cmbColor.TabIndex = 9
        '
        'rbAllowedWt
        '
        Me.rbAllowedWt.AutoSize = True
        Me.rbAllowedWt.Location = New System.Drawing.Point(193, 193)
        Me.rbAllowedWt.Name = "rbAllowedWt"
        Me.rbAllowedWt.Size = New System.Drawing.Size(76, 20)
        Me.rbAllowedWt.TabIndex = 11
        Me.rbAllowedWt.TabStop = True
        Me.rbAllowedWt.Text = "Allowed"
        Me.rbAllowedWt.UseVisualStyleBackColor = True
        '
        'rbNotAllowedWt
        '
        Me.rbNotAllowedWt.AutoSize = True
        Me.rbNotAllowedWt.Location = New System.Drawing.Point(302, 193)
        Me.rbNotAllowedWt.Name = "rbNotAllowedWt"
        Me.rbNotAllowedWt.Size = New System.Drawing.Size(100, 20)
        Me.rbNotAllowedWt.TabIndex = 12
        Me.rbNotAllowedWt.TabStop = True
        Me.rbNotAllowedWt.Text = "Not Allowed"
        Me.rbNotAllowedWt.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(193, 233)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 44)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(52, 312)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(863, 158)
        Me.dgvData.TabIndex = 14
        '
        'dtpItemDate
        '
        Me.dtpItemDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpItemDate.Location = New System.Drawing.Point(193, 162)
        Me.dtpItemDate.Name = "dtpItemDate"
        Me.dtpItemDate.Size = New System.Drawing.Size(220, 22)
        Me.dtpItemDate.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(314, 233)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 44)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(431, 233)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 44)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 556)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpItemDate)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rbNotAllowedWt)
        Me.Controls.Add(Me.rbAllowedWt)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.txtDesign)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtDesign As TextBox
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents rbAllowedWt As RadioButton
    Friend WithEvents rbNotAllowedWt As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents dtpItemDate As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class

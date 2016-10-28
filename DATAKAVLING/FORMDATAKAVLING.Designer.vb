<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMDATAKAVLING
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadStatusStrip2 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.dgRekapKavling = New System.Windows.Forms.DataGridView()
        Me.dgListKavling = New System.Windows.Forms.DataGridView()
        Me.btnRegister = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.FieldPilihan = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FieldID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FieldKavling = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRekapKavling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListKavling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgRekapKavling, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.dgListKavling, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRegister, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton3, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton4, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadCheckBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(735, 357)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'RadStatusStrip2
        '
        Me.RadStatusStrip2.Location = New System.Drawing.Point(0, 359)
        Me.RadStatusStrip2.Name = "RadStatusStrip2"
        Me.RadStatusStrip2.Size = New System.Drawing.Size(735, 24)
        Me.RadStatusStrip2.TabIndex = 1
        Me.RadStatusStrip2.Text = "RadStatusStrip2"
        Me.RadStatusStrip2.ThemeName = "Desert"
        '
        'dgRekapKavling
        '
        Me.dgRekapKavling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgRekapKavling, 4)
        Me.dgRekapKavling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRekapKavling.Location = New System.Drawing.Point(3, 245)
        Me.dgRekapKavling.Name = "dgRekapKavling"
        Me.dgRekapKavling.Size = New System.Drawing.Size(582, 79)
        Me.dgRekapKavling.TabIndex = 0
        '
        'dgListKavling
        '
        Me.dgListKavling.AllowUserToAddRows = False
        Me.dgListKavling.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListKavling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListKavling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListKavling.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FieldPilihan, Me.FieldID, Me.FieldKavling})
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgListKavling, 5)
        Me.dgListKavling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListKavling.Location = New System.Drawing.Point(3, 32)
        Me.dgListKavling.Name = "dgListKavling"
        Me.dgListKavling.ReadOnly = True
        Me.dgListKavling.RowHeadersVisible = False
        Me.TableLayoutPanel1.SetRowSpan(Me.dgListKavling, 2)
        Me.dgListKavling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListKavling.Size = New System.Drawing.Size(729, 207)
        Me.dgListKavling.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRegister.Location = New System.Drawing.Point(3, 330)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(141, 24)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register Baru"
        '
        'RadButton3
        '
        Me.RadButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton3.Location = New System.Drawing.Point(150, 330)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(141, 24)
        Me.RadButton3.TabIndex = 1
        Me.RadButton3.Text = "Ubah"
        '
        'RadButton4
        '
        Me.RadButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton4.Location = New System.Drawing.Point(591, 330)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(141, 24)
        Me.RadButton4.TabIndex = 1
        Me.RadButton4.Text = "Keluar"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(297, 330)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "Hapus"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(444, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(141, 23)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "[F3] CARI DATA"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(591, 3)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(141, 23)
        Me.RadButton5.TabIndex = 1
        Me.RadButton5.Text = "[F5] REFRESH"
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCheckBox1.Location = New System.Drawing.Point(3, 7)
        Me.RadCheckBox1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(80, 18)
        Me.RadCheckBox1.TabIndex = 2
        Me.RadCheckBox1.Text = "Pilihan Data"
        '
        'FieldPilihan
        '
        Me.FieldPilihan.HeaderText = "Pilihan"
        Me.FieldPilihan.Name = "FieldPilihan"
        Me.FieldPilihan.ReadOnly = True
        Me.FieldPilihan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FieldPilihan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FieldID
        '
        Me.FieldID.HeaderText = "NOMOR REKAM"
        Me.FieldID.Name = "FieldID"
        Me.FieldID.ReadOnly = True
        '
        'FieldKavling
        '
        Me.FieldKavling.HeaderText = "Nomor Kavling"
        Me.FieldKavling.Name = "FieldKavling"
        Me.FieldKavling.ReadOnly = True
        '
        'FORMDATAKAVLING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 383)
        Me.Controls.Add(Me.RadStatusStrip2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FORMDATAKAVLING"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = "FORM DAFTAR KAVLING"
        Me.ThemeName = "Desert"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRekapKavling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListKavling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RadStatusStrip2 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents dgRekapKavling As DataGridView
    Friend WithEvents dgListKavling As DataGridView
    Friend WithEvents btnRegister As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents FieldPilihan As DataGridViewCheckBoxColumn
    Friend WithEvents FieldID As DataGridViewTextBoxColumn
    Friend WithEvents FieldKavling As DataGridViewTextBoxColumn
End Class

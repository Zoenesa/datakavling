<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMINISIALSQLDB
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
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButtonOK = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButtonCANCEL = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButtonOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadButtonCANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(95, 9)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(214, 20)
        Me.RadTextBox1.TabIndex = 5
        Me.RadTextBox1.Text = "TRIRAKSA VILLAGE"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(6, 10)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(60, 18)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "DATABASE"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(6, 45)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "SERVER"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(95, 44)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(214, 20)
        Me.RadTextBox2.TabIndex = 5
        Me.RadTextBox2.Text = "localhost"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(6, 80)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "USERDB"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Location = New System.Drawing.Point(95, 79)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Size = New System.Drawing.Size(214, 20)
        Me.RadTextBox3.TabIndex = 5
        Me.RadTextBox3.Text = "SUPERVISOR"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(6, 115)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(46, 18)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "PASSDB"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.Location = New System.Drawing.Point(95, 114)
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.RadTextBox4.Size = New System.Drawing.Size(214, 20)
        Me.RadTextBox4.TabIndex = 5
        Me.RadTextBox4.Text = "di5t0rti0n"
        Me.RadTextBox4.UseSystemPasswordChar = True
        '
        'RadButtonOK
        '
        Me.RadButtonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RadButtonOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButtonOK.Location = New System.Drawing.Point(3, 3)
        Me.RadButtonOK.Name = "RadButtonOK"
        Me.RadButtonOK.Size = New System.Drawing.Size(153, 24)
        Me.RadButtonOK.TabIndex = 7
        Me.RadButtonOK.Text = "OK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadButtonOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButtonCANCEL, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 143)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 30)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'RadButtonCANCEL
        '
        Me.RadButtonCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RadButtonCANCEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButtonCANCEL.Location = New System.Drawing.Point(162, 3)
        Me.RadButtonCANCEL.Name = "RadButtonCANCEL"
        Me.RadButtonCANCEL.Size = New System.Drawing.Size(154, 24)
        Me.RadButtonCANCEL.TabIndex = 7
        Me.RadButtonCANCEL.Text = "BATAL"
        '
        'FORMINISIALSQLDB
        '
        Me.AcceptButton = Me.RadButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.CancelButton = Me.RadButtonCANCEL
        Me.ClientSize = New System.Drawing.Size(319, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadTextBox4)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FORMINISIALSQLDB"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INISIALISASI KONEKSI DATABASE MYSQL"
        Me.ThemeName = "Desert"
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButtonOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RadButtonCANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButtonOK As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RadButtonCANCEL As Telerik.WinControls.UI.RadButton
End Class

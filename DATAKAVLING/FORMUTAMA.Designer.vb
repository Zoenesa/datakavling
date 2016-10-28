<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORMUTAMA
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORMUTAMA))
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemDatabase = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemMYSQLDB = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemACDB = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.RadMenuItemKeluar = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemDATA = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemKavling = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemRegKavling = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemSetting = New Telerik.WinControls.UI.RadMenuItem()
        Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 400)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.RadStatusStrip1.Size = New System.Drawing.Size(919, 24)
        Me.RadStatusStrip1.TabIndex = 0
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Desert"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "STATUS"
        Me.RadLabelElement1.TextWrap = True
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItemDATA, Me.RadMenuItemSetting})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(919, 24)
        Me.RadMenu1.TabIndex = 1
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Desert"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemDatabase, Me.RadMenuSeparatorItem1, Me.RadMenuItemKeluar})
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.ShowArrow = False
        Me.RadMenuItem1.Text = "MENU"
        '
        'RadMenuItemDatabase
        '
        Me.RadMenuItemDatabase.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemMYSQLDB, Me.RadMenuItemACDB})
        Me.RadMenuItemDatabase.Name = "RadMenuItemDatabase"
        Me.RadMenuItemDatabase.Text = "DATABASE"
        '
        'RadMenuItemMYSQLDB
        '
        Me.RadMenuItemMYSQLDB.Name = "RadMenuItemMYSQLDB"
        Me.RadMenuItemMYSQLDB.Text = "MYSQL Database"
        '
        'RadMenuItemACDB
        '
        Me.RadMenuItemACDB.Name = "RadMenuItemACDB"
        Me.RadMenuItemACDB.Text = "ACCESS Database"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadMenuItemKeluar
        '
        Me.RadMenuItemKeluar.Name = "RadMenuItemKeluar"
        Me.RadMenuItemKeluar.Text = "KELUAR APLIKASI"
        '
        'RadMenuItemDATA
        '
        Me.RadMenuItemDATA.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemKavling, Me.RadMenuItemRegKavling})
        Me.RadMenuItemDATA.Name = "RadMenuItemDATA"
        Me.RadMenuItemDATA.ShowArrow = False
        Me.RadMenuItemDATA.Text = "DATA"
        '
        'RadMenuItemKavling
        '
        Me.RadMenuItemKavling.Name = "RadMenuItemKavling"
        Me.RadMenuItemKavling.Text = "KAVLING"
        '
        'RadMenuItemRegKavling
        '
        Me.RadMenuItemRegKavling.Name = "RadMenuItemRegKavling"
        Me.RadMenuItemRegKavling.Text = "REGISTER KAVLING BARU"
        '
        'RadMenuItemSetting
        '
        Me.RadMenuItemSetting.Name = "RadMenuItemSetting"
        Me.RadMenuItemSetting.Text = "SETTING"
        '
        'FORMUTAMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 424)
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FORMUTAMA"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APLIKASI DATA KAVLING"
        Me.ThemeName = "Desert"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemDatabase As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemDATA As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemSetting As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenuItemKeluar As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemKavling As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemRegKavling As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemMYSQLDB As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemACDB As Telerik.WinControls.UI.RadMenuItem
End Class

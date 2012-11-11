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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Test Me", "Path"}, 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCombine = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnAddFiles = New System.Windows.Forms.Button()
        Me.chFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chRotation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsHelp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsListView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DegreesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockwiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterclockwiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DegreesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHelp.SuspendLayout()
        Me.cmsListView.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = True
        Me.btnHelp.Image = Global.PDFCombiner.My.Resources.Resources.help_2
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(144, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(85, 48)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "&Help"
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lvFiles
        '
        Me.lvFiles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFilename, Me.chLocation, Me.chRotation, Me.chFileSize, Me.chStatus})
        Me.lvFiles.ContextMenuStrip = Me.cmsListView
        Me.lvFiles.FullRowSelect = True
        Me.lvFiles.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvFiles.Location = New System.Drawing.Point(12, 85)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(743, 290)
        Me.lvFiles.SmallImageList = Me.ImageList1
        Me.lvFiles.TabIndex = 3
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        Me.lvFiles.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Drag and Drop PDF files or click the Add Button"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = True
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = Global.PDFCombiner.My.Resources.Resources.cross
        Me.btnExit.Location = New System.Drawing.Point(673, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 48)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCombine
        '
        Me.btnCombine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCombine.AutoSize = True
        Me.btnCombine.Image = Global.PDFCombiner.My.Resources.Resources.ok
        Me.btnCombine.Location = New System.Drawing.Point(572, 389)
        Me.btnCombine.Name = "btnCombine"
        Me.btnCombine.Size = New System.Drawing.Size(95, 48)
        Me.btnCombine.TabIndex = 5
        Me.btnCombine.Text = "&Combine"
        Me.btnCombine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCombine.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Image = Global.PDFCombiner.My.Resources.Resources.minus
        Me.btnRemove.Location = New System.Drawing.Point(227, 389)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(89, 48)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDown.AutoSize = True
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(114, 389)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(111, 48)
        Me.btnDown.TabIndex = 5
        Me.btnDown.Text = "Move &Down"
        Me.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUp.AutoSize = True
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUp.Location = New System.Drawing.Point(12, 389)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(96, 48)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "Move &Up"
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Image = Global.PDFCombiner.My.Resources.Resources.plus
        Me.btnAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddFiles.Location = New System.Drawing.Point(12, 12)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(126, 48)
        Me.btnAddFiles.TabIndex = 0
        Me.btnAddFiles.Text = "&Add Files"
        Me.btnAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddFiles.UseVisualStyleBackColor = True
        '
        'chFilename
        '
        Me.chFilename.Text = "Filename"
        Me.chFilename.Width = 125
        '
        'chLocation
        '
        Me.chLocation.Text = "Location"
        Me.chLocation.Width = 150
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        '
        'chStatus
        '
        Me.chStatus.Text = "Status"
        Me.chStatus.Width = 200
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Apps-Adobe-Reader.ico")
        '
        'chRotation
        '
        Me.chRotation.Text = "Rotation"
        '
        'cmsHelp
        '
        Me.cmsHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.cmsHelp.Name = "cmsHelp"
        Me.cmsHelp.Size = New System.Drawing.Size(115, 48)
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'cmsListView
        '
        Me.cmsListView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RotationToolStripMenuItem})
        Me.cmsListView.Name = "cmsListView"
        Me.cmsListView.Size = New System.Drawing.Size(120, 26)
        '
        'RotationToolStripMenuItem
        '
        Me.RotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DegreesToolStripMenuItem, Me.ClockwiseToolStripMenuItem, Me.CounterclockwiseToolStripMenuItem, Me.DegreesToolStripMenuItem1})
        Me.RotationToolStripMenuItem.Name = "RotationToolStripMenuItem"
        Me.RotationToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RotationToolStripMenuItem.Text = "Rotation"
        '
        'DegreesToolStripMenuItem
        '
        Me.DegreesToolStripMenuItem.Name = "DegreesToolStripMenuItem"
        Me.DegreesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DegreesToolStripMenuItem.Text = "0 Degrees"
        '
        'ClockwiseToolStripMenuItem
        '
        Me.ClockwiseToolStripMenuItem.Name = "ClockwiseToolStripMenuItem"
        Me.ClockwiseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ClockwiseToolStripMenuItem.Text = "90 Clockwise"
        '
        'CounterclockwiseToolStripMenuItem
        '
        Me.CounterclockwiseToolStripMenuItem.Name = "CounterclockwiseToolStripMenuItem"
        Me.CounterclockwiseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CounterclockwiseToolStripMenuItem.Text = "90 Counter-clockwise"
        '
        'DegreesToolStripMenuItem1
        '
        Me.DegreesToolStripMenuItem1.Name = "DegreesToolStripMenuItem1"
        Me.DegreesToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.DegreesToolStripMenuItem1.Text = "180 Degrees"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCombine
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(767, 452)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCombine)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvFiles)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Combine PDF"
        Me.cmsHelp.ResumeLayout(False)
        Me.cmsListView.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddFiles As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lvFiles As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCombine As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chFilename As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFileSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents chStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents chRotation As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsHelp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsListView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RotationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DegreesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClockwiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterclockwiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DegreesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

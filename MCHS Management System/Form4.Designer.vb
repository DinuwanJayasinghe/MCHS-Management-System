<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F4))
        Me._2016_SEP_MCHSDataSet = New WindowsApplication1._2016_SEP_MCHSDataSet()
        Me.Copy_Of_tMchsAdmissionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copy_Of_tMchsAdmissionsTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSetTableAdapters.Copy_Of_tMchsAdmissionsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSetTableAdapters.TableAdapterManager()
        Me.Copy_Of_tMchsAdmissionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Copy_Of_tMchsAdmissionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        Me.CMD_CLOSE = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me._2016_SEP_MCHSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_tMchsAdmissionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_tMchsAdmissionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.SuspendLayout()
        CType(Me.Copy_Of_tMchsAdmissionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet
        '
        Me._2016_SEP_MCHSDataSet.DataSetName = "_2016_SEP_MCHSDataSet"
        Me._2016_SEP_MCHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copy_Of_tMchsAdmissionsBindingSource
        '
        Me.Copy_Of_tMchsAdmissionsBindingSource.DataMember = "Copy Of tMchsAdmissions"
        Me.Copy_Of_tMchsAdmissionsBindingSource.DataSource = Me._2016_SEP_MCHSDataSet
        '
        'Copy_Of_tMchsAdmissionsTableAdapter
        '
        Me.Copy_Of_tMchsAdmissionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copy_Of_tMchsAdmissionsTableAdapter = Me.Copy_Of_tMchsAdmissionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Copy_Of_tMchsAdmissionsBindingNavigator
        '
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.BindingSource = Me.Copy_Of_tMchsAdmissionsBindingSource
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem})
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.Name = "Copy_Of_tMchsAdmissionsBindingNavigator"
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.TabIndex = 0
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Copy_Of_tMchsAdmissionsDataGridView
        '
        Me.Copy_Of_tMchsAdmissionsDataGridView.AutoGenerateColumns = False
        Me.Copy_Of_tMchsAdmissionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Copy_Of_tMchsAdmissionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Copy_Of_tMchsAdmissionsDataGridView.DataSource = Me.Copy_Of_tMchsAdmissionsBindingSource
        Me.Copy_Of_tMchsAdmissionsDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Copy_Of_tMchsAdmissionsDataGridView.Name = "Copy_Of_tMchsAdmissionsDataGridView"
        Me.Copy_Of_tMchsAdmissionsDataGridView.Size = New System.Drawing.Size(1342, 623)
        Me.Copy_Of_tMchsAdmissionsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Rno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ldate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ldate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RegNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RegNo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Gename"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Gename"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ContactName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ContactName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BCRegisterNo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "BCRegisterNo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Religion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Religion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Scouts"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Scouts"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Guardian1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Guardian1"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Guardian2"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Guardian2"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Address2"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Address2"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn18.HeaderText = "City"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'CMD_PRE
        '
        Me.CMD_PRE.BackgroundImage = CType(resources.GetObject("CMD_PRE.BackgroundImage"), System.Drawing.Image)
        Me.CMD_PRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_PRE.Location = New System.Drawing.Point(27, 666)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 2
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        'CMD_CLOSE
        '
        Me.CMD_CLOSE.BackgroundImage = CType(resources.GetObject("CMD_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.CMD_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_CLOSE.Location = New System.Drawing.Point(1267, 666)
        Me.CMD_CLOSE.Name = "CMD_CLOSE"
        Me.CMD_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_CLOSE.TabIndex = 2
        Me.CMD_CLOSE.Text = "Close"
        Me.CMD_CLOSE.UseVisualStyleBackColor = True
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem
        '
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Name = "Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem"
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'F4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 699)
        Me.Controls.Add(Me.CMD_CLOSE)
        Me.Controls.Add(Me.CMD_PRE)
        Me.Controls.Add(Me.Copy_Of_tMchsAdmissionsDataGridView)
        Me.Controls.Add(Me.Copy_Of_tMchsAdmissionsBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F4"
        Me.Text = "MCHS Admtions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._2016_SEP_MCHSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_tMchsAdmissionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_tMchsAdmissionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.ResumeLayout(False)
        Me.Copy_Of_tMchsAdmissionsBindingNavigator.PerformLayout()
        CType(Me.Copy_Of_tMchsAdmissionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet As WindowsApplication1._2016_SEP_MCHSDataSet
    Friend WithEvents Copy_Of_tMchsAdmissionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Copy_Of_tMchsAdmissionsTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSetTableAdapters.Copy_Of_tMchsAdmissionsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Copy_Of_tMchsAdmissionsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Copy_Of_tMchsAdmissionsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Copy_Of_tMchsAdmissionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMD_CLOSE As System.Windows.Forms.Button
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
End Class

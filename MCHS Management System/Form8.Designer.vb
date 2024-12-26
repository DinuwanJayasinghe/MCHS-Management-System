<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F8))
        Me._2016_SEP_MCHSDataSet4 = New WindowsApplication1._2016_SEP_MCHSDataSet4()
        Me.QInfoAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInfoAllTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet4TableAdapters.qInfoAllTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet4TableAdapters.TableAdapterManager()
        Me.QInfoAllBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QInfoAllBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QInfoAllDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMD_CLOSE = New System.Windows.Forms.Button()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        CType(Me._2016_SEP_MCHSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInfoAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInfoAllBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QInfoAllBindingNavigator.SuspendLayout()
        CType(Me.QInfoAllDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet4
        '
        Me._2016_SEP_MCHSDataSet4.DataSetName = "_2016_SEP_MCHSDataSet4"
        Me._2016_SEP_MCHSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QInfoAllBindingSource
        '
        Me.QInfoAllBindingSource.DataMember = "qInfoAll"
        Me.QInfoAllBindingSource.DataSource = Me._2016_SEP_MCHSDataSet4
        '
        'QInfoAllTableAdapter
        '
        Me.QInfoAllTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QInfoAllBindingNavigator
        '
        Me.QInfoAllBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QInfoAllBindingNavigator.BindingSource = Me.QInfoAllBindingSource
        Me.QInfoAllBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QInfoAllBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QInfoAllBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QInfoAllBindingNavigatorSaveItem})
        Me.QInfoAllBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QInfoAllBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QInfoAllBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QInfoAllBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QInfoAllBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QInfoAllBindingNavigator.Name = "QInfoAllBindingNavigator"
        Me.QInfoAllBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QInfoAllBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.QInfoAllBindingNavigator.TabIndex = 0
        Me.QInfoAllBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'QInfoAllBindingNavigatorSaveItem
        '
        Me.QInfoAllBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QInfoAllBindingNavigatorSaveItem.Enabled = False
        Me.QInfoAllBindingNavigatorSaveItem.Image = CType(resources.GetObject("QInfoAllBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QInfoAllBindingNavigatorSaveItem.Name = "QInfoAllBindingNavigatorSaveItem"
        Me.QInfoAllBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QInfoAllBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QInfoAllDataGridView
        '
        Me.QInfoAllDataGridView.AutoGenerateColumns = False
        Me.QInfoAllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QInfoAllDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn1})
        Me.QInfoAllDataGridView.DataSource = Me.QInfoAllBindingSource
        Me.QInfoAllDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.QInfoAllDataGridView.Name = "QInfoAllDataGridView"
        Me.QInfoAllDataGridView.Size = New System.Drawing.Size(1342, 634)
        Me.QInfoAllDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RegNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RegNo"
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gename"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gename"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ContactName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ContactName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Address2"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn11.HeaderText = "City"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Ldate"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ldate"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Term"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Term"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FeeCode"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FeeCode"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Payment"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Payment"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Recipt No"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Recipt No"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Checked"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Checked"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'CMD_CLOSE
        '
        Me.CMD_CLOSE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMD_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_CLOSE.Location = New System.Drawing.Point(1267, 670)
        Me.CMD_CLOSE.Name = "CMD_CLOSE"
        Me.CMD_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_CLOSE.TabIndex = 4
        Me.CMD_CLOSE.Text = "Close"
        Me.CMD_CLOSE.UseVisualStyleBackColor = True
        '
        'CMD_PRE
        '
        Me.CMD_PRE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMD_PRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_PRE.Location = New System.Drawing.Point(12, 670)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 3
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        'F8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 700)
        Me.Controls.Add(Me.CMD_CLOSE)
        Me.Controls.Add(Me.CMD_PRE)
        Me.Controls.Add(Me.QInfoAllDataGridView)
        Me.Controls.Add(Me.QInfoAllBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F8"
        Me.Text = "All Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._2016_SEP_MCHSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInfoAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInfoAllBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QInfoAllBindingNavigator.ResumeLayout(False)
        Me.QInfoAllBindingNavigator.PerformLayout()
        CType(Me.QInfoAllDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet4 As WindowsApplication1._2016_SEP_MCHSDataSet4
    Friend WithEvents QInfoAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInfoAllTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet4TableAdapters.qInfoAllTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet4TableAdapters.TableAdapterManager
    Friend WithEvents QInfoAllBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QInfoAllBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QInfoAllDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CMD_CLOSE As System.Windows.Forms.Button
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
End Class

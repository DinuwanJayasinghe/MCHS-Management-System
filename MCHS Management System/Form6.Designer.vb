<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F6))
        Me._2016_SEP_MCHSDataSet2 = New WindowsApplication1._2016_SEP_MCHSDataSet2()
        Me.TTimeChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTimeChartTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet2TableAdapters.tTimeChartTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet2TableAdapters.TableAdapterManager()
        Me.TTimeChartBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TTimeChartBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TTimeChartDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.CMD_CLOSE = New System.Windows.Forms.Button()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        CType(Me._2016_SEP_MCHSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTimeChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTimeChartBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTimeChartBindingNavigator.SuspendLayout()
        CType(Me.TTimeChartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet2
        '
        Me._2016_SEP_MCHSDataSet2.DataSetName = "_2016_SEP_MCHSDataSet2"
        Me._2016_SEP_MCHSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TTimeChartBindingSource
        '
        Me.TTimeChartBindingSource.DataMember = "tTimeChart"
        Me.TTimeChartBindingSource.DataSource = Me._2016_SEP_MCHSDataSet2
        '
        'TTimeChartTableAdapter
        '
        Me.TTimeChartTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tTimeChartTableAdapter = Me.TTimeChartTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TTimeChartBindingNavigator
        '
        Me.TTimeChartBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TTimeChartBindingNavigator.BindingSource = Me.TTimeChartBindingSource
        Me.TTimeChartBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TTimeChartBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TTimeChartBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TTimeChartBindingNavigatorSaveItem})
        Me.TTimeChartBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TTimeChartBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TTimeChartBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TTimeChartBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TTimeChartBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TTimeChartBindingNavigator.Name = "TTimeChartBindingNavigator"
        Me.TTimeChartBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TTimeChartBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.TTimeChartBindingNavigator.TabIndex = 0
        Me.TTimeChartBindingNavigator.Text = "BindingNavigator1"
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
        'TTimeChartBindingNavigatorSaveItem
        '
        Me.TTimeChartBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TTimeChartBindingNavigatorSaveItem.Image = CType(resources.GetObject("TTimeChartBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TTimeChartBindingNavigatorSaveItem.Name = "TTimeChartBindingNavigatorSaveItem"
        Me.TTimeChartBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TTimeChartBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TTimeChartDataGridView
        '
        Me.TTimeChartDataGridView.AutoGenerateColumns = False
        Me.TTimeChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TTimeChartDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.TTimeChartDataGridView.DataSource = Me.TTimeChartBindingSource
        Me.TTimeChartDataGridView.Location = New System.Drawing.Point(9, 55)
        Me.TTimeChartDataGridView.Name = "TTimeChartDataGridView"
        Me.TTimeChartDataGridView.ShowRowErrors = False
        Me.TTimeChartDataGridView.Size = New System.Drawing.Size(1342, 606)
        Me.TTimeChartDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TC_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TC_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MonSub"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MonSub"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MonStf"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MonStf"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TueSub"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TueSub"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TueStf"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TueStf"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "WedSub"
        Me.DataGridViewTextBoxColumn8.HeaderText = "WedSub"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "WedStf"
        Me.DataGridViewTextBoxColumn9.HeaderText = "WedStf"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ThuSub"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ThuSub"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ThuStf"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ThuStf"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FriSub"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FriSub"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FriStf"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FriStf"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'CMD_CLOSE
        '
        Me.CMD_CLOSE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMD_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_CLOSE.Location = New System.Drawing.Point(1276, 678)
        Me.CMD_CLOSE.Name = "CMD_CLOSE"
        Me.CMD_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_CLOSE.TabIndex = 7
        Me.CMD_CLOSE.Text = "Close"
        Me.CMD_CLOSE.UseVisualStyleBackColor = True
        '
        'CMD_PRE
        '
        Me.CMD_PRE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMD_PRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_PRE.Location = New System.Drawing.Point(9, 678)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 6
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        'F6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.CMD_CLOSE)
        Me.Controls.Add(Me.CMD_PRE)
        Me.Controls.Add(Me.TTimeChartDataGridView)
        Me.Controls.Add(Me.TTimeChartBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F6"
        Me.Tag = ""
        Me.Text = "Time_Chart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._2016_SEP_MCHSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTimeChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTimeChartBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTimeChartBindingNavigator.ResumeLayout(False)
        Me.TTimeChartBindingNavigator.PerformLayout()
        CType(Me.TTimeChartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet2 As WindowsApplication1._2016_SEP_MCHSDataSet2
    Friend WithEvents TTimeChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TTimeChartTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet2TableAdapters.tTimeChartTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents TTimeChartBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TTimeChartBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TTimeChartDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents CMD_CLOSE As System.Windows.Forms.Button
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
End Class

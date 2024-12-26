<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F9))
        Me.CMD_CLOSE = New System.Windows.Forms.Button()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        Me._2016_SEP_MCHSDataSet5 = New WindowsApplication1._2016_SEP_MCHSDataSet5()
        Me.QLeftStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QLeftStudentsTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet5TableAdapters.qLeftStudentsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet5TableAdapters.TableAdapterManager()
        Me.QLeftStudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QLeftStudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QLeftStudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me._2016_SEP_MCHSDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLeftStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLeftStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QLeftStudentsBindingNavigator.SuspendLayout()
        CType(Me.QLeftStudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMD_CLOSE
        '
        Me.CMD_CLOSE.BackgroundImage = CType(resources.GetObject("CMD_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.CMD_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_CLOSE.Location = New System.Drawing.Point(878, 655)
        Me.CMD_CLOSE.Name = "CMD_CLOSE"
        Me.CMD_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_CLOSE.TabIndex = 6
        Me.CMD_CLOSE.Text = "Close"
        Me.CMD_CLOSE.UseVisualStyleBackColor = True
        '
        'CMD_PRE
        '
        Me.CMD_PRE.BackgroundImage = CType(resources.GetObject("CMD_PRE.BackgroundImage"), System.Drawing.Image)
        Me.CMD_PRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_PRE.Location = New System.Drawing.Point(12, 655)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 5
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        '_2016_SEP_MCHSDataSet5
        '
        Me._2016_SEP_MCHSDataSet5.DataSetName = "_2016_SEP_MCHSDataSet5"
        Me._2016_SEP_MCHSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QLeftStudentsBindingSource
        '
        Me.QLeftStudentsBindingSource.DataMember = "qLeftStudents"
        Me.QLeftStudentsBindingSource.DataSource = Me._2016_SEP_MCHSDataSet5
        '
        'QLeftStudentsTableAdapter
        '
        Me.QLeftStudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QLeftStudentsBindingNavigator
        '
        Me.QLeftStudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QLeftStudentsBindingNavigator.BindingSource = Me.QLeftStudentsBindingSource
        Me.QLeftStudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QLeftStudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QLeftStudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QLeftStudentsBindingNavigatorSaveItem})
        Me.QLeftStudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QLeftStudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QLeftStudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QLeftStudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QLeftStudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QLeftStudentsBindingNavigator.Name = "QLeftStudentsBindingNavigator"
        Me.QLeftStudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QLeftStudentsBindingNavigator.Size = New System.Drawing.Size(964, 25)
        Me.QLeftStudentsBindingNavigator.TabIndex = 7
        Me.QLeftStudentsBindingNavigator.Text = "BindingNavigator1"
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
        'QLeftStudentsBindingNavigatorSaveItem
        '
        Me.QLeftStudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QLeftStudentsBindingNavigatorSaveItem.Enabled = False
        Me.QLeftStudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("QLeftStudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QLeftStudentsBindingNavigatorSaveItem.Name = "QLeftStudentsBindingNavigatorSaveItem"
        Me.QLeftStudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QLeftStudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QLeftStudentsDataGridView
        '
        Me.QLeftStudentsDataGridView.AutoGenerateColumns = False
        Me.QLeftStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QLeftStudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.QLeftStudentsDataGridView.DataSource = Me.QLeftStudentsBindingSource
        Me.QLeftStudentsDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.QLeftStudentsDataGridView.Name = "QLeftStudentsDataGridView"
        Me.QLeftStudentsDataGridView.Size = New System.Drawing.Size(941, 612)
        Me.QLeftStudentsDataGridView.TabIndex = 7
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "StuName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "StuName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RegNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RegNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Guardian"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Guardian"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address2"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address2"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn9.HeaderText = "City"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'F9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 684)
        Me.Controls.Add(Me.QLeftStudentsDataGridView)
        Me.Controls.Add(Me.QLeftStudentsBindingNavigator)
        Me.Controls.Add(Me.CMD_CLOSE)
        Me.Controls.Add(Me.CMD_PRE)
        Me.MaximizeBox = False
        Me.Name = "F9"
        Me.Text = "Left Students"
        CType(Me._2016_SEP_MCHSDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLeftStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLeftStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QLeftStudentsBindingNavigator.ResumeLayout(False)
        Me.QLeftStudentsBindingNavigator.PerformLayout()
        CType(Me.QLeftStudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMD_CLOSE As System.Windows.Forms.Button
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
    Friend WithEvents _2016_SEP_MCHSDataSet5 As WindowsApplication1._2016_SEP_MCHSDataSet5
    Friend WithEvents QLeftStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QLeftStudentsTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet5TableAdapters.qLeftStudentsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet5TableAdapters.TableAdapterManager
    Friend WithEvents QLeftStudentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QLeftStudentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QLeftStudentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

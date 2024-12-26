<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F7))
        Me._2016_SEP_MCHSDataSet3 = New WindowsApplication1._2016_SEP_MCHSDataSet3()
        Me.TPrizeGivingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPrizeGivingTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet3TableAdapters.tPrizeGivingTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet3TableAdapters.TableAdapterManager()
        Me.TPrizeGivingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TPrizeGivingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TPrizeGivingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMD_CLOSE = New System.Windows.Forms.Button()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMDPRE = New System.Windows.Forms.Button()
        Me.CMDCLOSE = New System.Windows.Forms.Button()
        CType(Me._2016_SEP_MCHSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPrizeGivingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPrizeGivingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPrizeGivingBindingNavigator.SuspendLayout()
        CType(Me.TPrizeGivingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet3
        '
        Me._2016_SEP_MCHSDataSet3.DataSetName = "_2016_SEP_MCHSDataSet3"
        Me._2016_SEP_MCHSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPrizeGivingBindingSource
        '
        Me.TPrizeGivingBindingSource.DataMember = "tPrizeGiving"
        Me.TPrizeGivingBindingSource.DataSource = Me._2016_SEP_MCHSDataSet3
        '
        'TPrizeGivingTableAdapter
        '
        Me.TPrizeGivingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tPrizeGivingTableAdapter = Me.TPrizeGivingTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TPrizeGivingBindingNavigator
        '
        Me.TPrizeGivingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TPrizeGivingBindingNavigator.BindingSource = Me.TPrizeGivingBindingSource
        Me.TPrizeGivingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TPrizeGivingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TPrizeGivingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TPrizeGivingBindingNavigatorSaveItem})
        Me.TPrizeGivingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TPrizeGivingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TPrizeGivingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TPrizeGivingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TPrizeGivingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TPrizeGivingBindingNavigator.Name = "TPrizeGivingBindingNavigator"
        Me.TPrizeGivingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TPrizeGivingBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.TPrizeGivingBindingNavigator.TabIndex = 0
        Me.TPrizeGivingBindingNavigator.Text = "BindingNavigator1"
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
        'TPrizeGivingBindingNavigatorSaveItem
        '
        Me.TPrizeGivingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TPrizeGivingBindingNavigatorSaveItem.Image = CType(resources.GetObject("TPrizeGivingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TPrizeGivingBindingNavigatorSaveItem.Name = "TPrizeGivingBindingNavigatorSaveItem"
        Me.TPrizeGivingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TPrizeGivingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TPrizeGivingDataGridView
        '
        Me.TPrizeGivingDataGridView.AutoGenerateColumns = False
        Me.TPrizeGivingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TPrizeGivingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TPrizeGivingDataGridView.DataSource = Me.TPrizeGivingBindingSource
        Me.TPrizeGivingDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TPrizeGivingDataGridView.Name = "TPrizeGivingDataGridView"
        Me.TPrizeGivingDataGridView.Size = New System.Drawing.Size(742, 456)
        Me.TPrizeGivingDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Rno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RegNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RegNo"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ClassPrize"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ClassPrize"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SubjectPrize"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SubjectPrize"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MeritPrize"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MeritPrize"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Order"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Order"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'CMD_CLOSE
        '
        Me.CMD_CLOSE.Location = New System.Drawing.Point(979, 258)
        Me.CMD_CLOSE.Name = "CMD_CLOSE"
        Me.CMD_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_CLOSE.TabIndex = 9
        Me.CMD_CLOSE.Text = "Close"
        Me.CMD_CLOSE.UseVisualStyleBackColor = True
        '
        'CMD_PRE
        '
        Me.CMD_PRE.Location = New System.Drawing.Point(-288, 258)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 8
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1279, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CMDPRE
        '
        Me.CMDPRE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMDPRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRE.Location = New System.Drawing.Point(12, 503)
        Me.CMDPRE.Name = "CMDPRE"
        Me.CMDPRE.Size = New System.Drawing.Size(75, 23)
        Me.CMDPRE.TabIndex = 10
        Me.CMDPRE.Text = "<<Previous"
        Me.CMDPRE.UseVisualStyleBackColor = True
        '
        'CMDCLOSE
        '
        Me.CMDCLOSE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMDCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCLOSE.Location = New System.Drawing.Point(679, 503)
        Me.CMDCLOSE.Name = "CMDCLOSE"
        Me.CMDCLOSE.Size = New System.Drawing.Size(75, 23)
        Me.CMDCLOSE.TabIndex = 12
        Me.CMDCLOSE.Text = "Close"
        Me.CMDCLOSE.UseVisualStyleBackColor = True
        '
        'F7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 538)
        Me.Controls.Add(Me.CMDCLOSE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CMDPRE)
        Me.Controls.Add(Me.CMD_CLOSE)
        Me.Controls.Add(Me.CMD_PRE)
        Me.Controls.Add(Me.TPrizeGivingDataGridView)
        Me.Controls.Add(Me.TPrizeGivingBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F7"
        Me.Text = "Prize Giving"
        CType(Me._2016_SEP_MCHSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPrizeGivingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPrizeGivingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPrizeGivingBindingNavigator.ResumeLayout(False)
        Me.TPrizeGivingBindingNavigator.PerformLayout()
        CType(Me.TPrizeGivingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet3 As WindowsApplication1._2016_SEP_MCHSDataSet3
    Friend WithEvents TPrizeGivingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPrizeGivingTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet3TableAdapters.tPrizeGivingTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents TPrizeGivingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TPrizeGivingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TPrizeGivingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMD_CLOSE As System.Windows.Forms.Button
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CMDPRE As System.Windows.Forms.Button
    Friend WithEvents CMDCLOSE As System.Windows.Forms.Button
End Class

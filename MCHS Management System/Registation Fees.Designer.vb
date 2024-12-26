<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F12))
        Me._2016_SEP_MCHSDataSet7 = New WindowsApplication1._2016_SEP_MCHSDataSet7()
        Me.QRegistrationFeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QRegistrationFeeTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet7TableAdapters.qRegistrationFeeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet7TableAdapters.TableAdapterManager()
        Me.QRegistrationFeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QRegistrationFeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QRegistrationFeeDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.CMDCAN = New System.Windows.Forms.Button()
        Me.CMDPRE = New System.Windows.Forms.Button()
        CType(Me._2016_SEP_MCHSDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRegistrationFeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRegistrationFeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QRegistrationFeeBindingNavigator.SuspendLayout()
        CType(Me.QRegistrationFeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet7
        '
        Me._2016_SEP_MCHSDataSet7.DataSetName = "_2016_SEP_MCHSDataSet7"
        Me._2016_SEP_MCHSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QRegistrationFeeBindingSource
        '
        Me.QRegistrationFeeBindingSource.DataMember = "qRegistrationFee"
        Me.QRegistrationFeeBindingSource.DataSource = Me._2016_SEP_MCHSDataSet7
        '
        'QRegistrationFeeTableAdapter
        '
        Me.QRegistrationFeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QRegistrationFeeBindingNavigator
        '
        Me.QRegistrationFeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QRegistrationFeeBindingNavigator.BindingSource = Me.QRegistrationFeeBindingSource
        Me.QRegistrationFeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QRegistrationFeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QRegistrationFeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QRegistrationFeeBindingNavigatorSaveItem})
        Me.QRegistrationFeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QRegistrationFeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QRegistrationFeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QRegistrationFeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QRegistrationFeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QRegistrationFeeBindingNavigator.Name = "QRegistrationFeeBindingNavigator"
        Me.QRegistrationFeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QRegistrationFeeBindingNavigator.Size = New System.Drawing.Size(1070, 25)
        Me.QRegistrationFeeBindingNavigator.TabIndex = 0
        Me.QRegistrationFeeBindingNavigator.Text = "BindingNavigator1"
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
        'QRegistrationFeeBindingNavigatorSaveItem
        '
        Me.QRegistrationFeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QRegistrationFeeBindingNavigatorSaveItem.Enabled = False
        Me.QRegistrationFeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("QRegistrationFeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QRegistrationFeeBindingNavigatorSaveItem.Name = "QRegistrationFeeBindingNavigatorSaveItem"
        Me.QRegistrationFeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QRegistrationFeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QRegistrationFeeDataGridView
        '
        Me.QRegistrationFeeDataGridView.AutoGenerateColumns = False
        Me.QRegistrationFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QRegistrationFeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.QRegistrationFeeDataGridView.DataSource = Me.QRegistrationFeeBindingSource
        Me.QRegistrationFeeDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.QRegistrationFeeDataGridView.Name = "QRegistrationFeeDataGridView"
        Me.QRegistrationFeeDataGridView.Size = New System.Drawing.Size(1043, 623)
        Me.QRegistrationFeeDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PayID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PayID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RegNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RegNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FeeCode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FeeCode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tFeeCode_Payment"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tFeeCode_Payment"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tPayments_Payment"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tPayments_Payment"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Term"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Term"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Recipt No"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Recipt No"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CMDCAN
        '
        Me.CMDCAN.BackgroundImage = CType(resources.GetObject("CMDCAN.BackgroundImage"), System.Drawing.Image)
        Me.CMDCAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCAN.Location = New System.Drawing.Point(980, 661)
        Me.CMDCAN.Name = "CMDCAN"
        Me.CMDCAN.Size = New System.Drawing.Size(75, 23)
        Me.CMDCAN.TabIndex = 2
        Me.CMDCAN.Text = "Cancel"
        Me.CMDCAN.UseVisualStyleBackColor = True
        '
        'CMDPRE
        '
        Me.CMDPRE.BackgroundImage = CType(resources.GetObject("CMDPRE.BackgroundImage"), System.Drawing.Image)
        Me.CMDPRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDPRE.Location = New System.Drawing.Point(12, 661)
        Me.CMDPRE.Name = "CMDPRE"
        Me.CMDPRE.Size = New System.Drawing.Size(75, 23)
        Me.CMDPRE.TabIndex = 3
        Me.CMDPRE.Text = "<<Previous"
        Me.CMDPRE.UseVisualStyleBackColor = True
        '
        'F12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 690)
        Me.Controls.Add(Me.CMDPRE)
        Me.Controls.Add(Me.CMDCAN)
        Me.Controls.Add(Me.QRegistrationFeeDataGridView)
        Me.Controls.Add(Me.QRegistrationFeeBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F12"
        Me.Text = "Registation_Fees"
        CType(Me._2016_SEP_MCHSDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRegistrationFeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRegistrationFeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QRegistrationFeeBindingNavigator.ResumeLayout(False)
        Me.QRegistrationFeeBindingNavigator.PerformLayout()
        CType(Me.QRegistrationFeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet7 As WindowsApplication1._2016_SEP_MCHSDataSet7
    Friend WithEvents QRegistrationFeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QRegistrationFeeTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet7TableAdapters.qRegistrationFeeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet7TableAdapters.TableAdapterManager
    Friend WithEvents QRegistrationFeeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QRegistrationFeeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QRegistrationFeeDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents CMDCAN As System.Windows.Forms.Button
    Friend WithEvents CMDPRE As System.Windows.Forms.Button
End Class

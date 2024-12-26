<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F5))
        Me._2016_SEP_MCHSDataSet1 = New WindowsApplication1._2016_SEP_MCHSDataSet1()
        Me.Copy_Of_tPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copy_Of_tPaymentsTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet1TableAdapters.Copy_Of_tPaymentsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet1TableAdapters.TableAdapterManager()
        Me.Copy_Of_tPaymentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Copy_Of_tPaymentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMD_PRE = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CMDCL = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me._2016_SEP_MCHSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_tPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_Of_tPaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Copy_Of_tPaymentsBindingNavigator.SuspendLayout()
        CType(Me.Copy_Of_tPaymentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_2016_SEP_MCHSDataSet1
        '
        Me._2016_SEP_MCHSDataSet1.DataSetName = "_2016_SEP_MCHSDataSet1"
        Me._2016_SEP_MCHSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copy_Of_tPaymentsBindingSource
        '
        Me.Copy_Of_tPaymentsBindingSource.DataMember = "Copy Of tPayments"
        Me.Copy_Of_tPaymentsBindingSource.DataSource = Me._2016_SEP_MCHSDataSet1
        '
        'Copy_Of_tPaymentsTableAdapter
        '
        Me.Copy_Of_tPaymentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copy_Of_tPaymentsTableAdapter = Me.Copy_Of_tPaymentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Copy_Of_tPaymentsBindingNavigator
        '
        Me.Copy_Of_tPaymentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Copy_Of_tPaymentsBindingNavigator.BindingSource = Me.Copy_Of_tPaymentsBindingSource
        Me.Copy_Of_tPaymentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Copy_Of_tPaymentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Copy_Of_tPaymentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Copy_Of_tPaymentsBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.Copy_Of_tPaymentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Copy_Of_tPaymentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Copy_Of_tPaymentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Copy_Of_tPaymentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Copy_Of_tPaymentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Copy_Of_tPaymentsBindingNavigator.Name = "Copy_Of_tPaymentsBindingNavigator"
        Me.Copy_Of_tPaymentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Copy_Of_tPaymentsBindingNavigator.Size = New System.Drawing.Size(961, 25)
        Me.Copy_Of_tPaymentsBindingNavigator.TabIndex = 0
        Me.Copy_Of_tPaymentsBindingNavigator.Text = "BindingNavigator1"
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
        'Copy_Of_tPaymentsDataGridView
        '
        Me.Copy_Of_tPaymentsDataGridView.AutoGenerateColumns = False
        Me.Copy_Of_tPaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Copy_Of_tPaymentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8})
        Me.Copy_Of_tPaymentsDataGridView.DataSource = Me.Copy_Of_tPaymentsBindingSource
        Me.Copy_Of_tPaymentsDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Copy_Of_tPaymentsDataGridView.Name = "Copy_Of_tPaymentsDataGridView"
        Me.Copy_Of_tPaymentsDataGridView.Size = New System.Drawing.Size(938, 578)
        Me.Copy_Of_tPaymentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PayID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PayID"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Payment"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Payment"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Recipt No"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Recipt No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Checked"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Checked"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Term"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Term"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'CMD_PRE
        '
        Me.CMD_PRE.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMD_PRE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMD_PRE.Location = New System.Drawing.Point(12, 625)
        Me.CMD_PRE.Name = "CMD_PRE"
        Me.CMD_PRE.Size = New System.Drawing.Size(75, 23)
        Me.CMD_PRE.TabIndex = 4
        Me.CMD_PRE.Text = "<<Previous"
        Me.CMD_PRE.UseVisualStyleBackColor = True
        '
        'CMDCL
        '
        Me.CMDCL.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Windows_Seven_____7__by_Youness_toulouse1
        Me.CMDCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDCL.Location = New System.Drawing.Point(863, 625)
        Me.CMDCL.Name = "CMDCL"
        Me.CMDCL.Size = New System.Drawing.Size(75, 23)
        Me.CMDCL.TabIndex = 5
        Me.CMDCL.Text = "Cancel"
        Me.CMDCL.UseVisualStyleBackColor = True
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
        'Copy_Of_tPaymentsBindingNavigatorSaveItem
        '
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Copy_Of_tPaymentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem.Name = "Copy_Of_tPaymentsBindingNavigatorSaveItem"
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Copy_Of_tPaymentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButton1.Text = "Registation Fees"
        '
        'F5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 669)
        Me.Controls.Add(Me.CMDCL)
        Me.Controls.Add(Me.CMD_PRE)
        Me.Controls.Add(Me.Copy_Of_tPaymentsDataGridView)
        Me.Controls.Add(Me.Copy_Of_tPaymentsBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F5"
        Me.Text = "Payments"
        CType(Me._2016_SEP_MCHSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_tPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_Of_tPaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Copy_Of_tPaymentsBindingNavigator.ResumeLayout(False)
        Me.Copy_Of_tPaymentsBindingNavigator.PerformLayout()
        CType(Me.Copy_Of_tPaymentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet1 As WindowsApplication1._2016_SEP_MCHSDataSet1
    Friend WithEvents Copy_Of_tPaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Copy_Of_tPaymentsTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet1TableAdapters.Copy_Of_tPaymentsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Copy_Of_tPaymentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Copy_Of_tPaymentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Copy_Of_tPaymentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMD_PRE As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDCL As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F10))
        Me.QPayments4ReportsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QPayments4ReportsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QPayments4ReportsDataGridView = New System.Windows.Forms.DataGridView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PayIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFeeCodePaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPaymentsPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReciptNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPayments4Repo1to8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._2016_SEP_MCHSDataSet6 = New WindowsApplication1._2016_SEP_MCHSDataSet6()
        Me.QPayments4ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QPayments4ReportsTableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.qPayments4ReportsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.TableAdapterManager()
        Me.QPayments4Repo1to8TableAdapter = New WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.qPayments4Repo1to8TableAdapter()
        Me.TSB1 = New System.Windows.Forms.ToolStripButton()
        Me.CMDPRE = New System.Windows.Forms.Button()
        Me.CMDCAN = New System.Windows.Forms.Button()
        CType(Me.QPayments4ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QPayments4ReportsBindingNavigator.SuspendLayout()
        CType(Me.QPayments4ReportsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.QPayments4Repo1to8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._2016_SEP_MCHSDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QPayments4ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPayments4ReportsBindingNavigator
        '
        Me.QPayments4ReportsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QPayments4ReportsBindingNavigator.BindingSource = Me.QPayments4ReportsBindingSource
        Me.QPayments4ReportsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QPayments4ReportsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QPayments4ReportsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QPayments4ReportsBindingNavigatorSaveItem})
        Me.QPayments4ReportsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QPayments4ReportsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QPayments4ReportsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QPayments4ReportsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QPayments4ReportsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QPayments4ReportsBindingNavigator.Name = "QPayments4ReportsBindingNavigator"
        Me.QPayments4ReportsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QPayments4ReportsBindingNavigator.Size = New System.Drawing.Size(1058, 25)
        Me.QPayments4ReportsBindingNavigator.TabIndex = 0
        Me.QPayments4ReportsBindingNavigator.Text = "BindingNavigator1"
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
        'QPayments4ReportsBindingNavigatorSaveItem
        '
        Me.QPayments4ReportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QPayments4ReportsBindingNavigatorSaveItem.Enabled = False
        Me.QPayments4ReportsBindingNavigatorSaveItem.Image = CType(resources.GetObject("QPayments4ReportsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QPayments4ReportsBindingNavigatorSaveItem.Name = "QPayments4ReportsBindingNavigatorSaveItem"
        Me.QPayments4ReportsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QPayments4ReportsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QPayments4ReportsDataGridView
        '
        Me.QPayments4ReportsDataGridView.AutoGenerateColumns = False
        Me.QPayments4ReportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QPayments4ReportsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PayIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.SNameDataGridViewTextBoxColumn, Me.RegNoDataGridViewTextBoxColumn, Me.FeeCodeDataGridViewTextBoxColumn, Me.TFeeCodePaymentDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.TPaymentsPaymentDataGridViewTextBoxColumn, Me.TermDataGridViewTextBoxColumn, Me.ReciptNoDataGridViewTextBoxColumn})
        Me.QPayments4ReportsDataGridView.DataSource = Me.QPayments4Repo1to8BindingSource
        Me.QPayments4ReportsDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.QPayments4ReportsDataGridView.Name = "QPayments4ReportsDataGridView"
        Me.QPayments4ReportsDataGridView.Size = New System.Drawing.Size(1038, 623)
        Me.QPayments4ReportsDataGridView.TabIndex = 1
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton, Me.TSB1})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1058, 25)
        Me.FillByToolStrip.TabIndex = 2
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(122, 22)
        Me.FillByToolStripButton.Text = "Payment Report 9-30"
        '
        'PayIDDataGridViewTextBoxColumn
        '
        Me.PayIDDataGridViewTextBoxColumn.DataPropertyName = "PayID"
        Me.PayIDDataGridViewTextBoxColumn.HeaderText = "PayID"
        Me.PayIDDataGridViewTextBoxColumn.Name = "PayIDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'SNameDataGridViewTextBoxColumn
        '
        Me.SNameDataGridViewTextBoxColumn.DataPropertyName = "SName"
        Me.SNameDataGridViewTextBoxColumn.HeaderText = "SName"
        Me.SNameDataGridViewTextBoxColumn.Name = "SNameDataGridViewTextBoxColumn"
        Me.SNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegNoDataGridViewTextBoxColumn
        '
        Me.RegNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.HeaderText = "RegNo"
        Me.RegNoDataGridViewTextBoxColumn.Name = "RegNoDataGridViewTextBoxColumn"
        '
        'FeeCodeDataGridViewTextBoxColumn
        '
        Me.FeeCodeDataGridViewTextBoxColumn.DataPropertyName = "FeeCode"
        Me.FeeCodeDataGridViewTextBoxColumn.HeaderText = "FeeCode"
        Me.FeeCodeDataGridViewTextBoxColumn.Name = "FeeCodeDataGridViewTextBoxColumn"
        '
        'TFeeCodePaymentDataGridViewTextBoxColumn
        '
        Me.TFeeCodePaymentDataGridViewTextBoxColumn.DataPropertyName = "tFeeCode_Payment"
        Me.TFeeCodePaymentDataGridViewTextBoxColumn.HeaderText = "tFeeCode_Payment"
        Me.TFeeCodePaymentDataGridViewTextBoxColumn.Name = "TFeeCodePaymentDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'TPaymentsPaymentDataGridViewTextBoxColumn
        '
        Me.TPaymentsPaymentDataGridViewTextBoxColumn.DataPropertyName = "tPayments_Payment"
        Me.TPaymentsPaymentDataGridViewTextBoxColumn.HeaderText = "tPayments_Payment"
        Me.TPaymentsPaymentDataGridViewTextBoxColumn.Name = "TPaymentsPaymentDataGridViewTextBoxColumn"
        '
        'TermDataGridViewTextBoxColumn
        '
        Me.TermDataGridViewTextBoxColumn.DataPropertyName = "Term"
        Me.TermDataGridViewTextBoxColumn.HeaderText = "Term"
        Me.TermDataGridViewTextBoxColumn.Name = "TermDataGridViewTextBoxColumn"
        '
        'ReciptNoDataGridViewTextBoxColumn
        '
        Me.ReciptNoDataGridViewTextBoxColumn.DataPropertyName = "Recipt No"
        Me.ReciptNoDataGridViewTextBoxColumn.HeaderText = "Recipt No"
        Me.ReciptNoDataGridViewTextBoxColumn.Name = "ReciptNoDataGridViewTextBoxColumn"
        '
        'QPayments4Repo1to8BindingSource
        '
        Me.QPayments4Repo1to8BindingSource.DataMember = "qPayments4Repo1to8"
        Me.QPayments4Repo1to8BindingSource.DataSource = Me._2016_SEP_MCHSDataSet6
        '
        '_2016_SEP_MCHSDataSet6
        '
        Me._2016_SEP_MCHSDataSet6.DataSetName = "_2016_SEP_MCHSDataSet6"
        Me._2016_SEP_MCHSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QPayments4ReportsBindingSource
        '
        Me.QPayments4ReportsBindingSource.DataMember = "qPayments4Reports"
        Me.QPayments4ReportsBindingSource.DataSource = Me._2016_SEP_MCHSDataSet6
        '
        'QPayments4ReportsTableAdapter
        '
        Me.QPayments4ReportsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QPayments4Repo1to8TableAdapter
        '
        Me.QPayments4Repo1to8TableAdapter.ClearBeforeFill = True
        '
        'TSB1
        '
        Me.TSB1.Image = CType(resources.GetObject("TSB1.Image"), System.Drawing.Image)
        Me.TSB1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB1.Name = "TSB1"
        Me.TSB1.Size = New System.Drawing.Size(176, 22)
        Me.TSB1.Text = "Show Payment Report 1 to 8"
        '
        'CMDPRE
        '
        Me.CMDPRE.Location = New System.Drawing.Point(12, 659)
        Me.CMDPRE.Name = "CMDPRE"
        Me.CMDPRE.Size = New System.Drawing.Size(75, 23)
        Me.CMDPRE.TabIndex = 3
        Me.CMDPRE.Text = "<<Previous"
        Me.CMDPRE.UseVisualStyleBackColor = True
        '
        'CMDCAN
        '
        Me.CMDCAN.Location = New System.Drawing.Point(963, 659)
        Me.CMDCAN.Name = "CMDCAN"
        Me.CMDCAN.Size = New System.Drawing.Size(75, 23)
        Me.CMDCAN.TabIndex = 4
        Me.CMDCAN.Text = "Cancel"
        Me.CMDCAN.UseVisualStyleBackColor = True
        '
        'F10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 694)
        Me.Controls.Add(Me.CMDCAN)
        Me.Controls.Add(Me.CMDPRE)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.QPayments4ReportsDataGridView)
        Me.Controls.Add(Me.QPayments4ReportsBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "F10"
        Me.Text = "Payment Report 9 to 30"
        CType(Me.QPayments4ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QPayments4ReportsBindingNavigator.ResumeLayout(False)
        Me.QPayments4ReportsBindingNavigator.PerformLayout()
        CType(Me.QPayments4ReportsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.QPayments4Repo1to8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._2016_SEP_MCHSDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QPayments4ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _2016_SEP_MCHSDataSet6 As WindowsApplication1._2016_SEP_MCHSDataSet6
    Friend WithEvents QPayments4ReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QPayments4ReportsTableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.qPayments4ReportsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.TableAdapterManager
    Friend WithEvents QPayments4ReportsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QPayments4ReportsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QPayments4ReportsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents QPayments4Repo1to8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QPayments4Repo1to8TableAdapter As WindowsApplication1._2016_SEP_MCHSDataSet6TableAdapters.qPayments4Repo1to8TableAdapter
    Friend WithEvents PayIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFeeCodePaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPaymentsPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReciptNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSB1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CMDPRE As System.Windows.Forms.Button
    Friend WithEvents CMDCAN As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lstPersons = New System.Windows.Forms.ListBox()
        Me.TblPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PO_Data_DataSet = New Personal_organizer.PO_Data_DataSet()
        Me.btnShowDetails = New System.Windows.Forms.Button()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.TblPersonTableAdapter = New Personal_organizer.PO_Data_DataSetTableAdapters.tblPerson_TableAdapter()
        Me.TableAdapterManager = New Personal_organizer.PO_Data_DataSetTableAdapters.TableAdapterManager()
        CType(Me.TblPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PO_Data_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPersons
        '
        Me.lstPersons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPersons.FormattingEnabled = True
        Me.lstPersons.Location = New System.Drawing.Point(3, 3)
        Me.lstPersons.Name = "lstPersons"
        Me.lstPersons.Size = New System.Drawing.Size(248, 251)
        Me.lstPersons.TabIndex = 0
        '
        'TblPersonBindingSource
        '
        Me.TblPersonBindingSource.DataMember = "tblPerson"
        Me.TblPersonBindingSource.DataSource = Me.PO_Data_DataSet
        '
        'PO_Data_DataSet
        '
        Me.PO_Data_DataSet.DataSetName = "PO_Data_DataSet"
        Me.PO_Data_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnShowDetails
        '
        Me.btnShowDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowDetails.Location = New System.Drawing.Point(257, 3)
        Me.btnShowDetails.Name = "btnShowDetails"
        Me.btnShowDetails.Size = New System.Drawing.Size(95, 23)
        Me.btnShowDetails.TabIndex = 1
        Me.btnShowDetails.Text = "Show details"
        Me.btnShowDetails.UseVisualStyleBackColor = True
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteSelected.Location = New System.Drawing.Point(257, 32)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(95, 23)
        Me.btnDeleteSelected.TabIndex = 2
        Me.btnDeleteSelected.Text = "Delete selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        '
        'TblPersonTableAdapter
        '
        Me.TblPersonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPersonTableAdapter = Me.TblPersonTableAdapter
        Me.TableAdapterManager.tblPOUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Personal_organizer.PO_Data_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PersonList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.btnShowDetails)
        Me.Controls.Add(Me.lstPersons)
        Me.Name = "PersonList"
        Me.Size = New System.Drawing.Size(354, 257)
        CType(Me.TblPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PO_Data_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPersons As ListBox
    Friend WithEvents btnShowDetails As Button
    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents TblPersonBindingSource As BindingSource
    Friend WithEvents PO_Data_DataSet As PO_Data_DataSet
    Friend WithEvents TblPersonTableAdapter As PO_Data_DataSetTableAdapters.tblPerson_TableAdapter
    Friend WithEvents TableAdapterManager As PO_Data_DataSetTableAdapters.TableAdapterManager
End Class

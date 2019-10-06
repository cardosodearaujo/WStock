<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesquisa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.cboOpcoes = New System.Windows.Forms.ComboBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.gbxPesquisa = New System.Windows.Forms.GroupBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tspTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspExportar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPesquisa.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.White
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(7, 62)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(598, 231)
        Me.dgvResultados.TabIndex = 0
        '
        'cboOpcoes
        '
        Me.cboOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcoes.FormattingEnabled = True
        Me.cboOpcoes.Location = New System.Drawing.Point(10, 20)
        Me.cboOpcoes.Name = "cboOpcoes"
        Me.cboOpcoes.Size = New System.Drawing.Size(145, 21)
        Me.cboOpcoes.TabIndex = 1
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(161, 20)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(349, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'gbxPesquisa
        '
        Me.gbxPesquisa.Controls.Add(Me.btnPesquisar)
        Me.gbxPesquisa.Controls.Add(Me.txtFiltro)
        Me.gbxPesquisa.Controls.Add(Me.cboOpcoes)
        Me.gbxPesquisa.Location = New System.Drawing.Point(7, 4)
        Me.gbxPesquisa.Name = "gbxPesquisa"
        Me.gbxPesquisa.Size = New System.Drawing.Size(598, 52)
        Me.gbxPesquisa.TabIndex = 3
        Me.gbxPesquisa.TabStop = False
        Me.gbxPesquisa.Text = "Digite os dados da pesquisa"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(516, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 22)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'tspTotal
        '
        Me.tspTotal.Name = "tspTotal"
        Me.tspTotal.Size = New System.Drawing.Size(284, 17)
        Me.tspTotal.Spring = True
        Me.tspTotal.Text = "Total de registros: 0"
        '
        'tspExportar
        '
        Me.tspExportar.Name = "tspExportar"
        Me.tspExportar.Size = New System.Drawing.Size(284, 17)
        Me.tspExportar.Spring = True
        Me.tspExportar.Text = "Exportar - [F10]"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspTotal})
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspExportar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 294)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FrmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 316)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxPesquisa)
        Me.Controls.Add(Me.dgvResultados)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FrmPesquisa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPesquisa.ResumeLayout(False)
        Me.gbxPesquisa.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents cboOpcoes As ComboBox
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents gbxPesquisa As GroupBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents tspTotal As ToolStripStatusLabel
    Friend WithEvents tspExportar As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
End Class

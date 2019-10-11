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
        Me.cboOrdem = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboTipoOrdenacao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPesquisa.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvResultados.Location = New System.Drawing.Point(7, 103)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(636, 218)
        Me.dgvResultados.TabIndex = 0
        '
        'cboOpcoes
        '
        Me.cboOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcoes.FormattingEnabled = True
        Me.cboOpcoes.Location = New System.Drawing.Point(10, 59)
        Me.cboOpcoes.Name = "cboOpcoes"
        Me.cboOpcoes.Size = New System.Drawing.Size(145, 21)
        Me.cboOpcoes.TabIndex = 1
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(10, 20)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(544, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'gbxPesquisa
        '
        Me.gbxPesquisa.Controls.Add(Me.Label3)
        Me.gbxPesquisa.Controls.Add(Me.Label2)
        Me.gbxPesquisa.Controls.Add(Me.Label1)
        Me.gbxPesquisa.Controls.Add(Me.cboTipoOrdenacao)
        Me.gbxPesquisa.Controls.Add(Me.cboOrdem)
        Me.gbxPesquisa.Controls.Add(Me.PictureBox1)
        Me.gbxPesquisa.Controls.Add(Me.btnPesquisar)
        Me.gbxPesquisa.Controls.Add(Me.txtFiltro)
        Me.gbxPesquisa.Controls.Add(Me.cboOpcoes)
        Me.gbxPesquisa.Location = New System.Drawing.Point(7, 4)
        Me.gbxPesquisa.Name = "gbxPesquisa"
        Me.gbxPesquisa.Size = New System.Drawing.Size(636, 93)
        Me.gbxPesquisa.TabIndex = 3
        Me.gbxPesquisa.TabStop = False
        Me.gbxPesquisa.Text = "Digite os dados da pesquisa"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Location = New System.Drawing.Point(463, 58)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(91, 22)
        Me.btnPesquisar.TabIndex = 3
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'tspTotal
        '
        Me.tspTotal.Name = "tspTotal"
        Me.tspTotal.Size = New System.Drawing.Size(318, 17)
        Me.tspTotal.Spring = True
        Me.tspTotal.Text = "Total de registros: 0"
        '
        'tspExportar
        '
        Me.tspExportar.Name = "tspExportar"
        Me.tspExportar.Size = New System.Drawing.Size(318, 17)
        Me.tspExportar.Spring = True
        Me.tspExportar.Text = "Exportar - [F10]"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspTotal, Me.tspExportar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'cboOrdem
        '
        Me.cboOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrdem.FormattingEnabled = True
        Me.cboOrdem.Location = New System.Drawing.Point(161, 59)
        Me.cboOrdem.Name = "cboOrdem"
        Me.cboOrdem.Size = New System.Drawing.Size(145, 21)
        Me.cboOrdem.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WStock.My.Resources.Resources.search_2_
        Me.PictureBox1.Location = New System.Drawing.Point(559, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 64)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'cboTipoOrdenacao
        '
        Me.cboTipoOrdenacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoOrdenacao.FormattingEnabled = True
        Me.cboTipoOrdenacao.Items.AddRange(New Object() {"Crescente", "Decrescente"})
        Me.cboTipoOrdenacao.Location = New System.Drawing.Point(312, 59)
        Me.cboTipoOrdenacao.Name = "cboTipoOrdenacao"
        Me.cboTipoOrdenacao.Size = New System.Drawing.Size(145, 21)
        Me.cboTipoOrdenacao.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ordenação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de ordenação"
        '
        'FrmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 344)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboOrdem As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboTipoOrdenacao As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

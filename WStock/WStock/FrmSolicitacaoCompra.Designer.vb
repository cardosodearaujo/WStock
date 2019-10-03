<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicitacaoCompra
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicitacaoCompra))
        Me.lblSku = New System.Windows.Forms.Label()
        Me.cboSKU = New System.Windows.Forms.ComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblDataSolicitacao = New System.Windows.Forms.Label()
        Me.lblDataEntrega = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.lblNSolicitacaoCompra = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNumeroPedido = New System.Windows.Forms.TextBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.cboStatusItem = New System.Windows.Forms.ComboBox()
        Me.cboFornecedor = New System.Windows.Forms.ComboBox()
        Me.grbDetalhesItens = New System.Windows.Forms.GroupBox()
        Me.dgvItens = New System.Windows.Forms.DataGridView()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblTotalResgistros = New System.Windows.Forms.Label()
        Me.dtpEntrega = New System.Windows.Forms.DateTimePicker()
        Me.dtpSolicitacao = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.grbDetalhesItens.SuspendLayout()
        CType(Me.dgvItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSku
        '
        Me.lblSku.AutoSize = True
        Me.lblSku.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSku.Location = New System.Drawing.Point(9, 93)
        Me.lblSku.Name = "lblSku"
        Me.lblSku.Size = New System.Drawing.Size(29, 13)
        Me.lblSku.TabIndex = 0
        Me.lblSku.Text = "SKU"
        '
        'cboSKU
        '
        Me.cboSKU.FormattingEnabled = True
        Me.cboSKU.Location = New System.Drawing.Point(12, 109)
        Me.cboSKU.Name = "cboSKU"
        Me.cboSKU.Size = New System.Drawing.Size(407, 21)
        Me.cboSKU.TabIndex = 1
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQuantidade.Location = New System.Drawing.Point(422, 93)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 2
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(425, 109)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 3
        '
        'lblDataSolicitacao
        '
        Me.lblDataSolicitacao.AutoSize = True
        Me.lblDataSolicitacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataSolicitacao.Location = New System.Drawing.Point(145, 19)
        Me.lblDataSolicitacao.Name = "lblDataSolicitacao"
        Me.lblDataSolicitacao.Size = New System.Drawing.Size(83, 13)
        Me.lblDataSolicitacao.TabIndex = 5
        Me.lblDataSolicitacao.Text = "Data solicitação"
        '
        'lblDataEntrega
        '
        Me.lblDataEntrega.AutoSize = True
        Me.lblDataEntrega.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataEntrega.Location = New System.Drawing.Point(528, 93)
        Me.lblDataEntrega.Name = "lblDataEntrega"
        Me.lblDataEntrega.Size = New System.Drawing.Size(70, 13)
        Me.lblDataEntrega.TabIndex = 6
        Me.lblDataEntrega.Text = "Data Entrega"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(634, 93)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status item"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFornecedor.Location = New System.Drawing.Point(763, 93)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(61, 13)
        Me.lblFornecedor.TabIndex = 12
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'lblNSolicitacaoCompra
        '
        Me.lblNSolicitacaoCompra.AutoSize = True
        Me.lblNSolicitacaoCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNSolicitacaoCompra.Location = New System.Drawing.Point(12, 19)
        Me.lblNSolicitacaoCompra.Name = "lblNSolicitacaoCompra"
        Me.lblNSolicitacaoCompra.Size = New System.Drawing.Size(127, 13)
        Me.lblNSolicitacaoCompra.TabIndex = 13
        Me.lblNSolicitacaoCompra.Text = "Nº Solicitação de compra"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 20)
        Me.TextBox1.TabIndex = 14
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Location = New System.Drawing.Point(895, 109)
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedido.TabIndex = 15
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNumeroPedido.Location = New System.Drawing.Point(895, 93)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(94, 13)
        Me.lblNumeroPedido.TabIndex = 16
        Me.lblNumeroPedido.Text = "Número do pedido"
        '
        'cboStatusItem
        '
        Me.cboStatusItem.FormattingEnabled = True
        Me.cboStatusItem.Items.AddRange(New Object() {"ABERTO", "PARCIAL", "FECHADO"})
        Me.cboStatusItem.Location = New System.Drawing.Point(638, 109)
        Me.cboStatusItem.Name = "cboStatusItem"
        Me.cboStatusItem.Size = New System.Drawing.Size(121, 21)
        Me.cboStatusItem.TabIndex = 17
        '
        'cboFornecedor
        '
        Me.cboFornecedor.FormattingEnabled = True
        Me.cboFornecedor.Location = New System.Drawing.Point(767, 109)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Size = New System.Drawing.Size(121, 21)
        Me.cboFornecedor.TabIndex = 18
        '
        'grbDetalhesItens
        '
        Me.grbDetalhesItens.Controls.Add(Me.dgvItens)
        Me.grbDetalhesItens.Controls.Add(Me.btnDeleteItem)
        Me.grbDetalhesItens.Controls.Add(Me.btnAddItem)
        Me.grbDetalhesItens.Controls.Add(Me.lblTotalResgistros)
        Me.grbDetalhesItens.Controls.Add(Me.dtpEntrega)
        Me.grbDetalhesItens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grbDetalhesItens.Location = New System.Drawing.Point(3, 68)
        Me.grbDetalhesItens.Name = "grbDetalhesItens"
        Me.grbDetalhesItens.Size = New System.Drawing.Size(1088, 378)
        Me.grbDetalhesItens.TabIndex = 20
        Me.grbDetalhesItens.TabStop = False
        Me.grbDetalhesItens.Text = "Detalhes dos itens"
        '
        'dgvItens
        '
        Me.dgvItens.AllowUserToAddRows = False
        Me.dgvItens.AllowUserToDeleteRows = False
        Me.dgvItens.AllowUserToResizeColumns = False
        Me.dgvItens.AllowUserToResizeRows = False
        Me.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItens.Location = New System.Drawing.Point(10, 69)
        Me.dgvItens.MultiSelect = False
        Me.dgvItens.Name = "dgvItens"
        Me.dgvItens.ReadOnly = True
        Me.dgvItens.RowHeadersVisible = False
        Me.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItens.Size = New System.Drawing.Size(1044, 290)
        Me.dgvItens.TabIndex = 24
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Image = CType(resources.GetObject("btnDeleteItem.Image"), System.Drawing.Image)
        Me.btnDeleteItem.Location = New System.Drawing.Point(1029, 38)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(25, 24)
        Me.btnDeleteItem.TabIndex = 23
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.Location = New System.Drawing.Point(998, 38)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(25, 24)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'lblTotalResgistros
        '
        Me.lblTotalResgistros.AutoSize = True
        Me.lblTotalResgistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResgistros.Location = New System.Drawing.Point(957, 362)
        Me.lblTotalResgistros.Name = "lblTotalResgistros"
        Me.lblTotalResgistros.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalResgistros.TabIndex = 23
        Me.lblTotalResgistros.Text = "Total registro: 0"
        '
        'dtpEntrega
        '
        Me.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrega.Location = New System.Drawing.Point(528, 41)
        Me.dtpEntrega.Name = "dtpEntrega"
        Me.dtpEntrega.Size = New System.Drawing.Size(101, 20)
        Me.dtpEntrega.TabIndex = 22
        '
        'dtpSolicitacao
        '
        Me.dtpSolicitacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSolicitacao.Location = New System.Drawing.Point(148, 35)
        Me.dtpSolicitacao.Name = "dtpSolicitacao"
        Me.dtpSolicitacao.Size = New System.Drawing.Size(98, 20)
        Me.dtpSolicitacao.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExportar)
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 452)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 44)
        Me.Panel1.TabIndex = 22
        '
        'btnExportar
        '
        Me.btnExportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExportar.Location = New System.Drawing.Point(174, 4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(93, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "   Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(12, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "   Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'FrmSolicitacaoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 496)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpSolicitacao)
        Me.Controls.Add(Me.cboFornecedor)
        Me.Controls.Add(Me.cboStatusItem)
        Me.Controls.Add(Me.lblNumeroPedido)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNSolicitacaoCompra)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDataEntrega)
        Me.Controls.Add(Me.lblDataSolicitacao)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.cboSKU)
        Me.Controls.Add(Me.lblSku)
        Me.Controls.Add(Me.grbDetalhesItens)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSolicitacaoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitação de compra"
        Me.grbDetalhesItens.ResumeLayout(False)
        Me.grbDetalhesItens.PerformLayout()
        CType(Me.dgvItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSku As Label
    Friend WithEvents cboSKU As ComboBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblDataSolicitacao As Label
    Friend WithEvents lblDataEntrega As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents lblNSolicitacaoCompra As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNumeroPedido As TextBox
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents cboStatusItem As ComboBox
    Friend WithEvents cboFornecedor As ComboBox
    Friend WithEvents grbDetalhesItens As GroupBox
    Friend WithEvents dtpEntrega As DateTimePicker
    Friend WithEvents dtpSolicitacao As DateTimePicker
    Friend WithEvents lblTotalResgistros As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents dgvItens As DataGridView
End Class

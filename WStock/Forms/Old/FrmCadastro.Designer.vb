<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastro))
        Me.lblNomeUsuario = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblEmailUsuario = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSenhaUsuario = New System.Windows.Forms.TextBox()
        Me.lblsenha = New System.Windows.Forms.Label()
        Me.lblPermissao = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.cboPermissao = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNomeUsuario
        '
        Me.lblNomeUsuario.AutoSize = True
        Me.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomeUsuario.Location = New System.Drawing.Point(8, 14)
        Me.lblNomeUsuario.Name = "lblNomeUsuario"
        Me.lblNomeUsuario.Size = New System.Drawing.Size(38, 13)
        Me.lblNomeUsuario.TabIndex = 0
        Me.lblNomeUsuario.Text = "Nome "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblEmailUsuario
        '
        Me.lblEmailUsuario.Location = New System.Drawing.Point(314, 31)
        Me.lblEmailUsuario.Name = "lblEmailUsuario"
        Me.lblEmailUsuario.Size = New System.Drawing.Size(297, 20)
        Me.lblEmailUsuario.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmail.Location = New System.Drawing.Point(311, 14)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "E-mail"
        '
        'txtSenhaUsuario
        '
        Me.txtSenhaUsuario.Location = New System.Drawing.Point(617, 30)
        Me.txtSenhaUsuario.Name = "txtSenhaUsuario"
        Me.txtSenhaUsuario.Size = New System.Drawing.Size(115, 20)
        Me.txtSenhaUsuario.TabIndex = 5
        '
        'lblsenha
        '
        Me.lblsenha.AutoSize = True
        Me.lblsenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsenha.Location = New System.Drawing.Point(617, 14)
        Me.lblsenha.Name = "lblsenha"
        Me.lblsenha.Size = New System.Drawing.Size(38, 13)
        Me.lblsenha.TabIndex = 6
        Me.lblsenha.Text = "Senha"
        '
        'lblPermissao
        '
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPermissao.Location = New System.Drawing.Point(735, 14)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(55, 13)
        Me.lblPermissao.TabIndex = 7
        Me.lblPermissao.Text = "Permissão"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Controle terceirizadas", "Controle de qualidade", "Controle de embalagens", "Estoque", "Produção", "Recebimento", "Análises WMS x MEGA", "Cadastros"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(653, 56)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(183, 154)
        Me.CheckedListBox1.TabIndex = 0
        '
        'cboPermissao
        '
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Location = New System.Drawing.Point(739, 29)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(97, 21)
        Me.cboPermissao.TabIndex = 8
        '
        'FrmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 263)
        Me.Controls.Add(Me.cboPermissao)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.lblPermissao)
        Me.Controls.Add(Me.lblsenha)
        Me.Controls.Add(Me.txtSenhaUsuario)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblEmailUsuario)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNomeUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomeUsuario As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEmailUsuario As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtSenhaUsuario As TextBox
    Friend WithEvents lblsenha As Label
    Friend WithEvents lblPermissao As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents cboPermissao As ComboBox
End Class

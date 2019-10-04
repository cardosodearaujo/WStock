<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSearchWindow
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpar.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpar.Location = New System.Drawing.Point(278, 16)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpar.TabIndex = 11
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(6, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 13)
        Me.lblTitulo.TabIndex = 10
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPesquisar.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesquisar.Location = New System.Drawing.Point(302, 16)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(25, 23)
        Me.btnPesquisar.TabIndex = 7
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(3, 17)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(64, 22)
        Me.txtCodigo.TabIndex = 8
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(68, 17)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(210, 22)
        Me.txtDescricao.TabIndex = 9
        '
        'NewSearchWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtDescricao)
        Me.Name = "NewSearchWindow"
        Me.Size = New System.Drawing.Size(327, 41)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblTitulo As Label
End Class

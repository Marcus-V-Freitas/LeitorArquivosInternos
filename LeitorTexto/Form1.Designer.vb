<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtArquivo = New System.Windows.Forms.TextBox()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtArquivo
        '
        Me.txtArquivo.Location = New System.Drawing.Point(12, 96)
        Me.txtArquivo.Multiline = True
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.Size = New System.Drawing.Size(776, 551)
        Me.txtArquivo.TabIndex = 0
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(33, 34)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(127, 25)
        Me.btnCarregar.TabIndex = 1
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Caminho:"
        '
        'txtProcurar
        '
        Me.txtProcurar.Location = New System.Drawing.Point(465, 34)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(237, 20)
        Me.txtProcurar.TabIndex = 3
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(708, 31)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(90, 25)
        Me.btnProcurar.TabIndex = 4
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 659)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.txtArquivo)
        Me.Name = "Form1"
        Me.Text = "LeitorTexto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArquivo As TextBox
    Friend WithEvents btnCarregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProcurar As TextBox
    Friend WithEvents btnProcurar As Button
End Class

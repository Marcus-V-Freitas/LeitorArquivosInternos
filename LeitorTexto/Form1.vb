Public Class Form1
    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click

        'Abre caixa de dialogo para selecionar o arquivo
        Dim file As OpenFileDialog = New OpenFileDialog
        Dim result As DialogResult = file.ShowDialog

        'Armazena o nome do arquivo
        Dim filename As String
        filename = file.FileName

        'Cria o Stream para ler o arquivo selecionado
        Dim stream As System.IO.StreamReader
        stream = New System.IO.StreamReader(filename)

        'Mostra o texto obtido pelo stream até o fim
        txtArquivo.Text = stream.ReadToEnd

    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click

        Dim position As Integer
        Dim length As Integer
        Dim text As String
        Dim textFind As String

        'Guarda o que estiver no txtArquivo na variavel text
        text = txtArquivo.Text

        'Guarda o valor desejado de busca na variavel textFind
        textFind = txtProcurar.Text

        'Pega a posição do valor desejado no text
        position = text.IndexOf(textFind)

        'Pega o tamanho do valor desejado
        length = textFind.Length

        'Checa se o valor desejado existe com base na posição e tamanho passados e dando um foco caso verdadeiro e uma mensagem de aviso em falso
        If position > -1 Then
            txtArquivo.Select(position, length)
            txtArquivo.Focus()
        Else
            MessageBox.Show("Message not found")
        End If

    End Sub
End Class

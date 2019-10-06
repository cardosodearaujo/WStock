Imports Microsoft.Office.Interop
Module ExportGridToExcel
    Public Enum xlsOption
        xlsSaveAs
        xlsOpen
    End Enum

    Public Sub ExportGridToExcel(ByVal dgvName As DataGridView,
                                 ByVal [option] As xlsOption,
                                 ByVal frm As Form,
                                 ByVal tssExportar As ToolStripStatusLabel,
                                 Optional ByVal fileName As String = "")

        Dim objExcelApp As New Excel.Application()
        Dim objExcelBook As Excel.Workbook
        Dim objExcelSheet As Excel.Worksheet
        Dim sAntigo As String = tssExportar.Text
        Try
            If dgvName.Rows.Count = 0 Then
                MessageBox.Show("Não há dados para exportar!", frm.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If [option] = xlsOption.xlsSaveAs And fileName = String.Empty Then
                MessageBox.Show("É necessário indicar um nome para o arquivo!", frm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            tssExportar.Text = "Aguarde..."

            objExcelBook = objExcelApp.Workbooks.Add
            objExcelSheet = CType(objExcelBook.Worksheets(1), Excel.Worksheet)

            Dim dgvColumnIndex As Int16 = 1
            For Each col As DataGridViewColumn In dgvName.Columns
                objExcelSheet.Cells(1, dgvColumnIndex) = col.HeaderText
                objExcelSheet.Cells(1, dgvColumnIndex).Font.Bold = True
                dgvColumnIndex += 1
            Next

            Dim dgvRowIndex As Integer = 2
            Dim dgvTot As Integer = dgvName.RowCount + 1
            For Each row As DataGridViewRow In dgvName.Rows
                frm.Refresh()
                tssExportar.Text = "Aguarde...Exportando " & dgvRowIndex.ToString & " de " & dgvTot.ToString
                Dim dgvCellIndex As Integer = 1
                For Each cell As DataGridViewCell In row.Cells
                    objExcelSheet.Cells(dgvRowIndex, dgvCellIndex) = cell.Value
                    dgvCellIndex += 1
                Next
                dgvRowIndex += 1
            Next

            objExcelSheet.Columns.AutoFit()

            If [option] = xlsOption.xlsSaveAs Then
                objExcelBook.SaveAs(fileName)
                objExcelBook.Close()
                objExcelApp.Quit()
                MessageBox.Show("Arquivo exportado com sucesso para: " + fileName)
            Else
                objExcelApp.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Erro não identificado. Mensagem original:" + vbNewLine + ex.Message, "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objExcelSheet = Nothing
            objExcelBook = Nothing
            objExcelApp = Nothing
            tssExportar.Text = sAntigo
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub
End Module

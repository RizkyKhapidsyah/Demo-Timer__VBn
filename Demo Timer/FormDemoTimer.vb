Public Class FormDemoTimer
    Public intDetik As Integer = 0

    Private Sub tmrDetik_Tick(sender As Object, e As EventArgs) Handles tmrDetik.Tick
        'memperbarui detik yang ditampilkan
        intDetik += 1
        labelPencacah.Text = intDetik.ToString()
    End Sub

    Private Sub tombolTogglePewaktu_Click(sender As Object, e As EventArgs) Handles tombolTogglePewaktu.Click
        'toggle pewaktu
        If tmrDetik.Enabled = True Then
            tmrDetik.Enabled = False
            tombolTogglePewaktu.Text = "&Mulai Pewaktu"
        Else
            tmrDetik.Enabled = True
            tombolTogglePewaktu.Text = "&Hentikan Pewaktu"
        End If
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
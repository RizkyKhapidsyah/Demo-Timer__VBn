<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemoTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelPencacah = New System.Windows.Forms.Label()
        Me.tombolTogglePewaktu = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.tmrDetik = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pencacah Detik"
        '
        'labelPencacah
        '
        Me.labelPencacah.AutoSize = True
        Me.labelPencacah.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPencacah.Location = New System.Drawing.Point(102, 45)
        Me.labelPencacah.Name = "labelPencacah"
        Me.labelPencacah.Size = New System.Drawing.Size(30, 31)
        Me.labelPencacah.TabIndex = 1
        Me.labelPencacah.Text = "0"
        '
        'tombolTogglePewaktu
        '
        Me.tombolTogglePewaktu.Location = New System.Drawing.Point(12, 99)
        Me.tombolTogglePewaktu.Name = "tombolTogglePewaktu"
        Me.tombolTogglePewaktu.Size = New System.Drawing.Size(89, 38)
        Me.tombolTogglePewaktu.TabIndex = 2
        Me.tombolTogglePewaktu.Text = "&Hentikan Pewaktu"
        Me.tombolTogglePewaktu.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(135, 99)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(89, 38)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "&Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'tmrDetik
        '
        Me.tmrDetik.Enabled = True
        Me.tmrDetik.Interval = 1000
        '
        'FormDemoTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 158)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTogglePewaktu)
        Me.Controls.Add(Me.labelPencacah)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDemoTimer"
        Me.Text = "Demo Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelPencacah As System.Windows.Forms.Label
    Friend WithEvents tombolTogglePewaktu As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents tmrDetik As System.Windows.Forms.Timer

End Class

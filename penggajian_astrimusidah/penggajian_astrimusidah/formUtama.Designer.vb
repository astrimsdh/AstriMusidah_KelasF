<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUtama
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
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnGaji = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(313, 246)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(206, 39)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnGaji
        '
        Me.btnGaji.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGaji.Location = New System.Drawing.Point(313, 201)
        Me.btnGaji.Name = "btnGaji"
        Me.btnGaji.Size = New System.Drawing.Size(206, 39)
        Me.btnGaji.TabIndex = 4
        Me.btnGaji.Text = "Gaji Pegawai"
        Me.btnGaji.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Location = New System.Drawing.Point(313, 156)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(206, 39)
        Me.btnData.TabIndex = 3
        Me.btnData.Text = "Data Pegawai"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'formUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 429)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnGaji)
        Me.Controls.Add(Me.btnData)
        Me.Name = "formUtama"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnGaji As System.Windows.Forms.Button
    Friend WithEvents btnData As System.Windows.Forms.Button

End Class

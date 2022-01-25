<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTeisenda = New System.Windows.Forms.Button()
        Me.txtKilomeetrid = New System.Windows.Forms.TextBox()
        Me.txtMillid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTeisenda
        '
        Me.btnTeisenda.Location = New System.Drawing.Point(270, 206)
        Me.btnTeisenda.Name = "btnTeisenda"
        Me.btnTeisenda.Size = New System.Drawing.Size(245, 43)
        Me.btnTeisenda.TabIndex = 0
        Me.btnTeisenda.Text = "Teisenda millideks"
        Me.btnTeisenda.UseVisualStyleBackColor = True
        '
        'txtKilomeetrid
        '
        Me.txtKilomeetrid.Location = New System.Drawing.Point(270, 164)
        Me.txtKilomeetrid.Name = "txtKilomeetrid"
        Me.txtKilomeetrid.Size = New System.Drawing.Size(245, 26)
        Me.txtKilomeetrid.TabIndex = 1
        '
        'txtMillid
        '
        Me.txtMillid.Location = New System.Drawing.Point(270, 268)
        Me.txtMillid.Name = "txtMillid"
        Me.txtMillid.ReadOnly = True
        Me.txtMillid.Size = New System.Drawing.Size(245, 26)
        Me.txtMillid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "KM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Miles"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMillid)
        Me.Controls.Add(Me.txtKilomeetrid)
        Me.Controls.Add(Me.btnTeisenda)
        Me.Name = "Form1"
        Me.Text = "Esimene Praktikum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTeisenda As Button
    Friend WithEvents txtKilomeetrid As TextBox
    Friend WithEvents txtMillid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMonica = New System.Windows.Forms.Button()
        Me.btnJuan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMonica
        '
        Me.btnMonica.Location = New System.Drawing.Point(617, 12)
        Me.btnMonica.Name = "btnMonica"
        Me.btnMonica.Size = New System.Drawing.Size(152, 23)
        Me.btnMonica.TabIndex = 3
        Me.btnMonica.Text = "Funciones Monica"
        Me.btnMonica.UseVisualStyleBackColor = True
        '
        'btnJuan
        '
        Me.btnJuan.Location = New System.Drawing.Point(12, 12)
        Me.btnJuan.Name = "btnJuan"
        Me.btnJuan.Size = New System.Drawing.Size(152, 23)
        Me.btnJuan.TabIndex = 2
        Me.btnJuan.Text = "Funciones Juan"
        Me.btnJuan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMonica)
        Me.Controls.Add(Me.btnJuan)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMonica As Button
    Friend WithEvents btnJuan As Button
End Class

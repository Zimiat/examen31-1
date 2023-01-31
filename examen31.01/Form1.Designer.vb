<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_wachtwoord = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(476, 117)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 29)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(237, 117)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(187, 27)
        Me.txt_login.TabIndex = 1
        '
        'txt_wachtwoord
        '
        Me.txt_wachtwoord.Location = New System.Drawing.Point(237, 150)
        Me.txt_wachtwoord.Name = "txt_wachtwoord"
        Me.txt_wachtwoord.Size = New System.Drawing.Size(187, 27)
        Me.txt_wachtwoord.TabIndex = 2
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(476, 152)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(94, 29)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(237, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(157, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Wachtwoord tonen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_wachtwoord)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.btn_login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_wachtwoord As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(269, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Distritos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Atualizar População "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Apresentar Listagem "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Apresentar número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Apresentar dados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apresentar gáfico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(49, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Percentagem de territorio"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Image = Global.Distritos.My.Resources.Resources.greens
        Me.PictureBox2.Location = New System.Drawing.Point(473, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Distritos.My.Resources.Resources.circle
        Me.PictureBox1.Location = New System.Drawing.Point(726, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Distritos.My.Resources.Resources.menu
        Me.PictureBox4.Location = New System.Drawing.Point(29, 42)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(31, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 38)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "X"
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 7
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String() {"Aveiro", "Aã§ores", "Braga", "Braganã§a", "Beja", "Castelobranco", "Coimbra", "Ã‰vora", "Faro", "Guarda", "Lisboa", "Leiria", "Madeira", "Porto", "Portalegre", "Santarem", "Setãºbal", "Vianadocastelo", "Vilareal", "Viseu"}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(367, 102)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(359, 35)
        Me.BunifuDropdown1.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(367, 154)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(359, 271)
        Me.TextBox1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "t"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents TextBox1 As TextBox
End Class

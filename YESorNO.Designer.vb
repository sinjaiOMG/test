<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YESorNO
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bno = New System.Windows.Forms.Button()
        Me.byes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.bno)
        Me.Panel1.Controls.Add(Me.byes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 280)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Honeydew
        Me.Label4.Location = New System.Drawing.Point(54, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "''"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 257
        Me.Label3.Text = "Label3"
        '
        'bno
        '
        Me.bno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bno.Font = New System.Drawing.Font("Phetsarath OT", 13.0!, System.Drawing.FontStyle.Bold)
        Me.bno.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.bno.Location = New System.Drawing.Point(282, 200)
        Me.bno.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.bno.Name = "bno"
        Me.bno.Size = New System.Drawing.Size(127, 46)
        Me.bno.TabIndex = 256
        Me.bno.Text = "ຍົກເລີກ"
        Me.bno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bno.UseVisualStyleBackColor = True
        '
        'byes
        '
        Me.byes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.byes.Font = New System.Drawing.Font("Phetsarath OT", 13.0!, System.Drawing.FontStyle.Bold)
        Me.byes.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.byes.Location = New System.Drawing.Point(118, 200)
        Me.byes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.byes.Name = "byes"
        Me.byes.Size = New System.Drawing.Size(127, 46)
        Me.byes.TabIndex = 254
        Me.byes.Text = "ຢືນຢັນ"
        Me.byes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.byes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Phetsarath OT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(-3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(538, 280)
        Me.Label2.TabIndex = 253
        Me.Label2.Text = "ເກີດຂໍ້ຜິດພາດ "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 51)
        Me.Panel2.TabIndex = 256
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.clinic_project.My.Resources.Resources.warning
        Me.PictureBox2.Location = New System.Drawing.Point(331, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 256
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Phetsarath OT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(201, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ແຈ້ງເຕືອນ "
        '
        'YESorNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(542, 286)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YESorNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YESorNO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents byes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents bno As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPilotView = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn23mmCannons = New System.Windows.Forms.Button()
        Me.btn37mmCannon = New System.Windows.Forms.Button()
        Me.btn100kgBomb = New System.Windows.Forms.Button()
        Me.btnRockets = New System.Windows.Forms.Button()
        Me.lbl23mm = New System.Windows.Forms.Label()
        Me.lblBomb = New System.Windows.Forms.Label()
        Me.lbl37mm = New System.Windows.Forms.Label()
        Me.lblRockets = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picPilotView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPilotView
        '
        Me.picPilotView.BackgroundImage = CType(resources.GetObject("picPilotView.BackgroundImage"), System.Drawing.Image)
        Me.picPilotView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPilotView.Location = New System.Drawing.Point(213, 54)
        Me.picPilotView.Name = "picPilotView"
        Me.picPilotView.Size = New System.Drawing.Size(374, 284)
        Me.picPilotView.TabIndex = 0
        Me.picPilotView.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(362, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Weaponry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(650, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Controls"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(68, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Misc."
        '
        'btn23mmCannons
        '
        Me.btn23mmCannons.Location = New System.Drawing.Point(222, 372)
        Me.btn23mmCannons.Name = "btn23mmCannons"
        Me.btn23mmCannons.Size = New System.Drawing.Size(97, 23)
        Me.btn23mmCannons.TabIndex = 4
        Me.btn23mmCannons.Text = "23mm Cannon"
        Me.btn23mmCannons.UseVisualStyleBackColor = True
        '
        'btn37mmCannon
        '
        Me.btn37mmCannon.Location = New System.Drawing.Point(427, 372)
        Me.btn37mmCannon.Name = "btn37mmCannon"
        Me.btn37mmCannon.Size = New System.Drawing.Size(97, 23)
        Me.btn37mmCannon.TabIndex = 5
        Me.btn37mmCannon.Text = "37mm Cannon"
        Me.btn37mmCannon.UseVisualStyleBackColor = True
        '
        'btn100kgBomb
        '
        Me.btn100kgBomb.Location = New System.Drawing.Point(222, 412)
        Me.btn100kgBomb.Name = "btn100kgBomb"
        Me.btn100kgBomb.Size = New System.Drawing.Size(97, 23)
        Me.btn100kgBomb.TabIndex = 6
        Me.btn100kgBomb.Text = "100kg Bomb"
        Me.btn100kgBomb.UseVisualStyleBackColor = True
        '
        'btnRockets
        '
        Me.btnRockets.Location = New System.Drawing.Point(427, 412)
        Me.btnRockets.Name = "btnRockets"
        Me.btnRockets.Size = New System.Drawing.Size(97, 23)
        Me.btnRockets.TabIndex = 7
        Me.btnRockets.Text = "Rockets"
        Me.btnRockets.UseVisualStyleBackColor = True
        '
        'lbl23mm
        '
        Me.lbl23mm.AutoSize = True
        Me.lbl23mm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl23mm.Location = New System.Drawing.Point(337, 376)
        Me.lbl23mm.Name = "lbl23mm"
        Me.lbl23mm.Size = New System.Drawing.Size(28, 15)
        Me.lbl23mm.TabIndex = 8
        Me.lbl23mm.Text = "200"
        '
        'lblBomb
        '
        Me.lblBomb.AutoSize = True
        Me.lblBomb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBomb.Location = New System.Drawing.Point(337, 416)
        Me.lblBomb.Name = "lblBomb"
        Me.lblBomb.Size = New System.Drawing.Size(14, 15)
        Me.lblBomb.TabIndex = 9
        Me.lblBomb.Text = "2"
        '
        'lbl37mm
        '
        Me.lbl37mm.AutoSize = True
        Me.lbl37mm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl37mm.Location = New System.Drawing.Point(546, 376)
        Me.lbl37mm.Name = "lbl37mm"
        Me.lbl37mm.Size = New System.Drawing.Size(21, 15)
        Me.lbl37mm.TabIndex = 10
        Me.lbl37mm.Text = "40"
        '
        'lblRockets
        '
        Me.lblRockets.AutoSize = True
        Me.lblRockets.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRockets.Location = New System.Drawing.Point(546, 415)
        Me.lblRockets.Name = "lblRockets"
        Me.lblRockets.Size = New System.Drawing.Size(14, 15)
        Me.lblRockets.TabIndex = 11
        Me.lblRockets.Text = "6"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.Font = New System.Drawing.Font("Liberation Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(36, 100)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(115, 210)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(286, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(238, 26)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "MiG-15 Pilot"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblRockets)
        Me.Controls.Add(Me.lbl37mm)
        Me.Controls.Add(Me.lblBomb)
        Me.Controls.Add(Me.lbl23mm)
        Me.Controls.Add(Me.btnRockets)
        Me.Controls.Add(Me.btn100kgBomb)
        Me.Controls.Add(Me.btn37mmCannon)
        Me.Controls.Add(Me.btn23mmCannons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPilotView)
        Me.Name = "Form1"
        Me.Text = "MiG-15 Pilot (New)"
        CType(Me.picPilotView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPilotView As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn23mmCannons As Button
    Friend WithEvents btn37mmCannon As Button
    Friend WithEvents btn100kgBomb As Button
    Friend WithEvents btnRockets As Button
    Friend WithEvents lbl23mm As Label
    Friend WithEvents lblBomb As Label
    Friend WithEvents lbl37mm As Label
    Friend WithEvents lblRockets As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblTitle As Label
End Class

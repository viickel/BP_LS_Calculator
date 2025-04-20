<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        buttonExportCSV = New Button()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 46)
        Button1.TabIndex = 0
        Button1.Text = "Ouvrir fichier Cotcot"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(250, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 46)
        Button2.TabIndex = 3
        Button2.Text = "Créer Fichier Classement "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' buttonExportCSV
        ' 
        buttonExportCSV.Location = New Point(131, 12)
        buttonExportCSV.Name = "buttonExportCSV"
        buttonExportCSV.Size = New Size(113, 46)
        buttonExportCSV.TabIndex = 2
        buttonExportCSV.Text = "Exporter en CSV"
        buttonExportCSV.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.ASL_FFE___Logo_noir_BANNIERE
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(430, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(243, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(683, 359)
        DataGridView1.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(buttonExportCSV)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 76)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(685, 361)
        Panel2.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(685, 437)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonExportCSV As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class

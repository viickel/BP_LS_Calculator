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
        DataGridView1 = New DataGridView()
        Nom = New DataGridViewTextBoxColumn()
        Prenom = New DataGridViewTextBoxColumn()
        Licence = New DataGridViewTextBoxColumn()
        Cotation = New DataGridViewTextBoxColumn()
        NbVictoire = New DataGridViewTextBoxColumn()
        SommePoints = New DataGridViewTextBoxColumn()
        TieBreaker = New DataGridViewTextBoxColumn()
        SplitContainer1 = New SplitContainer()
        buttonExportCSV = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nom, Prenom, Licence, Cotation, NbVictoire, SommePoints, TieBreaker})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(649, 365)
        DataGridView1.TabIndex = 4
        ' 
        ' Nom
        ' 
        Nom.DataPropertyName = "Nom"
        Nom.HeaderText = "Nom"
        Nom.Name = "Nom"
        ' 
        ' Prenom
        ' 
        Prenom.DataPropertyName = "Prenom"
        Prenom.HeaderText = "Prénom"
        Prenom.Name = "Prenom"
        ' 
        ' Licence
        ' 
        Licence.DataPropertyName = "NumLicence"
        Licence.HeaderText = "Licence"
        Licence.Name = "Licence"
        ' 
        ' Cotation
        ' 
        Cotation.DataPropertyName = "Stats.PointsCotation"
        Cotation.HeaderText = "Cotation"
        Cotation.Name = "Cotation"
        ' 
        ' NbVictoire
        ' 
        NbVictoire.DataPropertyName = "Stats.NbVictoires"
        NbVictoire.HeaderText = "NbVictoire"
        NbVictoire.Name = "NbVictoire"
        ' 
        ' SommePoints
        ' 
        SommePoints.DataPropertyName = "Stats.SommePoints"
        SommePoints.HeaderText = "SommePoints"
        SommePoints.Name = "SommePoints"
        ' 
        ' TieBreaker
        ' 
        TieBreaker.DataPropertyName = "Stats.TieBreaker"
        TieBreaker.HeaderText = "TieBreaker"
        TieBreaker.Name = "TieBreaker"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(buttonExportCSV)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(Button1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(DataGridView1)
        SplitContainer1.Size = New Size(649, 450)
        SplitContainer1.SplitterDistance = 81
        SplitContainer1.TabIndex = 5
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
        PictureBox1.Image = My.Resources.Resources.ASL_FFE___Logo_noir_BANNIERE
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(400, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(243, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 450)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prenom As DataGridViewTextBoxColumn
    Friend WithEvents Licence As DataGridViewTextBoxColumn
    Friend WithEvents Cotation As DataGridViewTextBoxColumn
    Friend WithEvents NbVictoire As DataGridViewTextBoxColumn
    Friend WithEvents SommePoints As DataGridViewTextBoxColumn
    Friend WithEvents TieBreaker As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonExportCSV As Button

End Class

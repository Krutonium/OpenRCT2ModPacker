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
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.txtDesciption = New System.Windows.Forms.RichTextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtModName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OFD_PreviewImg = New System.Windows.Forms.OpenFileDialog()
        Me.OBD_ModDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdSelectImg = New System.Windows.Forms.Button()
        Me.cmdSelectDir = New System.Windows.Forms.Button()
        Me.SFD_Zip = New System.Windows.Forms.SaveFileDialog()
        Me.cmdSaveZip = New System.Windows.Forms.Button()
        Me.cmdInstallExample = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(403, 166)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(75, 28)
        Me.cmdTest.TabIndex = 6
        Me.cmdTest.Text = "Pack"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'txtDesciption
        '
        Me.txtDesciption.Location = New System.Drawing.Point(12, 64)
        Me.txtDesciption.Name = "txtDesciption"
        Me.txtDesciption.Size = New System.Drawing.Size(466, 96)
        Me.txtDesciption.TabIndex = 2
        Me.txtDesciption.Text = ""
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(12, 24)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(232, 20)
        Me.txtAuthor.TabIndex = 0
        '
        'txtModName
        '
        Me.txtModName.Location = New System.Drawing.Point(250, 24)
        Me.txtModName.Name = "txtModName"
        Me.txtModName.Size = New System.Drawing.Size(228, 20)
        Me.txtModName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mod Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description"
        '
        'OFD_PreviewImg
        '
        Me.OFD_PreviewImg.DefaultExt = "png"
        Me.OFD_PreviewImg.FileName = "Preview_Image"
        '
        'cmdSelectImg
        '
        Me.cmdSelectImg.Location = New System.Drawing.Point(12, 166)
        Me.cmdSelectImg.Name = "cmdSelectImg"
        Me.cmdSelectImg.Size = New System.Drawing.Size(127, 28)
        Me.cmdSelectImg.TabIndex = 3
        Me.cmdSelectImg.Text = "Select Preview Image"
        Me.cmdSelectImg.UseVisualStyleBackColor = True
        '
        'cmdSelectDir
        '
        Me.cmdSelectDir.Location = New System.Drawing.Point(145, 166)
        Me.cmdSelectDir.Name = "cmdSelectDir"
        Me.cmdSelectDir.Size = New System.Drawing.Size(121, 28)
        Me.cmdSelectDir.TabIndex = 4
        Me.cmdSelectDir.Text = "Select Mod Directory"
        Me.cmdSelectDir.UseVisualStyleBackColor = True
        '
        'SFD_Zip
        '
        Me.SFD_Zip.DefaultExt = "*.RCT2Mod|OpenRCT2 Mod Pack"
        '
        'cmdSaveZip
        '
        Me.cmdSaveZip.Location = New System.Drawing.Point(272, 166)
        Me.cmdSaveZip.Name = "cmdSaveZip"
        Me.cmdSaveZip.Size = New System.Drawing.Size(111, 28)
        Me.cmdSaveZip.TabIndex = 5
        Me.cmdSaveZip.Text = "Mod Save Location"
        Me.cmdSaveZip.UseVisualStyleBackColor = True
        '
        'cmdInstallExample
        '
        Me.cmdInstallExample.Location = New System.Drawing.Point(12, 201)
        Me.cmdInstallExample.Name = "cmdInstallExample"
        Me.cmdInstallExample.Size = New System.Drawing.Size(127, 28)
        Me.cmdInstallExample.TabIndex = 7
        Me.cmdInstallExample.Text = "Mod Install Example"
        Me.cmdInstallExample.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 241)
        Me.Controls.Add(Me.cmdInstallExample)
        Me.Controls.Add(Me.cmdSaveZip)
        Me.Controls.Add(Me.cmdSelectDir)
        Me.Controls.Add(Me.cmdSelectImg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtModName)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtDesciption)
        Me.Controls.Add(Me.cmdTest)
        Me.Name = "Form1"
        Me.Text = "OpenRCT2 Mod Packer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents txtDesciption As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtModName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OFD_PreviewImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OBD_ModDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdSelectImg As System.Windows.Forms.Button
    Friend WithEvents cmdSelectDir As System.Windows.Forms.Button
    Friend WithEvents SFD_Zip As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdSaveZip As System.Windows.Forms.Button
    Friend WithEvents cmdInstallExample As System.Windows.Forms.Button

End Class

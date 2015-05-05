Imports ORCT2ModPacker
Public Class Form1
    Dim Modd As New ModPack
    Dim Zip As String
    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        Me.Text = "Packing and Saving..."
        Me.Enabled = False
        Modd.Description = txtDesciption.Text
        Modd.ModName = txtModName.Text
        Modd.Directory = OBD_ModDir.SelectedPath
        Modd.PreviewImage = OFD_PreviewImg.FileName
        Modd.Author = txtAuthor.Text
        Modd.ZipLocation = Zip
        Dim Result = (Modd.PackMod())
        If Result = True Then
            MsgBox("Success!", MsgBoxStyle.Information, "It Worked!")
            Me.Enabled = True
        ElseIf Result = False Then
            MsgBox(Modd.LastErrorReason, MsgBoxStyle.Critical, "An Error Occured")
            Me.Enabled = True
        End If
        Me.Text = "OpenRCT2 Mod Packer"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Mod Packer Version 0.0.2 " & vbNewLine & _
        '       "5/4/2015" & vbNewLine & _
        '       "Created by Kenton Boadway" & vbNewLine & _
        '       "DO NOT DISTRIBUTE EXCEPT WITH PERMISSION. NOT FINAL VERSION." & vbNewLine & _
        '       "More info: http://www.openrct.net/", MsgBoxStyle.Exclamation, "WARNING")
    End Sub

    Private Sub cmdSelectImg_Click(sender As Object, e As EventArgs) Handles cmdSelectImg.Click
        OFD_PreviewImg.Filter = ("PNG Files|*.png")
        OFD_PreviewImg.ShowDialog()
    End Sub

    Private Sub cmdSelectDir_Click(sender As Object, e As EventArgs) Handles cmdSelectDir.Click
        OBD_ModDir.ShowDialog()
    End Sub

    Private Sub cmdSaveZip_Click(sender As Object, e As EventArgs) Handles cmdSaveZip.Click
        SFD_Zip.ShowDialog()
        SFD_Zip.DefaultExt = "*.RCT2Mod"
        If SFD_Zip.FileName.ToUpper.EndsWith(".RCT2MOD") = False Then
            Zip = SFD_Zip.FileName & ".RCT2Mod"
        Else
            Zip = SFD_Zip.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdInstallExample.Click
        MsgBox("Not Error Catched, make sure you select a file. This is for testing only, to verify that your mod packed correctly. It will install the mod to a folder called Example on your Desktop.")
        OFD_PreviewImg.Filter = ("RCT2Mod|*.RCT2Mod")
        Dim FooBar As New UnPackMod
        OFD_PreviewImg.ShowDialog()
        FooBar.GetInfoFromMod(OFD_PreviewImg.FileName)
        Dim Response = MsgBox("Install Mod " & FooBar.ModName & " From " & FooBar.Author & "?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.Yes Then
            FooBar.UnPackMod(OFD_PreviewImg.FileName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Example")
        End If
        MsgBox("Done!")
    End Sub
End Class

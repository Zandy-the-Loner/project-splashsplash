Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim aForm As New Form1
        Process.Start(AppDomain.CurrentDomain.BaseDirectory & "\example.exe")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Dim aForm As New Form1
        Process.Start(AppDomain.CurrentDomain.BaseDirectory & "\example.exe")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class

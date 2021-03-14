Public Class Form1
    Private Sub main(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarPanel()
    End Sub
    Private Sub OcultarPanel()
        PanelPago.Visible = False
        PanelPerfil.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False

    End Sub
    Private Sub Abrir(submenu As Panel)
        If submenu.Visible = False Then
            OcultarPanel()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub botonPerfil_Click(sender As Object, e As EventArgs) Handles botonPerfil.Click
        Abrir(PanelPerfil)

    End Sub

    Private Sub botonMetodosDePago_Click(sender As Object, e As EventArgs) Handles botonMetodosDePago.Click
        Abrir(PanelPago)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Abrir(Panel3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Abrir(Panel4)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class

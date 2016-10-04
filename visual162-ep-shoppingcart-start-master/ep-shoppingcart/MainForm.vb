Public Class MainForm
    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False

    Private CantHL1 As Integer = 0
    Private CantHL2 As Integer = 0
    Private CantHL3 As Integer = 0
    Private CantHL4 As Integer = 0

    Private CantML1 As Integer = 0
    Private CantML2 As Integer = 0
    Private CantML3 As Integer = 0
    Private CantML4 As Integer = 0

    Private CantCL1 As Integer = 0
    Private CantCL2 As Integer = 0
    Private CantCL3 As Integer = 0
    Private CantCL4 As Integer = 0

    Private CantAL1 As Integer = 0
    Private CantAL2 As Integer = 0
    Private CantAL3 As Integer = 0
    Private CantAL4 As Integer = 0

    Private Total As Integer = 0

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click

        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Hombres
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_01_small
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_02_small
        Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_03_small
        Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_04_small

        ' Datos Del Panel Hombres
        lblTitulo.Text = "End Poplin Shirt"
        lblPrecio.Text = "$85"

        ' Estado Paneles
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black


            ' Talla XS
            lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Estableciendo Etiquetas Cantidades
        txtCantidad.Text = CantHL1.ToString()
        txtCantidad.Text = CantHL2.ToString()
        txtCantidad.Text = CantHL3.ToString()
        txtCantidad.Text = CantHL4.ToString()

    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click

        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Mujeres
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.m_01_01_small
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.m_01_02_small
        Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.m_01_03_small
        Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.m_01_04_small

        ' Datos Del Panel Mujeres
        lblTitulo.Text = "Nicola Blouse"
        lblPrecio.Text = "$120"

        ' Estado Paneles
        PanelH = False
            PanelM = True
            PanelC = False
            PanelA = False

            ' Modificando Color de Botones 
            btnHombres.ForeColor = Color.Black
            btnMujeres.ForeColor = Color.SteelBlue
            btnCalzado.ForeColor = Color.Black
            btnAccesorios.ForeColor = Color.Black

        ' Talla XS
        lblTallaP1.Text = "XS"
            lblTallaP1.ForeColor = Color.Silver

            ' Talla S
            lblTallaP2.Text = "S"
            lblTallaP2.ForeColor = Color.Black

            ' Talla M
            lblTallaP3.Text = "M"
            lblTallaP3.ForeColor = Color.Black

            ' Talla L
            lblTallaP4.Text = "L"
            lblTallaP4.ForeColor = Color.Black

            ' Talla XL
            lblTallaP5.Text = "XL"
            lblTallaP5.ForeColor = Color.Silver

    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click

        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Calzado
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.c_01_01_small
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.c_01_02_small
        Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.c_01_03_small
        Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.c_01_04_small

        ' Datos Del Panel De Calzado
        lblTitulo.Text = "Philip 1d Trainers"
        lblPrecio.Text = "$55"


        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = True
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        ' Talla 37
        lblTallaP1.Text = "37"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla 38
        lblTallaP2.Text = "38"
        lblTallaP2.ForeColor = Color.Black

        ' Talla 40
        lblTallaP3.Text = "40"
        lblTallaP3.ForeColor = Color.Black

        ' Talla 41
        lblTallaP4.Text = "41"
        lblTallaP4.ForeColor = Color.Black

        ' Talla 42
        lblTallaP5.Text = "42"
        lblTallaP5.ForeColor = Color.Silver
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Accesorios
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.a_01_01_small
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.a_02_01_small
        Me.PictureBox3.Image = Nothing
        Me.PictureBox4.Image = Nothing

        ' Datos Del Panel De Accesorios
        lblTitulo.Text = "Strap Watch 1791"
        lblPrecio.Text = "$175"

        ' Estado Paneles
        PanelH = False
        PanelM = False
        PanelC = False
        PanelA = True

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        ' Talla XS
        lblTallaP1.Text = "-"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "-"
        lblTallaP2.ForeColor = Color.Silver

        ' Talla M
        lblTallaP3.Text = "-"
        lblTallaP3.ForeColor = Color.Silver

        ' Talla L
        lblTallaP4.Text = "-"
        lblTallaP4.ForeColor = Color.Silver

        ' Talla XL
        lblTallaP5.Text = "-"
        lblTallaP5.ForeColor = Color.Silver
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("GRACIAS POR SU COMPRA", MsgBoxStyle.Information, "Tommy Hilfiger")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelH Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_01_normal
        ElseIf PanelM Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.m_02_01_normal
        ElseIf PanelC Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.I_5054618311879_50_20160419
        ElseIf PanelA Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.a_01_01_normal1
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If PanelH Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_02_normal

        ElseIf PanelM Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.m_02_02_normal
        ElseIf PanelC Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.I_5054618311879_51_20160419
        ElseIf PanelA Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.a_02_01_normal
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If PanelH Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_03_normal

        ElseIf PanelM Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.m_02_03_normal
        ElseIf PanelC Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.I_5054618311879_52_20160419
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If PanelH Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_04_normal

        ElseIf PanelM Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.m_02_04_normal
        ElseIf PanelC Then
            Me.PictureBox6.Image = Global.ep_shoppingcart.My.Resources.Resources.I_5054618311879_54_20160419
        End If
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        ' Cambiando al siguiente

        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Hombres
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.h_02_01_small
            Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.h_02_02_small
            Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.h_02_03_small
            Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.h_02_04_small

            ' Datos Del Panel Hombres
            lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
            lblPrecio.Text = "$110"

            ' Estado Paneles
            PanelH = True
            PanelM = False
            PanelC = False
            PanelA = False

            ' Modificando Color de Botones 
            btnHombres.ForeColor = Color.SteelBlue
            btnMujeres.ForeColor = Color.Black
            btnCalzado.ForeColor = Color.Black
            btnAccesorios.ForeColor = Color.Black


            ' Talla XS
            lblTallaP1.Text = "XS"
            lblTallaP1.ForeColor = Color.Silver

            ' Talla S
            lblTallaP2.Text = "S"
            lblTallaP2.ForeColor = Color.Black

            ' Talla M
            lblTallaP3.Text = "M"
            lblTallaP3.ForeColor = Color.Black

            ' Talla L
            lblTallaP4.Text = "L"
            lblTallaP4.ForeColor = Color.Black

            ' Talla XL
            lblTallaP5.Text = "XL"
            lblTallaP5.ForeColor = Color.Silver


    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        'Cambiando Al Anterior
        'Limpiando Panel De Imagen Grande
        Me.PictureBox6.Image = Nothing

        ' Panel De Imagenes De Hombres
        Me.PictureBox1.Image = Global.ep_shoppingcart.My.Resources.Resources.h_03_01_small
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.h_03_02_small
        Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.h_03_03_small
        Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.h_03_04_small

        ' Datos Del Panel Hombres
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        lblPrecio.Text = "$95"

        ' Estado Paneles
        PanelH = True
        PanelM = False
        PanelC = False
        PanelA = False

        ' Modificando Color de Botones 
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black


        ' Talla XS
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver

        ' Talla S
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black

        ' Talla M
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black

        ' Talla L
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black

        ' Talla XL
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver


    End Sub
End Class
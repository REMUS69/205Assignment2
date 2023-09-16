Public Class Form1
    Dim quaBur, quaSpag, quaPizza, quaFries, quaCoke, quaSprite, quaIced, quaOrange As Integer

    Private Sub CalculateTotalPrice()
        Dim burgerPrice As Integer = 50
        Dim spagPrice As Integer = 100
        Dim pizzaPrice As Integer = 500
        Dim friesPrice As Integer = 40
        Dim cokePrice As Integer = 30
        Dim spritePrice As Integer = 30
        Dim icedPrice As Integer = 30
        Dim orangePrice As Integer = 50

        Dim totalSum As Integer = 0

        If chkBurger.Checked Then
            totalSum += quaBur * burgerPrice
        End If

        If chkSpag.Checked Then
            totalSum += quaSpag * spagPrice
        End If

        If chkPizza.Checked Then
            totalSum += quaPizza * pizzaPrice
        End If

        If chkFries.Checked Then
            totalSum += quaFries * friesPrice
        End If

        If chkCoke.Checked Then
            totalSum += quaCoke * cokePrice
        End If

        If chkSprite.Checked Then
            totalSum += quaSprite * spritePrice
        End If

        If chkIced.Checked Then
            totalSum += quaIced * icedPrice
        End If

        If chkOrange.Checked Then
            totalSum += quaOrange * orangePrice
        End If

        txtTotal.Text = totalSum.ToString()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub chkBurger_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurger.CheckedChanged
        If chkBurger.Checked Then
            txtBurgerqua.Text = 1
            btnBurgerplus.Enabled = True
            btnBurgermin.Enabled = True


        Else
            txtBurgerqua.Clear()
            quaBur = 0
        End If
    End Sub

    Private Sub chkSpag_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpag.CheckedChanged
        If chkSpag.Checked Then
            txtSpagqua.Text = 1
            btnSpagplus.Enabled = True
            btnSpagmin.Enabled = True


        Else
            txtSpagqua.Clear()
            quaSpag = 0
        End If
    End Sub

    Private Sub chkPizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPizza.CheckedChanged
        If chkPizza.Checked Then
            txtPizzaqua.Text = 1
            btnPizzaplus.Enabled = True
            btnPizzamin.Enabled = True


        Else
            txtPizzaqua.Clear()
            quaPizza = 0
        End If
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            txtFriesqua.Text = 1
            btnFriesplus.Enabled = True
            btnFriesmin.Enabled = True


        Else
            txtFriesqua.Clear()
            quaFries = 0
        End If
    End Sub

    Private Sub chkCoke_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoke.CheckedChanged
        If chkCoke.Checked Then
            txtCokequa.Text = 1
            btnCokeplus.Enabled = True
            btnCokemin.Enabled = True


        Else
            txtCokequa.Clear()
            quaCoke = 0
        End If
    End Sub

    Private Sub chkSprite_CheckedChanged(sender As Object, e As EventArgs) Handles chkSprite.CheckedChanged
        If chkSprite.Checked Then
            txtSpritequa.Text = 1
            btnSpriteplus.Enabled = True
            btnSpritemin.Enabled = True


        Else
            txtSpritequa.Clear()
            quaSprite = 0
        End If
    End Sub

    Private Sub chkIced_CheckedChanged(sender As Object, e As EventArgs) Handles chkIced.CheckedChanged
        If chkIced.Checked Then
            txtIcedqua.Text = 1
            btnIcedplus.Enabled = True
            btnIcedmin.Enabled = True


        Else
            txtIcedqua.Clear()
            quaIced = 0
        End If
    End Sub

    Private Sub chkOrange_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrange.CheckedChanged
        If chkOrange.Checked Then
            txtOrangequa.Text = 1
            btnOrangeplus.Enabled = True
            btnOrangemin.Enabled = True


        Else
            txtOrangequa.Clear()
            quaOrange = 0
        End If
    End Sub

    Private Sub btnBurgerplus_Click(sender As Object, e As EventArgs) Handles btnBurgerplus.Click
        quaBur = quaBur + 1

        txtBurgerqua.Text = quaBur

    End Sub

    Private Sub btnSpagplus_Click(sender As Object, e As EventArgs) Handles btnSpagplus.Click
        quaSpag = quaSpag + 1

        txtSpagqua.Text = quaSpag

    End Sub

    Private Sub btnPizzaplus_Click(sender As Object, e As EventArgs) Handles btnPizzaplus.Click
        quaPizza = quaPizza + 1

        txtPizzaqua.Text = quaPizza

    End Sub

    Private Sub btnFriesplus_Click(sender As Object, e As EventArgs) Handles btnFriesplus.Click
        quaFries = quaFries + 1

        txtFriesqua.Text = quaFries
    End Sub

    Private Sub btnCokeplus_Click(sender As Object, e As EventArgs) Handles btnCokeplus.Click
        quaCoke = quaCoke + 1

        txtCokequa.Text = quaCoke
    End Sub

    Private Sub btnSpriteplus_Click(sender As Object, e As EventArgs) Handles btnSpriteplus.Click
        quaSprite = quaSprite + 1

        txtSpritequa.Text = quaSprite
    End Sub

    Private Sub btnIcedplus_Click(sender As Object, e As EventArgs) Handles btnIcedplus.Click
        quaIced = quaIced + 1

        txtIcedqua.Text = quaIced
    End Sub

    Private Sub btnOrangeplus_Click(sender As Object, e As EventArgs) Handles btnOrangeplus.Click
        quaOrange = quaOrange + 1

        txtOrangequa.Text = quaOrange
    End Sub

    Private Sub btnBurgermin_Click(sender As Object, e As EventArgs) Handles btnBurgermin.Click
        quaBur = quaBur - 1

        txtBurgerqua.Text = quaBur
        If quaBur < 1 Then
            chkBurger.Checked = False
        End If
    End Sub

    Private Sub btnSpagmin_Click(sender As Object, e As EventArgs) Handles btnSpagmin.Click
        quaSpag = quaSpag - 1

        txtSpagqua.Text = quaSpag
        If quaSpag < 1 Then
            chkSpag.Checked = False
        End If
    End Sub

    Private Sub btnPizzamin_Click(sender As Object, e As EventArgs) Handles btnPizzamin.Click
        quaPizza = quaPizza - 1

        txtPizzaqua.Text = quaPizza
        If quaPizza < 1 Then
            chkPizza.Checked = False
        End If
    End Sub

    Private Sub btnFriesmin_Click(sender As Object, e As EventArgs) Handles btnFriesmin.Click
        quaFries = quaFries - 1

        txtFriesqua.Text = quaFries
        If quaFries < 1 Then
            chkFries.Checked = False
        End If
    End Sub

    Private Sub btnCokemin_Click(sender As Object, e As EventArgs) Handles btnCokemin.Click
        quaCoke = quaCoke - 1

        txtCokequa.Text = quaCoke
        If quaCoke < 1 Then
            chkCoke.Checked = False
        End If
    End Sub

    Private Sub btnSpritemin_Click(sender As Object, e As EventArgs) Handles btnSpritemin.Click
        quaSprite = quaSprite - 1

        txtSpritequa.Text = quaSprite
        If quaSprite < 1 Then
            chkSprite.Checked = False
        End If
    End Sub

    Private Sub btnIcedmin_Click(sender As Object, e As EventArgs) Handles btnIcedmin.Click
        quaIced = quaIced - 1

        txtIcedqua.Text = quaIced
        If quaIced < 1 Then
            chkIced.Checked = False
        End If
    End Sub

    Private Sub btnOrangemin_Click(sender As Object, e As EventArgs) Handles btnOrangemin.Click
        quaOrange = quaOrange - 1

        txtOrangequa.Text = quaOrange
        If quaOrange < 1 Then
            chkOrange.Checked = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim Answer As DialogResult

        Answer = MessageBox.Show("are you sure you want to clear?", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Answer = DialogResult.Yes Then
            txtBurgerqua.Clear()
            txtCokequa.Clear()
            txtFriesqua.Clear()
            txtPayment.Clear()
            txtPizzaqua.Clear()
            txtSpagqua.Clear()
            txtSpritequa.Clear()
            txtChange.Clear()
            txtTotal.Clear()
            chkBurger.Checked() = False
            chkSpag.Checked() = False
            chkPizza.Checked() = False
            chkFries.Checked() = False
            chkCoke.Checked() = False
            chkSprite.Checked() = False
            chkIced.Checked() = False
            chkOrange.Checked() = False



        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        CalculateTotalPrice()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim totalSum As Integer
        Dim paymentAmount As Integer

        If Integer.TryParse(txtTotal.Text, totalSum) AndAlso Integer.TryParse(txtPayment.Text, paymentAmount) Then
            Dim change As Integer = paymentAmount - totalSum
            txtChange.Text = change.ToString()
        End If
    End Sub
End Class

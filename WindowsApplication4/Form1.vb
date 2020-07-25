Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox(System.Math.Ceiling(1.2))

        'MsgBox(Screen.PrimaryScreen.Bounds.Width * Screen.PrimaryScreen.Bounds.Height + 54)


        Dim Red As Byte = 255
        Dim Green As Byte = 150
        Dim Blue As Byte = 50

        Dim RSmall As Byte = IIf(Red < 240, Red / 32, 7)
        Dim GSmall As Byte = IIf(Green < 240, Green / 32, 7)
        Dim BSmall As Byte = IIf(Blue < 224, Blue / 64, 3)

        Dim RShifted As Byte = RSmall
        Dim GShifted As Byte = GSmall << 3
        Dim BShifted As Byte = BSmall << 6


        Dim ByteColor As Byte = RShifted Or GShifted Or BShifted



        Dim __BShifted As Byte = ByteColor
        __BShifted = __BShifted >> 6 << 6

        Dim __GShifted As Byte = ByteColor
        __GShifted = __GShifted << 2
        __GShifted = __GShifted >> 2
        __GShifted = __GShifted >> 3
        __GShifted = __GShifted << 3

        Dim __RShifted As Byte = ByteColor
        __RShifted = __RShifted << 5
        __RShifted = __RShifted >> 5



        Dim __RSmall As Byte = __RShifted

        Dim __GSmall As Byte = __GShifted
        __GSmall = __GSmall >> 3

        Dim __BSmall As Byte = __BShifted
        __BSmall = __BSmall >> 6


        Dim __Red As Byte = __RSmall * 32

        Dim __Green As Byte = __GSmall * 32

        Dim __Blue As Byte = __BSmall * 64

        Me.Close()
    End Sub
End Class

Module Modulogeneral

    Public gColorRow As Color = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(193, Byte), Integer))

#Region " Class CellBackColorAlternate "
    Public Class CellBackColorAlternate
        Inherits SourceGrid.Cells.Views.Cell
        Public Sub New(ByVal firstColor As Color, ByVal secondColor As Color)
            FirstBackground = New DevAge.Drawing.VisualElements.BackgroundSolid(firstColor)
            SecondBackground = New DevAge.Drawing.VisualElements.BackgroundSolid(secondColor)
        End Sub

        Private mFirstBackground As DevAge.Drawing.VisualElements.IVisualElement
        Public Property FirstBackground() As DevAge.Drawing.VisualElements.IVisualElement
            Get
                Return mFirstBackground
            End Get
            Set(ByVal Value As DevAge.Drawing.VisualElements.IVisualElement)
                mFirstBackground = Value
            End Set
        End Property

        Private mSecondBackground As DevAge.Drawing.VisualElements.IVisualElement
        Public Property SecondBackground() As DevAge.Drawing.VisualElements.IVisualElement
            Get
                Return mSecondBackground
            End Get
            Set(ByVal Value As DevAge.Drawing.VisualElements.IVisualElement)
                mSecondBackground = Value
            End Set
        End Property

        Protected Overrides Sub PrepareView(ByVal context As SourceGrid.CellContext)
            MyBase.PrepareView(context)
            If Math.IEEERemainder(context.Position.Row, 2) = 0 Then
                Background = FirstBackground
            Else
                Background = SecondBackground
            End If
        End Sub
    End Class
#End Region
End Module



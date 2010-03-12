USE [SMercado_LogicaNegocio] 
GO
/****** Object:  UserDefinedFunction [dbo].[fnc_EsNumero]    Script Date: 02/24/2010 10:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create Function [dbo].[fnc_EsNumero](@pNumero VarChar(18))
Returns Bit
As
Begin
  Return (Select IsNumeric(@pNumero + 'e0'))
End

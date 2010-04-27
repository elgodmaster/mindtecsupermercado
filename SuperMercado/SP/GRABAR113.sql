drop proc dbo.GRABAR113
go

CREATE PROCEDURE [dbo].[GRABAR113]
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int
)

AS
BEGIN
  Set NoCount On
  --------------------------
  --Salidas
  --------------------------

  --Variables de Trabajo
  Declare @Registro  Int
  Declare @Valor1    VarChar(8000)  
  Declare @Valor2    Varchar(8000)
  Declare @Valor3    VarChar(8000)
  Declare @Valor4    Varchar(8000)
  Declare @Valor5    Varchar(8000)
  Declare @Valor6    Varchar(8000)
  Declare @Valor7    Varchar(8000)
  Declare @Valor8    Varchar(8000)
  Declare @Valor9    Varchar(8000)
  Declare @Valor10   Varchar(8000)
  Declare @Valor11   Varchar(8000)
  Declare @Valor12   Varchar(8000)
  Declare @Valor13   Varchar(8000)
  Declare @Valor14   Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Folio Salida
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Fecha
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --Usuario
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --Motivo
 
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código de salida para continuar|'
     Return    
   End
  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre una fecha para continuar|'
     Return    
   End
 
  If Len(RTrim(LTrim(@Valor4)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre un motivo para continuar|'
     Return    
   End
  
   ----Inicia Transaccion
	Begin Tran TGrabar113
	
	Select @Desc0 = idSalida 
	From SMercado..Salidas
	Where idSalida  = @Valor1 And LEN(Rtrim(Ltrim(Motivo))) = 0
	Select  @Registro = @@ROWCOUNT 
	
	If @Registro = 0
	Begin
	Insert SMercado..Salidas(fecha,idUsuario,Motivo)
	Values (@Valor2,@Valor3,@Valor4)
	End
	 Else
	  Begin
	  Update SMercado..Salidas 
       Set Fecha = @Valor2,
           IdUsuario = @Valor3,
           Motivo = @Valor4
        Where idSalida = @Valor1 
	  End
	  
	 If @@ERROR <> 0
	  Begin
	   RollBack Tran TGrabar113
	   Return
	  End
-----------------------------------------------------     --Leer XML     -----------------------------------------------------     
--Validación de dataset 
Declare @idoc int    
Exec sp_xml_preparedocument @idoc OUTPUT, @DataSet     
SELECT  C5  = C5,    --FoliSalida                 
        C1  = C1,    --IdProducto
        C2  = C2,    --Descripcion producto                       
        C3  = C3,     --Cantidad 
        C4  = C4      --Unidad      
        Into #TmpGrabar113     
        FROM OPENXML (@idoc, '/Root/Table',2)          
        WITH (C5  Int,
              C1  Varchar(50),
              C2  Varchar(250),               
              C3  Decimal(18,2),
              C4  Varchar (250))   
        EXEC sp_xml_removedocument @idoc     
        -----------------------------------------------     -- Fin de XML     -----------------------------------------------
	  If @@ERROR <> 0
	  Begin
	   RollBack Tran TGrabar113
	   Return
	  End
	--Insert de la tabla temporal..
	Insert SMercado..Salida_detalles(idSalida,IdProducto,Descripcion,cantidad,Unidad)
    Select C5,C1,C2,C3,C4
    From #TmpGrabar113
	 
---Actualizar Existencias

        Update a
	    Set a.cantidad = a.cantidad - b.C3
	    From SMercado..Existencias a 
	    Left join #TmpGrabar113 b on b.C1 = a.codigo
	    Where b.C5 = @Valor1

	  Commit Tran TGrabar113
	    
  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se Grabó Correctamente|'   
  Set NoCount OFF
END


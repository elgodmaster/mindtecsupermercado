
drop proc dbo.GRABAR105
go

CREATE PROCEDURE dbo.GRABAR105
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
  --Clientes
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
  Declare @Valor15   Varchar(8000)
  Declare @Valor16   Varchar(8000)
  Declare @Valor17	 Varchar(8000)
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
  Declare @estado	 VarChar(8000)
  Declare @ciudad	 VarChar(8000)
    
  --Asignar Valores
  Select @Desc0  = '' 
  Select @Desc1  = ''
  Select @Resul  = ''
  Select @Resul2 = ''
  
  --Obtener los Parametros
  Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @Valor1 Output --Codigo
  Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @Valor2 Output --Nombre
  Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @Valor3 Output --RFC
  Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @Valor4 Output --Colonia
  Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @Valor5 Output --Direccion
  Exec Emulador_SepararCadena 'V6',  @Cabezero, '|', @Valor6 Output --CP
  Exec Emulador_SepararCadena 'V7',  @Cabezero, '|', @Valor7 Output --IdEstado
  Exec Emulador_SepararCadena 'V8',  @Cabezero, '|', @Valor8 Output --IdCiudad
  Exec Emulador_SepararCadena 'V9',  @Cabezero, '|', @Valor9 Output --Telefono1
  Exec Emulador_SepararCadena 'V10',  @Cabezero, '|', @Valor10 Output --Extencion1
  Exec Emulador_SepararCadena 'V11',  @Cabezero, '|', @Valor11 Output --Telefono2
  Exec Emulador_SepararCadena 'V12',  @Cabezero, '|', @Valor12 Output --Extencion2
  Exec Emulador_SepararCadena 'V13',  @Cabezero, '|', @Valor13 Output --Cel1
  Exec Emulador_SepararCadena 'V14',  @Cabezero, '|', @Valor14 Output --Cel2
  Exec Emulador_SepararCadena 'V15',  @Cabezero, '|', @Valor15 Output --Fax
  Exec Emulador_SepararCadena 'V16',  @Cabezero, '|', @Valor16 Output --Email
  Exec Emulador_SepararCadena 'V17',  @Cabezero, '|', @Valor17 Output --Límite de crédito
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código de cliente para continuar|'
     Return    
   End

  
  If Len(RTrim(LTrim(@Valor2)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el nombre para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor3)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el RFC para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor4)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la colonia para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor5)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la dirección para continuar|'
     Return    
   End
If Len(RTrim(LTrim(@Valor6)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre cp para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor7)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el estado para continuar|'
     Return    
   End

If Len(RTrim(LTrim(@Valor8)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre la ciudad para continuar|'
     Return    
   End
   
  select @estado = ISNULL(e.IdEstado, 0)
  From SMercado..Cat_EstadosdelaRepublica e
  where e.Descripcion = @Valor7
  
  select @ciudad = ISNULL(c.IdCiudad, 0)
  From SMercado..Cat_Ciudades c
  where c.Descripcion = @Valor8
        
  -- Logica de Negocio      
  Select @Desc1 = NombreFiscal
  From SMercado..Cat_Clientes(NoLock)
  Where Codigo = @Valor1
  
  Select C.Codigo from SMercado..Cat_Clientes C
  Where C.Codigo = @Valor1
  
  If @@RowCount = 0
   Begin
     Insert SMercado..Cat_Clientes(Codigo,NombreFiscal,Rfc,Colonia,Direccion,CP,IdEstado,IdCiudad,Telefono1,Extencion1,Telefono2,Extencion2,Cel1,Cel2,Fax,Email,LimiteCredito, Adeudo)
            Values(@Valor1,@Valor2,@Valor3,@Valor4,@Valor5,@Valor6,@estado,@ciudad,@Valor9,@Valor10,@Valor11,@Valor12,@Valor13,@Valor14,@Valor15,@Valor16, CONVERT(decimal(16,2),@Valor17), 0)
   End
  Else
   Begin
     Update SMercado..Cat_Clientes
            Set NombreFiscal = @Valor2,
                RFC          = @Valor3,
                Colonia      = @Valor4,
                Direccion    = @Valor5,
                Cp           = @Valor6,
                IdEstado     = @estado,
                IdCiudad     = @ciudad,
                Telefono1    = @Valor9,
                Extencion1   = @Valor10,
                Telefono2    = @Valor11,
                Extencion2   = @Valor12,
                Cel1         = @Valor13,
                Cel2         = @Valor14,
                Fax          = @Valor15,
                Email        = @Valor16,
                LimiteCredito = @Valor17
     Where Codigo = @Valor1
   End  

  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Se Grabó Correctamente|'   

  Set NoCount OFF
END




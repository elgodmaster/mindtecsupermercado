
drop proc dbo.GRABAR106
go

CREATE PROCEDURE dbo.GRABAR106
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
  --Proveedores
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
  Declare @Desc0     Varchar(8000)
  Declare @Desc1     VarChar(8000)
  Declare @Resul2    VarChar(8000)
  Declare @estado    varchar(8000)
  Declare @ciudad    varchar(8000)
    
  --Asignar Valores
  Select @Desc0  = "" 
  Select @Desc1  = ""
  Select @Resul  = ""
  Select @Resul2 = ""
  
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
  Exec Emulador_SepararCadena 'V15',  @Cabezero, '|', @Valor15 Output --Email
  Exec Emulador_SepararCadena 'V16',  @Cabezero, '|', @Valor16 Output --Fax
  
  -- Validar Parametros
  If Len(RTrim(LTrim(@Valor1)))= 0
   Begin
     Select @Resul='2R=ERROR|2M=Registre el código del proveedor para continuar|'
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
     Select @Resul='2R=ERROR|2M=Registre el cp para continuar|'
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
  Select @Desc1 = Nombre
  From SMercado..Cat_Proveedores(NoLock)
  Where Codigo = @Valor1
  
  Select P.Codigo from SMercado..Cat_Proveedores P
  Where P.Codigo = @Valor1
  
  If @@RowCount = 0
   Begin
     Insert SMercado..Cat_Proveedores(Codigo,Nombre,Rfc,Colonia,Direccion,Cp,IdEstado,IdCiudad,Telefono1,Extencion1,Telefono2,Extencion2,Celular1,Celular2,Email,Fax, Deuda )
            Values(@Valor1,@Valor2,@Valor3,@Valor4,@Valor5,@Valor6,@estado,@ciudad,@Valor9,@Valor10,@Valor11,@Valor12,@Valor13,@Valor14,@Valor15,@Valor16, 0)
   End
  Else
   Begin
     Update SMercado..Cat_Proveedores
            Set Nombre       = @Valor2,
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
                Celular1     = @Valor13,
                Celular2     = @Valor14,
                Email        = @Valor15,
                Fax        = @Valor16
     Where Codigo = @Valor1
   End  

  -- Enviar Resultado
  Select @Resul='2R=OK|2M=Los cambios efectuados se guardaron correctamente|'   

  Set NoCount OFF
END




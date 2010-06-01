-- Graba un abono, y actualiza el adeudo en la tabla Cuentas Cobrar.

drop proc dbo.GRABAR122
go

CREATE PROCEDURE dbo.GRABAR122
(
  @cabezero Varchar(8000),
  @Resul    Varchar(8000)  OutPut,
  @DataSet  nText,
  @Validar  Int

)

AS
BEGIN

DECLARE @usuario		varchar(8000)
DECLARE @nomUsuario		varchar(8000)
DECLARE @contraseña		varchar(8000)
DECLARE @permiso		varchar(8000)

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @usuario		Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @nomUsuario	Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @contraseña	Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @permiso		Output 

Set noCount ON

Select @permiso = P.idPermiso 
From SMercado_Seguridad..Permisos P
Where P.nomPermiso = @permiso 

Select U.idUsuario 
From SMercado_Seguridad..Usuarios U
Where U.nombreUsuario = @usuario 

select * from SMercado_Seguridad..Usuarios 

IF @@ROWCOUNT = 0
	BEGIN
		Insert SMercado_Seguridad..Usuarios 
		Values ( @usuario, @contraseña, @nomUsuario, @permiso, 1) 
	END
ELSE
	BEGIN
		Update SMercado_Seguridad..Usuarios 
		Set nombreUsuario = @usuario,
		    Pass = @contraseña,
		    nombreCompleto = @nomUsuario,
		    idPermiso = @permiso
		Where nombreUsuario = @usuario 
	END	
END


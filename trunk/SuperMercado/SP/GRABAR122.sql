-- Graba un usuario.

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
DECLARE @nombreCompleto	varchar(8000)
DECLARE @contraseña		varchar(8000)
DECLARE @permiso		varchar(8000)
DECLARE @usuarioNuevo	varchar(8000)
DECLARE @error			integer 
DECLARE @registro       integer 

Exec Emulador_SepararCadena 'V1',  @Cabezero, '|', @usuario			Output 
Exec Emulador_SepararCadena 'V2',  @Cabezero, '|', @nombreCompleto	Output 
Exec Emulador_SepararCadena 'V3',  @Cabezero, '|', @contraseña		Output 
Exec Emulador_SepararCadena 'V4',  @Cabezero, '|', @permiso			Output
Exec Emulador_SepararCadena 'V5',  @Cabezero, '|', @usuarioNuevo	Output

Set noCount ON

Select @permiso = P.idPermiso 
From SMercado_Seguridad..Permisos P
Where P.nomPermiso = @permiso 

Select U.idUsuario 
From SMercado_Seguridad..Usuarios U
Where U.nombreUsuario = @usuario 

IF @@ROWCOUNT = 0
	BEGIN
		Insert SMercado_Seguridad..Usuarios 
		Values ( @usuarioNuevo , @contraseña, @nombreCompleto, @permiso, 1)
		Select @resul = '2R=OK|2M=Nuevo usuario agregado.'
	END
ELSE
	BEGIN
		IF @usuario <> @usuarioNuevo 
		BEGIN 
			Select U.idUsuario From SMercado_Seguridad..Usuarios U
			Where U.nombreUsuario = @usuarioNuevo 
			Select @registro = @@ROWCOUNT 
			IF @registro <> 0
			BEGIN
				Select @resul = '2R=ERROR|2M=Ese nombre de usuario ya ha sido registrado.'
				Return
			END
		END
		
		Update SMercado_Seguridad..Usuarios 
		Set nombreUsuario = @usuarioNuevo,
		    Pass = @contraseña,
		    nombreCompleto = @nombreCompleto,
		    idPermiso = @permiso
		Where nombreUsuario = @usuario
		
		Select @resul = '2R=OK|2M=Se guardaron los cambios.'
	END	
END


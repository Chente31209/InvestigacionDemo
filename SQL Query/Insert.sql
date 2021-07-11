insert into tiposdeoraganisaciones(Id,Descripcion) values (2,'Empresa');

insert into organisaciones(Id,Nombre,Giro,Decripcion,Id_tipoDeOraganisacionId) values (1,'Prueba-SC','Venta','vendre mercasias',1);

insert into usuarios(Id, Nombre, E_Mail,NumeroDeTelefono,FecaDeNacimento,Id_organisacionId) 
values(1,'Vcente Eduardo Martines Morales','chente31209@hotmail.com',1526,991027,1);

insert into acsesos(Id,NombreDeUsario,Pasword,UsuarioId) 
values(1,'Chente31209','Osoosa123',1);
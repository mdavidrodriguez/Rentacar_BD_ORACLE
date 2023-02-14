---------------------------------------
--Paquetes y procedimientos
--------------------------------------
--declaracion del paquete
create or replace package MANTENIMIENTO_CLIENTE
as
procedure sp_guardar_cliente
(idc varchar2,nomb varchar2,apelli varchar2,fechaN varchar2,gen varchar2,tipoc varchar2,
tele number,direc varchar2);
procedure sp_modificar_cliente
(idc varchar2,nomb varchar2,apelli varchar2,fechaN varchar2,gen varchar2,tipoc varchar2,
tele number,direc varchar2);
procedure sp_eliminar_cliente(idc varchar2);
procedure sp_consultar_clientes(registros OUT SYS_REFCURSOR);
end MANTENIMIENTO_CLIENTE;

--funcionalidad del paquete
create or replace package BODY MANTENIMIENTO_CLIENTE
as
procedure sp_guardar_cliente(idc varchar2,nomb varchar2,apelli varchar2,fechaN varchar2,gen varchar2,tipoc varchar2,
tele number,direc varchar2)
is
begin
insert into clientes(idcliente,nombre,apellido,fechanacimiento,genero,tipocliente,telefono,direccion) 
values(idc,nomb,apelli,fechaN,gen,tipoc,tele,direc);
end sp_guardar_cliente;

procedure sp_modificar_cliente(idc varchar2,nomb varchar2,apelli varchar2,fechaN varchar2,gen varchar2,tipoc varchar2,
tele number,direc varchar2)
as
begin
update clientes
set nombre= nomb,apellido= apelli,fechanacimiento= fechaN,genero= gen,
tipocliente= tipoc,telefono= tele,direccion= direc 
where idcliente=idc;
end sp_modificar_cliente;
procedure sp_eliminar_cliente(idc varchar2)
as
begin
delete from clientes where idcliente = idc;
end sp_eliminar_cliente;

procedure sp_consultar_clientes(registros out SYS_REFCURSOR)
as
begin 
open registros for select * from clientes;
end;
end MANTENIMIENTO_CLIENTE;


CREATE OR REPLACE PROCEDURE sp_consultar_idcliente(registro OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN registro FOR SELECT * FROM clientes where idcliente = idcliente or nombre = nombre;
END sp_consultar_idcliente;

select * from clientes;

procedure modificar_cliente(idc varchar2,nomb varchar2,apelli varchar2,fechaN varchar2,gen varchar2,tipoc varchar2,
tele number,direc varchar2)
as
begin
update clientes
set nombre= nomb,apellido= apelli,fechanacimiento= fechaN,genero= gen,
tipocliente= tipoc,telefono= tele,direccion= direc 
where idcliente=idc;
end modificar_cliente;



---paquete tabla vehiculos
Create Table Vehiculos(
Placa varchar2(10) not null,
marca varchar2(10),
kilometrajeActual number,
modelo number,
estado varchar2(10),
color varchar(2)
);
create table color(
idcolor varchar2(2),
nombre_color varchar2(15)
);
create table marca(
idmarca varchar2(3),
nombremarca varchar2(15)
);

alter table color ADD CONSTRAINT pk_color PRIMARY KEY (idcolor);
alter table marca ADD CONSTRAINT pk_marca PRIMARY KEY (idmarca);
alter table vehiculos ADD CONSTRAINT PK_placa PRIMARY KEY (placa);
alter table vehiculos add constraint fk_marca FOREIGN key (marca) references marca(idmarca);
alter table vehiculos add constraint fk_color FOREIGN key (color) references color(idcolor);


create or replace package MANTENIMIENTO_VEHICULOS
as
procedure sp_guardar_vehiculo
(plac varchar2,mar varchar2,kilom number,modelos number,estad varchar2,colores varchar2);
procedure sp_modificar_vehiculo
(plac varchar2,mar varchar2,kilom number,modelos number,estad varchar2,colores varchar2);
procedure sp_eliminar_vehiculo(plac varchar2);
procedure sp_consultar_vehiculos(registros OUT SYS_REFCURSOR);
end MANTENIMIENTO_VEHICULOS;


--funcionalidad del paquete vehiculos
create or replace package BODY MANTENIMIENTO_VEHICULOS
as
procedure sp_guardar_vehiculo(plac varchar2,mar varchar2,kilom number,modelos number,estad varchar2,colores varchar2)
is
begin
insert into vehiculos(placa,marca,kilometrajeactual,modelo,estado,color) 
values(plac,mar,kilom,modelos,estad,colores);
end sp_guardar_vehiculo;

procedure sp_modificar_vehiculo(plac varchar2,mar varchar2,kilom number,modelos number,estad varchar2,colores varchar2)
as
begin
update vehiculos
set placa= plac,marca= mar,kilometrajeactual= kilom,modelo= modelos,
estado= estad,color= colores
where placa=plac;
end sp_modificar_vehiculo;
procedure sp_eliminar_vehiculo(plac varchar2)
as
begin
delete from vehiculos where placa = plac;
end sp_eliminar_vehiculo;

procedure sp_consultar_vehiculos(registros out SYS_REFCURSOR)
as
begin 
open registros for select * from vehiculos;
end;
end MANTENIMIENTO_VEHICULOS;


--tabla marca [secuencia y disparador]
CREATE OR REPLACE PROCEDURE sp_cargar_marca(marcas OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN marcas FOR SELECT idmarca,nombremarca from marca;
END sp_cargar_marca;

--secuencia marca
create sequence sec_codigo_marca
  start with 1
  increment by 1
  maxvalue 100
  minvalue 1;
  
--trigger para generar el id de marca de vehiculos
 CREATE OR REPLACE TRIGGER secuencia_marca BEFORE INSERT ON marca
FOR EACH ROW
DECLARE

BEGIN

    SELECT sec_codigo_marca.NEXTVAL INTO :NEW.idmarca FROM DUAL;

END;

insert into marca (nombremarca)values('Toyota');
insert into marca (nombremarca)values('Nissan');
insert into marca (nombremarca)values('BMW');
insert into marca (nombremarca)values('Ferrari');
insert into marca (nombremarca)values('Chevrolet');


--secuencia colores
CREATE OR REPLACE PROCEDURE sp_cargar_color(colores OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN colores FOR SELECT idcolor,nombre_color from color;
END sp_cargar_color;

--secuencia marca
create sequence sec_codigo_color
  start with 1
  increment by 1
  maxvalue 30
  minvalue 1;
  
--trigger para generar el id de marca de vehiculos
 CREATE OR REPLACE TRIGGER secuencia_color BEFORE INSERT ON color
FOR EACH ROW
DECLARE

BEGIN

    SELECT sec_codigo_color.NEXTVAL INTO :NEW.idcolor FROM DUAL;

END;
--insert probando secuencia
insert into color (nombre_color)values('Amariilo');
insert into color (nombre_color)values('Azul');
insert into color (nombre_color)values('Rojo');
insert into color (nombre_color)values('Verde');
insert into color (nombre_color)values('Morado');
select * from color;



Create Table Vehiculos(
Placa varchar2(10) not null,
marca varchar2(3),
kilometrajeActual number,
modelo number,
estado varchar2(10),
color varchar(2)
);
alter table vehiculos add constraint fk_marca FOREIGN key (marca) references marca(idmarca);
alter table vehiculos add constraint fk_color FOREIGN key (color) references color(idcolor);
select * from vehiculos;
commit




--avances con procedimientos 
CREATE  procedure sp_listar_vehiculos(registros out SYS_REFCURSOR)
as
begin 
open registros for select v.placa, m.nombremarca, v.kilometrajeactual,v.modelo,v.estado,c.nombre_color from 
vehiculos v
join color c on 
v.color = c.idcolor
join marca m on 
v.marca = m.idmarca;
end;

execute sp_listar_vehiculos;

select v.placa, m.nombremarca, v.kilometrajeactual,v.modelo,v.estado,c.nombre_color from 
vehiculos v
join color c on 
v.color = c.idcolor
join marca m on 
v.marca = m.idmarca;

CREATE OR REPLACE PROCEDURE sp_cargar_cliente(clientes OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN clientes FOR SELECT idcliente  from clientes;
END sp_cargar_cliente;




---nuevos procedimientos, paquetes y funciones
create or replace package GESTION_FACTURA
as
procedure sp_guardar_factura
(idalq int,idc varchar2,plac varchar2,fechaE DATE,fechaR DATE,kmEntre number,
kmRecep number,kmrec number, valork number, descuen number, tot number);
procedure sp_consultar_factura(registros OUT SYS_REFCURSOR);
end GESTION_FACTURA;
rollback;



create table factura(
idalquiler int,
idcliente varchar2(10),
placa varchar2(10),
fechaentrega date,
fecharecepcion date,
kmentrega number,
kmrecepcion number,
kmrecorridos number,
valorkm number, 
descuento number,
total number
);

alter table vehiculos add constraint Pk_placa_veh PRIMARY KEY(placa);
alter table factura add constraint Fk_id_cliente FOREIGN KEY(idcliente) REFERENCES clientes(idcliente);
alter table factura add constraint Fk_placa_veh FOREIGN KEY(placa) REFERENCES vehiculos(placa);



create or replace package BODY GESTION_FACTURA
as
procedure sp_guardar_factura(idalq int,idc varchar2,plac varchar2,fechaE DATE,fechaR DATE,kmEntre number,
kmRecep number,kmrec number, valork number, descuen number, tot number)
is
begin
insert into factura(idalquiler,idcliente,placa,fechaentrega,fecharecepcion,kmentrega,kmrecepcion,kmrecorridos, valorkm, descuento,total)
values(idalq,idc,plac,fechaE,fechaR,kmEntre,kmRecep,kmrec,valork,descuen,tot);
end sp_guardar_factura;

procedure sp_consultar_factura(registros out SYS_REFCURSOR)
as
begin 
open registros for select * from factura;
end;
end GESTION_FACTURA;


CREATE OR REPLACE procedure sp_idcliente_cargar(registros out SYS_REFCURSOR)
as
begin 
open registros for select  idcliente from clientes;
END;

create or replace procedure sp_placa_cargar(registros out SYS_REFCURSOR)
as
begin 
open registros for select placa from vehiculos;
END;

select * from factura;

create sequence sec_codigo_alquiler
  start with 1
  increment by 1
  maxvalue 100
  minvalue 1;
  
  
  CREATE OR REPLACE TRIGGER sec_calquiler BEFORE INSERT ON factura
FOR EACH ROW
DECLARE

BEGIN

    SELECT sec_codigo_alquiler.NEXTVAL INTO :NEW.idalquiler FROM DUAL;

END;



CREATE OR REPLACE PROCEDURE sp_cargar_marca(marcas OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN marcas FOR SELECT idmarca,nombremarca from marca;
END sp_cargar_marca;
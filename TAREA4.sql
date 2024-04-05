CREATE DATABASE TAREA4

CREATE TABLE CLIENTE (
IdCliente INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(100) NOT NULL,
CorreoElectronico VARCHAR(250) NOT NULL,
Telefono VARCHAR(15) NOT NULL,
Direccion VARCHAR(250) NOT NULL);

CREATE TABLE PEDIDOS (
IdPedido INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
IdCliente INT NOT NULL,
Fecha DATETIME NOT NULL,
Total MONEY NOT NULL,
Estado VARCHAR(50) NOT NULL,
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE));


insert into cliente values('Pedro' ,'Fernandez','pedro@gmail.com','+59172979377','Calle 123');
insert into cliente values('Adri�n' ,'P�rez' ,'adrian@gmail.com','+59161234567','Avenida Principal');
insert into cliente values('Bel�n','Gonz�lez' ,'belen@gmail.com','+59173456789','Calle Flores');
insert into cliente values('Ana' ,'Rodr�guez' ,'ana@gmail.com','+59169876543','Avenida Libertad');
insert into cliente values('Bruno' ,'L�pez' ,'bruno@gmail.com','+59176213456','Calle 456');
insert into cliente values('Carla' ,'Garc�a' ,'carla@gmail.com','+59164738291','Avenida Bol�var');
insert into cliente values('Diego' ,'S�nchez' ,'diego@gmail.com','+59171345678','Calle 789');
insert into cliente values('Elena' ,'Mart�nez' ,'elena@gmail.com','+59168912345','Avenida Juana Azurduy');
insert into cliente values('Fabi�n','G�mez' ,'fabian@gmail.com','+59167483921','Calle 901');
insert into cliente values('Gloria' ,'D�az' ,'gloria@gmail.com','+59176294837','Avenida del Sol');
insert into cliente values('Hugo' ,'Ruiz' ,'hugo@gmail.com','+59163729184','Calle 234');
insert into cliente values('Irene' ,'Torrez' ,'irene@gmail.com','+59172836491','Avenida de los �lamos');
insert into cliente values('Jorge' ,'Morales' ,'jorge@gmail.com','+59169485732','Calle 567');
insert into cliente values('Karen' ,'Vargas' ,'karen@gmail.com','+59161293847','Avenida del Norte');
insert into cliente values('Luis' ,'Castro' ,'luis@gmail.com','+59174321658','Calle 890');
insert into cliente values('Mar�a' ,'Ram�rez' ,'maria@gmail.com','+59168749321','Avenida de la Paz');
insert into cliente values('Nicol�s' ,'Flores' ,'nicolas@gmail.com','+59165432198','Calle 012');
insert into cliente values('Olivia' ,'Romero' ,'olivia@gmail.com','+59172938475','Avenida San Mart�n');
insert into cliente values('Pablo' ,'Ortiz' ,'pablo@gmail.com','+59169384752','Calle 345');
insert into cliente values('Emma' ,'�lvarez' ,'emma@gmail.com','+59161472583','Avenida de Mayo');
insert into cliente values('Ra�l' ,'Cruz' ,'raul@gmail.com','+59174839265','Calle 678');
insert into cliente values('Sonia' ,'Herrera' ,'sonia@gmail.com','+59168294731','Avenida Espa�a');
insert into cliente values('Tom�s' ,'Soto' ,'tomas@gmail.com','+59165837492','Calle 901');
insert into cliente values('�rsula' ,'Jim�nez' ,'ursula@gmail.com','+59172648395','Avenida 6 de Agosto');
insert into cliente values('V�ctor' ,'Reyes' ,'victor@gmail.com','+59169123487','Calle 234');
insert into cliente values('Wendy' ,'Moreno' ,'wendy@gmail.com','+59161728394','Avenida Kennedy');
insert into cliente values('Xavier' ,'N��ez' ,'xavier@gmail.com','+59173948572','Calle 567');
insert into cliente values('Yolanda' ,'Medina' ,'yolanda@gmail.com','+59168572934','Avenida Las Am�ricas');
insert into cliente values('Zacar�as' ,'Mu�oz' ,'zacarias@gmail.com','+59165394827','Calle 890');
insert into cliente values('Abel' ,'R�os' ,'abel@gmail.com','+59172483916','Avenida 16 de Julio');
insert into cliente values('Bianca' ,'Rojas' ,'bianca@gmail.com','+59169217483','Calle 012');
insert into cliente values('C�sar' ,'Salazar' ,'cesar@gmail.com','+59167123456','Avenida del Ej�rcito');
insert into cliente values('Dalia' ,'Su�rez' ,'dalia@gmail.com','+59176345678','Calle 345');
insert into cliente values('Ernesto' ,'Vel�squez' ,'ernesto@gmail.com','+59169786543','Avenida del Progreso');
insert into cliente values('Flora' ,'Aguilar' ,'flora@gmail.com','+59175213456','Calle 678');
insert into cliente values('Gast�n' ,'Alvarado' ,'gaston@gmail.com','+59164837291','Avenida del Trabajo');
insert into cliente values('Helena' ,'Arce' ,'helena@gmail.com','+59171345678','Calle 901');
insert into cliente values('Iv�n' ,'Arias' ,'ivan@gmail.com','+59168912345','Avenida de la Revoluci�n');
insert into cliente values('Julia' ,'Ben�tez' ,'julia@gmail.com','+59167483921','Calle 234');
insert into cliente values('Kevin' ,'C�ceres' ,'kevin@gmail.com','+59176294837','Avenida del Cambio');
insert into cliente values('Laura' ,'Campos' ,'laura@gmail.com','+59163729184','Calle 567');
insert into cliente values('Marco' ,'Carvajal' ,'marco@gmail.com','+59172836491','Avenida del Saber');
insert into cliente values('Nora' ,'Cordero' ,'nora@gmail.com','+59169485732','Calle 890');
insert into cliente values('�scar' ,'Delgado' ,'oscar@gmail.com','+59161293847','Avenida de la Esperanza');
insert into cliente values('Patricia' ,'Dur�n' ,'patricia@gmail.com','+59174321658','Calle 012');
insert into cliente values('Serguio' ,'Escobar' ,'serguio@gmail.com','+59168749321','Avenida de la Alegr�a');
insert into cliente values('Rosa' ,'Fuentes' ,'rosa@gmail.com','+59165432198','Calle 345');
insert into cliente values('Teresa' ,'Galindo' ,'teresa@gmail.com','+59172938475','Avenida de la Victoria');
insert into cliente values('Ulises' ,'Ib��ez' ,'ulises@gmail.com','+59169384752','Calle 678');

select *
from Cliente


INSERT INTO PEDIDOS (IdCliente, FECHA, TOTAL, ESTADO) 
VALUES 
(1, '2024-04-01 08:15:00', 50.00, 'En proceso'),
(2, '2024-04-02 10:30:00', 75.50, 'Enviado'),
(3, '2024-04-02 14:45:00', 120.25, 'Pendiente'),
(4, '2024-04-03 09:20:00', 200.00, 'Cancelado'),
(5, '2024-04-03 11:55:00', 85.75, 'En proceso'),
(6, '2024-04-03 16:10:00', 150.50, 'Enviado'),
(7, '2024-04-04 08:00:00', 90.00, 'En proceso'),
(8, '2024-04-04 12:30:00', 175.25, 'En proceso');
select *
from PEDIDOS
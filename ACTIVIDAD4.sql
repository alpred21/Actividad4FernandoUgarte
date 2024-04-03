CREATE DATABASE TAREA4
;

CREATE TABLE Cliente (
    IdCliente INT IDENTITY (1,1) NOT NULL,
    Nombre VARCHAR(50)NOT NULL,
    Apellido VARCHAR(50)NOT NULL,
    CorreoElectronico VARCHAR(100)NOT NULL,
    Telefono VARCHAR(20)NOT NULL,
    Direccion VARCHAR(100)NOT NULL,
	PRIMARY KEY (IdCliente)
);

insert into cliente values('Pedro' ,'Fernandez','pedro@gmail.com','+59172979377','Calle 123');
insert into cliente values('Adrián' ,'Pérez' ,'adrian@gmail.com','+59161234567','Avenida Principal');
insert into cliente values('Belén','González' ,'belen@gmail.com','+59173456789','Calle Flores');
insert into cliente values('Ana' ,'Rodríguez' ,'ana@gmail.com','+59169876543','Avenida Libertad');
insert into cliente values('Bruno' ,'López' ,'bruno@gmail.com','+59176213456','Calle 456');
insert into cliente values('Carla' ,'García' ,'carla@gmail.com','+59164738291','Avenida Bolívar');
insert into cliente values('Diego' ,'Sánchez' ,'diego@gmail.com','+59171345678','Calle 789');
insert into cliente values('Elena' ,'Martínez' ,'elena@gmail.com','+59168912345','Avenida Juana Azurduy');
insert into cliente values('Fabián','Gómez' ,'fabian@gmail.com','+59167483921','Calle 901');
insert into cliente values('Gloria' ,'Díaz' ,'gloria@gmail.com','+59176294837','Avenida del Sol');
insert into cliente values('Hugo' ,'Ruiz' ,'hugo@gmail.com','+59163729184','Calle 234');
insert into cliente values('Irene' ,'Torrez' ,'irene@gmail.com','+59172836491','Avenida de los Álamos');
insert into cliente values('Jorge' ,'Morales' ,'jorge@gmail.com','+59169485732','Calle 567');
insert into cliente values('Karen' ,'Vargas' ,'karen@gmail.com','+59161293847','Avenida del Norte');
insert into cliente values('Luis' ,'Castro' ,'luis@gmail.com','+59174321658','Calle 890');
insert into cliente values('María' ,'Ramírez' ,'maria@gmail.com','+59168749321','Avenida de la Paz');
insert into cliente values('Nicolás' ,'Flores' ,'nicolas@gmail.com','+59165432198','Calle 012');
insert into cliente values('Olivia' ,'Romero' ,'olivia@gmail.com','+59172938475','Avenida San Martín');
insert into cliente values('Pablo' ,'Ortiz' ,'pablo@gmail.com','+59169384752','Calle 345');
insert into cliente values('Emma' ,'Álvarez' ,'emma@gmail.com','+59161472583','Avenida de Mayo');
insert into cliente values('Raúl' ,'Cruz' ,'raul@gmail.com','+59174839265','Calle 678');
insert into cliente values('Sonia' ,'Herrera' ,'sonia@gmail.com','+59168294731','Avenida España');
insert into cliente values('Tomás' ,'Soto' ,'tomas@gmail.com','+59165837492','Calle 901');
insert into cliente values('Úrsula' ,'Jiménez' ,'ursula@gmail.com','+59172648395','Avenida 6 de Agosto');
insert into cliente values('Víctor' ,'Reyes' ,'victor@gmail.com','+59169123487','Calle 234');
insert into cliente values('Wendy' ,'Moreno' ,'wendy@gmail.com','+59161728394','Avenida Kennedy');
insert into cliente values('Xavier' ,'Núñez' ,'xavier@gmail.com','+59173948572','Calle 567');
insert into cliente values('Yolanda' ,'Medina' ,'yolanda@gmail.com','+59168572934','Avenida Las Américas');
insert into cliente values('Zacarías' ,'Muñoz' ,'zacarias@gmail.com','+59165394827','Calle 890');
insert into cliente values('Abel' ,'Ríos' ,'abel@gmail.com','+59172483916','Avenida 16 de Julio');
insert into cliente values('Bianca' ,'Rojas' ,'bianca@gmail.com','+59169217483','Calle 012');
insert into cliente values('César' ,'Salazar' ,'cesar@gmail.com','+59167123456','Avenida del Ejército');
insert into cliente values('Dalia' ,'Suárez' ,'dalia@gmail.com','+59176345678','Calle 345');
insert into cliente values('Ernesto' ,'Velásquez' ,'ernesto@gmail.com','+59169786543','Avenida del Progreso');
insert into cliente values('Flora' ,'Aguilar' ,'flora@gmail.com','+59175213456','Calle 678');
insert into cliente values('Gastón' ,'Alvarado' ,'gaston@gmail.com','+59164837291','Avenida del Trabajo');
insert into cliente values('Helena' ,'Arce' ,'helena@gmail.com','+59171345678','Calle 901');
insert into cliente values('Iván' ,'Arias' ,'ivan@gmail.com','+59168912345','Avenida de la Revolución');
insert into cliente values('Julia' ,'Benítez' ,'julia@gmail.com','+59167483921','Calle 234');
insert into cliente values('Kevin' ,'Cáceres' ,'kevin@gmail.com','+59176294837','Avenida del Cambio');
insert into cliente values('Laura' ,'Campos' ,'laura@gmail.com','+59163729184','Calle 567');
insert into cliente values('Marco' ,'Carvajal' ,'marco@gmail.com','+59172836491','Avenida del Saber');
insert into cliente values('Nora' ,'Cordero' ,'nora@gmail.com','+59169485732','Calle 890');
insert into cliente values('Óscar' ,'Delgado' ,'oscar@gmail.com','+59161293847','Avenida de la Esperanza');
insert into cliente values('Patricia' ,'Durán' ,'patricia@gmail.com','+59174321658','Calle 012');
insert into cliente values('Serguio' ,'Escobar' ,'serguio@gmail.com','+59168749321','Avenida de la Alegría');
insert into cliente values('Rosa' ,'Fuentes' ,'rosa@gmail.com','+59165432198','Calle 345');
insert into cliente values('Teresa' ,'Galindo' ,'teresa@gmail.com','+59172938475','Avenida de la Victoria');
insert into cliente values('Ulises' ,'Ibáñez' ,'ulises@gmail.com','+59169384752','Calle 678');

select *
from Cliente



CREATE TABLE PEDIDO (
IDPEDIDO INT IDENTITY (1,1) NOT NULL,
IdCliente INT NOT NULL,
FECHA DATETIME NOT NULL,
TOTAL MONEY NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPEDIDO),
FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente)
);


INSERT INTO PEDIDO (IdCliente, FECHA, TOTAL, ESTADO) 
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
from PEDIDO
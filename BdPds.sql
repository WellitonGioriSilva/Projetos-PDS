create database app_contato_db;
use app_contato_db;

create table contato(
	id_con int not null auto_increment primary key,
    nome_con varchar(100) not null,
    data_nasc_con date null,
    sexo_con varchar(30) not null,
	email_con varchar(100) not null,
    telefone_con varchar(30) not null
);

insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (1, 'Claiborne Barbrook', '1986-04-27', 'Male', 'cbarbrook0@springer.com', '560-280-8514');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (2, 'Tami Walhedd', '1993-05-05', 'Female', 'twalhedd1@sohu.com', '756-799-9746');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (3, 'Tilly Thomtson', '1987-07-09', 'Female', 'tthomtson2@behance.net', '986-939-8842');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (4, 'Gage Wildor', '1991-06-10', 'Male', 'gwildor3@nationalgeographic.com', '240-601-6771');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (5, 'Rafa Comrie', '2018-07-14', 'Female', 'rcomrie4@vinaora.com', '575-878-1356');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (6, 'Avrom Duffyn', '1990-01-14', 'Male', 'aduffyn5@topsy.com', '839-362-9586');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (7, 'Adolph Rubinlicht', '2016-07-26', 'Male', 'arubinlicht6@addtoany.com', '545-851-1359');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (8, 'Craggie McGraffin', '1988-10-30', 'Male', 'cmcgraffin7@google.cn', '191-385-0532');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (9, 'Cobb Roggieri', '2020-03-15', 'Male', 'croggieri8@surveymonkey.com', '247-344-4825');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (10, 'Levey Dinse', '1988-06-05', 'Male', 'ldinse9@cpanel.net', '854-364-2578');


select * from contato;
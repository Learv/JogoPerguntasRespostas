-- cria��o de uma database chamada "PerguntasERespostas" Obs: db = database
create database db_PerguntasERespostas

-- uso da tabela criada acima--
use db_PerguntasERespostas

-- inicio da cria��o de uma tabela chamada "Jogador" Obs: tb = table
create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null,
	sobrenome varchar (30),
	email varchar (30) not null
)
-- termino da cria��o da tabela "tb_Jogador"

-- exibi��o da tabela "tb_Jogador"
select * from tb_Jogador

--inserir na tabela tb_Jogador um campo de nome de valor X (no caso: Ram�n)
insert into tb_Jogador(nome) values('Ram�n')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas (
id int identity primary key,
pergunta varchar(max),
resposta_correta varchar(max),
nivel varchar(max),
pontos int,
id_jogador int,
data datetime default getdate()
)

select * from tb_Perguntas

--insere na tabela tb_Perguntas a pergunta de valor X, e a resposta correta de valor X
insert into tb_Perguntas(pergunta, resposta_correta)
values('Onde se deve programar?', 'Computador')

--deleta um id de valor expecifico (valor 8, no caso) da tabela tb_Jogador
delete from tb_Jogador where id = 2

-- deleta todos os nomes da tabela
delete from tb_Jogador

--reseta todos os dados da tabela
truncate table tb_Jogador

--add 
alter table tb_Jogador add email varchar (30)

select * from tb_Jogador join tb_Perguntas on tb_Jogador.id = tb_Perguntas.id_Jogador

select @@IDENTITY
select @@SERVERNAME
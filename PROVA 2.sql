use master 
create database EmpresaCurso
go
use EmpresaCurso
go 
create table Turmas (
TurmaID int identity (1,1) primary key, 
TurmaDesc Varchar (100), 
TurmaInicio date not null, 
TurmaFim date not null,
) 

create table Curso (
CursoID int identity(1,1) primary key, 
CursoNome Varchar (100),
CursoArea Varchar(100), 
)



create table Matricula (
MatriculaID int identity(1,1) primary key, 
MatriculaTaxa Varchar (30), 
MatriculaData date not null,
)

create table Relatorios (
RelatorioID int identity (1,1) primary key,
RelatorioMatriPorTurma Varchar (150),
RelatorioHist Varchar (500),
RelatorioFem Varchar (150),
RelatorioMasc Varchar (150),
RelatorioCodCurso Varchar (100), 
) 



Insert Turmas(TurmaDesc, TurmaInicio, TurmaFim)
values ('Turma A', '23/01/2023', '01/01/2024')

Insert Turmas(TurmaDesc, TurmaInicio, TurmaFim)
values ('Turma C', '01/02/2025', '23/12/2026')

Insert Turmas(TurmaDesc, TurmaInicio, TurmaFim)
values ('Turma B', '05/06/2025', '30/10/2027')

select * from turmas 



Insert Curso(CursoNome, CursoArea)
values ('Engenharia de software', 'TI') 

Insert Curso( CursoNome, CursoArea)
values ('Gestao', 'Financas')

Insert Curso( CursoNome, CursoArea)
values ('Biomedicina', 'Saude')

select * from Curso




Insert Matricula(MatriculaTaxa, MatriculaData)
values ('20%', '12/01/2023') 

Insert Matricula(MatriculaTaxa, MatriculaData)
values ('15%', '21/12/2023') 

Insert Matricula(MatriculaTaxa, MatriculaData)
values ('35%', '13/07/2028') 

select * from matricula

Insert Relatorios(RelatorioMatriPorTurma, RelatorioHist, RelatorioFem, RelatorioMasc, RelatorioCodCurso)
values ('23', 'Marcos, Engenharia de software, Turma A' , '13', '10', 'CURSO001')

Insert Relatorios(RelatorioMatriPorTurma, RelatorioHist, RelatorioFem, RelatorioMasc, RelatorioCodCurso)
values ('17', 'Joana, Gestao, Turma C' , '12', '5', 'CURSO005')

Insert Relatorios(RelatorioMatriPorTurma, RelatorioHist, RelatorioFem, RelatorioMasc, RelatorioCodCurso)
values ('10', 'Menino Feio, Biomedicina, Turma B' , '4', '6', 'CURSO006')



select * from relatorios

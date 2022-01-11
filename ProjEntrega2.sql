CREATE TABLE Contato 
( 
 id_contato INT PRIMARY KEY IDENTITY (1,1),  
 empresa VARCHAR(50) NOT NULL UNIQUE ,  
 nome VARCHAR(50) NOT NULL ,  
 sobrenome VARCHAR(50) NOT NULL ,  
 email VARCHAR(50) NOT NULL ,  
 telefone CHAR(15) NOT NULL,  
 comentarios VARCHAR(2000),  
);
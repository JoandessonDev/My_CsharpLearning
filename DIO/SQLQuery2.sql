SELECT * FROM Clientes
ALTER TABLE Clientes 
ALTER COLUMN Renda decimal(12,2);

ALTER TABLE Clientes
--ADD CONSTRAINT CK_Clientes_Sexo CHECK (Sexo IN ('M', 'F'));
ADD UNIQUE (Cpf)



INSERT INTO Clientes(Nome, Endereco, Sexo, Renda, DataDeNascimento, Cpf)
VALUES
	--('Joandesson', 'Santa Marta', 'M', 2500.00, '2004-01-21', '40987654321'),
	('Alencar', 'Cidade Jardim', 'm', 7000.00, '2003-07-01', '12345678914') ,
	('Jose', 'Cidade Jardim', 'm', 9000.00, '2003-07-01', '12345678913') 

SELECT * FROM Produtos
INSERT INTO Produtos(Nome, Quantidade, Validade, CodigoBarrasEAN)
VALUES	
	('Arroz', 17, '2025-01-01', '234567890'),
	('Sardinha', 30, '2025-01-01', '236667890'),
	('Melancia', 30, '2025-07-23', '236667890')

SELECT * FROM Pedidos

INSERT INTO Pedidos (ID_Produto, ID_Cliente)
VALUES	
	(1,1)
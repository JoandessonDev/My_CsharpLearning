CREATE TABLE Clientes(
	ID_Cliente int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Endereco varchar(255),
	Sexo char(1),
	Renda decimal(5,2),
	DataDeNascimento date,
	Cpf char(11)
);

CREATE TABLE Produtos(
	ID_Produto int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Quantidade int DEFAULT 0,
	Validade date,
	CodigoBarrasEAN varchar(255)
);

CREATE TABLE Pedidos(
	ID_Pedido int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_Produto int NOT NULL, 
    ID_Cliente int NOT NULL,
	CONSTRAINT FK_PedidosProduto FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID_Produto),
	CONSTRAINT FK_PedidosCliente FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);

CREATE TABLE Fornecedores(
	ID_Fornecedor int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255),
	Cnpj char(14),
	Endereco varchar(255)

);

CREATE TABLE ProdutosFornecedores(
	ID_ProdutosFornecedores int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_Produto int NOT NULL,
	ID_Fornecedor int NOT NULL,
	CONSTRAINT FK_Produto FOREIGN KEY (ID_Produto) REFERENCES Produtos(ID_Produto),
	CONSTRAINT FK_Fornecedor FOREIGN KEY (ID_Fornecedor) REFERENCES Fornecedores(ID_Fornecedor)
)
USE LaShiliquitaBD;

CREATE TABLE PROVEEDOR (
    nroDocProveedor VARCHAR(15) PRIMARY KEY,
    tipoDoc VARCHAR(15) NOT NULL,
    nomEmpresa VARCHAR(100) NOT NULL,
    nroContacto1 VARCHAR(15),
    nroContacto2 VARCHAR(15),
    correo VARCHAR(100),
    direccion VARCHAR(150)
);
CREATE TABLE CARGO (
    CodCargo VARCHAR(10) PRIMARY KEY,
    nombreCargo VARCHAR(50) NOT NULL,
    salarioBase DECIMAL(10, 2) NOT NULL
);
CREATE TABLE EMPLEADO (
    nroDocE VARCHAR(15) PRIMARY KEY,         
    tipoDoc VARCHAR(15) NOT NULL,            
    primerNom VARCHAR(50) NOT NULL,
    apellidoP VARCHAR(50) NOT NULL,
    apellidoM VARCHAR(50) NOT NULL,
    nroContacto VARCHAR(15),
    fechaContrato DATE NOT NULL,
    CodCargo VARCHAR(10),
    FOREIGN KEY (CodCargo) REFERENCES CARGO (CodCargo)
);

CREATE TABLE CLIENTE (
    nroDocC VARCHAR(15) PRIMARY KEY,   
    tipoDoc VARCHAR(15) NOT NULL,           
    primerNom VARCHAR(50) NOT NULL,
    apellidoP VARCHAR(50),
    apellidoM VARCHAR(50),
    direccion VARCHAR(150)
);

CREATE TABLE PRODUCTO (
    IDProducto VARCHAR(10) PRIMARY KEY,      
    nomProd VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    categoria VARCHAR(50),
    precio DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    CHECK (stock >=0,
    nroDocProveedor VARCHAR(15),
    FOREIGN KEY (nroDocProveedor) REFERENCES PROVEEDOR(nroDocProveedor)
);

CREATE TABLE BOLETA (
    IDBoleta VARCHAR(15) PRIMARY KEY,         
    Fecha_hora DATETIME NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    nroDocC VARCHAR(15),                     
    nroDocE VARCHAR(15),                
    FOREIGN KEY (nroDocC) REFERENCES CLIENTE(nroDocC), 
    FOREIGN KEY (nroDocE) REFERENCES EMPLEADO(nroDocE)
);

CREATE TABLE DETALLE_BOLETA (
    PRIMARY KEY (IDBoleta, IDProducto),
    IDBoleta VARCHAR(15),
    IDProducto VARCHAR(10),                
    nomProd VARCHAR(100) NOT NULL,     --BUENA PRACTICA DENOMINADA SNAPSHOT       
    precioUnit DECIMAL(10, 2) NOT NULL,--Sirve para el historial de la venta y que los precios no se modifiquen
    cantVendida INT NOT NULL,
    FOREIGN KEY (IDBoleta) REFERENCES BOLETA(IDBoleta),
    FOREIGN KEY (IDProducto) REFERENCES PRODUCTO(IDProducto)
);



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

CREATE TABLE EMPLEADO (
    nroDocE VARCHAR(15) PRIMARY KEY,         
    tipoDoc VARCHAR(15) NOT NULL,            
    primerNom VARCHAR(50) NOT NULL,
    apellidoP VARCHAR(50) NOT NULL,
    apellidoM VARCHAR(50) NOT NULL,
    nroContacto VARCHAR(15),
    fechaContrato DATE NOT NULL,
    cargo VARCHAR(50),
    salarioMen DECIMAL(10, 2)
);

CREATE TABLE CLIENTES (
    nroDocC VARCHAR(15) PRIMARY KEY,   
    tipoDoc VARCHAR(15) NOT NULL,           
    primerNom VARCHAR(50) NOT NULL,
    apellidoP VARCHAR(50),
    apellidoM VARCHAR(50),
    direccion VARCHAR(150)
);

CREATE TABLE PRODUCTOS (
    IDProducto VARCHAR(10) PRIMARY KEY,       -- IDProducto*
    nomProd VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    categoria VARCHAR(50),
    precio DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    nroDocProveedor VARCHAR(15),
    FOREIGN KEY (nroDocProveedor) REFERENCES PROVEEDOR(nroDocProveedor)
);

CREATE TABLE BOLETA (
    IDBoleta VARCHAR(15) PRIMARY KEY,         
    Fecha_hora DATETIME NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    nroDocC VARCHAR(15),                     
    nroDocE VARCHAR(15),                
    FOREIGN KEY (nroDocC) REFERENCES CLIENTES(nroDocC), 
    FOREIGN KEY (nroDocE) REFERENCES EMPLEADO(nroDocE)
);

CREATE TABLE DETALLE_BOLETA (
    IDBoleta VARCHAR(15),
    IDProducto VARCHAR(10),                
    nomProd VARCHAR(100) NOT NULL,            
    precioUnit DECIMAL(10, 2) NOT NULL,
    cantVendida INT NOT NULL,
    PRIMARY KEY (IDBoleta, IDProducto),
    FOREIGN KEY (IDBoleta) REFERENCES BOLETA(IDBoleta),
    FOREIGN KEY (IDProducto) REFERENCES PRODUCTOS(IDProducto)
);

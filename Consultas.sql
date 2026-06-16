--Consultas
--1.Productos de una categoria
SELECT nomProd, precio, stock, categoria 
FROM PRODUCTOS WHERE categoria = 'Barras de Chocolate';

--2. Productos con bajo stock
SELECT nomProd, stock FROM PRODUCTOS 
WHERE stock < 10 ORDER BY stock ASC;

--3.Contratos de 2026
SELECT primerNom, apellidoP, cargo FROM EMPLEADO 
WHERE fechaContrato >= '2026-01-01';

--4. Total de productos por categoria 
SELECT categoria, COUNT(*) as 'Total Productos' 
FROM PRODUCTOS  GROUP BY categoria;

--5. Valor total del inventario
SELECT categoria, SUM(precio * stock) as 'Valor Total Inventario' 
FROM PRODUCTOS  GROUP BY categoria;

--6. Salario por cargo 
SELECT cargo, AVG(salarioMen) as 'Salario Promedio' 
FROM EMPLEADO GROUP BY cargo;

--7. Productos de proveedores
SELECT p.nomProd, pr.nomEmpresa, pr.nroContacto1 
FROM PRODUCTOS p INNER JOIN PROVEEDOR pr ON p.nroDocProveedor = pr.nroDocProveedor;

--8. Unimos productos con proveedores
SELECT p.nomProd, p.precio, pr.nomEmpresa FROM PRODUCTOS p
INNER JOIN PROVEEDOR pr ON p.nroDocProveedor = pr.nroDocProveedor 
WHERE p.precio > 20;

--9. Proveedores sin productos registrados
SELECT pr.nomEmpresa FROM PROVEEDOR pr
LEFT JOIN PRODUCTOS p ON pr.nroDocProveedor = p.nroDocProveedor
WHERE p.IDProducto IS NULL;

--10. Total de personas o empresas registradas
SELECT primerNom as 'Nombre' FROM CLIENTES
UNION
SELECT primerNom FROM EMPLEADO;
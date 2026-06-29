--Consultas
-- 1. Productos por categoria
SELECT nomProd, precio, stock, categoria FROM PRODUCTO 
WHERE categoria = 'Barras de Chocolate';

-- 2. Productos con bajo stock
SELECT nomProd, stock FROM PRODUCTO 
WHERE stock < 10 ORDER BY stock ASC;

-- 3. Contratos de 2026 
SELECT E.primerNom, E.apellidoP, C.nombreCargo FROM EMPLEADO E
INNER JOIN CARGO C ON E.CodCargo = C.CodCargo
WHERE E.fechaContrato >= '2026-01-01';

-- 4. Total de productos por categoria 
SELECT categoria, COUNT(*) as 'Total Productos' 
FROM PRODUCTO GROUP BY categoria;

-- 5. Valor total del inventario
SELECT categoria, SUM(precio * stock) as 'Valor Total Inventario' 
FROM PRODUCTO GROUP BY categoria;

-- 6. Salario por cargo
SELECT nombreCargo, salarioBase FROM CARGO;

-- 7. Productos de proveedores 
SELECT p.nomProd, pr.nomEmpresa, pr.nroContacto1 
FROM PRODUCTO p 
INNER JOIN PROVEEDOR pr ON p.nroDocProveedor = pr.nroDocProveedor;

-- 8. Productos con precio mayor a 20 
SELECT p.nomProd, p.precio, pr.nomEmpresa 
FROM PRODUCTO p
INNER JOIN PROVEEDOR pr ON p.nroDocProveedor = pr.nroDocProveedor 
WHERE p.precio > 20;

-- 9. Proveedores sin productos registrados
SELECT pr.nomEmpresa FROM PROVEEDOR pr
LEFT JOIN PRODUCTO p ON pr.nroDocProveedor = p.nroDocProveedor
WHERE p.IDProducto IS NULL;

-- 10. Total de nombres registrados
SELECT primerNom FROM CLIENTE 
UNION
SELECT primerNom FROM EMPLEADO;
USE LaShiliquitaBD;
INSERT INTO CARGO (CodCargo, nombreCargo, salarioBase) VALUES 
('C001', 'Administrador', 2500.00),
('C002', 'Cajero', 1200.00),
('C003', 'Encargado almacén', 1500.00),
('C004', 'Limpieza', 1200.00);

INSERT INTO EMPLEADO (nroDocE, tipoDoc, primerNom, apellidoP, apellidoM, nroContacto, fechaContrato, CodCargo) VALUES 
('20514261', 'DNI', 'Amelia', 'Caruajulca', 'Muñoz', '951425633', '2026-01-15', 'C001'),
('74182930', 'DNI', 'Carlos', 'Vigo', 'Pereyra', '942819304', '2025-06-01', 'C002'),
('48192034', 'DNI', 'Jorge', 'Saldaña', 'Rojas', '963810294', '2025-10-10', 'C003');

INSERT INTO PROVEEDOR (nroDocProveedor, tipoDoc, nomEmpresa, nroContacto1, nroContacto2, correo, direccion)
VALUES 
('20543218901', 'RUC', 'Cacao Nativo San Ignacio SAC', '943210584', NULL, 'ventas@cacaonativo.pe', 'Jr. Comercio 432, San Ignacio'),
('20194837261', 'RUC', 'Distribuidora Dulces del Norte', '951847201', NULL, 'contacto@dulcesnorte.com', 'Av. Industrial 520, Chiclayo'),
('10428193042', 'RUC', 'Envolturas y Empaques Cajamarca', '974810293', '920000000', 'empaquescajaofficial@gmail.com', 'Jr. Tarapacá 812, Cajamarca');

INSERT INTO CLIENTE (nroDocC, tipoDoc, primerNom, apellidoP, apellidoM, direccion)
VALUES 
('72819304', 'DNI', 'Luis', 'Robles', 'Castro', 'Jr. Amalia Puga 450, Cajamarca'),
('17281930410', 'RUC', 'Cafetería El Grano SAC', NULL, NULL, 'Av. El Maestro 789, Cajamarca'),
('45218392', 'DNI', 'María', 'Mendoza', 'Portal', 'Jr. Dos de Mayo 112, Cajamarca'),
('20748192031', 'RUC', 'Inversiones Turísticas del Norte', NULL, NULL, 'Av. Vía de Evitamiento 1015, Cajamarca');

INSERT INTO PRODUCTO (IDProducto, nomProd, descripcion, categoria, precio, stock, nroDocProveedor)
VALUES 
('PROD01', 'PackX2 Chocolate 100g', 'Barra de chocolate amargo 100%', 'Packs y Regalos', 15.00, 12, '20543218901'),
('PROD02', 'Chocolate 250g', 'Barra de chocolate amargo 100%', 'Barras de Chocolate', 17.00, 7, '20543218901'),
('PROD03', 'Chocolate 100g', 'Barra de chocolate amargo 100%', 'Barras de Chocolate', 9.00, 12, '20543218901'),
('PROD04', 'Chocolate 100g', 'Barra de chocolate amargo 90%', 'Barras de Chocolate', 17.00, 18, '20543218901'),
('PROD05', 'Chocolate 100g', 'Barra de chocolate amargo 70%', 'Barras de Chocolate', 17.00, 18, '20543218901'),
('PROD06', 'Chocolate 100g', 'Barra de chocolate amargo 50%', 'Barras de Chocolate', 17.00, 30, '20543218901'),
('PROD07', 'Chocolate 100g', 'Barra amargo 70% SIN AZUCAR', 'Barras de Chocolate', 18.00, 18, '20543218901'),
('PROD08', 'Chocolate 100g', 'Barra amargo 50% SIN AZUCAR', 'Barras de Chocolate', 18.00, 18, '20543218901'),
('PROD09', 'Black Chocolate', 'Barra de chocolate amargo 100%', 'Barras de Chocolate', 17.00, 20, '20543218901'),
('PROD10', 'Chocolate Blanco', 'Barra de chocolate blanco', 'Barras de Chocolate', 17.00, 18, '20543218901'),
('PROD11', 'Golden Berry', 'Aguaimanto 100gr', 'Otros', 7.00, 4, '20194837261'),
('PROD12', 'Café Gourmet', 'Café Chotano selecto', 'Otros', 21.00, 10, '20194837261'),
('PROD13', 'Almendras', 'Almendras 100 gr', 'Otros', 9.00, 6, '20194837261'),
('PROD14', 'Té de cacao', 'Caja de 25 unidades', 'Bebidas de Cacao', 9.00, 3, '20194837261'),
('PROD15', 'Cacao en polvo', 'Bolsa de 1 kg', 'Bebidas de Cacao', 17.00, 6, '20194837261'),
('PROD16', 'Cajita Rellenos 6un', 'Bombones rellenos de manjar y frutas', 'Chocolates Rellenos', 25.00, 10, '20543218901'),
('PROD17', 'Cajita Rellenos 12un', 'Surtido de rellenos de licor y frutos secos', 'Chocolates Rellenos', 45.00, 8, '20543218901'),
('PROD18', 'Trufas Clásicas', 'Caja de 6 trufas de chocolate bitter', 'Trufas y Bombones', 20.00, 15, '20543218901'),
('PROD19', 'Bombones Premium', 'Selección de bombones con frutos amazónicos', 'Trufas y Bombones', 35.00, 12, '20543218901'),
('PROD20', 'Pack Experiencia', 'Incluye 2 barras, té de cacao y una taza', 'Packs y Regalos', 60.00, 5, '20194837261'),
('PROD21', 'Regalo Gourmet', 'Cesta con productos seleccionados de la región', 'Packs y Regalos', 95.00, 3, '20194837261'),
('PROD22', 'Cacao Energético', 'Mezcla para preparar bebida instantánea 500g', 'Bebidas de Cacao', 22.00, 10, '20194837261'),
('PROD23', 'Cacao Kids', 'Cacao endulzado con panela 300g', 'Bebidas de Cacao', 18.00, 12, '20194837261');


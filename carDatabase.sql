CREATE DATABASE cars;
CREATE TABLE car(
ID INT PRIMARY KEY AUTO_INCREMENT,
CarBrand TEXT,
Price TEXT,
EngineSize TEXT,
UseOfGas Text,
MODIFIED DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
CREATED DATETIME DEFAULT CURRENT_TIMESTAMP
)

INSERT INTO car(CarBrand, Price, EngineSize, UseOfGas)
VALUES('Renault Megane', '206.900 DKK', '115hp', '23km/L');

INSERT INTO car(CarBrand, Price, EngineSize, UseOfGas)
VALUES('Kia Cee´d', '214.999 DKK', '136hp', '17km/L');

INSERT INTO car(CarBrand, Price, EngineSize, UseOfGas)
VALUES('Mercedes A200', '402.300 DKK', '184hp', '15,4km/L');

INSERT INTO car(CarBrand, Price, EngineSize, UseOfGas)
VALUES('Tesla Model S', '669.820 DKK', '259hp', 'none. Its electic lol');


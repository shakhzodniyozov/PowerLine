CREATE TABLE IF NOT EXISTS customers
(
    id SERIAL PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS orders
(
    id SERIAL PRIMARY KEY,
    customerId INTEGER NOT NULL,
    FOREIGN KEY (customerId) REFERENCES customers (id)
);

INSERT INTO customers(name) VALUES('Max');
INSERT INTO customers(name) VALUES('Pavel');
INSERT INTO customers(name) VALUES('Ivan');
INSERT INTO customers(name) VALUES('Leonid');

INSERT INTO orders(customerId) VALUES(2);
INSERT INTO orders(customerId) VALUES(4);

SELECT c.name FROM customers c
LEFT JOIN orders o ON o.customerId = c.id
WHERE o.customerId IS NULL

-- add_cart.sql
-- Stefan Grace - ITWD7.358 Project 2
-- 2021


USE project2;

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (1, "CPU", "Intel Core i7-4790", 400, 1);

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (2, "Graphics Card", "NVIDIA GeForce GTX 1060", 300, 1);

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (3, "Hard Drive", "2 TB WD Black", 190, 2);

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (4, "Hard Drive", "10 TB Seagate Barracuda Pro", 650, 1);

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (5, "Monitor", "Dell U2412M", 250, 2);

INSERT INTO cart (item_id, item_category, product_name, item_price, qty)
VALUES (6, "Monitor", "Dell P2415Q", 580, 1);

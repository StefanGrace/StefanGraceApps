-- create_db.sql
-- Stefan Grace - ITWD7.358 Project 2
-- 2021


CREATE DATABASE project2;
USE project2;


CREATE TABLE categories (
	category_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	category_name VARCHAR(20) DEFAULT NULL,
	--
	PRIMARY KEY (category_id),
	UNIQUE full_name (category_name)
) ENGINE=MyISAM;


CREATE TABLE products (
	product_id INT UNSIGNED NOT NULL,
	category_id INT UNSIGNED NOT NULL,
	product_name VARCHAR(60) NOT NULL,
	price DECIMAL(6, 2) UNSIGNED NOT NULL,
	description VARCHAR(255) DEFAULT NULL,
	image_name VARCHAR(60) NOT NULL,
	--
	PRIMARY KEY (product_id),
	INDEX (category_id),
	INDEX (product_name),
	INDEX (price)
) ENGINE=MyISAM;


CREATE TABLE customers (
	customer_id INT UNSIGNED NOT NULL,
	email VARCHAR(60) NOT NULL,
	pass CHAR(40) NOT NULL,
	--
	PRIMARY KEY (customer_id),
	UNIQUE (email),
	INDEX login (email, pass)
) ENGINE=MyISAM;


CREATE TABLE orders (
	order_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	customer_id INT UNSIGNED NOT NULL,
	total DECIMAL(10, 2) UNSIGNED NOT NULL,
	order_date TIMESTAMP,
	--
	PRIMARY KEY (order_id),
	INDEX (customer_id),
	INDEX (order_date)
) ENGINE=InnoDB;


CREATE TABLE order_contents (
	oc_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	order_id INT UNSIGNED NOT NULL,
	product_id INT UNSIGNED NOT NULL,
	quantity TINYINT UNSIGNED NOT NULL DEFAULT 1,
	price DECIMAL(6, 2) UNSIGNED NOT NULL,
	ship_date DATETIME DEFAULT NULL,
	--
	PRIMARY KEY (oc_id),
	INDEX (order_id),
	INDEX (product_id),
	INDEX (ship_date)
) ENGINE=InnoDB;


CREATE TABLE cart (
	item_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	item_category VARCHAR(20) NOT NULL,
	product_name VARCHAR(60) NOT NULL,
	item_price DECIMAL(6, 2) UNSIGNED NOT NULL,
	qty INT UNSIGNED NOT NULL,
	--
	PRIMARY KEY (item_id)
);
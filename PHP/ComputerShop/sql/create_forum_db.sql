-- create_forum_db.sql
-- Stefan Grace - ITWD7.358 Project 2
-- 2021


USE project2;


-- Create tables

CREATE TABLE languages (
	lang_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
	lang VARCHAR(60) NOT NULL,
	lang_eng VARCHAR(20) NOT NULL,
	--
	PRIMARY KEY (lang_id),
	UNIQUE (lang)
);

CREATE TABLE threads (
	thread_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	lang_id TINYINT(3) UNSIGNED NOT NULL,
	user_id INT UNSIGNED NOT NULL,
	subject VARCHAR(150) NOT NULL,
	posted_by VARCHAR(30),
	replies INT,
	--
	PRIMARY KEY (thread_id),
	INDEX (lang_id),
	INDEX (user_id)
);

CREATE TABLE posts (
	post_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	thread_id INT UNSIGNED NOT NULL,
	user_id INT UNSIGNED NOT NULL,
	message TEXT NOT NULL,
	posted_on DATETIME NOT NULL,
	--
	PRIMARY KEY (post_id),
	INDEX (thread_id),
	INDEX (user_id)
);

CREATE TABLE users (
	user_id MEDIUMINT UNSIGNED NOT NULL,
	lang_id TINYINT UNSIGNED NOT NULL,
	time_zone VARCHAR(30) NOT NULL,
	username VARCHAR(30) NOT NULL,
	pass CHAR(40) NOT NULL,
	email VARCHAR(60) NOT NULL,
	--
	PRIMARY KEY (user_id),
	UNIQUE (username),
	UNIQUE (email),
	INDEX login (username, pass)
);


-- Populate tables

INSERT INTO languages (lang, lang_eng) VALUES
('English', 'English');

INSERT INTO users (user_id, lang_id, time_zone, username, pass, email) VALUES
(1, 1, 'Pacific/Auckland', 'Stefan', SHA1('stefan123'), 'graces3@student.eit.ac.nz'),
(2, 1, 'America/New_York', 'Test', SHA1('pass123'), 'email1@example.com');

INSERT INTO `threads` (`thread_id`, `lang_id`, `user_id`, `subject`, posted_by, replies) VALUES
(1, 1, 1, 'Sample thread', 'Stefan', 1),
(2, 1, 2, 'Test', 'Test', 0),
(3, 1, 2, 'Available products', 'Test', 2);


INSERT INTO `posts` (`post_id`, `thread_id`, `user_id`, `message`, `posted_on`) VALUES
(1, 1, 1, 'This is the body of the sample thread. This is the body of the sample thread. This is the body of the sample thread. ', '2021-06-17 10:30:02'),
(2, 1, 2, 'I like your thread. It''s simple and sweet.', '2021-06-17 22:15:58'),
(3, 2, 2, 'This is a test.', '2021-06-17 22:24:23'),
(4, 3, 2, 'What products are available in your shop?', '2021-06-17 22:29:05'),
(5, 3, 1, 'We sell CPUs, Graphics Cards, Hard Drives and Monitors.', '2021-06-17 22:29:56'),
(6, 3, 2, 'OK thanks.', '2021-06-17 22:30:40');
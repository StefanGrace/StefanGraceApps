-- add_products.sql
-- Stefan Grace - ITWD7.358 Project 2
-- 2021


USE project2;


-- CPUs

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (1, 1, "Intel Core i7-4790", 400, "
Cores: 4<br />
Threads: 8<br />
Base clock: 3.6 GHz<br />
Boost clock: 4.0 GHz<br />
Cache: 8 MB<br />
Socket: LGA1150<br />
TDP: 84 W",
"cpu_i7-4790");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (2, 1, "AMD Ryzen 9 5950X", 1200, "
Cores: 16<br />
Threads: 32<br />
Base clock: 3.4 GHz<br />
Boost clock: 4.9 GHz<br />
Cache: 72 MB<br />
Socket: AM4<br />
TDP: 105 W",
"cpu_ryzen9_5950x");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (3, 1, "AMD Ryzen Threadripper 3990X", 7600, "
Cores: 64<br />
Threads: 128<br />
Base clock: 2.9 GHz<br />
Boost clock: 4.3 GHz<br />
Cache: 288 MB<br />
Socket: sTRX4<br />
TDP: 280 W",
"cpu_ryzen_threadripper_3990x");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (4, 1, "AMD Ryzen 3 3200G", 175, "
Cores: 4<br />
Threads: 4<br />
Base clock: 3.6 GHz<br />
Boost clock: 4.0 GHz<br />
Cache: 6 MB<br />
Socket: AM4<br />
TDP: 65 W",
"cpu_ryzen3_3200g");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (5, 1, "Intel Core i9-10980XE", 1700, "
Cores: 18<br />
Threads: 36<br />
Base clock: 3.0 GHz<br />
Boost clock: 4.8 GHz<br />
Cache: 24.75 MB<br />
Socket: LGA2066<br />
TDP: 165 W",
"cpu_i9-10980xe");


-- Graphics Cards

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) VALUES (6, 2, "NVIDIA GeForce GT 1030", 100, "Video RAM: 2 GB", "gpu_gt-1030");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) VALUES (7, 2, "NVIDIA GeForce GTX 1060", 300, "Video RAM: 3 GB", "gpu_gtx-1060");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) VALUES (8, 2, "AMD Radeon RX 6700 XT", 1560, "Video RAM: 12 GB", "gpu_rx-6700xt");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) VALUES (9, 2, "NVIDIA GeFore RTX 3070", 1700, "Video RAM: 8 GB", "gpu_rtx-3070");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) VALUES (10, 2, "NVIDIA GeFore RTX 3090", 4000, "Video RAM: 24 GB", "gpu_rtx-3090");


-- Hard Drives

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (11, 3, "1 TB WD Blue", 70, '
Capacity: 1 TB<br />
Form factor: 3.5"<br />
Interface: SATA 3<br />
Rotational speed: 7200 RPM',
"hdd_1TB_wd_blue");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (12, 3, "2 TB WD Black", 190, '
Capacity: 2 TB<br />
Form factor: 3.5"<br />
Interface: SATA 3<br />
Rotational speed: 7200 RPM',
"hdd_2TB_wd_black");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (13, 3, '4 TB Seagate Barracuda 2.5"', 300, '
Capacity: 4 TB<br />
Form factor: 2.5"<br />
Interface: SATA 3<br />
Rotational speed: 5400 RPM',
"hdd_4TB_seagate_barracuda_pro");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (14, 3, "10 TB Seagate Barracuda Pro", 650, '
Capacity: 10 TB<br />
Form factor: 3.5"<br />
Interface: SATA 3<br />
Rotational speed: 7200 RPM',
"hdd_10TB_seagate_barracuda_pro");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (15, 3, "18 TB WD Ultrastar", 1200, '
Capacity: 18 TB<br />
Form factor: 3.5"<br />
Interface: SATA 3<br />
Rotational speed: 7200 RPM',
"hdd_18_TB_wd_ultrastar");


-- Monitors

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (16, 4, "ASUS XG438Q", 1800, '
Resolution: 3840 x 2160<br />
Aspect ratio: 16:9<br />
Diagonal screen size: 43"<br />
Pixel density: 104 PPI<br />
Refresh rate: 120 Hz<br />
Panel type: VA<br />
Inputs: DisplayPort, HDMI, HDMI, HDMI<br />
USB hub: 2 x 3.0 ports',
"monitor_ASUS_G438Q");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (17, 4, "Dell P2415Q", 580, '
Resolution: 3840 x 2160<br />
Aspect ratio: 16:9<br />
Diagonal screen size: 24"<br />
Pixel density: 182 PPI<br />
Refresh rate: 60 Hz<br />
Panel type: IPS<br />
Inputs: DisplayPort, Mini DisplayPort, HDMI<br />
USB hub: 4 x 3.0 ports',
"monitor_Dell_P2415Q");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (18, 4, "Dell U2412M", 250, '
Resolution: 1920 x 1200<br />
Aspect ratio: 16:10<br />
Diagonal screen size: 24"<br />
Pixel density: 94 PPI<br />
Refresh rate: 60 Hz<br />
Panel type: IPS<br />
Inputs: VGA, DVI, DisplayPort<br />
USB Hub: 4 x 2.0 ports',
"monitor_Dell_U2412M");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (19, 4, "Gigabyte FI32Q", 1600, '
Resolution: 2560 x 1440<br />
Aspect ratio: 16:9<br />
Diagonal screen size: 32"<br />
Pixel density: 92 PPI<br />
Refresh rate: 165 Hz<br />
Panel type: IPS<br />
Inputs: DisplayPort, HDMI, HDMI<br />
USB Hub: Built in KVM',
"monitor_Gigabyte_FI32Q");

INSERT INTO products(product_id, category_id, product_name, price, description, image_name) 
VALUES (20, 4, "Samsung Odyssey G9 LC49G95TSSEXXY", 2800, '
Resolution: Resolution: 5120 x 1440<br />
Aspect ratio: 32:9<br />
Diagonal screen size: 49"<br />
Pixel density: 109 PPI<br />
Refresh rate: 240 Hz<br />
Panel type: VA<br />
Inputs: DisplayPort, DisplayPort, HDMI<br />
USB hub: 2x USB 3.0 ports',
"monitor_Samsung_Odyssey_G9_LC49G95TSSEXXY");
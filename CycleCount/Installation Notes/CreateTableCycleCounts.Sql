CREATE TABLE cyclecounts
(
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    item_sid BIGINT NOT NULL,
    store_sid BIGINT NOT NULL,
    alu VARCHAR(50),
    counted_qty DECIMAL(18,3),
    system_qty DECIMAL(18,3),
    count_date DATE
);

GRANT SELECT, INSERT, UPDATE, DELETE ON rpsods.cyclecounts TO 'reportuser'@'%';
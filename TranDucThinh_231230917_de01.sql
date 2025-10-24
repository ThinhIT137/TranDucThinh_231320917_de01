create database TranDucThinh_231230917_de01
go

CREATE TABLE HvtComputer (
    hvtComId CHAR(5) PRIMARY KEY,
    hvtComName NVARCHAR(100),
    hvtComPrice DECIMAL(12,2),
    hvtComImage NVARCHAR(255),
    hvtComStatus BIT
);

INSERT INTO HvtComputer (hvtComId, hvtComName, hvtComPrice, hvtComImage, hvtComStatus)
VALUES
('C001', N'Máy tính của Thịnh Trần', 25000000, N'images/computer_thinh.png', 1),  
('C002', N'Dell XPS 15', 38000000, N'images/dell_xps15.png', 1),
('C003', N'HP Pavilion Gaming', 28000000, N'images/hp_pavilion.png', 0);

SELECT * FROM HvtComputer;

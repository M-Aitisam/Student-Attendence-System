USE AttendanceDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SerialNo INT NOT NULL,
    RollId NVARCHAR(50) NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    IsPresent BIT NOT NULL,
    AttendanceDate DATETIME DEFAULT GETDATE()
);

Select * from  Students;
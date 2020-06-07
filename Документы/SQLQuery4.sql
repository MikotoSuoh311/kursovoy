USE master
IF EXISTS (SELECT * FROM SYS.DATABASES WHERE NAME='Courses_project')
DROP DATABASE Courses_project
GO
CREATE DATABASE Courses_project
ON PRIMARY
( NAME= Courses_project ,
FILENAME='c:\users\public\ Courses_project.mdf', SIZE=3 MB, MAXSIZE=100,
FILEGROWTH=10)
LOG ON
(NAME= Coursesproject,

FILENAME='c:\users\public\Coursesproject.ldf', SIZE=3MB, MAXSIZE=100,

FILEGROWTH=10)

GO
USE Courses_project
GO
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Disciplines' AND TYPE='U')
DROP TABLE Disciplines
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Groups' AND TYPE='U')
DROP TABLE Groups
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Students' AND TYPE='U')
DROP TABLE Students
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Teachers' AND TYPE='U')
DROP TABLE Teachers
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Guide' AND TYPE='U')
DROP TABLE Guide
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Course_Work' AND TYPE='U')
DROP TABLE Course_Work
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Subjects' AND TYPE='U')
DROP TABLE Subjects
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Registr' AND TYPE='U')
DROP TABLE Registr
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='SaveWork' AND TYPE='U')
DROP TABLE SaveWork
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME='Journal' AND TYPE='U')
DROP TABLE Journal
GO
Create Table Subjects
(
  Subjects_id INT PRIMARY KEY CHECK(Subjects_id>0),
  Subjects_name VARCHAR(50),
)
GO
Create Table Teachers
(
 Teachers_id INT PRIMARY KEY CHECK (Teachers_id>0),
 Teachers_name VARCHAR(50),
)
GO
Create Table Disciplines
(
  Disciplines_id INT PRIMARY KEY CHECK(Disciplines_id>0),
  Disciplines_name VARCHAR(50),
)
GO
Create Table Groups
(
  Groups_code int PRIMARY KEY CHECK(Groups_code>0),
  Groups_id INT NOT NULL,
  disciplines_id INT,
                    CONSTRAINT fk_disciplines_id FOREIGN KEY(disciplines_id)
					             REFERENCES Disciplines(Disciplines_id)
)
GO
Create Table Students
(
 Student_id INT PRIMARY KEY CHECK (Student_id>0),
 Fam VARCHAR(50),
 Fname VARCHAR(50),
 Last_name VARCHAR(50),
 groups_code int,
                    CONSTRAINT fk_groups_code FOREIGN KEY(groups_code)
					             REFERENCES Groups(Groups_code),
)
GO
Create Table Guide
(
 subjects_id INT,
 teachers_id INT,
 DateYear DATE PRIMARY KEY,
              CONSTRAINT fk_subjects_id FOREIGN KEY(subjects_id)
			               REFERENCES Subjects(Subjects_id),
			  CONSTRAINT fk_teachers_id FOREIGN KEY (teachers_id)
			               REFERENCES Teachers(Teachers_id),
)
GO
Create Table Course_Work
(
 Subjects_code INT,
 Student_code INT,
 disciplines_code INT,
 Theme VARCHAR(50) PRIMARY KEY,
 YearDate Date,
                 CONSTRAINT fk_Subject_code FOREIGN KEY(Subjects_code)
				              REFERENCES Subjects(Subjects_id),
				 CONSTRAINT fk_Student_code FOREIGN KEY (Student_code)
				              REFERENCES Students(Student_id),
				 CONSTRAINT fk_disciplines_code FOREIGN KEY(disciplines_code)
				              REFERENCES Disciplines(Disciplines_id),
)
GO
Create Table SaveWork
(
  SaveWork_id INT PRIMARY KEY CHECK(SaveWork_id>0),
  SaveWork_name VARCHAR(50),
)
GO
Create Table Journal
(
 Journal_id INT PRIMARY KEY CHECK(Journal_id>0),
 students_code INT,
 StageOne INT,
 StageTwo INT,
 Result INT,
                   CONSTRAINT fk_students_code FOREIGN KEY(students_code)
				               REFERENCES Students(Student_id),
)
GO
Create Table Registr
(
  Login VARCHAR(50) PRIMARY KEY,
  Password VARCHAR(50),
)
GO
INSERT INTO Subjects
VALUES('1','Русский язык'),
      ('2','Математика');
INSERT INTO Teachers
VALUES ('1','Гудкова Е.А.'),
       ('2','Фомина К.Н.');
INSERT INTO Disciplines
VALUES ('1','Программирование'),
       ('2','Прикладное');
INSERT INTO Groups
VALUES ('090203','1','1'),
       ('090302','2','2');
INSERT INTO Students
VALUES ('1','Горохов','Антон','Викторович','090203'),
       ('2','Ильин','Илья','Ильич','090302');
INSERT INTO Guide
VALUES ('1','1','2017-05-29'),
       ('2','2','2017-05-30');
INSERT INTO Course_Work
VALUES ('1','1','1','Учет курсовых работ','2020-06-05'),
       ('2','2','2','Учет автостоянок','2020-05-06');
INSERT INTO SaveWork
VALUES ('1','Учет машин'),
       ('2','Программа транспортиовки грузов');
INSERT INTO Journal
VALUES ('1','1','25','40','65'),
       ('2','2','60','40','100');
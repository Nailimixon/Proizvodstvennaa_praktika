USE Teachears
GO

CREATE TABLE positions (
	id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL
);

CREATE TABLE qualifications (
	id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL
);

CREATE TABLE teachers (
    id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    patronymic VARCHAR(50),
    birth_date DATE NOT NULL,
    hire_date DATE NOT NULL,
    position INT NOT NULL,
    qualification INT,
    email VARCHAR(100) UNIQUE,
    FOREIGN KEY (position) REFERENCES positions(id),
    FOREIGN KEY (qualification) REFERENCES qualifications(id)
);

CREATE TABLE subjects (
	id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL,
	all_hours INT NOT NULL
);

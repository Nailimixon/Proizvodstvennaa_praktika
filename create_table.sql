USE Teachears
GO

CREATE TABLE positions (
	id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE qualifications (
	id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL UNIQUE
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
	namen VARCHAR(50) NOT NULL UNIQUE,
	all_hours INT NOT NULL
);

CREATE TABLE works (
    id INT PRIMARY KEY IDENTITY(1,1),
    teacher_id INT NOT NULL,
    subject_id INT NOT NULL,
    academic_year  VARCHAR(9) NOT NULL,
    count_hours INT NOT NULL,
    is_there_an_exam BIT DEFAULT 0,
    FOREIGN KEY (teacher_id) REFERENCES teachers(id),
    FOREIGN KEY (subject_id) REFERENCES subjects(id),
);

CREATE TABLE level_types (
    id INT PRIMARY KEY IDENTITY(1,1),
	namen VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE achievements (
    id INT PRIMARY KEY IDENTITY(1,1),
    teacher_id INT NOT NULL,
    namen VARCHAR(100) NOT NULL,
    achi_date DATE NOT NULL,
    level_id INT NOT NULL,
    reward VARCHAR(50),
    FOREIGN KEY (teacher_id) REFERENCES teachers(id),
    FOREIGN KEY (level_id) REFERENCES level_types(id)
);
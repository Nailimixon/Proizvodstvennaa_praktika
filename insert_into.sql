USE Teachears
GO

INSERT INTO positions (namen)
VALUES (
	'Преподаватель'),
	('Техник'),
	('Классный руководитель');

INSERT INTO qualifications (namen)
VALUES (
	'Высшая категория'),
	('Первая категория'),
	('Вторая категория'),
	('Третья категория'),
	('Без категории');

INSERT INTO subjects (
	namen, all_hours) 
VALUES (
	'Информматика', 144),
	('Кибер кикиена', 150),
	('Физическая культура', 90),
	('Основы программирования на пайтон', 60);

INSERT INTO level_types (namen)
VALUES (
	'Внутриколледжный'),
	('Региональный'),
	('Всероссийский'),
	('Международнный');

INSERT INTO teachers (
	first_name, last_name, patronymic, birth_date, hire_date, position, qualification, email)
VALUES (
	'Богунов', 'Алексей', 'Николаевич', '1900', '1920', 1, 1, 'bogunov@.ru'),
	('Васина', 'Наталья', 'Викторовна', '1983', '2020', 3, 1, 'vasina@.ru'),
	('Адещенко', 'Алексей', 'Алексеевич', '1970', '1990', 1, 1, 'AAA@.ru'),
	('Баланцев', 'Сергей', 'Михайлович', '1990', '2023', 1, 1, 'god@.ru');

INSERT INTO works (
	teacher_id, subject_id, academic_year, count_hours, is_there_an_exam)
VALUES (
	2, 1, '2025-2026', 120, 1),
	(3, 2, '2025-2026', 130, 0),
	(4, 3, '2025-2026', 70, 0),
	(5, 4, '2025-2026', 40, 1);

INSERT INTO achievements (
	teacher_id, namen, achi_date, level_id, reward)
VALUES (
	2, 'Конкурс "Преподаватель года"', '2025-11-15', 2, 'Диплом I степени'),
	(2, 'Публикация статьи по SQL', '2025-01-20', 3, 'Сертификат автора'),
	(5, 'Олимпиада по программированию', '2025-05-12', 4, 'Грамота за 1 место');
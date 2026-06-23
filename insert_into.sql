USE Teachears
GO

INSERT INTO positions (namen)
VALUES (
	'Преподаватель'),
	('Старший преподаватель'),
	('Классный руководитель');

INSERT INTO qualifications (namen)
VALUES (
	'Высшая категория'),
	('Нисшая категория'),
	('Без категории');

INSERT INTO subjects (
	namen, all_hours) 
VALUES (
	'Информматика', 144),
	('Английский язык', 150),
	('Русский язык', 90),
	('Физическая культура', 60);

INSERT INTO level_types (namen)
VALUES (
	'Внутриколледжный'),
	('Региональный'),
	('Всероссийский'),
	('Международнный');
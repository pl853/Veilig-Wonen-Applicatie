DROP TABLE IF EXISTS student;
create table student (
	student_id char(6) PRIMARY KEY,
	naam char(25),
	achternaam char(35),
	bsn char(9),
	inschrijvings_jaar int
);
DROP TABLE IF EXISTS leraar;
create table leraar(
	bsn_leraar char(9) PRIMARY KEY,
	naam char(25),
	achternaam char(35),
	schaal int,
	salaris int
);

DROP TABLE IF EXISTS curcus;
create table curcus(
	curcus_code char(10) PRIMARY KEY,
	naam char(30),
	studiepunten int
);
DROP TABLE IF EXISTS opdrachten;
create table opdrachten (
	opdracht_code char(8) PRIMARY KEY,
	jaar int,
	geldig boolean 
);
DROP TABLE IF EXISTS studieprogramma;
create table studieprogramma(
	naam_curcus char(10),
	niveau char(8),
	duur char(2),
	code_pogramma char(4) PRIMARY KEY
);
DROP TABLE IF EXISTS student_curcus;
create table student_curcus (
	student_id char(6),
	curcus_code char(10),
	PRIMARY KEY (student_id, curcus_code)	
);
DROP TABLE IF EXISTS student_opdracht_leraar;
create table student_opdracht_leraar(
	student_id char(6),
	opdracht_code char(8),
	bsn_leraar char(9),
	voltooid boolean,
	PRIMARY KEY (student_id, opdracht_code, bsn_leraar)
);
DROP TABLE IF EXISTS leraar_curcus;
create table leraar_curcus(
	bsn_leraar char(9),
54	curcus_code char(10),	
	taak char(9),
	PRIMARY KEY (bsn_leraar, curcus_code)
);
DROP TABLE IF EXISTS student_studieprogramma;
create table student_studieprogramma(
	student_id char(6),
	code_pogramma char(4),
	voltooid boolean,
	PRIMARY KEY (student_id, code_pogramma)	
);

INSERT INTO student VALUES ('938013', 'Asjad', 'Hussain', '111222333', 2016),('938014','Pieter','Lems','123456782',2015), ('938015','Jawed','Balkhi','12345676',2015);
INSERT INTO leraar VALUES ('111222444', 'Bob', 'Eleveld', 150, 2500), ('111444333', 'Aninka', 'Langras', 155, 2560), ('444222333', 'Mohammed', 'Abbadi', 100, 2010);
INSERT INTO curcus VALUES ('Analyse_1_1', 'Analyse_Database', 4), ('Analyse_2_1', 'Analyse_Usability', 3),('Development_2_1', 'Python', 4);
INSERT INTO opdrachten VALUES ('2016_123', 2016, True), ('2016_456', 2016, False), ('2016_197', 2016, True);
INSERT INTO studieprogramma VALUES ('INF', 'Bachelor', '4', '2354'), ('TI', 'Master', '2', '2385'),('BIM', 'Bachelor', '4', '4637');
INSERT INTO student_curcus VALUES ('938013','Analyse_1_1'),('938014','Development_2_1'), ('938015','Analyse_2_1'), ('938016','Analyse_2_1'),('938017','Development_2_1'),('938018','Analyse_1_1');
INSERT INTO student_opdracht_leraar VALUES ('938013', '2016_123','111222444', TRUE), ('928198', '2016_123','111222444', TRUE), ('938014', '2016_456','111444333', FALSE), ('938015', '2016_123','111444333', FALSE);
INSERT INTO leraar_curcus VALUES ('111444333', 'Analyse_2_1', 'Les Geven'), ('111444333', 'Development_2_1', 'Les Geven'), ('444222333', 'Development_2_1', 'Les Geven'), ('111222444', 'Development_2_1', 'Les Geven'), ('111222444', 'Analyse_2_1', 'Les Geven'), ('111444333', 'Analyse_1_1', 'Les Geven'), ('111222444', 'Analyse_1_1', 'Ontwerpen');
INSERT INTO student_studieprogramma VALUES ('938013', '2354', TRUE), ('938014', '2385', TRUE), ('938015', '4637', FALSE);

/* 1. Give a list of cources plus number of students per teacher */
SELECT leraar.naam, student_curcus.curcus_code, count(student_curcus.student_id) FROM leraar
JOIN leraar_curcus ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
JOIN curcus ON curcus.curcus_code = leraar_curcus.curcus_code
JOIN student_curcus ON student_curcus.curcus_code = curcus.curcus_code
WHERE leraar_curcus.taak = 'Les Geven'
GROUP BY leraar.naam, student_curcus.curcus_code;

/* 2. Give a list of students that have not completed a study program */
SELECT student.student_id, student.naam, student.achternaam FROM student
JOIN student_studieprogramma ON student.student_id = student_studieprogramma.student_id
WHERE voltooid = FALSE;

/* 3. Give a list of teachers that are teaching courses, but do not work on assignments */
SELECT leraar.bsn_leraar FROM leraar
JOIN student_opdracht_leraar ON student_opdracht_leraar.bsn_leraar = leraar.bsn_leraar
JOIN leraar_curcus ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
WHERE leraar.bsn_leraar NOT IN (SELECT DISTINCT student_opdracht_leraar.bsn_leraar FROM student_opdracht_leraar)
AND leraar.bsn_leraar IN (
	SELECT DISTINCT leraar_curcus.bsn_leraar FROM leraar_curcus
	);
/* 4. Give a list of students per course per enrollment year. */
SELECT student_curcus.curcus_code, student.inschrijvings_jaar, student.naam FROM student
JOIN student_curcus ON student_curcus.student_id = student.student_id
ORDER BY student_curcus.curcus_code, student.inschrijvings_jaar; 

/* 5. Give a list of teachers that are teaching less than two classes or teachers that are teaching more than average. */
SELECT leraar.naam, COUNT(*) "total classes", count(*)/count(DISTINCT leraar_curcus.bsn_leraar ) as "AVG"  FROM leraar_curcus
JOIN leraar ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
WHERE taak = 'Les Geven'
GROUP BY leraar.naam
HAVING COUNT(*) < 2
OR count(*) > ( SELECT COUNT(*)/ COUNT(DISTINCT bsn_leraar) "AVG" FROM leraar_curcus ) ;

/* 6. Give a list of students that have completed an assignment. */
SELECT student.naam FROM student
JOIN student_opdracht_leraar ON student_opdracht_leraar.student_id = student.student_id
WHERE student_opdracht_leraar.voltooid = TRUE;

/* 7. Find the number of students per course taught by each teacher. */
SELECT leraar.naam, curcus.naam, count(student.naam) FROM leraar
JOIN leraar_curcus ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
JOIN curcus ON leraar_curcus.curcus_code = curcus.curcus_code
JOIN student_curcus ON student_curcus.curcus_code = curcus.curcus_code
JOIN student ON student_curcus.student_id = student.student_id
WHERE leraar_curcus.taak = 'Les Geven'
GROUP BY  curcus.naam, leraar.naam;

/* 8. Find the number of designed assignment per teacher. Output the bsn and the number of the assignments. */
SELECT leraar.bsn_leraar, count(leraar_curcus.curcus_code) FROM leraar_curcus
JOIN leraar ON leraar.bsn_leraar = leraar_curcus.bsn_leraar
WHERE leraar_curcus.taak = 'Ontwerpen'
GROUP BY leraar.bsn_leraar;

/* 9. */
SELECT * FROM (
/* leraren met meer dan 2000 salaris*/
	(SELECT leraar.naam as res1 FROM leraar 
	WHERE salaris > 2000 ) as a
	JOIN
/* bonus for curcus (100) maal 10% van het aantal studenten */
	(SELECT leraar.naam as res2 , count(DISTINCT leraar_curcus.curcus_code), count(DISTINCT student_curcus.student_id)
	FROM leraar
	JOIN leraar_curcus ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
	JOIN curcus ON curcus.curcus_code = leraar_curcus.curcus_code 
	JOIN student_curcus ON student_curcus.curcus_code = curcus.curcus_code
	GROUP BY leraar.naam) as b
	ON a.res1 = b.res2 
/* Bonus van 50 per designed assignment*/
	JOIN
	(SELECT leraar.naam as res3 FROM leraar
	JOIN leraar_curcus ON leraar_curcus.bsn_leraar = leraar.bsn_leraar
	WHERE leraar_curcus.taak = 'Ontwerpen') as c
	ON a.res1 = c.res3)

/* Iedereen boven schaal 10 stijgt met 500 salaris*/
SELECT leraar.naam FROM leraar
WHERE schaal > 10;


select boot.naam,kapitein.naam
from boot
join kapitein on boot.kapitein_ID=kapitein.kapitein_ID
where kapitein.naam = 'Asjad'

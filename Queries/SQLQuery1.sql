CREATE DATABASE se_db_pzdr;

USE se_db_pzdr;

CREATE TABLE se_tbl_emp(
	id INT PRIMARY KEY NOT NULL,
	title VARCHAR(5) NULL,
	f_name VARCHAR(50) NULL,
	l_name VARCHAR(50) NULL,
	img IMAGE NULL,
	age INT NULL,
	contact VARCHAR(15) NULL,
	address VARChAR(100) NULL,
	position VARCHAR(50) NULL,
	password VARCHAR(10) NULL
);

SELECT * FROM se_tbl_emp;

INSERT INTO se_tbl_emp (id , title , f_name , l_name , age , contact , address , position , password) VALUES (002 ,'Mr.', 'Randula' , 'Mawaththa' , 22 , '071-3812415' , 'Galigamuwa' , 'admin' , 'epic#98' );

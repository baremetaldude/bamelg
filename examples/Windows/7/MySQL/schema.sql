--
-- Created by %USERNAME%
--

-- setup db
create database Bamelg_Example;

-- setup user
create user 'bamelg'@'%' identified by 'Lj.jUef5DQJxcZC353Do6s21p@';
grant all privileges on Bamelg_Example.* to 'bamelg'@'%';
flush privileges;
quit;

-- setup tables
use Bamelg_Example;
show warnings;

drop table SomeData;
create table SomeData (
	id mediumint not null auto_increment,
	c0 bit,
	c1 integer,
	c2 smallint,
	c3 decimal,
	c4 numeric,
	c5 float,
	c6 real,
	c7 double precision,
	c8 bigint,
	c9 tinyint,
	c10 mediumint,
	c11 int,
	c12 decimal( 5, 2 ),
	`enum_value` ENUM( 'T','F' ) not null,
	
	primary key( id )
);

INSERT INTO `SomeData` ( `c0`, `c1`, `c2`, `c3`, `c4`, `c5`, `c6`, `c7`, `c8`, `c9`, `c10`, `c11`, `c12`, `enum_value` ) VALUES ( 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12.00, 'T' );
INSERT INTO `SomeData` ( `c0`, `c1`, `c2`, `c3`, `c4`, `c5`, `c6`, `c7`, `c8`, `c9`, `c10`, `c11`, `c12`, `enum_value` ) VALUES ( 1, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22.00, 'F' );

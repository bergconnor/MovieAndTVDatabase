/* Delete the tables if they already exist */
DROP TABLE IF EXISTS history;
DROP TABLE IF EXISTS favorites;
DROP TABLE IF EXISTS show_actor;
DROP TABLE IF EXISTS show_genre;
DROP TABLE IF EXISTS actors;
DROP TABLE IF EXISTS genres;
DROP TABLE IF EXISTS episodes;
DROP TABLE IF EXISTS seasons;
DROP TABLE IF EXISTS series;
DROP TABLE IF EXISTS movies;
DROP TABLE IF EXISTS shows;
DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS accounts;

/* Create the schema for our tables */
CREATE TABLE accounts(id 			int primary key auto_increment,
					  email			varchar(100) not null,
					  password		varchar(50) not null,
					  start 		date not null,
					  end 			date not null,
					  access_movie	boolean not null,
					  access_series	boolean not null,
					  constraint 	accounts_uq unique(email));

CREATE TABLE users(id 			int primary key,
				   name 		varchar(30) not null,
				   account_id	int not null,
				   constraint   users_uq unique(name, account_id),
				   constraint 	users_fk
				       foreign key(account_id) references accounts(id));

CREATE TABLE shows(id 			int not null primary key auto_increment,
				   name			varchar(100) not null,
				   homepage		varchar(200),
				   poster		varchar(100),
				   description	varchar(2000),
				   constraint   shows_uq unique(name, poster)) CHARACTER SET utf8 COLLATE utf8_general_ci;

CREATE TABLE movies(show_id 	int not null primary key,
					released	date,
					duration 	smallint,
					constraint 	movies_fk
						foreign key(show_id) references shows(id));

CREATE TABLE series(show_id 	int not null primary key,
					channel 	varchar(50),
					constraint	series_fk
						foreign key(show_id) references shows(id)) CHARACTER SET utf8 COLLATE utf8_general_ci;
	
CREATE TABLE seasons(num 		smallint not null,
					 show_id	int not null,
					 year 		smallint,
					constraint 	season_fk
						foreign key(show_id) references shows(id),
					constraint 	season_pk primary key(num,show_id));
	
CREATE TABLE episodes(num			smallint not null,
					  season_num	smallint not null,
					  show_id		int not null,
					  air_date		date,
					  name			varchar(500),
					  constraint 	episodes_fk1
				  	      foreign key(season_num) references seasons(num),
  					  constraint 	episodes_fk2
				  	      foreign key(show_id) references shows(id),
					  constraint 	episodes_pk primary key(num, season_num, show_id)) CHARACTER SET utf8 COLLATE utf8_general_ci;
	
CREATE TABLE genres(id 			int not null primary key auto_increment,
					name		varchar(30) not null,
					constraint	genres_uq unique(name));

CREATE TABLE actors(id		int not null primary key,
					name	varchar(50) not null) CHARACTER SET utf8 COLLATE utf8_general_ci;

CREATE TABLE show_genre(show_id		int not null,
						genre_id	int not null,
						constraint 	show_genre_fk1
							foreign key (show_id) references shows(id),
						constraint 	show_genre_fk2
							foreign key(genre_id) references genres(id),
						constraint 	show_genre_pk primary key(show_id, genre_id));

CREATE TABLE show_actor(show_id 	int not null,
						actor_id	int not null,
						constraint 	show_actor_fk1
							foreign key(show_id) references shows(id),
						constraint 	show_actor_fk2
							foreign key(actor_id) references actors(id),
						constraint 	show_actor_pk primary key(show_id, actor_id));

CREATE TABLE history(user_id	int not null,
 					 show_id 	int not null,
					 date 		date,
				 	 constraint history_fk1
					     foreign key(user_id) references users(id),
					 constraint history_fk2	
					     foreign key(show_id) references shows(id),
					 constraint history_pk primary key(user_id, show_id));


CREATE TABLE favorites(user_id 	    int not null,
					   show_id 		int not null,
					   date     	date,
				       constraint 	favorites_fk1
					       foreign key(user_id) references users(id),
				       constraint 	favorites_fk2
					       foreign key(show_id) references shows(id),
					   constraint favorites_pk primary key(user_id, show_id));
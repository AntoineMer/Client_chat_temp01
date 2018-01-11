use dlcdi_chat;

--DROP TABLE event;
--DROP TABLE users;
--DROP TABLE groups;

/*------------------------------------------------------------
-- Table: users
------------------------------------------------------------*/
CREATE TABLE users(
	login      CHAR (16)  NOT NULL ,
	gender     CHAR (1)  NOT NULL,
	email      VARCHAR (255) NOT NULL UNIQUE,
	passwd     CHAR (128)  NOT NULL ,
	registered DATETIME  NOT NULL ,
	birthday   DATETIME NOT NULL ,
	group_id   INT  NOT NULL ,
	CHECK (gender IN('M', 'F')),
	CONSTRAINT prk_constraint_users PRIMARY KEY NONCLUSTERED (login)
);


/*------------------------------------------------------------
-- Table: groups
------------------------------------------------------------*/
CREATE TABLE groups(
	group_id    INT IDENTITY (1,1) NOT NULL ,
	group_name  CHAR (16)  NOT NULL ,
	group_level TINYINT  NOT NULL ,
	CHECK(group_level > 0),
	CONSTRAINT prk_constraint_groups PRIMARY KEY NONCLUSTERED (group_id)
);


/*------------------------------------------------------------
-- Table: event
------------------------------------------------------------*/
CREATE TABLE event(
	event_id     INT IDENTITY (1,1) NOT NULL ,
	ip_address   CHAR (15)  NOT NULL ,
	event_date   DATETIME  NOT NULL ,
	message      TEXT  NOT NULL ,
	message_type CHAR (16)  NOT NULL ,
	login        CHAR (16)  NOT NULL ,
	CONSTRAINT prk_constraint_event PRIMARY KEY NONCLUSTERED (event_id)
);


CREATE INDEX event_message_type_idx ON event (message_type);

ALTER TABLE users ADD CONSTRAINT FK_users_group_id FOREIGN KEY (group_id) REFERENCES groups(group_id);
ALTER TABLE event ADD CONSTRAINT FK_event_login FOREIGN KEY (login) REFERENCES users(login);

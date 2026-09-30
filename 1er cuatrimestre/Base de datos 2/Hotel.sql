CREATE TABLE HOTEL(
	hotelNo INT,
	hotelName VARCHAR(50),
	city VARCHAR(50),
	PRIMARY KEY (hotelNo)
);

CREATE TABLE ROOM(
	roomNo INT,
	hotelNo INT,
	kind VARCHAR(50), /* <- "type" es una palabra reservada asique use "kind"*/
	price FLOAT,
	PRIMARY KEY(roomNo, hotelNo),
	FOREIGN KEY(hotelNo) REFERENCES HOTEL(hotelNo)
);

CREATE TABLE GUEST(
	guestNo INT,
	guestName VARCHAR(50),
	guestAddress VARCHAR(50),
	PRIMARY KEY(guestNo)
);


CREATE TABLE BOOKING(
	hotelNo INT,
	guestNo INT,
	dateFrom DATETIME,
	dateTo DATETIME,
	roomNo INT,
	PRIMARY KEY (hotelNo, guestNo, dateFrom),
	FOREIGN KEY(hotelNo) REFERENCES HOTEL(hotelNo),
	FOREIGN KEY(guestNo) REFERENCES GUEST(guestNo),
);

	
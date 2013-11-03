--select 'drop table '||table_name||' cascade constraints;' from user_tables;

DROP TABLE Reader;
CREATE TABLE Reader(
	Reader_Passport_ID INT NOT NULL PRIMARY KEY,
	Reader_First_Name VARCHAR(255) NOT NULL,
	Reader_Middle_Name VARCHAR(255) NOT NULL,
	Reader_Last_Name VARCHAR(255) NOT NULL,
	Reader_Address VARCHAR(255) NOT NULL,
	Reader_Phone VARCHAR(255) NOT NULL
);

DROP TABLE Card;
CREATE TABLE Card(
	Card_ID INT NOT NULL PRIMARY KEY,
	Card_Reader_Passport_ID INT NOT NULL,
	Card_Issue_Date DATE DEFAULT SYSDATE,
	Card_Expiry_Date DATE NOT NULL,
	FOREIGN KEY (Card_Reader_Passport_ID) REFERENCES Reader ON DELETE CASCADE,
	CHECK (Card_Issue_Date < Card_Expiry_Date)
);

DROP TABLE Publisher;
CREATE TABLE Publisher(
	Publisher_ID INT NOT NULL PRIMARY KEY,
	Publisher_Name VARCHAR(255) NOT NULL, 
	Publisher_Location VARCHAR(255) NOT NULL,
	Publisher_Description VARCHAR(1000)
);

DROP TABLE Author;
CREATE TABLE Author(
	Author_ID INT NOT NULL PRIMARY KEY,
	Author_First_Name VARCHAR(255) NOT NULL, 
	Author_Middle_Name VARCHAR(255) NOT NULL, 
	Author_Last_Name VARCHAR(255) NOT NULL, 
	Author_Biography VARCHAR(1000)
);

DROP TABLE Rubric;
CREATE TABLE Rubric(
	Rubric_ID INT NOT NULL PRIMARY KEY,
	Rubric_Parent_ID INT,
	Rubric_Name VARCHAR(255) NOT NULL,
	Rubric_Description VARCHAR(1000),
	FOREIGN KEY (Rubric_Parent_ID) REFERENCES Rubric ON DELETE SET NULL
);

DROP TABLE Book;
CREATE TABLE Book(
	Book_ID INT NOT NULL PRIMARY KEY,
	Book_Name VARCHAR(255) NOT NULL,
	Book_Imprint_Date DATE NOT NULL,
	Book_Page_Quantity INT NOT NULL,
	Book_Annotation VARCHAR(1000),
	Book_Quantity INT NOT NULL,
	Book_Rubric_ID INT NOT NULL,
	Book_Publisher_ID INT NOT NULL,
	Book_Create_Date DATE DEFAULT SYSDATE,
	FOREIGN KEY (Book_Rubric_ID) REFERENCES Rubric ON DELETE CASCADE,
	FOREIGN KEY (Book_Publisher_ID) REFERENCES Publisher ON DELETE CASCADE,
	CHECK(Book_Page_Quantity > 0),
	CHECK(Book_Imprint_Date < Book_Create_Date),
	CHECK(Book_Quantity > -1)
);

DROP TABLE Book_Author;
CREATE TABLE Book_Author(
	Book_Author_Book_ID	INT NOT NULL,
	Book_Author_Author_ID INT NOT NULL,
	Book_Author_Edition INT NOT NULL,
	PRIMARY KEY (Book_Author_Book_ID, Book_Author_Author_ID),
	FOREIGN KEY (Book_Author_Book_ID) REFERENCES Book ON DELETE CASCADE,
	FOREIGN KEY (Book_Author_Author_ID) REFERENCES Author ON DELETE CASCADE,
	CHECK(Book_Author_Edition > 0)
);

DROP TABLE Request;
CREATE TABLE Request(
	Request_ID INT NOT NULL,
	Request_Book_ID INT NOT NULL,
	Request_Card_ID INT NOT NULL,
	Request_Book_Quantity INT NOT NULL,
	Request_Create_Date DATE DEFAULT SYSDATE,
	PRIMARY KEY (Request_ID, Request_Book_ID),
	FOREIGN KEY (Request_ID) REFERENCES Book ON DELETE CASCADE,
	FOREIGN KEY (Request_Card_ID) REFERENCES Card ON DELETE CASCADE,
	CHECK(Request_Book_Quantity > 0)
);

DROP TABLE Reject_Reason;
CREATE TABLE Reject_Reason(
  Reject_Reason_ID INT NOT NULL PRIMARY KEY,
  Reject_Reason_Name VARCHAR(255) NOT NULL UNIQUE 
);

DROP TABLE Request_Rejected;
CREATE TABLE Request_Rejected(
	Request_Rejected_Request_ID INT NOT NULL,
	Request_Rejected_Book_ID INT NOT NULL,
	Request_Rejected_Reason_ID INT NOT NULL,
	PRIMARY KEY (Request_Rejected_Request_ID, Request_Rejected_Book_ID),
	FOREIGN KEY (Request_Rejected_Request_ID, Request_Rejected_Book_ID) REFERENCES Request(Request_ID, Request_Book_ID) ON DELETE CASCADE,
	FOREIGN KEY (Request_Rejected_Reason_ID) REFERENCES Reject_Reason(Reject_Reason_ID) ON DELETE CASCADE
);

DROP TABLE Request_Approved;
CREATE TABLE Request_Approved(
	Request_Approved_Request_ID INT NOT NULL,
	Request_Approved_Book_ID INT NOT NULL,
	Request_Approved_Return_Date DATE NOT NULL,
	Request_Approved_Renewal_Count INT DEFAULT 0,
	Request_Approved_Is_Returned INT DEFAULT 0,
	PRIMARY KEY (Request_Approved_Request_ID, Request_Approved_Book_ID),
	FOREIGN KEY (Request_Approved_Request_ID, Request_Approved_Book_ID) REFERENCES Request(Request_ID, Request_Book_ID) ON DELETE CASCADE,
	CHECK (Request_Approved_Renewal_Count BETWEEN  0 AND 5),
	CHECK (Request_Approved_Is_Returned IN (0, 1))
);

DROP TABLE Notification_Type;
CREATE TABLE Notification_Type(
  Notification_Type_ID INT NOT NULL PRIMARY KEY,
  Notification_Text VARCHAR(255) NOT NULL UNIQUE
);

DROP TABLE Notification;
CREATE TABLE Notification(
	Notification_Request_ID INT NOT NULL,
	Notification_Book_ID INT NOT NULL,
	Notification_Type_ID,
	PRIMARY KEY (Notification_Request_ID, Notification_Book_ID),
	FOREIGN KEY (Notification_Request_ID, Notification_Book_ID) REFERENCES Request(Request_ID, Request_Book_ID) ON DELETE CASCADE,
  FOREIGN KEY (Notification_Type_ID) REFERENCES Notification_Type(Notification_Type_ID) ON DELETE CASCADE
);

DROP TABLE  Role;
CREATE TABLE Role(
  Role_ID INT NOT NULL PRIMARY KEY,
  Role_Name VARCHAR(255) NOT NULL UNIQUE
);

DROP TABLE Employee;
CREATE TABLE Employee(
  Employee_ID INT NOT NULL PRIMARY KEY,
  Employee_Name VARCHAR(255) NOT NULL UNIQUE,
  Employee_Password VARCHAR(64) NOT NULL,
  Employee_Role_ID INT NOT NULL,
  FOREIGN KEY (Employee_Role_ID) REFERENCES Role(Role_ID) ON DELETE CASCADE
);

CREATE SEQUENCE Publisher_Sequence;
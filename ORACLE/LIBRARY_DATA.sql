DELETE FROM Request_Rejected;
DELETE FROM Request_Approved;
DELETE FROM Request;
DELETE FROM Book_Author;
DELETE FROM Book;
DELETE FROM Card;
DELETE FROM Reader;
DELETE FROM Publisher;
DELETE FROM Author;
DELETE FROM Rubric;

INSERT INTO Reader
           (Reader_Passport_ID, Reader_First_Name, Reader_Middle_Name, Reader_Last_Name, Reader_Address, Reader_Phone)
           SELECT 1, 'Иван', 'Иванович', 'Иванов', 'г. Москва, Ленинградское шоссе д. 1', '111-000-111' FROM dual
     UNION SELECT 2, 'Петр', 'Петрович', 'Петров', 'г. Москва, Ленинградское шоссе д. 2', '111-000-112' FROM dual
     UNION SELECT 3, 'Алексей', 'Васильевич', 'Сидоров', 'г. Москва, Ленинградское шоссе д. 3', '111-000-113' FROM dual
     UNION SELECT 4, 'Сергей', 'Владимирович', 'Федоров', 'г. Москва, Ленинградское шоссе д. 3', '111-000-114' FROM dual
     UNION SELECT 5, 'Владимир', 'Георгеевич', 'Исаев', 'г. Москва, Ленинградское шоссе д. 5', '113-000-115' FROM dual;

INSERT INTO Publisher
           (Publisher_ID, Publisher_Name, Publisher_Location, Publisher_Description)
           SELECT 1, 'Эксмо', 'г. Москва', '-' FROM dual
     UNION SELECT 2, 'АСТ', 'г. Москва', '-' FROM dual
     UNION SELECT 3, 'Просвещение', 'г. Санкт-Петербург', '-' FROM dual
	   UNION SELECT 4, 'Вильямс', 'г. Вашингтон', '-'  FROM dual;

INSERT INTO Author
           (Author_ID, Author_First_Name, Author_Middle_Name, Author_Last_Name, Author_Biography)
           SELECT 1, 'Александр', 'Сергеевич', 'Пушкин', '' FROM dual
     UNION SELECT 2, 'Петр', 'Иванович', 'Пирогов', '' FROM dual
	   UNION SELECT 3, 'Евгений', 'Петрович', 'Сидоров', '' FROM dual
	   UNION SELECT 4, 'Кирилл', 'Александрович', 'Кузнецов', '' FROM dual
	   UNION SELECT 5, 'Дмитрий', 'Евгеньевич', 'Толстой', '' FROM dual;

INSERT INTO Rubric
           (Rubric_ID, Rubric_Parent_ID, Rubric_Name, Rubric_Description)
           SELECT 1, NULL, 'Классическая литература', '' FROM dual
	   UNION SELECT 2, 1, 'Школьная учебная литература', '' FROM dual
	   UNION SELECT 3, NULL, 'Фантастика', '' FROM dual;

INSERT INTO Book
           (Book_ID, Book_Name, Book_Imprint_Date, Book_Page_Quantity, Book_Annotation, Book_Quantity, Book_Rubric_ID, Book_Publisher_ID)
           SELECT 1, 'Золотая рыбка', '20-12-2003', 100, '', 5, 1, 1 FROM dual
     UNION SELECT 2, 'Математика для школьников', '12-01-2013', 143, '', 39, 2, 2 FROM dual
     UNION SELECT 3, 'Война и мир', '12-01-2000', 500, '', 31, 3, 3 FROM dual
     UNION SELECT 4, 'Базы данных', '10-01-2004', 541, '', 10, 2, 1 FROM dual
     UNION SELECT 5, 'Программирование на С++', '12-12-2007', 1080, '', 55, 1, 2 FROM dual
     UNION SELECT 6, 'Словарь русского языка', '01-10-2000', 245, 'Словарь для самых безграмотных', 10, 2, 4 FROM dual
     UNION SELECT 7, 'ЗАВЕЩАНИЕ НОЧИ', '10-10-2005', 500, '', 50, 3, 1 FROM dual;

INSERT INTO Book_Author
           (Book_Author_Book_ID, Book_Author_Author_ID, Book_Author_Edition)
           SELECT 1, 1, 1 FROM dual
     UNION SELECT 2, 2, 2 FROM dual
     UNION SELECT 3, 3, 5 FROM dual
     UNION SELECT 6, 4, 5 FROM dual
     UNION SELECT 6, 5, 5 FROM dual;

INSERT INTO Card
           (Card_ID, Card_Reader_Passport_ID, Card_Issue_Date, Card_Expiry_Date)
           SELECT 1, 1, '10-12-2010', '10-12-2020' FROM dual
     UNION SELECT 2, 2, '10-01-2013', '10-01-2023' FROM dual
     UNION SELECT 3, 3, '11-01-2004', '11-01-2014' FROM dual
     UNION SELECT 4, 4, '20-01-2013', '20-01-2024' FROM dual
     UNION SELECT 5, 5, '20-01-2003', '20-01-2014' FROM dual;


INSERT INTO Request
           (Request_ID, Request_Book_ID, Request_Card_ID, Request_Book_Quantity)
           SELECT 1, 1, 1, 5 FROM dual
     UNION SELECT 1, 2, 1, 1 FROM dual
     UNION SELECT 1, 3, 1, 1 FROM dual
     UNION SELECT 1, 4, 1, 1 FROM dual
     UNION SELECT 2, 2, 2, 1 FROM dual
     UNION SELECT 2, 1, 2, 1 FROM dual
     UNION SELECT 3, 3, 3, 3 FROM dual
     UNION SELECT 3, 2, 3, 1 FROM dual
     UNION SELECT 4, 2, 2, 1 FROM dual
     UNION SELECT 5, 2, 2, 1 FROM dual
     UNION SELECT 7, 7, 3, 1 FROM dual;
	
  INSERT INTO Request_Approved
           (Request_Approved_Request_ID, Request_Approved_Book_ID, Request_Approved_Issue_Date, Request_Approved_Return_Date, Request_Approved_Book_Quantity, Request_Approved_Renewal_Count, Request_Approved_Is_Returned)
           SELECT 1, 1, '12-10-2013', '15-11-2013', 1, 0, 0 FROM dual
        UNION SELECT 1, 2, '15-10-2013', '15-11-2013', 1, 0, 0 FROM dual;
        /*UNION SELECT 1, 3, '3-12-2013', '15-10-2013', 1, 3, 0 FROM dual
        UNION SELECT 1, 4, '3-12-2013', '15-10-2013', 1, 4, 0 FROM dual
        UNION SELECT 2, 2, '3-12-2013', '15-10-2013', 1, 0, 0 FROM dual
        UNION SELECT 2, 1, '3-12-2013', '15-10-2013', 1, 0, 0 FROM dual
        UNION SELECT 7, 7, '3-12-2013', '15-10-2013', 1, 0, 0 FROM dual;*/
        /*
        UNION SELECT 3, 3, '3-12-2013', '5-15-2013', 1, 0, 0 FROM dual
        UNION SELECT 3, 2, '3-12-2013', '5-15-2013', 1, 0, 0 FROM dual
        UNION SELECT 4, 2, '3-12-2013', '5-15-2013', 1, 0, 0 FROM dual
        UNION SELECT 5, 2, '3-12-2013', '5-15-2013', 1, 0, 0 FROM dual;*/

INSERT INTO Request_Rejected
           (Request_Rejected_Request_ID, Request_Rejected_Book_ID, Request_Rejected_Reason)
		/*SELECT 1, 1, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION
		SELECT 1, 2, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION
		SELECT 1, 3, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION
		SELECT 1, 4, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION
		SELECT 2, 2, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION
		SELECT 2, 1, '3-12-2013', '5-15-2013', 1, 0, 0
		UNION*/
		SELECT 3, 3, 'ОБЕД' FROM dual
		UNION SELECT 3, 2, 'НЕЛЬЗЯ' FROM dual
		UNION SELECT 4, 2, 'ПЕРЕРЫВ' FROM dual
		UNION SELECT 5, 2, 'ОБЕД' FROM dual;
		
INSERT INTO Reject_Reason (Reject_Reason_ID, Reject_Reason_Name)
  VALUES(1, 'Отсутствует на складе');
INSERT INTO Reject_Reason (Reject_Reason_ID, Reject_Reason_Name)
  VALUES(2, 'Превышен допустимый лимит книг');
INSERT INTO Reject_Reason (Reject_Reason_ID, Reject_Reason_Name)
  VALUES(3, 'Запрос аннулирован по причине истечения срока давности');
  
INSERT INTO Notification_Type (Notification_Type_ID, Notification_Text)
	VALUES(1, 'Книга выдана');
	
INSERT INTO Notification_Type (Notification_Type_ID, Notification_Text)
	VALUES(2, 'Запрос аннулирован по истечению срока давности');
	
INSERT INTO Role (Role_ID, Role_Name)
	VALUES(0, 'Администратор');
INSERT INTO Role (Role_ID, Role_Name)
	VALUES(1, 'Библиограф');
INSERT INTO Role (Role_ID, Role_Name)
	VALUES(2, 'Оператор');
INSERT INTO Role (Role_ID, Role_Name)
	VALUES(3, 'Заведующий библиотекой');

	
INSERT INTO Employee (Employee_ID, Employee_Name, Employee_Password, Employee_Role_ID)
  VALUES(0, 'Администратор', '1917EE334D5A87B30E538265BF484448C46E70B69ADA3D599A64D8EF6E01F7F9', 0); 
INSERT INTO Employee (Employee_ID, Employee_Name, Employee_Password, Employee_Role_ID)
  VALUES(1, 'Библиограф', 'E7CA2C35359D856D014AEE9AACB65E56BFC8A295272539E3632E476C8271456A', 1);
INSERT INTO Employee (Employee_ID, Employee_Name, Employee_Password, Employee_Role_ID)
  VALUES(2, 'Оператор', '85516918546A9BFF3CAADDD2BED0B2B36CC740D341A863C8BE40F822B19CC487', 2);
INSERT INTO Employee (Employee_ID, Employee_Name, Employee_Password, Employee_Role_ID)
  VALUES(3, 'Заведующий библиотекой', '5D9251E95E1746D07CDE7152E1F3B008F58D3E7F98C609DD6214DCF4441DB75C', 3);
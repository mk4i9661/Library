create or replace TRIGGER AFTER_RESOLVE_REQUEST 
AFTER INSERT ON REQUEST
DECLARE
  total NUMBER;
  max_quantity NUMBER;
  book_available NUMBER;
  book_requested NUMBER;
  requestID NUMBER;
  cardID NUMBER;
  bookID NUMBER;
  return_date DATE;
BEGIN
  -- люйяхлюкэмне дносярхлне вхякн ймхц мю псйюу с вхрюрекъ
  SELECT GET_DEFAULT_MAX_BOOK_QUANTITY() INTO max_quantity FROM DUAL;
  -- дюрю бнгбпюрю он слнквюмхч
  SELECT get_default_return_date() INTO return_date FROM DUAL;
  
  FOR I IN 1 .. request_state.new_rows.count LOOP
    requestID := request_state.new_rows(i).RequestID;
    cardID := request_state.new_rows(i).CardID;
    bookID := request_state.new_rows(i).BookID;
    book_requested := request_state.new_rows(i).BookQuantity;
    
    -- бяецн ймхц мю псйюу с онкэгнбюрекъ
    SELECT get_unreturned_book_quantity(cardID) INTO total FROM dual;
    -- вхякн щйгелокъпнб ймхцх б ахакхнрейе
    SELECT Book_Quantity INTO book_available FROM Book WHERE Book_ID = bookID;
    
    IF book_available < book_requested THEN
    ---еякх ймхц меднярюрнвмн, рн нрйюг он опхвхме меубюрйх
    INSERT INTO Request_Rejected (Request_Rejected_Request_ID, Request_Rejected_Book_ID, Request_Rejected_Reason_ID)
    VALUES (requestID, bookID, 1);
    DBMS_OUTPUT.put_line('нрйюг он опхвхме меубюрйх');
  ELSIF total + book_requested > max_quantity THEN
    -- ймхц мю псйюу якхьйнл лмнцн, нрйюг он опхвхме анкэьнцн йнкхвеярбю ймхц
    INSERT INTO Request_Rejected (Request_Rejected_Request_ID, Request_Rejected_Book_ID, Request_Rejected_Reason_ID)
    VALUES (requestID, bookID, 2);
    DBMS_OUTPUT.put_line('гюопньемн ймхц анкэье вел днгбнкемн хлерэ мю псйюу');
  ELSE
      -- намнбкъел хрнцнбне вхякн ймхц б рюакхже ймхц
      UPDATE Book SET Book_Quantity = book_available - book_requested WHERE Book_ID = bookID;
      -- бяе мнплюкэмн, бшдюел ймхцс
      INSERT INTO Request_Approved (Request_Approved_Request_ID, Request_Approved_Book_ID, Request_Approved_Return_Date)
      VALUES (requestID, bookID, return_date);
      DBMS_OUTPUT.put_line('ймхцю бшдюмю');
  END IF;
  END LOOP;
END;

create or replace TRIGGER BEFORE_RESOLVE_REQUEST 
BEFORE INSERT ON REQUEST 
BEGIN
  request_state.new_rows := request_state.empty;
END;

create or replace TRIGGER RESOLVE_REQUEST 
AFTER INSERT ON REQUEST FOR EACH ROW
DECLARE
  item request_state.CardBook;

BEGIN
    item.RequestID := :new.Request_ID;
    item.CardID :=:new.Request_Card_ID;
    item.BookID := :new.Request_Book_ID;
    item.BookQuantity := :new.Request_Book_Quantity;
    request_state.new_rows(request_state.new_rows.count + 1) := item;
END;
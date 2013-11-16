create or replace PROCEDURE SEND_NOTIFICATIONS (
  sended out sended_notifications
) AS 
  from_request Request%ROWTYPE;
  total INTEGER;
  max_quantity INTEGER;
  book_available INTEGER;
  return_date DATE;
  sended_index INTEGER;
BEGIN
  DBMS_OUTPUT.put_line('BEGIN');
  
  sended := sended_notifications();
  
  -- люйяхлюкэмне дносярхлне вхякн ймхц мю псйюу с вхрюрекъ
  SELECT GET_DEFAULT_MAX_BOOK_QUANTITY() INTO max_quantity FROM DUAL;
  -- дюрю бнгбпюрю он слнквюмхч
  SELECT get_default_return_date() INTO return_date FROM DUAL;
  -- бяе нрйюгш, врн еые ме сярюпекх
  
  for from_rejected in (
    SELECT * FROM Request_Rejected WHERE request_rejected_reason_id != 3
  ) loop
    -- яюл гюопня, йнрнпнлс ашкн нрйюгюмн
    select * into from_request from Request WHERE Request_ID = from_rejected.Request_Rejected_Request_ID AND Request_Book_ID = from_rejected.Request_Rejected_Book_ID;
    
    IF is_outdated_request(from_request.request_create_date) = 1 THEN
      -- гюопня хярей он япнйс дюбмнярх, нропюбкъел рюйне сбеднлкемхе х лемъел бхд нрйюгю
      INSERT INTO Notification(Notification_Request_ID, Notification_Book_ID, Notification_Type_ID)
      VALUES(from_rejected.Request_Rejected_Request_ID, from_rejected.Request_Rejected_Book_ID, 2);
	  -- х днаюбкъел рс фе ярпнйс б йнккейжхч дкъ бнгбпюрю
      sended_index := sended.count + 1;
      sended.extend();
      sended(sended_index) := notification_object(0, 0, 0);
      sended(sended_index).Request_ID := from_rejected.Request_Rejected_Request_ID;
      sended(sended_index).Book_ID := from_rejected.Request_Rejected_Book_ID;
      sended(sended_index).Type_ID := 2;
      
      -- намнбкъел нрйюг йюй хярейьхи
      UPDATE Request_Rejected SET Request_Rejected_Reason_ID = 3
      WHERE Request_Rejected_Request_ID = from_rejected.Request_Rejected_Request_ID AND Request_Rejected_Book_ID = from_rejected.Request_Rejected_Book_ID;
      DBMS_OUTPUT.put_line('гЮОПНЯ ХЯРЕЙ ОН ЯПНЙС ДЮБМНЯРХ. сБЕДНЛКЕМХЕ НРОПЮБКЕМН');
    ELSE
      -- опнбепъел, лнфер кх онкэгнбюрекэ онксвхрэ ймхцс хяундъ хг кхлхрю ймхц мю псйюу
      SELECT get_unreturned_book_quantity(from_request.Request_Card_ID) INTO total FROM dual;
      DBMS_OUTPUT.put_line('бЯЕЦН ЙМХЦ МЮ ПСЙЮУ: '||total);
      
       -- вхякн щйгелокъпнб ймхцх б ахакхнрейе
      SELECT Book_Quantity INTO book_available FROM Book WHERE Book_ID = from_request.Request_Book_ID;
      -- хрнцнбне вхякн ймхц мю псйюу асдер лемэье кхлхрю х хлееряъ днярюрнвмне ймхц б ахакхнрейе
      IF total + from_request.Request_Book_Quantity <= max_quantity AND from_request.Request_Book_Quantity <= book_available THEN
        -- нй, намнбкъел вхякн ймхц мю яйкюде
        UPDATE Book SET Book_Quantity = book_available - from_request.Request_Book_Quantity WHERE Book_ID = from_request.Request_Book_ID;
        -- оняшкюел сбеднлкемхе
        INSERT INTO Notification(Notification_Request_ID, Notification_Book_ID, Notification_Type_ID)
        VALUES(from_rejected.Request_Rejected_Request_ID, from_rejected.Request_Rejected_Book_ID, 1);
        -- х днаюбкъел рс фе ярпнйс б йнккейжхч дкъ бнгбпюрю
        sended_index := sended.count + 1;
        sended.extend();
        sended(sended_index) := notification_object(0, 0, 0);
        sended(sended_index).Request_ID := from_rejected.Request_Rejected_Request_ID;
        sended(sended_index).Book_ID := from_rejected.Request_Rejected_Book_ID;
        sended(sended_index).Type_ID := 1;
        
        -- сдюкъел гюопня х нрйюгнб
        DELETE FROM Request_Rejected WHERE 
                                      Request_Rejected_Request_ID = from_rejected.Request_Rejected_Request_ID
                                      AND
                                      Request_Rejected_Book_ID = from_rejected.Request_Rejected_Book_ID
                                      AND
                                      Request_Rejected_Reason_ID = from_rejected.Request_Rejected_Reason_ID;
        -- х днаюбкъел ецн йюй бшдюммши
        INSERT INTO Request_Approved (Request_Approved_Request_ID, Request_Approved_Book_ID, Request_Approved_Return_Date)
        VALUES(from_rejected.Request_Rejected_Request_ID, from_rejected.Request_Rejected_Book_ID, return_date);
        DBMS_OUTPUT.put_line('вХРЮРЕКЧ БШДЮМЮ ЙМХЦЮ. сБЕДНЛКЕМХЕ НРОПЮБКЕМН');
      END IF;
    END IF;
  end loop;
  DBMS_OUTPUT.put_line('END'); 
  COMMIT;
END SEND_NOTIFICATIONS;
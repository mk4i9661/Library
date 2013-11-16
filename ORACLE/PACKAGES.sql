create or replace PACKAGE Request_State AS
  TYPE CardBook IS RECORD(
    RequestID NUMBER,
    CardID NUMBER,
    BookID NUMBER,
    BookQuantity NUMBER
  );
  TYPE requests IS TABLE OF CardBook INDEX BY BINARY_INTEGER;
  
  new_rows requests;
  empty requests;
END;

create or replace package return_types as
  type sended_notifications is table of Notification%ROWTYPE;
  type notification_cursor is ref cursor return Notification%ROWTYPE;
end;
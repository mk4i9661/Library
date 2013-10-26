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
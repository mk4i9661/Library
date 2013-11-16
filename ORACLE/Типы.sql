create or replace type notification_object as object(request_id integer, book_id integer, type_id integer);
create or replace type sended_notifications as table of notification_object;
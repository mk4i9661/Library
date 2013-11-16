using Library.DataContracts.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WindowsClient.InformationForms
{
    partial class SendedNotificationsForm : LibraryForm
    {
        public SendedNotificationsForm(IEnumerable<Notification> notifications) {
            InitializeComponent();
            gcNotifications.Bind(from n in notifications
                                 select new NotificationWrap(n));
        }

        class NotificationWrap : IEquatable<NotificationWrap>
        {
            Notification Notification {
                get;
                set;
            }

            public NotificationWrap(Notification notification) {
                Notification = notification;
            }

            public string NotificationText {
                get {
                    return Notification.NotificationType.Text;
                }
            }

            public DateTime CreateDate {
                get {
                    return Notification.Id.Id.CreateDate;
                }
            }

            public string Rubric {
                get {
                    return Notification.Id.Book.Rubric.Name;
                }
            }

            public string Publisher {
                get {
                    return Notification.Id.Book.Publisher.Name;
                }
            }

            public string Book {
                get {
                    return Notification.Id.Book.Name;
                }
            }

            public int BookQuantity {
                get {
                    return Notification.Id.BookQuantity;
                }
            }

            public string Reader {
                get {
                    var reader = Notification.Id.Id.Card.Reader;
                    return string.Format("{0} {1} {2}", reader.LastName, reader.FirstName, reader.MiddleName);
                }
            }

            public string Address {
                get {
                    return Notification.Id.Id.Card.Reader.Address;
                }
            }

            public string Phone {
                get {
                    return Notification.Id.Id.Card.Reader.Phone;
                }
            }

            public bool Equals(NotificationWrap other) {
                return Notification.Equals(other);
            }
        }
    }
}

using Library.Contracts;
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
using System.Monads;

namespace Library.WindowsClient.EditForms
{
    partial class RubricEditForm : RubricEditFormMock
    {
        IEnumerable<Rubric> Rubrics {
            get;
            set;
        }

        public RubricEditForm(IEnumerable<Rubric> rubrics) {
            var list = rubrics.ToList();
            list.Insert(0, new Rubric() {
                Id = -1,
                Name = "--Родительская рубрика--"
            });
            Rubrics = list;
            InitializeComponent();
        }

        protected override void OnInitFormFields(Rubric data) {
            cbParentRubric.Bind(Rubrics.Where(r => r.Id != data.Id), r => r.Name, data.Parent);
            RubricName = data.Name;
            Description = data.Description;
        }

        protected override void OnInitDataFields(Rubric data) {
            data.Parent = ParentRubric;
            data.Name = RubricName;
            data.Description = Description;
        }

        protected override void OnValidateFormFields() {
            ValidateControl(teName, string.IsNullOrEmpty(RubricName), "Название должно быть задано");
        }

        protected override Rubric InsertOperation(Rubric data) {
            return GetProxy().AddRubric(data);
        }

        protected override Rubric UpdateOperation(Rubric data) {
            return GetProxy().UpdateRubric(data);
        }

        Rubric ParentRubric {
            get {
                var rubric = cbParentRubric.GetSelectedElement<Rubric>();
                return rubric.IfNot(r => r.Id == -1);
            }
        }

        string RubricName {
            get {
                return teName.Text.Trim();
            }
            set {
                teName.Text = value;
            }
        }

        string Description {
            get {
                return meDescription.Text.Trim();
            }
            set {
                meDescription.Text = value;
            }
        }
    }

    class RubricEditFormMock : LibraryEditForm<IBibliographer, Rubric>
    {

    }
}

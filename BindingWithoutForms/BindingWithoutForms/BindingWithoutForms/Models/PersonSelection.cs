using System;
using Assisticant.Fields;

namespace BindingWithoutForms.Models
{
	public class PersonSelection
	{
		private Observable<string> _newName = new Observable<string>();
		private Observable<Person> _selectedPerson = new Observable<Person>();

		public string NewName
		{
			get { return _newName; }
			set { _newName.Value = value; }
		}

        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson.Value = value;
            }
        }
    }
}


using BindingWithoutForms.Models;
using System.Collections.Generic;
using System.Linq;

namespace BindingWithoutForms.ViewModels
{
    public class AddressBookViewModel
	{
		private readonly AddressBook _addressBook;
		private readonly PersonSelection _selection;

		public AddressBookViewModel(
			AddressBook addressBook,
			PersonSelection selection)
		{
			_addressBook = addressBook;
			_selection = selection;
		}

		public IEnumerable<PersonViewModel> People =>
			from person in _addressBook.People
			orderby person.Name
			select new PersonViewModel(person);

		public PersonViewModel SelectedPerson
		{
			get
			{
				if (_selection.SelectedPerson == null)
					return null;
				else
					return new PersonViewModel(_selection.SelectedPerson);
			}
			set
			{
				if (value == null)
					_selection.SelectedPerson = null;
				else
					_selection.SelectedPerson = value.Person;
			}
		}

		public string NewName
		{
			get { return _selection.NewName; }
			set { _selection.NewName = value; }
		}

        public bool CanAddPerson =>
            !string.IsNullOrWhiteSpace(_selection.NewName);

		public void AddPerson()
		{
			var person = _addressBook.NewPerson();
			person.Name = _selection.NewName;
			_selection.NewName = string.Empty;
		}
	}
}


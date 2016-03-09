using BindingWithoutForms.Models;
using System;

namespace BindingWithoutForms.Droid.ViewModels
{
    public class PersonViewModel
	{
		private readonly Person _person;

		public PersonViewModel(Person person)
		{
			_person = person;
		}

		public Person Person
		{
			get { return _person; }
		}

		public string Name
		{
			get
			{
				if (string.IsNullOrWhiteSpace(_person.Name))
					return "<no name>";
				else
					return _person.Name;
			}
		}

		public override bool Equals(Object obj)
		{
			if (obj == this)
				return true;

			var that = obj as PersonViewModel;
			if (that == null)
				return false;

			return this._person == that._person;
		}

		public override int GetHashCode()
		{
			return _person.GetHashCode();
		}
	}

}


using System;
using Assisticant.Collections;
using System.Collections.Generic;

namespace BindingWithoutForms.Models
{
    public class AddressBook
	{
		private ObservableList<Person> _people = new ObservableList<Person>(
			new Person[]
			{
				new Person
				{
					Name = "Sargon"
				},
				new Person
				{
					Name = "Hammurabi"
				},
				new Person
				{
					Name = "Asherbanipal"
				}
			}
		);

        public IEnumerable<Person> People
        {
            get { return _people; }
        }

        public Person NewPerson()
        {
            var person = new Person();
            _people.Add(person);
            return person;
        }
    }
}


using System;
using Assisticant.Fields;

namespace BindingWithoutForms.Models
{
	public class Person
	{
		private Observable<string> _name = new Observable<string>();

		public string Name
		{
			get { return _name; }
			set { _name.Value = value; }
		}
	}
}


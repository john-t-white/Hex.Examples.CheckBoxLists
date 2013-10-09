using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hex.Examples.CheckBoxLists.Models.CheckBoxList
{
	public class PersonViewModel
	{
		public PersonViewModel( int id, string firstName, string lastName )
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }
	}
}
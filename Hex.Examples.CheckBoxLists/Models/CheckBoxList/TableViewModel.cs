using Hex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hex.Examples.CheckBoxLists.Models.CheckBoxList
{
	public class TableViewModel
	{
		public TableViewModel()
		{ }

		public TableViewModel( List<PersonViewModel> people )
		{
			this.People = people;
		}

		public List<PersonViewModel> People { get; set; }

		public CheckBoxValues<int> SelectedPersonIds { get; set; }
	}
}
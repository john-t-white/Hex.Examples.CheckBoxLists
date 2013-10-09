using Hex.Examples.CheckBoxLists.Models.CheckBoxList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hex.Examples.CheckBoxLists.Controllers
{
	public class CheckBoxListController
		: Controller
	{
		public ActionResult UnorderedList()
		{
			return View( new UnorderedListViewModel() );
		}

		[HttpPost]
		public ActionResult UnorderedList( UnorderedListViewModel viewModel )
		{
			return View( viewModel );
		}




		public ActionResult Table()
		{
			var viewModel = new TableViewModel( this.GeneratePeople() );

			return this.View( viewModel );
		}

		[HttpPost]
		public ActionResult Table( TableViewModel viewModel )
		{
			viewModel.People = this.GeneratePeople();

			return this.View( viewModel );
		}

		private List<PersonViewModel> GeneratePeople()
		{
			List<PersonViewModel> people = new List<PersonViewModel>();
			people.Add( new PersonViewModel( 1, "Santa", "Claus" ) );
			people.Add( new PersonViewModel( 2, "George", "Washington" ) );
			people.Add( new PersonViewModel( 3, "Bill", "Gates" ) );
			people.Add( new PersonViewModel( 4, "Steve", "Jobs" ) );

			return people;
		}
	}
}

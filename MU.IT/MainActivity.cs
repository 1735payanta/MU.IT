using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace MU.IT
{
	[Activity (Label = "Instructors", MainLauncher = true, Icon = "@drawable/rsz_mu_logo")]
	public class MainActivity : Activity
	{
		ListView instructorListView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var instructorList = FindViewById(Resource.Id.instructorListView);

			instructorList.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, InstructorData.Instructors);
			// MAY NOT GO HERE????BELOW

			void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
			{
				var instructor = InstructorData.Instructors[e.Position};

				var dialog = new AlertDialog.Builder(this);
				dialog.SetMessage(instructor.Name);
				dialog.SetNeutralButton("OK", delegate { });
				dialog.Show();
			}
			// Get our button from the layout resource,
			// and attach an event to it

		}
	}
}



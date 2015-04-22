
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Randomizer
{
	[Activity (Label = "Randomizer", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleInstance, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]			
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.MainScreen);

			string category;

			// Buttons
			Button fourdigitsCategory = FindViewById<Button> (Resource.Id.fourdigitsCategory);
			Button fivedigitsCategory = FindViewById<Button> (Resource.Id.fivedigitsCategory);
			Button sixdigitsCategory = FindViewById<Button> (Resource.Id.sixdigitsCategory);
			Button sevendigitsCategory = FindViewById<Button> (Resource.Id.sevendigitsCategory);
			Button tendigitsCategory = FindViewById<Button> (Resource.Id.tendigitsCategory);
			Button fifteendigitsCategory = FindViewById<Button> (Resource.Id.fifteendigitsCategory);
			Button twentyfivedigitsCategory = FindViewById<Button> (Resource.Id.twentyfivedigitsCategory);

			var titleText = FindViewById<TextView> (Resource.Id.titleText);
			var chooseaCategoryText = FindViewById<TextView> (Resource.Id.chooseaCategoryText);
			var authorText = FindViewById<TextView> (Resource.Id.authorText);

			fourdigitsCategory.TextSize = 15;
			fivedigitsCategory.TextSize = 15;
			sixdigitsCategory.TextSize = 15;
			sevendigitsCategory.TextSize = 15;
			tendigitsCategory.TextSize = 15;
			fifteendigitsCategory.TextSize = 15;
			twentyfivedigitsCategory.TextSize = 15;

			titleText.TextSize = 40;
			chooseaCategoryText.TextSize = 20;
			authorText.TextSize = 10;

			fourdigitsCategory.Click += delegate {
				category = "4";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			fivedigitsCategory.Click += delegate {
				category = "5";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			sixdigitsCategory.Click += delegate {
				category = "6";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			sevendigitsCategory.Click += delegate {
				category = "7";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			tendigitsCategory.Click += delegate {
				category = "10";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			fifteendigitsCategory.Click += delegate {
				category = "15";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};

			twentyfivedigitsCategory.Click += delegate {
				category = "25";
				Intent slideIntent = new Intent(this, typeof(RandomizeActivity));
				slideIntent.PutExtra("category", category);
				Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
				StartActivity(slideIntent, slideAnim);
			};
		}
	}
}


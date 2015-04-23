
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

			bool digitsChecked = true;
			bool lettersChecked = false;

			// Buttons
			Button fourdigitsCategory = FindViewById<Button> (Resource.Id.fourdigitsCategory);
			Button fivedigitsCategory = FindViewById<Button> (Resource.Id.fivedigitsCategory);
			Button sixdigitsCategory = FindViewById<Button> (Resource.Id.sixdigitsCategory);
			Button sevendigitsCategory = FindViewById<Button> (Resource.Id.sevendigitsCategory);
			Button tendigitsCategory = FindViewById<Button> (Resource.Id.tendigitsCategory);
			Button fifteendigitsCategory = FindViewById<Button> (Resource.Id.fifteendigitsCategory);
			Button twentyfivedigitsCategory = FindViewById<Button> (Resource.Id.twentyfivedigitsCategory);

			ToggleButton DigitsLettersToggleButton = FindViewById<ToggleButton> (Resource.Id.DigitsLettersToggleButton);

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

			DigitsLettersToggleButton.SetAllCaps (false);
			DigitsLettersToggleButton.Checked = true;

			fourdigitsCategory.SetAllCaps (false);
			fivedigitsCategory.SetAllCaps (false);
			sixdigitsCategory.SetAllCaps (false);
			sevendigitsCategory.SetAllCaps (false);
			tendigitsCategory.SetAllCaps (false);
			fifteendigitsCategory.SetAllCaps (false);
			twentyfivedigitsCategory.SetAllCaps (false);

			titleText.TextSize = 40;
			chooseaCategoryText.TextSize = 20;
			authorText.TextSize = 10;

			DigitsLettersToggleButton.Click += (o, e) => {
				// Perform action on clicks
				if (DigitsLettersToggleButton.Checked) {
					fourdigitsCategory.Text = "4 Digits";
					fivedigitsCategory.Text = "5 Digits";
					sixdigitsCategory.Text = "6 Digits";
					sevendigitsCategory.Text = "7 Digits";
					tendigitsCategory.Text = "10 Digits";
					fifteendigitsCategory.Text = "SC: 15 Digits";
					twentyfivedigitsCategory.Text = "SC: 25 Digits";

					digitsChecked = true;
					lettersChecked = false;
				}
				else {
					fourdigitsCategory.Text = "4 Letters";
					fivedigitsCategory.Text = "5 Letters";
					sixdigitsCategory.Text = "6 Letters";
					sevendigitsCategory.Text = "7 Letters";
					tendigitsCategory.Text = "10 Letters";
					fifteendigitsCategory.Text = "SC: 15 Letters";
					twentyfivedigitsCategory.Text = "SC: 25 Letters";

					digitsChecked = false;
					lettersChecked = true;
				}
			};

			fourdigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "4";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "4";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			fivedigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "5";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "5";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			sixdigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "6";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "6";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			sevendigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "7";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "7";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			tendigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "10";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "10";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			fifteendigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "15";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "15";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};

			twentyfivedigitsCategory.Click += delegate {
				if(digitsChecked){
					category = "25";
					Intent slideIntent = new Intent(this, typeof(RandomizeDigitsActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
				else if (lettersChecked) {
					category = "25";
					Intent slideIntent = new Intent(this, typeof(RandomizeLettersActivity));
					slideIntent.PutExtra("category", category);
					Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim1, Resource.Animation.Anim2).ToBundle();
					StartActivity(slideIntent, slideAnim);
				}
			};
		}
	}
}


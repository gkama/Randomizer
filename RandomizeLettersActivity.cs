using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;

namespace Randomizer
{
	[Activity(Label = "Randomizer", LaunchMode = Android.Content.PM.LaunchMode.SingleInstance, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class RandomizeLettersActivity : Activity, GestureDetector.IOnGestureListener
	{
		private GestureDetector gestureDetector;

		private static int SWIPE_THRESHOLD = 100;
		private static int SWIPE_VELOCITY_THRESHOLD = 100;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.RandomizeLettersScreen);

			// Layout
			EditText inputText = FindViewById<EditText> (Resource.Id.inputText);

			Button translateButton = FindViewById<Button> (Resource.Id.randomizeButton);

			string category = Intent.GetStringExtra("category") ?? "Category is not available!";
			int categoryInt = Int32.Parse(category);

			string translatedLetters = String.Empty;
			string output = String.Empty;

			string ranString15 = "ABCDEFGHIJKLMNO";
			string ranString25 = "ABCDEFGHIJKLMNOPQRSTUVWXY";

			var errorText = FindViewById<TextView> (Resource.Id.errorText);
			var outputText = FindViewById<TextView> (Resource.Id.outputText);
			var aboutText = FindViewById<TextView> (Resource.Id.aboutText);
			var titleText = FindViewById<TextView> (Resource.Id.titleText);

			translateButton.TextSize = 15;
			outputText.TextSize = 30;
			aboutText.TextSize = 9;

			aboutText.SetPadding (8, 8, 8, 8);
			aboutText.Text = "ABOUT: Letters part of the Application is designed to generate random sequence of letters based on the " +
							 "letters input in the box above. Hopefully you get some random not-in-the-English-language words that " +
							 "sound funny. For example, if the sequence ABCD is entered then it generates a random letters sequence using letters between A-D. " +
							 "If the letters sequence ABCDEFG is enetered then the application will generate a random letters sequence using letters between A-G. " +
							 "There are also special cases marked as 'SC' where user input is not needed. It generates random letter sequence based of the first 15 or 25 letters in the English alphabet respectively.\n" +
							 "If needed, Swipe LEFT to go back!\n" +
							 "Have fun!\n" + 
							 "\nAuthor: Georgi Kamacharov \nRevision: 1.0";

			titleText.Text = "Enter " + categoryInt + " Letters Below";
			
			// Set default text
			if (categoryInt == 5) {inputText.Text = "ABCDE";}
			else if(categoryInt == 6) {inputText.Text = "ABCDEF";}
			else if(categoryInt == 7) {inputText.Text = "ABCDEFG";}
			else if(categoryInt == 10) {inputText.Text = "ABCDEFGHIJ";}
			else if(categoryInt == 15) {inputText.Text = "ABCDEFGH..";
				titleText.Text = "Good Luck reading that...";
				inputText.Focusable = false;
				inputText.Enabled = false;
			}
			else if(categoryInt == 25) {inputText.Text = "ABCDEFGH..";
				titleText.Text = "Good Luck reading that...";
				inputText.Focusable = false;
				inputText.Enabled = false;
			}

			// Randomize Button click
			translateButton.Click += (object sender, EventArgs e) => {
				if(categoryInt == 15) {
					translatedLetters = LetterTranslator.RandomString(ranString15);
					outputText.Text = translatedLetters.ToUpper();
				}
				else if(categoryInt == 25) {
					translatedLetters = LetterTranslator.RandomString(ranString25);
					outputText.TextSize = 20;
					outputText.Text = translatedLetters.ToUpper();
				}
				else{ 
					if (inputText.Text.ToString().Length != categoryInt)
					{
						errorText.Text = "Incorrect Input! Try Again!";
					}
					else if (String.IsNullOrWhiteSpace(inputText.Text.ToString()))
					{
						errorText.Text = "Incorrect Input! Try Again!";
					}
					else if (LetterTranslator.isString(inputText.Text.ToString()) == false)
					{
						errorText.Text = "Incorrect Input! Try Again!";
					}
					else if (LetterTranslator.isString(inputText.Text.ToString()) == true)
					{
						InputMethodManager closeKeyboard = (InputMethodManager)GetSystemService(Context.InputMethodService);
						closeKeyboard.HideSoftInputFromWindow(inputText.WindowToken, 0);

						translatedLetters = LetterTranslator.RandomString (inputText.Text.ToString());

						errorText.Text = "";
						outputText.Text = translatedLetters.ToUpper();
					}
				}
			};

			// Gesture Detection
			gestureDetector = new GestureDetector(this);
		}

		// Gestures
		public override bool OnTouchEvent(MotionEvent e)
		{
			gestureDetector.OnTouchEvent(e);
			return true;
		}
		public bool OnDown(MotionEvent e) {return true;}

		// Used for Swiping
		public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		{
			float diffY = e2.GetY() - e1.GetY();
			float diffX = e2.GetX() - e1.GetX();

			if (Math.Abs(diffX) > Math.Abs(diffY))
			{
				if (Math.Abs(diffX) > SWIPE_THRESHOLD && Math.Abs(velocityX) > SWIPE_VELOCITY_THRESHOLD)
				{
					if (diffX > 0)
					{
						// Left Swipe - go back
						Intent slideIntent = new Intent(this, typeof(MainActivity));
						Bundle slideAnim = ActivityOptions.MakeCustomAnimation(Application.Context, Resource.Animation.Anim3, Resource.Animation.Anim4).ToBundle();
						StartActivity(slideIntent, slideAnim);
						Finish ();
					}
					else
					{
						// Right Swipe
					}
				}
			}
			else if (Math.Abs(diffY) > SWIPE_THRESHOLD && Math.Abs(velocityY) > SWIPE_VELOCITY_THRESHOLD)
			{
				if (diffY > 0)
				{
					// Top swipe
				}
				else
				{
					// Bottom swipe
				}
			}
			return true;
		}
		//
		public void OnLongPress(MotionEvent e) {}
		public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY) {return false;}
		public void OnShowPress(MotionEvent e) {}
		public bool OnSingleTapUp(MotionEvent e) {return false;}
	}
}



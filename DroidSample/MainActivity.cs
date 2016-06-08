using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace DroidSample
{
	[Activity(Label = "DroidSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
			var textView = FindViewById<TextView>(Resource.Id.textView);


			seekBar.ObserveEveryValueChanged(x => x.Progress)
				.Subscribe(x => textView.Text = x.ToString());
		}
	}
}



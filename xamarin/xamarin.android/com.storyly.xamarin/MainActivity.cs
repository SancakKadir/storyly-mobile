using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Com.Appsamurai.Storyly;
using Com.Appsamurai.Storyly.Config;
using Com.Appsamurai.Storyly.Analytics;
using Com.Appsamurai.Storyly.Config.Styling.Group;
using Android.Graphics;
using System.Collections.Generic;
using Android.Util;

namespace com.storyly.xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IStorylyListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);

            StorylyStoryGroupStyling groupStyling = new StorylyStoryGroupStyling.Builder()
                .SetIconBorderAnimation(StoryGroupAnimation.BorderRotation)
                .Build();

            Dictionary<string, string> map = new Dictionary<string, string>();

            // Add "user" to "kadir" mapping
            map["user"] = "kadir";

            StorylyConfig config = new StorylyConfig.Builder()
                .SetLayoutDirection(StorylyLayoutDirection.Rtl)
                .SetLocale("tr-TR")
                .SetStoryGroupStyling(groupStyling)
                .SetUserData(map)
                .Build();

            StorylyInit init = new StorylyInit("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NfaWQiOjU4OTMsImFwcF9pZCI6MTc1MTMsImluc19pZCI6MTk1MzV9.RzvLM7KNF01AgOYzOfgJoafr6cSB9kc1DmJ6U14A3XQ", config);

            StorylyView storylyView = FindViewById<StorylyView>(Resource.Id.storylyView);

            storylyView.StorylyListener = this;

            storylyView.StorylyInit = init;

            fab.Click += FabOnClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void StorylyActionClicked(StorylyView storylyView, Story story)
        {
            Log.Info("TAG", "StorylyActionClicked");
        }

        public void StorylyEvent(StorylyView storylyView, StorylyEvent e, StoryGroup storyGroup, Story story, StoryComponent storyComponent)
        {
            Log.Info("TAG", "StorylyEvent");
        }

        public void StorylyLoadFailed(StorylyView storylyView, string errorMessage)
        {
            Log.Info("TAG", "StorylyLoadFailed");
        }

        public void StorylyLoaded(StorylyView storylyView, IList<StoryGroup> storyGroupList, StorylyDataSource dataSource)
        {
            System.Console.WriteLine("DEBUG - StorylyLoaded");
        }


        public void StorylyStoryDismissed(StorylyView storylyView)
        {
            Log.Info("TAG", "StorylyStoryDismissed");
        }

        public void StorylyStoryShowFailed(StorylyView storylyView, string errorMessage)
        {
            Log.Info("TAG", "StorylyStoryShowFailed");
        }

        public void StorylyStoryShown(StorylyView storylyView)
        {
            Log.Info("TAG", "StorylyStoryShown");
        }

        public void StorylyUserInteracted(StorylyView storylyView, StoryGroup storyGroup, Story story, StoryComponent storyComponent)
        {
            Log.Info("TAG", "StorylyUserInteracted");
        }
    }
}


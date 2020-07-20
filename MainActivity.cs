using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace XamPaperScissorsRock2020
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView GamePic;
        TextView txtMainMsg;
        Button btnPlay;
        string Human, Name, NPC;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Init();
        }

        void Init()
        {
            txtMainMsg = FindViewById<TextView>(Resource.Id.txtMainMsg);
            GamePic = FindViewById<ImageView>(Resource.Id.imgAnswer);
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);

            RadioButton rbnPaper = FindViewById<RadioButton>(Resource.Id.rbnPaper);
            RadioButton rbnScissors = FindViewById<RadioButton>(Resource.Id.rbnScissors);
            RadioButton rbnRock = FindViewById<RadioButton>(Resource.Id.rbnRock);

            rbnPaper.Click += Rbn_Click;
            rbnScissors.Click += Rbn_Click;
            rbnRock.Click += Rbn_Click;

            btnPlay.Click += btnPlay_Click;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string NPC = Gameplay.ComputerChoice();
            string Result = Gameplay.Play(Human, NPC);

            txtMainMsg.Text = $"{Result}, NPC chose {NPC} while you chose {Human}!";
        }

        private void Rbn_Click(object sender, EventArgs e)
        {
            RadioButton tempRB = (RadioButton)sender;

            Human = tempRB.Text;
            txtMainMsg.Text = $"{Name}, You chose {Human}";

            throw new NotImplementedException();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
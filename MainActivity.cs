using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Linq;

namespace XamPaperScissorsRock2020
{
    [Activity(Label = "@string/app_name")]
    public class MainActivity : AppCompatActivity
    {
        TextView txtMainMsg;
        ImageView imgResult;
        Button btnPlay;
        TextView txtWelcomeMsg;
        string Human, Name, NPC;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Game);

            Name = Intent.GetStringExtra("Name");
            Init();
        }

        void Init()
        {
            txtMainMsg = FindViewById<TextView>(Resource.Id.txtMainMsg);
            imgResult = FindViewById<ImageView>(Resource.Id.imgResult);
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);
            txtWelcomeMsg = FindViewById<TextView>(Resource.Id.txtWelcomeMsg);

            RadioButton rbnPaper = FindViewById<RadioButton>(Resource.Id.rbnPaper);
            RadioButton rbnScissors = FindViewById<RadioButton>(Resource.Id.rbnScissors);
            RadioButton rbnRock = FindViewById<RadioButton>(Resource.Id.rbnRock);

            rbnPaper.Click += Rbn_Click;
            rbnScissors.Click += Rbn_Click;
            rbnRock.Click += Rbn_Click;

            txtWelcomeMsg.Text = $"Welcome {Name}!";

            btnPlay.Click += btnPlay_Click;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string NPC = Gameplay.ComputerChoice();
            string Result = Gameplay.Play(Human, NPC);

            switch (Result)
            {
                case "Win":
                    txtMainMsg.Text = $"You {Result}, NPC chose {NPC} while you chose {Human}!";
                    imgResult.SetImageResource(Resource.Drawable.Win);
                    break;
                case "Lose":
                    txtMainMsg.Text = $"You {Result}, NPC chose {NPC} while you chose {Human}!";
                    imgResult.SetImageResource(Resource.Drawable.Lose);
                    break;
                case "Draw":
                    txtMainMsg.Text = $"It's a {Result}, NPC chose {NPC} while you chose {Human}!";
                    imgResult.SetImageResource(Resource.Drawable.Draw);
                    break;
            }
        }

        private void Rbn_Click(object sender, EventArgs e)
        {
            RadioButton tempRB = (RadioButton)sender;

            Human = (tempRB.Text);
            txtMainMsg.Text = $"{Name}, You chose {Human}";
        }
    }
}
using Android.Content;
using Android.Graphics.Drawables;
using MeuPredio.Controls;
using MeuPredio.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MeuPredio.Droid.Renders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                BorderLessBotton();
                BorderEntry();
            }
        }

        private void BorderLessBotton()
        {
            Control.Background = new ColorDrawable(Android.Graphics.Color.WhiteSmoke);
        }

        private void BorderEntry()
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Android.Graphics.Color.WhiteSmoke);
            gd.SetCornerRadius(10);
            gd.SetStroke(2, Android.Graphics.Color.WhiteSmoke);
            Control.SetBackground(gd);
        }
    }
}
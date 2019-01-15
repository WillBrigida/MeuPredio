using Android.Content;
using Android.Graphics.Drawables;
using MeuPredio.Controls;
using MeuPredio.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRender))]


namespace MeuPredio.Droid.Renders
{
    public class CustomPickerRender : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                BorderPicker();
            }
        }

        public CustomPickerRender(Context context) : base(context)
        {
        }
        
        private void BorderPicker()
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Android.Graphics.Color.White);
            gd.SetCornerRadius(10);
            gd.SetStroke(2, Android.Graphics.Color.LightGray);
            Control.SetBackground(gd);
        }
    }
}
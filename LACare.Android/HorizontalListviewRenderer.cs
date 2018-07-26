using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using LACare.Droid;
using LACare;

[assembly: ExportRenderer(typeof(HorizontalListview), typeof(HorizontalListviewRenderer))]
namespace LACare.Droid
{
    public class HorizontalListviewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as HorizontalListview;
            element?.Render();

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;

        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ChildCount > 0)
            {
                GetChildAt(0).HorizontalScrollBarEnabled = false;
                GetChildAt(0).VerticalScrollBarEnabled = false;
            }
        }
    }
}
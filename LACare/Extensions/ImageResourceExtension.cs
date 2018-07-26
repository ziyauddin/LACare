using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LACare.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// ProvideValue
        /// </summary>
        /// <param name="serviceProvider">The Service Provider</param>
        /// <returns></returns>
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            return ImageSource.FromResource(Source);
        }
    }
}

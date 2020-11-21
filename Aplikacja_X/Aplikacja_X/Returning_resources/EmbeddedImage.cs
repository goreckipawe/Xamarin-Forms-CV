using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X.Returning_resources
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public int Resource_name { get; set; }
        public object Binding_name { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Resource_name == 0)
            {
                if (String.IsNullOrWhiteSpace(ResourceId))
                {
                    return null;
                }
                else
                {
                    return ImageSource.FromResource(ResourceId);
                }
            }
            else {
                if (String.IsNullOrWhiteSpace(ResourceId))
                {
                    return null;
                }
                else
                {
                    return ImageSource.FromResource("Aplikacja_X.Images." + Binding_name);
                }
            }
        }
    }
}

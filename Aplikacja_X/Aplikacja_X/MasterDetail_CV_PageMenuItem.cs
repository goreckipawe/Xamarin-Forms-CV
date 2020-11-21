using System;
using Xamarin.Forms;

namespace Aplikacja_X
{

    public class MasterDetail_CV_PageMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ContentPage Page { get; set; }
        public Type TargetType { get; set; }
    }
}
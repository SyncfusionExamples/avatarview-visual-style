using Syncfusion.XForms.AvatarView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualStyles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CircleVisualStyle : ContentPage
    {
        public CircleVisualStyle()
        {
            InitializeComponent();
            //StackLayout stack = new StackLayout();
            //stack.Orientation = StackOrientation.Vertical;
            //stack.HorizontalOptions = LayoutOptions.CenterAndExpand;
            //stack.VerticalOptions = LayoutOptions.CenterAndExpand;

            //Grid mainGrid = new Grid();
            //mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            //mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //mainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //Label XLargeCirclelabel = new Label();
            //XLargeCirclelabel.Text = "Extra Large Circle";
            //XLargeCirclelabel.FontSize = 12;
            //XLargeCirclelabel.FontAttributes = FontAttributes.Bold;
            //XLargeCirclelabel.HorizontalOptions = LayoutOptions.Center;
            //XLargeCirclelabel.VerticalOptions = LayoutOptions.Center;
            //XLargeCirclelabel.HorizontalTextAlignment = TextAlignment.Center;
            //XLargeCirclelabel.VerticalTextAlignment = TextAlignment.Center;
            //XLargeCirclelabel.FontSize = 10;

            //SfAvatarView avatarview1 = new SfAvatarView();
            //avatarview1.VerticalOptions = LayoutOptions.Center;
            //avatarview1.HorizontalOptions = LayoutOptions.Center;
            //avatarview1.AvatarShape = AvatarShape.Circle;
            //avatarview1.AvatarSize = AvatarSize.ExtraLarge;
            //avatarview1.ContentType = ContentType.Default;
            //avatarview1.ImageSource = "ellanaa.png";

            //Label LargeCirclelabel = new Label();
            //LargeCirclelabel.Text = "Large Circle";
            //LargeCirclelabel.FontSize = 12;
            //LargeCirclelabel.FontAttributes = FontAttributes.Bold;
            //LargeCirclelabel.HorizontalOptions = LayoutOptions.Center;
            //LargeCirclelabel.VerticalOptions = LayoutOptions.Center;
            //LargeCirclelabel.HorizontalTextAlignment = TextAlignment.Center;
            //LargeCirclelabel.VerticalTextAlignment = TextAlignment.Center;
            //LargeCirclelabel.FontSize = 10;

            //SfAvatarView avatarview2 = new SfAvatarView();
            //avatarview2.VerticalOptions = LayoutOptions.Center;
            //avatarview2.HorizontalOptions = LayoutOptions.Center;
            //avatarview2.AvatarShape = AvatarShape.Circle;
            //avatarview2.AvatarSize = AvatarSize.Large;
            //avatarview2.ContentType = ContentType.Default;
            //avatarview2.ImageSource = "ellanaa.png";

            //Label MediumCirclelabel = new Label();
            //MediumCirclelabel.Text = "Medium Circle";
            //MediumCirclelabel.FontSize = 12;
            //MediumCirclelabel.FontAttributes = FontAttributes.Bold;
            //MediumCirclelabel.HorizontalOptions = LayoutOptions.Center;
            //MediumCirclelabel.VerticalOptions = LayoutOptions.Center;
            //MediumCirclelabel.HorizontalTextAlignment = TextAlignment.Center;
            //MediumCirclelabel.VerticalTextAlignment = TextAlignment.Center;
            //MediumCirclelabel.FontSize = 10;

            //SfAvatarView avatarview3 = new SfAvatarView();
            //avatarview3.VerticalOptions = LayoutOptions.Center;
            //avatarview3.HorizontalOptions = LayoutOptions.Center;
            //avatarview3.AvatarShape = AvatarShape.Circle;
            //avatarview3.AvatarSize = AvatarSize.Medium;
            //avatarview3.ContentType = ContentType.Default;
            //avatarview3.ImageSource = "ellanaa.png";

            //Label SmallCirclelabel = new Label();
            //SmallCirclelabel.Text = "Small Circle";
            //SmallCirclelabel.FontSize = 12;
            //SmallCirclelabel.FontAttributes = FontAttributes.Bold;
            //SmallCirclelabel.HorizontalOptions = LayoutOptions.Center;
            //SmallCirclelabel.VerticalOptions = LayoutOptions.Center;
            //SmallCirclelabel.HorizontalTextAlignment = TextAlignment.Center;
            //SmallCirclelabel.VerticalTextAlignment = TextAlignment.Center;
            //SmallCirclelabel.FontSize = 10;

            //SfAvatarView avatarview4 = new SfAvatarView();
            //avatarview4.VerticalOptions = LayoutOptions.Center;
            //avatarview4.HorizontalOptions = LayoutOptions.Center;
            //avatarview4.AvatarShape = AvatarShape.Circle;
            //avatarview4.AvatarSize = AvatarSize.Small;
            //avatarview4.ContentType = ContentType.Default;
            //avatarview4.ImageSource = "ellanaa.png";

            //Label XSmallCirclelabel = new Label();
            //XSmallCirclelabel.Text = "Extra Small Circle";
            //XSmallCirclelabel.FontSize = 12;
            //XSmallCirclelabel.FontAttributes = FontAttributes.Bold;
            //XSmallCirclelabel.HorizontalOptions = LayoutOptions.Center;
            //XSmallCirclelabel.VerticalOptions = LayoutOptions.Center;
            //XSmallCirclelabel.HorizontalTextAlignment = TextAlignment.Center;
            //XSmallCirclelabel.VerticalTextAlignment = TextAlignment.Center;
            //XSmallCirclelabel.FontSize = 10;

            //SfAvatarView avatarview5 = new SfAvatarView();
            //avatarview5.VerticalOptions = LayoutOptions.Center;
            //avatarview5.HorizontalOptions = LayoutOptions.Center;
            //avatarview5.AvatarShape = AvatarShape.Circle;
            //avatarview5.AvatarSize = AvatarSize.ExtraSmall;
            //avatarview5.ImageSource = "ellanaa.png";
            //avatarview5.ContentType = ContentType.Default;


            //mainGrid.Children.Add(XLargeCirclelabel, 4, 1);
            //mainGrid.Children.Add(avatarview1, 4, 0);
            //mainGrid.Children.Add(LargeCirclelabel, 3, 1);
            //mainGrid.Children.Add(avatarview2, 3, 0);
            //mainGrid.Children.Add(MediumCirclelabel, 2, 1);
            //mainGrid.Children.Add(avatarview3, 2, 0);
            //mainGrid.Children.Add(SmallCirclelabel, 1, 1);
            //mainGrid.Children.Add(avatarview4, 1, 0);
            //mainGrid.Children.Add(XSmallCirclelabel, 0, 1);
            //mainGrid.Children.Add(avatarview5, 0, 0);

            //stack.Children.Add(mainGrid);
            //this.Content = stack;
        }
    }
}
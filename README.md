# Xamarin Avatar View (SfAvatarView)

The SfAvatarView control for Xamarin.Forms provides a graphical representation of user image that allows you to customize the view by adding image, background color, icon, text, etc.

For know more details about AvatarView:https://www.syncfusion.com/xamarin-ui-controls/xamarin-avatar-view

AvatarView user guide documentation:https://help.syncfusion.com/xamarin/avatar-view/getting-started

# Visual Style in Xamarin Avatar View(SfAvatarView)

The SfAvatarView control supports customization using the following built-in visual styles:

*   Custom
*   Circle
*   Square

##  Custom
Custom type allows you to customize the control, where you can handle the size, colors, images, etc. of the control. Refer to this documentation.

## Circle
You can directly set value to the circle in the SfAvatarView using the following styles:

*   ExtraLargeCircle
*   LargeCircle
*   MediumCircle
*   SmallCircle
*   ExtraSmallCircle

The following code sample demonstrates how to define visual style of circle AvatarView.

**[XAML]**

```
<ContentPage.Content>
   <StackLayout Orientation="Vertical" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand">
     <Grid >
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>

                    <sfavatar:SfAvatarView AvatarShape="Circle" AvatarSize="ExtraLarge" Grid.Row="0" Grid.Column="4" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="ExtraLargeCircle" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="4" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Circle" AvatarSize="Large" Grid.Row="0" Grid.Column="3" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="LargeCircle" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="3" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Circle" AvatarSize="Medium" Grid.Row="0" Grid.Column="2" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="MediumCircle" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="2" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Circle" AvatarSize="Small" Grid.Row="0" Grid.Column="1" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="SmallCircle" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="1" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Circle" AvatarSize="ExtraSmall" Grid.Row="0" Grid.Column="0" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="ExtraSmallCircle" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="0" FontSize="10"/>
    </Grid>
   </StackLayout>
</ContentPage.Content>
```

##   Square
You can directly set value to the square in the SfAvatarView using the following styles:

*   ExtraLargeSquare
*   LargeSquare
*   MediumSquare
*   SmallSquare
*   ExtraSmallSquare

The following code sample demonstrates how to define visual style of square AvatarView.

**[XAML]**
```
<ContentPage.Resources>
            <ResourceDictionary>
           <Style x:Key="AvatarViewStyle"  TargetType="sfavatar:SfAvatarView">
                <Setter Property="VerticalOptions" Value="Center"/>
                <Setter Property="HorizontalOptions" Value="Center"/>
                <Setter Property="ContentType" Value="Custom"/>
                <Setter Property="ImageSource" Value="ellanaa.png"/>
            </Style>
            </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <StackLayout Orientation="Vertical" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand">
       <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>

                    <sfavatar:SfAvatarView AvatarShape="Square" AvatarSize="ExtraLarge" Grid.Row="0" Grid.Column="4" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="ExtraLargeSquare" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="4" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Square" AvatarSize="Large" Grid.Row="0" Grid.Column="3" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="LargeSquare" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="3" FontSize="10"/>
                    <sfavatar:SfAvatarView  AvatarShape="Square" AvatarSize="Medium" Grid.Row="0" Grid.Column="2" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="MediumSquare" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="2" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Square" AvatarSize="Small" Grid.Row="0" Grid.Column="1" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="SmallSquare" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="1" FontSize="10"/>
                    <sfavatar:SfAvatarView AvatarShape="Square" AvatarSize="ExtraSmall" Grid.Row="0" Grid.Column="0" Style="{StaticResource AvatarViewStyle}"/>
                    <Label Text="ExtraSmallSquare" FontAttributes="Bold" Grid.Row="1" HorizontalOptions="Center" VerticalOptions="Center" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" Grid.Column="0" FontSize="10"/>
        </Grid>
     </StackLayout>
  </ContentPage.Content>
  ```
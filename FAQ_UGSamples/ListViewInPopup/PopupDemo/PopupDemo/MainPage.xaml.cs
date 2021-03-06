﻿using Syncfusion.ListView.XForms;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupDemo
{
    public partial class MainPage : ContentPage
    {
        //SfListView listView;
        //ContactsViewModel viewModel;
        //SfPopupLayout popupLayout;

        public MainPage()
        {
            InitializeComponent();

            //Comment the xaml page content and uncomment the below code to get the same output in code behind
            
            //listView = new SfListView() { ItemSpacing = 5 };
            //listView.WidthRequest = 350;
            //// Load the desired template as the ItemTemplate of SfListView.
            //listView.ItemTemplate = new DataTemplate(() =>
            //{
            //    ViewCell viewCell = new ViewCell();
            //    var grid = new Grid() { RowSpacing = 1 };
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 200 });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });
            //    var contactImage = new Image()
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        HorizontalOptions = LayoutOptions.Center,
            //        HeightRequest = 50
            //    };
            //    contactImage.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
            //    var contactName = new Label()
            //    {
            //        HorizontalTextAlignment = TextAlignment.Center,
            //        LineBreakMode = LineBreakMode.NoWrap,
            //        FontSize = Font.SystemFontOfSize(NamedSize.Medium).FontSize,
            //    };
            //    contactName.SetBinding(Label.TextProperty, new Binding("ContactName"));
            //    var contactType = new Image()
            //    {
            //        VerticalOptions = LayoutOptions.End,
            //        HorizontalOptions = LayoutOptions.End,
            //        HeightRequest = 50,
            //    };
            //    contactType.SetBinding(Image.SourceProperty, new Binding("ContactType"));
            //    grid.Children.Add(contactImage, 0, 0);
            //    grid.Children.Add(contactName, 1, 0);
            //    grid.Children.Add(contactType, 2, 0);
            //    viewCell.View = grid;
            //    return viewCell;
            //});
            //viewModel = new ContactsViewModel();
            //// Set the ItemsSource for the SfListView for loading the items.
            //listView.ItemsSource = viewModel.Items;
            //popupLayout = new SfPopupLayout();
            //// Set the HeaderTitle of the popup.
            //popupLayout.PopupView.HeaderTitle = "ListView";
            //// Load any view as the Template to show in Popup.
            //popupLayout.PopupView.ContentTemplate = new DataTemplate(() =>
            //{
            //    return listView;
            //});
            //StackLayout stackLayout = new StackLayout();
            //Button isOpenButton = new Button();
            //isOpenButton.Clicked += isOpenButton_Clicked;
            //isOpenButton.Text = "Click to show popup";
            //stackLayout.Children.Add(isOpenButton);
            //popupLayout.Content = stackLayout;
            //this.Content = popupLayout;
        }

        private void isOpenButton_Clicked(object sender, EventArgs e)
        {
            //Displays the popup.
            popupLayout.Show();
        }
    }
}

// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "1.7.0.0")]
    public sealed class Dictionary : ResourceDictionary {
        
        private static Dictionary singleton = new Dictionary();
        
        public Dictionary() {
            this.InitializeResources();
        }
        
        public static Dictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [buttonStyle] Style
            var r_0_s_bo = this[typeof(Button)];
            Style r_0_s = new Style(typeof(Button), r_0_s_bo as Style);
            Setter r_0_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new ColorW(255, 140, 0, 255)));
            r_0_s.Setters.Add(r_0_s_S_0);
            this.Add("buttonStyle", r_0_s);
            // Resource - [Image] BitmapImage
            BitmapImage r_1_bm = new BitmapImage();
            r_1_bm.TextureAsset = "Images/MonoGameLogo";
            ImageManager.Instance.AddImage("Images/MonoGameLogo");
            this.Add("Image", r_1_bm);
            // Resource - [TitleResource] String
            this.Add("TitleResource", "Basic UI Example");
            // Resource - [DataTemplateKey(GameData.TestTreeDataItem)] DataTemplate
            Func<UIElement, UIElement> r_3_dtFunc = r_3_dtMethod;
            this.Add(typeof(GameData.TestTreeDataItem), new DataTemplate(typeof(GameData.TestTreeDataItem), r_3_dtFunc));
            // Resource - [CustomWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_4_ctFunc = r_4_ctMethod;
            ControlTemplate r_4_ct = new ControlTemplate(r_4_ctFunc);
            this.Add("CustomWindowTemplate", r_4_ct);
            // Resource - [buttonAnimStyle] Style
            var r_5_s_bo = this[typeof(Button)];
            Style r_5_s = new Style(typeof(Button), r_5_s_bo as Style);
            Setter r_5_s_S_0 = new Setter(Button.WidthProperty, 200F);
            r_5_s.Setters.Add(r_5_s_S_0);
            Setter r_5_s_S_1 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_5_s.Setters.Add(r_5_s_S_1);
            Setter r_5_s_S_2 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_5_s.Setters.Add(r_5_s_S_2);
            EventTrigger r_5_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_5_s.Triggers.Add(r_5_s_ET_0);
            BeginStoryboard r_5_s_ET_0_AC_0 = new BeginStoryboard();
            r_5_s_ET_0_AC_0.Name = "r_5_s_ET_0_AC_0";
            r_5_s_ET_0.AddAction(r_5_s_ET_0_AC_0);
            Storyboard r_5_s_ET_0_AC_0_SB = new Storyboard();
            r_5_s_ET_0_AC_0.Storyboard = r_5_s_ET_0_AC_0_SB;
            r_5_s_ET_0_AC_0_SB.Name = "r_5_s_ET_0_AC_0_SB";
            ThicknessAnimation r_5_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_0_AC_0_SB_TL_0.Name = "r_5_s_ET_0_AC_0_SB_TL_0";
            r_5_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_5_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_5_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_5_s_ET_0_AC_0_SB.Children.Add(r_5_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_5_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_5_s_ET_0_AC_0_SB_TL_1.Name = "r_5_s_ET_0_AC_0_SB_TL_1";
            r_5_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_5_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_5_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_5_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_5_s_ET_0_AC_0_SB.Children.Add(r_5_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_5_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_5_s.Triggers.Add(r_5_s_ET_1);
            BeginStoryboard r_5_s_ET_1_AC_0 = new BeginStoryboard();
            r_5_s_ET_1_AC_0.Name = "r_5_s_ET_1_AC_0";
            r_5_s_ET_1.AddAction(r_5_s_ET_1_AC_0);
            Storyboard r_5_s_ET_1_AC_0_SB = new Storyboard();
            r_5_s_ET_1_AC_0.Storyboard = r_5_s_ET_1_AC_0_SB;
            r_5_s_ET_1_AC_0_SB.Name = "r_5_s_ET_1_AC_0_SB";
            ThicknessAnimation r_5_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_1_AC_0_SB_TL_0.Name = "r_5_s_ET_1_AC_0_SB_TL_0";
            r_5_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_5_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_5_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_5_s_ET_1_AC_0_SB.Children.Add(r_5_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_5_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_5_s_ET_1_AC_0_SB_TL_1.Name = "r_5_s_ET_1_AC_0_SB_TL_1";
            r_5_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_5_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_5_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_5_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_5_s_ET_1_AC_0_SB.Children.Add(r_5_s_ET_1_AC_0_SB_TL_1);
            this.Add("buttonAnimStyle", r_5_s);
            // Resource - [Sounds] SoundSourceCollection
            var r_6_sounds = new SoundSourceCollection();
            r_6_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click" });
            SoundManager.Instance.AddSound("Click");
            r_6_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress" });
            SoundManager.Instance.AddSound("KeyPress");
            r_6_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move" });
            SoundManager.Instance.AddSound("Move");
            r_6_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select" });
            SoundManager.Instance.AddSound("Select");
            this.Add("Sounds", r_6_sounds);
            // Resource - [DataTemplateKey(GameData.CustomWindow)] DataTemplate
            Func<UIElement, UIElement> r_7_dtFunc = r_7_dtMethod;
            this.Add(typeof(GameData.CustomWindow), new DataTemplate(typeof(GameData.CustomWindow), r_7_dtFunc));
        }
        
        private static UIElement r_3_dtMethod(UIElement parent) {
            // e_39 element
            TextBlock e_39 = new TextBlock();
            e_39.Parent = parent;
            e_39.Name = "e_39";
            e_39.Margin = new Thickness(2F, 2F, 2F, 2F);
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_39_Text = new Binding("Name");
            e_39.SetBinding(TextBlock.TextProperty, binding_e_39_Text);
            return e_39;
        }
        
        private static UIElement r_4_ctMethod(UIElement parent) {
            // e_40 element
            Grid e_40 = new Grid();
            e_40.Parent = parent;
            e_40.Name = "e_40";
            RowDefinition row_e_40_0 = new RowDefinition();
            row_e_40_0.Height = new GridLength(20F, GridUnitType.Pixel);
            e_40.RowDefinitions.Add(row_e_40_0);
            RowDefinition row_e_40_1 = new RowDefinition();
            e_40.RowDefinitions.Add(row_e_40_1);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_40.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // e_41 element
            ContentPresenter e_41 = new ContentPresenter();
            e_40.Children.Add(e_41);
            e_41.Name = "e_41";
            Grid.SetRow(e_41, 1);
            Binding binding_e_41_Content = new Binding();
            e_41.SetBinding(ContentPresenter.ContentProperty, binding_e_41_Content);
            return e_40;
        }
        
        private static UIElement r_7_dtMethod(UIElement parent) {
            // e_42 element
            Border e_42 = new Border();
            e_42.Parent = parent;
            e_42.Name = "e_42";
            e_42.Background = new SolidColorBrush(new ColorW(0, 0, 255, 255));
            // e_43 element
            StackPanel e_43 = new StackPanel();
            e_42.Child = e_43;
            e_43.Name = "e_43";
            // e_44 element
            TextBlock e_44 = new TextBlock();
            e_43.Children.Add(e_44);
            e_44.Name = "e_44";
            e_44.HorizontalAlignment = HorizontalAlignment.Center;
            e_44.VerticalAlignment = VerticalAlignment.Center;
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            Binding binding_e_44_Text = new Binding("TextData");
            e_44.SetBinding(TextBlock.TextProperty, binding_e_44_Text);
            // e_45 element
            Button e_45 = new Button();
            e_43.Children.Add(e_45);
            e_45.Name = "e_45";
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Regular, "Segoe_UI_9_Regular");
            e_45.Content = "Hide Window";
            Binding binding_e_45_Command = new Binding("HideCommand");
            e_45.SetBinding(Button.CommandProperty, binding_e_45_Command);
            return e_42;
        }
    }
}

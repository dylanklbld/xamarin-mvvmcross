using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloWorld.UI.Views
{
    using HelloWord.Core.ViewModel;
    using MvvmCross.Binding.BindingContext;
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Droid.Views;
    using MvvmCross.Platform.Core;

    [Activity]
    public class MenuView : MvxActivity
    {
        public MenuView()
        {
            var set = this.CreateBindingSet<MenuView, MenuViewModel>();
            set.Bind(this).For(view => view.Interaction).To(viewModel => viewModel.Interaction).OneWay();
            set.Apply();

        }


        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.menu_view);
        }

        //demo
        private IMvxInteraction<MenuViewModel.YesNoQuestion> _interaction;
        public IMvxInteraction<MenuViewModel.YesNoQuestion> Interaction
        {
            get
            {
                return _interaction;
            }
            set
            {
                if (_interaction != null)
                    _interaction.Requested -= OnInteractionRequested;

                _interaction = value;
                _interaction.Requested += OnInteractionRequested;
            }
        }

        private async void OnInteractionRequested(object sender, MvxValueEventArgs<MenuViewModel.YesNoQuestion> eventArgs)
        {
            var yesNoQuestion = eventArgs.Value.Question;
            // show dialog
            Toast.MakeText(this, yesNoQuestion, ToastLength.Long).Show();
        }


    }
}
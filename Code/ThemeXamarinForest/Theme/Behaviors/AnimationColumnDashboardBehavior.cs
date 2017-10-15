using System;
using Prism.Navigation;
using Xamarin.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using System.Reflection;
using Prism.Behaviors;

namespace Theme.Behaviors
{
    public class AnimationColumnDashboardBehavior : BehaviorBase<View>
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(DelegateCommand), typeof(AnimationColumnDashboardBehavior), null);

        public DelegateCommand Command
        {
            get { return (DelegateCommand)GetValue(CommandProperty); }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

        private TapGestureRecognizer _gesture;


        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);

            _gesture = new TapGestureRecognizer()
            {
                Command = new Command((o) =>
                {
                    BeginAnimation();
                }),
                NumberOfTapsRequired = 1

            };

            bindable.GestureRecognizers.Add(_gesture);
        }

        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
            AssociatedObject.GestureRecognizers.Remove(_gesture);
            _gesture = null;

        }

        protected Task BeginAnimation()
        {
            if (AssociatedObject == null)
            {
                throw new NullReferenceException("Null AssociatedObject property.");
            }

            return Task.Run(() =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    OnItemClicked();
                });
            });
        }

        private void OnItemClicked()
        {
            if (!AssociatedObject.AnimationIsRunning("ChangeRGB"))
            {
                var backgroundColorOriginal = AssociatedObject.BackgroundColor;
                var repeatCount = 0;
                AssociatedObject.Animate("ChangeRGB",
                    animation: new Animation(
                        (v) =>
                        {
                            // val will be a from 0 - 1 and can use that to set a BG color
                            if (repeatCount == 0)
                            {
                                AssociatedObject.BackgroundColor = Color.FromHex("#a1a1a1");
                            }
                            else
                            {
                                AssociatedObject.BackgroundColor = Color.FromRgb(backgroundColorOriginal.R, backgroundColorOriginal.G, backgroundColorOriginal.B);
                            }
                        }
                    ),
                    // set the length
                    length: 70,
                    // set the repeat action to update the repeatCount
                    finished: (val, b) =>
                    {
                        repeatCount++;
                        if (repeatCount > 1)
                        {
                            Command.Execute();
                        }
                    },

                    // determine if we should repeat
                    repeat: () =>
                    {
                        return repeatCount < 1;
                    });
            }
        }
    }
}

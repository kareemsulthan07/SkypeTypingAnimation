using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkypeTypingAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DoubleAnimation e1GrowAnimation, e1ShrinkAnimation,
            e2GrowAnimation, e2ShrinkAnimation,
            e3GrowAnimation, e3ShrinkAnimation,
            meFirstMoveAnimation, meSecondMoveAnimation;
        double duration = 400;

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                meFirstMoveAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 0,
                    To = 200,
                    AutoReverse = false,
                };

                meSecondMoveAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 200,
                    To = 400,
                    AutoReverse = false,
                };

                e1GrowAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 1,
                    To = 2,
                    AutoReverse = false,
                };
                e1GrowAnimation.Completed += E1GrowAnimation_Completed;

                e1ShrinkAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 2,
                    To = 1,
                    AutoReverse = false,
                };
                e1ShrinkAnimation.Completed += E1ShrinkAnimation_Completed;


                e2GrowAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 1,
                    To = 2,
                    AutoReverse = false,
                };
                e2GrowAnimation.Completed += E2GrowAnimation_Completed;

                e2ShrinkAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 2,
                    To = 1,
                    AutoReverse = false,
                };
                e2ShrinkAnimation.Completed += E2ShrinkAnimation_Completed;


                e3GrowAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 1,
                    To = 2,
                    AutoReverse = false,
                };
                e3GrowAnimation.Completed += E3GrowAnimation_Completed;

                e3ShrinkAnimation = new DoubleAnimation()
                {
                    Duration = TimeSpan.FromMilliseconds(duration),
                    From = 2,
                    To = 1,
                    AutoReverse = false,
                };
                e3ShrinkAnimation.Completed += E3ShrinkAnimation_Completed;



                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e1GrowAnimation);
                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e1GrowAnimation);

                meTranslateTransform.BeginAnimation(TranslateTransform.XProperty, meFirstMoveAnimation);
            }
            catch (Exception exception)
            {
            }
        }


        private void E1GrowAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
                e2ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e2GrowAnimation);
                e2ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e2GrowAnimation);

                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e1ShrinkAnimation);
                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e1ShrinkAnimation);

                meTranslateTransform.BeginAnimation(TranslateTransform.XProperty, meSecondMoveAnimation);
            }
            catch (Exception exception)
            {
            }
        }

        private void E1ShrinkAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
            }
        }


        private void E2GrowAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
                e3ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e3GrowAnimation);
                e3ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e3GrowAnimation);


                e2ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e2ShrinkAnimation);
                e2ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e2ShrinkAnimation);

            }
            catch (Exception exception)
            {
            }
        }

        private void E2ShrinkAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
            }
        }


        private void E3GrowAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
                e3ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e3ShrinkAnimation);
                e3ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e3ShrinkAnimation);
            }
            catch (Exception exception)
            {
            }
        }

        private void E3ShrinkAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, e1GrowAnimation);
                e1ScaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, e1GrowAnimation);

                meTranslateTransform.X = 0;
                meTranslateTransform.BeginAnimation(TranslateTransform.XProperty, meFirstMoveAnimation);
            }
            catch (Exception exception)
            {
            }
        }
    }
}

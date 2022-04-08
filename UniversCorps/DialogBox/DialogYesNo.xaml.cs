using System.Media;
using System.Windows;

namespace UniversCorps.DialogBox

{
    
    /// <summary>
    /// Custom MessageBox
    /// </summary>
    public partial class WinDeleteQ : Window
    
    {
     
        public WinDeleteQ(string Message, string Title, MessageButtons Buttons, MessageSound Sound)
        
        {
            
            InitializeComponent();

            TxtText.Text = Message;
            TxtTitle.Text = Title;

            switch (Buttons) //Settings for Custom MessageBox Buttons
            
            {
                
                case MessageButtons.YesNo:

                    BtnYes.Visibility = Visibility.Visible;
                    BtnNo.Visibility = Visibility.Visible;
                    break;

                case MessageButtons.Ok:

                    BtnOk.Visibility = Visibility.Visible;
                    break;

                case MessageButtons.OkCancel:

                    BtnOk.Visibility = Visibility.Visible;
                    BtnCancel.Visibility = Visibility.Visible;
                    break;

                case MessageButtons.YesNoCancel:

                    BtnYes.Visibility = Visibility.Visible;
                    BtnNo.Visibility = Visibility.Visible;
                    BtnCancel.Visibility = Visibility.Visible;
                    break;

            }
            
            switch (Sound) //Settings for Custom MessageBox Sounds and Image

            {

                case MessageSound.Information:

                    SystemSounds.Beep.Play();
                    break;

                case MessageSound.Warning:

                    SystemSounds.Beep.Play();
                    break;

                case MessageSound.Error:

                    SystemSounds.Hand.Play();
                    break;

                case MessageSound.Exclamation:

                    SystemSounds.Exclamation.Play();
                    break;
            
            }

        }

        /// <summary>
        /// Red button for closing the custom MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        
        {

            this.DialogResult = false;
            this.Close();

        }

        /// <summary>
        /// Button for custom MessageBox: "Yes"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYes_Click(object sender, RoutedEventArgs e)
       
        {

            this.DialogResult = true;
            this.Close();

        }

        /// <summary>
        /// Button for custom MessageBox: "No"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNo_Click(object sender, RoutedEventArgs e)
        
        {

            this.DialogResult = false;
            this.Close();

        }

        /// <summary>
        /// Button for custom MessageBox: "Ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        
        {

            this.DialogResult = false;
            this.Close();

        }

        /// <summary>
        /// Button for custom MessageBox: "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        
        {

            this.DialogResult = false;
            this.Close();

        }

        public enum MessageButtons
        
        {

            YesNo,
            Ok,
            OkCancel,
            YesNoCancel,

        }

        public enum MessageSound
        
        {

            Information,
            Warning,
            Error,
            Exclamation,

        }


    }

}

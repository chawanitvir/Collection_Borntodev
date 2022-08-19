using System.Collections;
using System.Windows;

namespace ArrayList_Borntodev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ArrayList arr = new ArrayList();
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void AddButton_click(object sender, RoutedEventArgs e)
        {
            /* ArrayList Add
             * 
             * 
            arr.Add(txtInput.Text);
            txtInput.Text = "";

            */

            //Add-Hashtable
            hashtable.Add(txtKey.Text,txtValue.Text);
        }

        private void RemoveButton_click(object sender, RoutedEventArgs e)
        {
            /*ArrayList Remove
             * 
             * 
            arr.Remove(txtInput.Text);
            txtInput.Text = "";

            */

            //Remove-Hashtable
            hashtable.Remove(txtKey.Text);
        }

        private void ShowAllButton_click(object sender, RoutedEventArgs e)
        {
            /*ArrayList
            //Show all
            foreach(object data in arr)
            {
                MessageBox.Show(data.ToString());
            }*/

            ICollection icollection = hashtable.Keys;
            //ShowAll-Hashtable
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}

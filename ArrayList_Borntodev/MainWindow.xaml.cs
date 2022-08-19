using System;
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
        //Hashtable hashtable;
        SortedList sort;
        public MainWindow()
        {
            InitializeComponent();
            //hashtable = new Hashtable();
            sort = new SortedList();
        }

        private void AddButton_click(object sender, RoutedEventArgs e)
        {
            #region ArrayList
            /* ArrayList Add
             * 
             * 
            arr.Add(txtInput.Text);
            txtInput.Text = "";

            */
            #endregion ArrayList

            #region HashTable
            //Add-Hashtable
            //hashtable.Add(txtKey.Text,txtValue.Text);
            #endregion HashTable

            #region SortedList
            sort.Add(txtKey.Text, txtValue.Text);
            ICollection collection = sort.Keys;
            string all = string.Empty;
            foreach(string key in collection)
            {
                all += sort[key] + Environment.NewLine;
            }

            MessageBox.Show(all);
            #endregion SortedList
        }

        private void RemoveButton_click(object sender, RoutedEventArgs e)
        {
            #region ArrayList
            /*ArrayList Remove
             * 
             * 
            arr.Remove(txtInput.Text);
            txtInput.Text = "";

            */
            #endregion

            #region HashTable
            /*** Remove-Hashtable
            hashtable.Remove(txtKey.Text);
            */
            #endregion HashTable
        }

        private void ShowAllButton_click(object sender, RoutedEventArgs e)
        {
            #region Array List
            /*ArrayList
            //Show all
            foreach(object data in arr)
            {
                MessageBox.Show(data.ToString());
            }*/
            #endregion Array List

            #region Hashtable
            //ICollection icollection = hashtable.Keys;
            ////ShowAll-Hashtable
            //foreach (string key in icollection)
            //{
            //    MessageBox.Show(hashtable[key].ToString());
            //}
            #endregion Hashtable

        }
    }
}

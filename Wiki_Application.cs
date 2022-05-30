using System.Text;

namespace Wiki_Application
{
    public partial class Wiki_Application : Form
    {
        public Wiki_Application()
        {
            InitializeComponent();
        }
        string checkStructure;
        //6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();
        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
        String[] comboCategory = {"Array", "List", "Tree", "Graphs", "Abstract", "Hash"};

        //6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.

        string currentFileName = "Information.dat";
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxDefinition.Text) && (radioButtonLinear.Checked || radioButtonNon_Linear.Checked) && !string.IsNullOrEmpty(comboBoxCategory.Text))
            {
                if (ValidName(textBoxName.Text))
                {
                    Information newInfo = new Information();
                    newInfo.gsName = textBoxName.Text;
                    newInfo.gsCategory = comboBoxCategory.Text;
                    newInfo.gsStructure = checkStructure;
                    newInfo.gsDefinition = textBoxDefinition.Text;
                   // Information newInfo = new Information(newInfo.gsName, newInfo.gsCategory, newInfo.gsStructure, newInfo.gsDefinition);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Plate is already present in list", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Make sure all data items are filled", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Wiki.Sort();
            string fileName = currentFileName;
            SaveFileDialog SaveText = new SaveFileDialog();
            DialogResult sr = SaveText.ShowDialog();
            SaveText.Filter = "Binary Files | *.dat";
            SaveText.DefaultExt = "dat";
            if (sr == DialogResult.OK)
            {
                fileName = SaveText.FileName;

            }
            if (sr == DialogResult.Cancel)
            {
                SaveText.FileName = fileName;
            }
            try
            {
                using (var stream = File.Open(currentFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var info in Wiki)
                        {
                            writer.Write(info.gsName);
                            writer.Write(info.gsCategory);
                            writer.Write(info.gsStructure);
                            writer.Write(info.gsDefinition);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {

                if (Wiki.BinarySearch(textBoxSearch.Text) == 0)
                {
                    MessageBox.Show("The Name is Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("The Name is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else
            {
                MessageBox.Show("Search Box is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        
    }

        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox. The first method must return a string value from the selected radio button (Linear or Non-Linear). The second method must send an integer index which will highlight an appropriate radio button.
        private void radioButtonLinear_CheckedChanged(object sender, EventArgs e)
        {
            checkStructure = radioButtonLinear.Text;
        }
        private void radioButtonNon_Linear_CheckedChanged(object sender, EventArgs e)
        {
            checkStructure = radioButtonNon_Linear.Text;
        }

        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clear();            
        }

        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
        private void Wiki_Application_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
            Display();
        }


        #region Methods 
        private void Clear()
        {
            textBoxDefinition.Clear();
            textBoxName.Clear();
            radioButtonLinear.Checked = false;
            radioButtonNon_Linear.Checked = false;
            comboBoxCategory.SelectedIndex = -1;

        }

        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix.Create a custom method to populate the ComboBox when the Form Load method is called.
        private void ComboBoxFill()
        {
            //comboBoxCategory.DataSource = comboCategory;
            foreach (String categoray in comboCategory)
            {
                comboBoxCategory.Items.Add(categoray);
            }
        }

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(string checkThisName)
        {
            if (Wiki.Exists(duplicate => duplicate.Equals(checkThisName)))
                return false;
            else
                return true;
        }
        private void Display()
        {
            listViewDisplay.Items.Clear();
            Wiki.Sort();
            foreach (var newInfo in Wiki)
            { 
            listViewDisplay.Items.Add(newInfo.gsName);
                listViewDisplay.Items.Add(newInfo.gsCategory);
            }
        }

        #endregion


    }
}
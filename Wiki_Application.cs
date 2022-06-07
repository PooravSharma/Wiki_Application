using System.Text;

namespace Wiki_Application
{
    public partial class Wiki_Application : Form
    {
        public Wiki_Application()
        {
            InitializeComponent();
        }
        string checkStructure = "";
        int count = 0;

        //6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();

        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
        String[] comboCategory = { "Array", "List", "Tree", "Graphs", "Abstract", "Hash" };

        //6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.
        string currentFileName = "Information.dat";
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxDefinition.Text) && (radioButtonLinear.Checked || radioButtonNon_Linear.Checked) && !string.IsNullOrEmpty(comboBoxCategory.Text))
            {
                if (ValidName(textBoxName.Text))
                {
                    string name = textBoxName.Text;
                    string category = comboBoxCategory.Text;
                    string structure = checkStructure;
                    string definition = textBoxDefinition.Text;
                    Information newInfo = new Information(name, category, structure, definition);
                    Wiki.Add(newInfo);
                    count++;
                    Clear();
                    Display();

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

        //6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listViewDisplay.SelectedIndices[0];

            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item ", "Aleart", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); ;

                if (result == DialogResult.Yes)
                {
                    Wiki.RemoveAt(index);
                    Clear();
                    Display();
                    MessageBox.Show("Item has been deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nothing has been deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Nothing is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView.All the changes in the input controls will be written back to the list. Display an updated version of the sorted list at the end of this process.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listViewDisplay.SelectedIndices[0];

            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxDefinition.Text) && (radioButtonLinear.Checked || radioButtonNon_Linear.Checked) && !string.IsNullOrEmpty(comboBoxCategory.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this item ", "Aleart", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); ;

                if (result == DialogResult.Yes)
                {
                    Wiki[index] = new Information(textBoxName.Text, comboBoxCategory.Text, checkStructure, textBoxDefinition.Text);
                    Clear();
                    Display();
                    MessageBox.Show("Edit complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit canceled", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Nothing is selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file. All Wiki data is stored/retrieved using a binary file format.
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string fileName = currentFileName;
            OpenFileDialog OpenText = new OpenFileDialog();
            DialogResult sr = OpenText.ShowDialog();
            fileName = OpenText.FileName;
            LoadFile(fileName);
            Display();
        }

        //6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file.All Wiki data is stored/retrieved using a binary file format.
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
            Save(fileName);
            Display();
        }

        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name.If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.At the end of the search process the search input TextBox must be cleared.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                Information info = new Information(textBoxSearch.Text, "0", "0", "0");

                if (Wiki.BinarySearch(info) >= 0)
                {
                    MessageBox.Show("The Name is Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int index = Wiki.BinarySearch(info);
                    listViewDisplay.Items[index].Selected = true;
                    DisplayObject(index);
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

        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clear();
        }

        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
        private void Wiki_Application_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
            LoadFile("Information.dat");
            /*try
            {
                using (var stream = File.Open("category.dat", FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream))
                    {
                        foreach (var String in comboCategory)
                        {
                            writer.Write(String);
                            
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

        }


        private void listViewDisplay_DoubleClick(object sender, EventArgs e)
        {
            int index = listViewDisplay.SelectedIndices[0];
            if (index != -1)
            {
                DisplayObject(index);

            }
            else
            {
                MessageBox.Show("Please select from the array Box", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //6.15 The Wiki application will save data when the form closes. 
        private void Wiki_Application_FormClosed(object sender, FormClosedEventArgs e)
        {
            Save("Backup.dat");
        }

        #region Methods 

        //6.12 Create a custom method that will clear and reset the TextBboxes, ComboBox and Radio button
        private void Clear()
        {
            textBoxDefinition.Clear();
            textBoxName.Clear();
            radioButtonLinear.Checked = false;
            radioButtonNon_Linear.Checked = false;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxCategory.Text = null;
        }

        //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix.Create a custom method to populate the ComboBox when the Form Load method is called.
        private void ComboBoxFill()
        {
            if (comboBoxCategory.Items.Count == 0)
            {
                try
                {
                    using (var stream = File.Open("category.dat", FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                comboBoxCategory.Items.Add(reader.ReadString());
                            }

                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                //comboBoxCategory.DataSource = comboCategory;
                foreach (String categoray in comboCategory)
                {
                    comboBoxCategory.Items.Add(categoray);
                }
            }
        }

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(string checkThisName)
        {
            if (Wiki.Exists(duplicate => duplicate.gsName == checkThisName))
                return false;
            else
                return true;
        }
        private void Display()
        {
            listViewDisplay.Items.Clear();
            Wiki.Sort();
            foreach (Information info in Wiki)
            {

                ListViewItem item = new ListViewItem(info.gsName);
                item.SubItems.Add(info.gsCategory);
                listViewDisplay.Items.Add(item);

            }


        }

        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox. The first method must return a string value from the selected radio button (Linear or Non-Linear). The second method must send an integer index which will highlight an appropriate radio button.
        private void DisplayObject(int x)
        {
            textBoxName.Text = Wiki[x].gsName;
            comboBoxCategory.Text = Wiki[x].gsCategory;
            textBoxDefinition.Text = Wiki[x].gsDefinition;
            if (Wiki[x].gsStructure == "Linear")
            {
                radioButtonLinear.Checked = true;
            }
            else
            {
                radioButtonNon_Linear.Checked = true;
            }
            listViewDisplay.Items[x].Selected = true;
        }
        private void Save(string filename)
        {
            try
            {
                using (var stream = File.Open(filename, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream))
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
        private void LoadFile(string fileName)
        {

            try
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Wiki.Clear();
                        while (stream.Position < stream.Length)
                        {
                            string name = reader.ReadString();
                            string category = reader.ReadString();
                            string structure = reader.ReadString();
                            string definition = reader.ReadString();
                            Information loadInfo = new Information(name, category, structure, definition);
                            Wiki.Add(loadInfo);
                        }
                    }
                }
                Display();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        #endregion

    }
}
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

        String [] comboCategory = {"Array", "List", "Tree", "Graphs", "Abstract", "Hash"};

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxDefinition.Text) && (radioButtonLinear.Checked || radioButtonNon_Linear.Checked))
            {
                Information newInfo = new Information();
                newInfo.gsName = textBoxName.Text;
                newInfo.gsCategory = comboBoxCategory.Text;
                newInfo.gsStructure = checkStructure;
                newInfo.gsDefinition = textBoxDefinition.Text;
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

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

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
        private void Wiki_Application_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
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
        private void ComboBoxFill()
        {
            //comboBoxCategory.DataSource = comboCategory;
            foreach (String categoray in comboCategory)
            {
                comboBoxCategory.Items.Add(categoray);
            }
        }

        #endregion

        
    }
}
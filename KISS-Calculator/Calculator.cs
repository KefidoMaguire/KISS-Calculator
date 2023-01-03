namespace KISS_Calculator
{
    public partial class Calculator : Form
    {
        //Dont set list on get; set; when adding something up it causes NullReferenceException
        //instead "assign" it like a normal list

        //When pressed a button, the Text of the Button is added into the list
        List<string> calText = new List<string>();
        //result property is public to give it into another class
        public string result { get; set; }
        //calls object
        calculating cs = new calculating();

        public Calculator()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Output to display the result on the textbox
        /// </summary>
        public void output()
        {
            result += calText[calText.Count - 1];
            Display.Clear();
            Display.Text = result;
        }

        /// <summary>
        /// Clears textbox, list and result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AC_Click(object sender, EventArgs e)
        {
            Display.Clear();
            calText.Clear();
            result = "";
        }

        /// <summary>
        /// calculates textbox / result string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_Click(object sender, EventArgs e)
        {
            Display.Text = cs.cal(result);
        }

        /// <summary>
        /// One button method for bearly all buttons - code is cleaner and easier to understand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            calText.Add(sender.ToString().Substring(sender.ToString().Length -1));
            output();
        }
    }
}
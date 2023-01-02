namespace KISS_Calculator
{
    public partial class Calculator : Form
    {
        //Dont set list on get; set; when adding something up it causes NullReferenceException
        //instead "assign" it like a normal list

        List<string> calText = new List<string>();
        public string result { get; set; }
        calculating cs = new calculating();

        public Calculator()
        {
            InitializeComponent(); 
        }


        public void output()
        {
            result += calText[calText.Count - 1];
            Display.Clear();
            Display.Text = result;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Display.Clear();
            calText.Clear();
            result = "";
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            Display.Text = cs.cal(result);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            calText.Add(sender.ToString().Substring(sender.ToString().Length -1));
            output();
        }
    }
}
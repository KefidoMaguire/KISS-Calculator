namespace KISS_Calculator
{
    public partial class Calculator : Form
    {
        //Dont set list on get; set; when adding something up it causes NullReferenceException
        //instead "assign" it like a normal list
        public List<string> numbers = new List<string>();
        calculating cg = new calculating();
        string betweennumber = "";
        bool displayclear = false;


        public Calculator()
        {
            InitializeComponent();
            Display.Text = "";

        }

        public void showCalcString()
        {
            Display.Clear();
            foreach (string number in numbers) 
            { 
                Display.Text = Display.Text + number;
            }
        }
        

        private void zero_Click(object sender, EventArgs e)
        {
            //Instead of writing like "0" in the list.add I wrote *button*.text, so if I change the button text (for whatever reason)
            //I dont have to go in the code and change it :)
            numbers.Add(zero.Text);
            showCalcString();

        }

        private void eins_Click(object sender, EventArgs e)
        {
            numbers.Add(eins.Text);
            showCalcString();
        }

        private void zwei_Click(object sender, EventArgs e)
        {
            numbers.Add(zwei.Text);
            showCalcString();
        }

        private void drei_Click(object sender, EventArgs e)
        {
            numbers.Add(drei.Text);
            showCalcString();
        }

        private void vier_Click(object sender, EventArgs e)
        {
            numbers.Add(vier.Text);
            showCalcString();
        }

        private void fuenf_Click(object sender, EventArgs e)
        {
            numbers.Add(fuenf.Text);
            showCalcString();
        }

        private void sechs_Click(object sender, EventArgs e)
        {
            numbers.Add("6");
            showCalcString();
        }

        private void sieben_Click(object sender, EventArgs e)
        {
            numbers.Add("7");
            showCalcString();
        }

        private void acht_Click(object sender, EventArgs e)
        {
            numbers.Add("8");
            showCalcString();
        }

        private void neun_Click(object sender, EventArgs e)
        {
            numbers.Add("9");
            showCalcString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            numbers.Add("+");
            showCalcString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            numbers.Add("-");
            showCalcString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
           
            Display.Text = Display.Text + "     Calculated:  " +  cg.calculaterMethod(numbers);
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            Display.Text = "";
            numbers.Clear();
            cg.lastlistlength = 0;
            cg.value = "";
            cg.solution = "";
          
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            numbers.Add("*");
            showCalcString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            numbers.Add("/");
            showCalcString();
        }
    }
}
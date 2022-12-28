namespace KISS_Calculator
{
    public partial class Calculator : Form
    {
        //Dont set list on get; set; when adding something up it causes NullReferenceException
        //instead "assign" it like a normal list
        

        public Calculator()
        {
            InitializeComponent();
            

        }

        
    }
}
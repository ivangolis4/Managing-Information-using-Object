namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Info info = new Info();
                Form2 form = new Form2(info);
                String Name = tbName.Text;
                String Address = tbAddress.Text;
                String Gender = "";
                int Age = int.Parse(comboBox1.Text);

                if(Name != "" && Address != "") {

                    if (radioButton1.Checked)
                    {
                        Gender = Convert.ToString(radioButton1.Text);
                        info.info(Name, Address, Age, Gender);
                        form.load();
                        form.Show();
                    }
                    else if (radioButton2.Checked)
                    {
                        Gender = Convert.ToString(radioButton2.Text);
                        info.info(Name, Address, Age, Gender);
                        form.load();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("CHOOSE GENDER!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Lack of Information!!");
                } 

               
            }
            catch(Exception ex) {
                MessageBox.Show("Please Put Your Age!!!");
            }
               
                    
                    
                
                


            
            
        }
    }
}

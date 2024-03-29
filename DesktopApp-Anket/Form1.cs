using DesktopApp_Anket.DataBase;
using DesktopApp_Anket.Models;

namespace DesktopApp_Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JsonHandler<Person> PeopleJson = new("PeopleJson");
            var people = PeopleJson.Values.ToList();
            foreach (var person in people)
            {
                if(person.Name==LoadTb.Text)
                {
                    NameTb .Text = person.Name;
                    SurnameTb .Text = person.Surname;
                    AgeTb.Text= person.Age.ToString();
                    if(person.Gender=="Male")
                    {
                        MaleRb.Checked =true;   
                    }
                    else
                    {
                         FemaleRb.Checked= true;
                    }


                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AgeTb.Text, out int age))
            {
                string? gender=null;
                if(MaleRb.Checked) { gender = MaleRb.Text; }
                else if(FemaleRb.Checked) { gender = FemaleRb.Text; }
                
                Person person = new(NameTb.Text, SurnameTb.Text, age, gender);
                JsonHandler<Person> PeopleJson = new("PeopleJson");
                PeopleJson.Values.Add(person);
                PeopleJson.SaveData();
                MessageBox.Show("Saved All Data");
            }
        }
    }
}

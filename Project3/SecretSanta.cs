using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class SecretSanta : Form
    {
        string fileName = @"C:\users\valentin.brad\documents\Visual Studio 2013\Projects\Project3\Project3\AllPeople.txt";
        public SecretSanta()
        {
            InitializeComponent();
        }

        private void SecretSanta_Load(object sender, EventArgs e)
        {

            incarcaDatele();
        }

        public void incarcaDatele()
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] peopleName = line.Split(' ');
                string name = peopleName[0];
                string surname = peopleName[1];
                string[] row = { name, surname };
                ListViewItem lvi = new ListViewItem(row);
                this.listViewPeople.Items.Add(lvi);
            }
           
        }

        

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            this.listViewPeople.Items.Clear();
            List<string> peopleList = new List<string>();
            List<string> listToChoose = new List<string>();
            List<string> chosenPeople = new List<string>();
           // List<string> listNoChoose = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                peopleList.Add(line);
            }
            
            foreach (string people in peopleList)
            {
                string[] peopleName = people.Split(' ');
                
                listToChoose = listNotChoose(peopleList, chosenPeople);
                if (listToChoose.Count > 3)
                {
                    Random random = new Random();
                    listToChoose = notSameName(peopleName[0], listToChoose);
                    int randomNumber = random.Next(0, listToChoose.Count);
                    chosenPeople.Add(listToChoose[randomNumber]);
                    string[] row = { peopleName[0], peopleName[1], listToChoose[randomNumber] };
                    ListViewItem lvi = new ListViewItem(row);
                    this.listViewPeople.Items.Add(lvi);
                }
                else
                {
                    chosenPeople.Add(listToChoose[listToChoose.Count - 1]);
                    string[] row = { peopleName[0], peopleName[1], listToChoose[listToChoose.Count-1] };
                    ListViewItem lvi = new ListViewItem(row);
                    this.listViewPeople.Items.Add(lvi);
                }
                
                              
            }
            
        }

        public List<string> notSameName(string name,List<string> listNoChoose)
        {
            List<string> notSameName = new List<string>();
            
            foreach (string people in listNoChoose) 
            { 
                string[] peopleName = people.Split(' ');
                if ((peopleName[0].CompareTo(name) < 0 || peopleName[0].CompareTo(name) > 0) )
                {
                    notSameName.Add(people);
                }
            }

            return notSameName;
        }

        public List<string> listNotChoose(List<string> peopleList,List<string> chosenPeople)
        {
             List<string> listNoChoose = new List<string>();
             listNoChoose = copyList(peopleList);
             foreach (string people in chosenPeople)
             {
                     listNoChoose.Remove(people);
                
             }
             return listNoChoose;
        }

        public List<string> copyList(List<string> peopleList)
        {
            List<string> copyList = new List<string>();
            foreach (string people in peopleList)
                copyList.Add(people);
            return copyList;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.listViewPeople.Items.Clear();
            incarcaDatele();
        }
    }
}

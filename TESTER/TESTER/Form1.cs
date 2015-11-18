using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTER
{
    public partial class Form1 : Form
    {
        List<TEST> list = new List<TEST>();
        TEST test = new TEST();
        public Form1()
        {
            InitializeComponent();
        }
        BDDataSet1 bds = new BDDataSet1();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.bdQuest". При необходимости она может быть перемещена или удалена.
            this.bdQuestTableAdapter.Fill(this.bDDataSet1.bdQuest);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.AddTestToDB();
            list.Add(test);
        }
    }
}

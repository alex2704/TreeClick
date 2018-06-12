using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeClick
{
    public partial class GenerateTree : Form
    {
        public GenerateTree()
        {
            InitializeComponent();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            Deep = Convert.ToInt32(InputDeep.Text);
            NodesCount = Convert.ToInt32(InputNodes.Text);
        }
        public int Deep { get; set; }
        public int NodesCount { get; set; }
        private void GenerateTree_Load(object sender, EventArgs e)
        {
            InputDeep.Text = Deep.ToString();
            InputNodes.Text = NodesCount.ToString();
        }
    }
}

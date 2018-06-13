using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace TreeClick
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }
        Tree tree;
        DrawTree draw;

        private void Form1_Load(object sender, EventArgs e)
        {
            tree = new Tree();
            draw = new DrawTree(new Size(750, 400), tree);
        }
        private void TreeForm_Paint(object sender, PaintEventArgs e)
        {
            if (draw != null)
                e.Graphics.DrawImage(draw.Draw(), 0, 50);
        }
        Node SelectedNode;
        private void TreeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                SelectedNode = draw.GetNode(e.X, e.Y - 50);
                if(SelectedNode != null)
                {
                    if (SelectedNode == tree.Root)
                        RemoveBtn.Enabled = false;
                    else
                        RemoveBtn.Enabled = true;
                    contextMenuStrip.Show(this, e.Location);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NodeForm node = new NodeForm();
            node.Value = 0;
            try
            {
                if(node.ShowDialog() == DialogResult.OK)
                {
                    SelectedNode.Add(node.Value);
                    Refresh();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            SelectedNode.Parent.Nodes.Remove(SelectedNode);
            Refresh();
        }

        private void Generate_tree_Click(object sender, EventArgs e)
        {
            tree.Root = new Node();
            SelectedNode = tree.Root;
            GenerateTree node = new GenerateTree();
            node.Deep = 0;
            node.NodesCount = 0;
            try
            {
                if (node.ShowDialog() == DialogResult.OK)
                {
                    tree.GenerateRandomTree(SelectedNode,node.Deep,node.NodesCount);
                    Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void записатьПутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tree.WriteTree(saveFileDialog.FileName);
            }
        }

        private void SortTree_Click(object sender, EventArgs e)
        {
            tree.SortInsertionTree();
            Refresh();
        }
    }
}

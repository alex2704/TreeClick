using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Node
    {
        public Node Parent { get; set; }
        public double Value { get; set; }
        public List<Node> Nodes { get; set; }
        public int GetLevelCount()
        {
            if (Nodes.Count == 0)
                return 1;
            else
            {
                int max = 0;
                for (int i = 0; i < Nodes.Count; i++)
                    max = Math.Max(max, Nodes[i].GetLevelCount());
                return max + 1;
            }
        }
        public Node(double value = 0, Node parent = null)
        {
            Value = value;
            Parent = parent;
            Nodes = new List<Node>();
        }
        public void Add(double value)
        {
            Nodes.Add(new Node(value, this));
        }
    }
    public class Tree
    {
        public Node Root { get; set; }
        public int GetLevelCount()
        {
            return Root.GetLevelCount();
        }
        public Tree()
        {
            Root = new Node();
        }
        public void Generate(int N, int K)
        {
            Root = Generate2(0, N, K);
        }

        private Node Generate2(int v, int N, int K)
        {
            return null;
        }
        //Random rnd = new Random();
        public void GenerateRandomTree(Node SelectedNode, int deep, int count, int t = 0)
        {
            Random rnd = new Random();
            for (int j = 0; j < count; j++)
            {
                Node node = new Node();
                node.Parent = SelectedNode;
                node.Value = rnd.Next(4);
                SelectedNode.Nodes.Add(node);
            }
            t++;
            if (t < deep)
            {
                for(int i=0;i<count;i++)
                    GenerateRandomTree(SelectedNode.Nodes[i], deep, count, t);
            }
        }
        //List<Node> NodesData { get; set; }
        //List<String> Ways { get; set; }
        public void WriteTree(string FileName)
        {
            List<Node>NodesData = new List<Node>();
            List<string> Ways = new List<string>();
            WriteTree(Root,  Ways, NodesData);
            File.WriteAllLines(FileName, Ways);
        }
        private void WriteTree(Node SelectedNode, List<string> Ways,List<Node> NodesData)
        {
            NodesData.Add(SelectedNode);
            if (SelectedNode.Nodes.Count != 0)
            {
                foreach (var item in SelectedNode.Nodes)
                {
                    WriteTree(item, Ways,NodesData);
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in NodesData)
                {
                    sb.Append(item.Value.ToString() + " ");
                }
                Ways.Add(sb.ToString());
            }
            NodesData.Remove(SelectedNode);
        }
        public void SortInsertionTree()
        {
            SortInsertionTree(Root);
        }
        private void SortInsertionTree(Node SelectedNode)
        {
            if (SelectedNode.Nodes.Count != 0)
            {
                SortInsertion(SelectedNode.Nodes);
                foreach(Node item in SelectedNode.Nodes)
                {
                    SortInsertionTree(item);
                }
            }
            //return SelectedNode.Nodes;
        }
        private List<Node> SortInsertion(List<Node> mas)
        {
            for (int i = 1; i < mas.Count; i++)
            {
                int j = i;
                Node tmpNode = mas[j];
                double tmp = mas[j].Value;
                while (j > 0 && tmp < mas[j - 1].Value)
                {
                    mas[j] = mas[j - 1];
                    j--;
                }
                mas[j] = tmpNode;
            }
            return mas;
        }
    }
}

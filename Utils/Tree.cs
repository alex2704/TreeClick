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
        Random rnd = new Random();
        public void GenerateRandomTree(Node SelectedNode, int deep, int count, int t = 0)
        {
            for (int j = 0; j < count; j++)
            {
                Node node = new Node();
                node.Parent = SelectedNode;
                node.Value = rnd.Next(100);
                SelectedNode.Nodes.Add(node);
            }
            t++;
            if (t < deep)
            {
                for(int i=0;i<count;i++)
                    GenerateRandomTree(SelectedNode.Nodes[i], deep, count, t);
            }
        }
        List<double> NodesData { get; set; }
        public void WriteTree(Node SelectedNode, string filename,int localCount = 0)
        {
            if (SelectedNode != null)
            {
                NodesData.Add(SelectedNode.Value);
                if (SelectedNode.Nodes.Count != 0)
                    for (int i = 0; i < SelectedNode.Nodes.Count; i++)
                    {
                        localCount = i;
                        WriteTree(SelectedNode.Nodes[i], filename, localCount);
                    }
                else
                {
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        string s = Convert.ToString(NodesData);
                        sw.Write("{0}", s);
                        NodesData.Remove(NodesData[localCount]);
                        SelectedNode.Parent.Nodes.Remove(SelectedNode);
                        WriteTree(SelectedNode.Parent, filename, localCount);
                    }
                }
            }
        }
        //private void WriteTreeHelper(Node SelectedNode, string filename, int localCount = 0)
        //{
        //    if (SelectedNode.Nodes.Count != 0)
        //        for (int i = 0; i < SelectedNode.Nodes.Count; i++)
        //        {
        //            localCount = i;
        //            WriteTree(SelectedNode.Nodes[i], filename, localCount);
        //        }
        //    else
        //    {
        //        using (StreamWriter sw = File.CreateText(filename))
        //        {
        //            string s = Convert.ToString(NodesData);
        //            sw.Write("{0}", s);
        //            NodesData.Remove(NodesData[localCount]);
        //            WriteTreeHelper(SelectedNode.Parent, filename, localCount);
        //        }
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppParikshan
{
    public partial class Parikshan : Form
    {
        public Parikshan()
        {
            InitializeComponent();
        }
        string path = @"C:\SL\AppParikshan";
        private void Parikshan_Load(object sender, EventArgs e)
        {
            var directories = Directory.GetDirectories(path);
            var rootNode = new TreeNode("Requests");
            foreach (var dir in directories)
            {
                var directoryName = dir.Split(Path.DirectorySeparatorChar).Last();
                var directoryNode = new TreeNode(directoryName);
                var files = Directory.GetFiles(dir, "*.xml")?.Where(f => f.Contains("Request"));
                foreach (var file in files)
                {
                    var fileNode = new TreeNode(Path.GetFileName(file));
                    directoryNode.Nodes.Add(fileNode);
                }

                rootNode.Nodes.Add(directoryNode);
            }
            treeView1.Nodes.Add(rootNode);
            treeView1.Select();
            treeView1.ExpandAll();
        }
    }
}

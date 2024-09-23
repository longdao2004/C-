using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemNodeCha_Click(object sender, EventArgs e)
        {
            string nodeCha = txtThemNodeCha.Text.Trim();
            if (nodeCha.Equals(""))
            {
                return;
            }

            TreeNode root = new TreeNode(nodeCha);
            treeView1.Nodes.Add(root);
        }

        private void btnThemNodeCon_Click(object sender, EventArgs e)
        {
            string nodeCon = txtThemNodeCon.Text.Trim();
            if (nodeCon.Equals(""))
            {
                return ;
            }

            TreeNode childNode = new TreeNode(nodeCon);
            treeView1.SelectedNode.Nodes.Add(childNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtSuaNode.Text = treeView1.SelectedNode.Text;
            groupBox2.Text = "Ban da chon " + treeView1.SelectedNode.Text;
            txtDuongDan.Text = treeView1.SelectedNode.FullPath;
        }

        private void btnSuaNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = txtSuaNode.Text.Trim();

            //groupBox2.Text = "Ban da chon " + treeView1.SelectedNode.Text;
        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon xoa k" + treeView1.SelectedNode.Text, "Hoi xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
    }
}

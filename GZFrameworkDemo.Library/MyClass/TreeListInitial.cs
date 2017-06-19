using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyClass
{
    /// <summary>
    /// 初始化TreeList，父子节点选择关联
    /// </summary>
    public class TreeListInitial
    {
        TreeList Tree;
        /// <summary>
        /// 初始化TreeList，父子节点选择关联
        /// </summary>
        /// <param name="tree"></param>
        public TreeListInitial(TreeList tree)
        {
            Tree = tree;
            tree.BeforeCheckNode += tree_BeforeCheckNode;
            tree.AfterCheckNode += tree_AfterCheckNode;
        }

        public bool AllowCheck = true;

        public void tree_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        void tree_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.CanCheck = AllowCheck;


            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        public void SetNodeCheckState(TreeListNode node, CheckState checkState)
        {
            Tree.SetNodeCheckState(node, CheckState.Checked);
            SetCheckedChildNodes(node, CheckState.Checked);
            SetCheckedParentNodes(node, CheckState.Checked);
        }

        void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);

            }
        }
        void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }


    }
}

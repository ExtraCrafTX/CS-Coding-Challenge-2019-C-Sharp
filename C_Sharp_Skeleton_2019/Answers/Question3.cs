using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            TreeNode root = new TreeNode(scores[scores.Length - 1]);
            BuildTree(root, scores);
            Array.Sort(alice);
            TreeNode current = getStart(root);
            return getModePos(current, alice);
        }

        public static int getModePos(TreeNode current, int[] alice)
        {
            int currentPos = 1;
            int lastPos = 0;
            int count = 0;
            int maxCount = 0;
            int maxVal = 0;
            for (int i = alice.Length - 1; i >= 0; i--)
            {
                int score = alice[i];
                while (current != null && score < current.val)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                        while (current.right != null)
                            current = current.right;
                    }
                    else
                    {
                        while (current != null && !current.big)
                        {
                            current = current.parent;
                        }
                        if(current != null)
                            current = current.parent;
                    }
                    currentPos++;
                }
                if (currentPos != lastPos)
                {
                    lastPos = currentPos;
                    count = 1;
                }
                else
                {
                    count++;
                }
                if (count >= maxCount)
                {
                    maxCount = count;
                    maxVal = currentPos;
                }
            }
            return maxVal;
        }

        public static TreeNode getFinish(TreeNode node)
        {
            while (node.left != null)
                node = node.left;
            return node;
        }

        public static TreeNode getStart(TreeNode node)
        {
            while (node.right != null)
                node = node.right;
            return node;
        }

        public static void BuildTree(TreeNode root, int[] scores)
        {
            for (int i = scores.Length - 2; i >= 0; i--)
            {
                TreeNode curr = root;
                int score = scores[i];
                while (true)
                {
                    if (score == curr.val)
                        break;
                    else if (score < curr.val)
                    {
                        if (curr.left == null)
                        {
                            curr.left = new TreeNode(score, curr);
                        }
                        else
                        {
                            curr = curr.left;
                        }
                    }
                    else
                    {
                        if (curr.right == null)
                        {
                            curr.right = new TreeNode(score, curr, true);
                        }
                        else
                        {
                            curr = curr.right;
                        }
                    }
                }
            }
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;
        public bool big;
        public int val;

        public TreeNode(int val)
        {
            this.val = val;
        }

        public TreeNode(int val, TreeNode parent)
        {
            this.val = val;
            this.parent = parent;
        }

        public TreeNode(int val, TreeNode parent, bool big)
        {
            this.val = val;
            this.parent = parent;
            this.big = big;
        }
    }
}
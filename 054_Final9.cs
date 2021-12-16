using System;

namespace _054_Final9
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Queue SkillTree = new Queue();

            Console.Write("Input skill name: ");

            string skillName = Console.ReadLine();
            Node skill = new Node(skillName);

            SkillTree.Push(skill);

            CheckSkillName(skillName, SkillTree);

        }


        static void CheckSkillName(string skillName, Queue SkillTree)
        {
            if (skillName == "?")
            {
                Node name = SkillTree.Pop();
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Add dependency for {0}?", skillName);
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'Y')
                {
                    InputDependencySkill();
                }

            }
        }

        static void InputDependencySkill()
        {
            Console.Write("Input skill name: ");
            string DependencySkill = Console.ReadLine();

            CheckDependencySkill(DependencySkill);

        }

        static void CheckDependencySkill(string DependencySkill)
        {
            Console.WriteLine("Add dependency for {0}?", DependencySkill);
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'Y')
            {
                InputDependencySkill();
            }
            else
            {

            }
        }
    }

    class Node
    {
        public Node depency;
        public Node Next;
        public string Name;

        public Node (string name)
        {
            Name = name;
        }
    }

    class Queue
    {
        public Node root;

        public void Push(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node ptr = root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
        }

        public Node Pop()
        {
            Node node = root;
            if (root != null)
            {
                root = root.Next;
                node.Next = null;
            }
            return node;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Tree
{
    public class Node
    {
        public int Cost = 0;
        public int x;
        public int y;
        public Node Father = null;
        public Node(Node Father, int x, int y)
        {
            this.Father = Father;
            this.x = x;
            this.y = y;
            if (Father != null)
                this.Cost = Father.Cost + 1;
        }
        public bool IsAddable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Data.Width || y >= Data.Height)
                return false;
            if (Data.board.homes[x, y].type == Home.Type.Obstacle)
                return false;
            if (this.x == x && this.y == y)
                return false;
            if (this.Father == null)
                return true;
            return this.Father.IsAddable(x, y);
        }
        public bool IsDestinition()
        {
            if (Data.DestinationHome.x == this.x && Data.DestinationHome.y == this.y)
                return true;
            return false;
        }
        public Node Search(int Limited)
        {
            if (IsDestinition())
                return this;
            if (this.Cost >= Limited)
                return null;
            if (IsAddable(this.x, this.y + 1))
            {
                IDS.ChildFinded++;
                Node temp = new Node(this, this.x, this.y + 1).Search(Limited);
                if (temp != null)
                    return temp;
            }
            if (IsAddable(this.x, this.y - 1))
            {
                IDS.ChildFinded++;
                Node temp = new Node(this, this.x, this.y - 1).Search(Limited);
                if (temp != null)
                    return temp;
            }
            if (IsAddable(this.x + 1, this.y))
            {
                IDS.ChildFinded++;
                Node temp = new Node(this, this.x + 1, this.y).Search(Limited);
                if (temp != null)
                    return temp;
            }
            if (IsAddable(this.x - 1, this.y))
            {
                IDS.ChildFinded++;
                Node temp = new Node(this, this.x - 1, this.y).Search(Limited);
                if (temp != null)
                    return temp;
            }

            if (Data.Is8Side)
            {
                if (IsAddable(this.x + 1, this.y + 1))
                {
                    IDS.ChildFinded++;
                    Node temp = new Node(this, this.x + 1, this.y + 1).Search(Limited);
                    if (temp != null)
                        return temp;
                }
                if (IsAddable(this.x - 1, this.y - 1))
                {
                    IDS.ChildFinded++;
                    Node temp = new Node(this, this.x - 1, this.y - 1).Search(Limited);
                    if (temp != null)
                        return temp;
                }
                if (IsAddable(this.x - 1, this.y + 1))
                {
                    IDS.ChildFinded++;
                    Node temp = new Node(this, this.x - 1, this.y + 1).Search(Limited);
                    if (temp != null)
                        return temp;
                }
                if (IsAddable(this.x + 1, this.y - 1))
                {
                    IDS.ChildFinded++;
                    Node temp = new Node(this, this.x + 1, this.y - 1).Search(Limited);
                    if (temp != null)
                        return temp;
                }
            }
            return null;
        }
    }
}


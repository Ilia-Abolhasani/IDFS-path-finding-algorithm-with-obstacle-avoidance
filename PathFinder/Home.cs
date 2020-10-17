using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PathFinder
{
    public class Home :Button
    {
        public enum Type
        {
            StartPoint,
            Destination,
            Passage,
            Obstacle            
        }
        public Home.Type type;
        public int x;
        public int y;

        public Home(int x,int y)
        {
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "";
            this.ChangeType(Type.Passage);
            this.Click += Home_Click;
            this.x = x;
            this.y = y;
        }
        public void ChangeType(Home.Type type)
        {
            this.type = type;
            this.SetColor();
        }
        void Home_Click(object sender, EventArgs e)
        {
            if (this.type == Home.Type.Destination)
                Data.DestinationHome = null;
            if (this.type == Home.Type.StartPoint)
                Data.StartHome= null;

            if (Data.SelectionType == Home.Type.Destination)
            {            
                if (Data.DestinationHome != null)             
                    Data.DestinationHome.ChangeType(Type.Passage);                
                Data.DestinationHome = this;
            }
            if (Data.SelectionType == Home.Type.StartPoint)
            {            
                if (Data.StartHome != null)                
                    Data.StartHome.ChangeType(Type.Passage);
                Data.StartHome = this;
            }
            
            ChangeType(Data.SelectionType);

            Data.board.ClearTexts();
        }
        public void SetColor()
        {
            switch (type)
            {
                case Type.StartPoint:
                    this.BackColor = Color.Green;
                    break;
                case Type.Destination:
                    this.BackColor = Color.Gold;
                    break;
                case Type.Passage:
                    this.BackColor = Color.GreenYellow;
                    break;
                case Type.Obstacle:
                    this.BackColor = Color.Black;
                    break;
                default:
                    break;
            }                
        }
        public void SetSelected()
        {
            this.Text = "*";
        }
    }
}

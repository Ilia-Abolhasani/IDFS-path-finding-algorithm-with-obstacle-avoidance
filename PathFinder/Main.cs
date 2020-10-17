using PathFinder.Tree;
using System;
using System.Windows.Forms;

namespace PathFinder
{
    public partial class Main : Form
    {
        public Board board;
        public Main()
        {
            InitializeComponent();            
            board = new Board();
            panel2.Controls.Add(board);
            Data.board = board;
        }
        private void StartPointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Data.SelectionType = Home.Type.StartPoint;
        }
        private void DestinationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Data.SelectionType = Home.Type.Destination;            
        }
        private void ObstacleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Data.SelectionType = Home.Type.Obstacle;            
        }
        private void PassageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Data.SelectionType = Home.Type.Passage;            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartAlgorithem();
        }   
        private void StartAlgorithem()
        {
            if(Data.StartHome==null)
                MessageBox.Show("Start home not selected!");
            else if(Data.DestinationHome==null)
                MessageBox.Show("Destination home not selected!");
            else
            {
                IDS ids = new IDS();
                ids.Start();
                if (ids.Answer == null)
                    MessageBox.Show("There is no answer for this solution!");
                else
                    ShowPath(ids.Answer);
            }
        }
        private void ShowPath(Node node)
        {
            board.IsTextchenged = true;
            while (node != null)
            {
                board.homes[node.x, node.y].SetSelected();
                node = node.Father;
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

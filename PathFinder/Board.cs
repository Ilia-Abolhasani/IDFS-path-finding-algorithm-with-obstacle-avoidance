using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Board:Panel
    {
        public bool IsTextchenged = false;
        public Home[,] homes;                
        public Board():base()
        {            
            this.Dock = DockStyle.Fill;            
            Initialize();
            this.SizeChanged += Board_SizeChanged;            
        }
        public void Initialize()
        {
            homes = new Home[Data.Width, Data.Height];
            for (int i = 0; i < Data.Width; i++)
                for (int j = 0; j < Data.Height; j++)
                {
                    homes[i, j] = new Home(i,j);
                    this.Controls.Add(homes[i, j]);
                }
            SetSize();
        }
        void Board_SizeChanged(object sender, EventArgs e)
        {
            SetSize();
        }
        void SetSize()
        {
            int Width = this.Size.Width / Data.Width;
            int Height = this.Size.Height / Data.Height;
            for (int i = 0; i < Data.Width; i++)
                for (int j = 0; j < Data.Height; j++)
                {
                    homes[i, j].Size = new System.Drawing.Size(Width, Height);
                    homes[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    homes[i, j].Location = new System.Drawing.Point(i * Width, j * Height);
                }       
        }
        public void ClearTexts()
        {
            if (!IsTextchenged)
                return;
            for (int i = 0; i < Data.Width; i++)
                for (int j = 0; j < Data.Height; j++)
                    homes[i, j].Text = "";
            IsTextchenged = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flood_it
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        public struct Coords // Structure for saving cell coordinates 
        {
            public int x, y;
            public Coords(int nx, int ny)
            {
                x = nx;
                y = ny;
            }
        }

        int[,] game; // Array of the playing field
        int[,] tgame; // Additional array
        Label[,] field; // Array of Label elements
        int Rows = 25, Cols = 25; // The size of the playing field
        int WxH = 21; // Cell size
        int player, comp; // Points scored by players
        int countClick; // Counter of the number of steps
        bool flagEnd; // Sign of the end of the game
        const int maxColor = 6; // Count of colors
        // Array of color names
        Color[] colors = new Color[] { Color.Salmon, Color.LightSkyBlue, Color.MediumOrchid, Color.LightSeaGreen, Color.Gold, Color.DeepPink };
        int pColor, cColor; // The number of the current player and computer color
        int[] col = new int[maxColor]; //  An array of colors 
        int pMark = 11, cMark = 22; // Markers of recolored cells 
        int i, j;

        // Черга для збереження координат клітинок, які аналізуються
        Queue<Coords> tmpQ = new Queue<Coords>(); 
        Queue<Coords> colQ = new Queue<Coords>();

        // Array for analyzing the coordinates of adjacent cells
        int[,] dir = new int[2, 4] { { -1, 0, 1, 0 }, { 0, -1, 0, 1 } };

        Random rand = new Random();

        // The function that is run when the program starts
        // Used to initialize some game parameters 
        private void Root_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = "0";
            lblComp.Text = "0";

            game = new int[Rows, Cols]; // Allocation of memory for the main array of the game
            tgame = new int[Rows, Cols];

            field = new Label[Rows, Cols]; // Allocation of memory for the array of Label elements
            CreateField(Rows, Cols, WxH); // A function that creates an array of Label elements

            tlpField.Width = Cols * WxH;
            tlpField.Height = Rows * WxH;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            NewGame(); // A function that generates a new game
        }

        // A function that dynamically creates Label controls and places them in the field array 
        private void CreateField(int cRows, int cCols, int size)
        {
            tlpField.Visible = false;
            tlpField.Controls.Clear();
            tlpField.ColumnStyles.Clear();
            tlpField.RowStyles.Clear();
            tlpField.ColumnCount = cCols;
            tlpField.RowCount = cRows;
            for (i = 0; i < cRows; i++)
            {
                tlpField.RowStyles.Add(new RowStyle(SizeType.Absolute));
                tlpField.RowStyles[i].Height = WxH;
                for (j = 0; j < cCols; j++)
                {
                    if (i == 0)
                    {
                        tlpField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
                        tlpField.ColumnStyles[j].Width = WxH;
                    }
                    Label lbl = new Label();
                    lbl.AutoSize = false;
                    lbl.Width = size;
                    lbl.Height = size;
                    lbl.Click += CellClick; // An event handler is connected for each Label element
                    lbl.Tag = i + " " + j;
                    lbl.Margin = new Padding(1, 1, 0, 0);
                    lbl.BorderStyle = BorderStyle.None;
                    lbl.Text = "";
                    field[i, j] = lbl;
                    tlpField.Controls.Add(lbl, i, j);
                }
            }
            tlpField.Visible = true;
        }

        //A function that sets the default values when you start a new game
        private void NewGame()
        {
            player = 0;
            comp = 0;
            RNDGame();
            pColor = game[0, 0];
            game[0, 0] = pMark;
            cColor = game[Rows - 1, Cols - 1];
            game[Rows - 1, Cols - 1] = cMark;
            flagEnd = false;
            FloodField(1, pColor);
            FloodField(2, cColor);
            RefreshField();
            countClick = 0;
        }

        //A function that identifies the coordinates of a clicked cell
        private void CellClick(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            string tag = lbl.Tag as String;
            var iandj = tag.Split(' ');
            int x = Convert.ToInt32(iandj[0]);
            int y = Convert.ToInt32(iandj[1]);

            if (flagEnd)
                return;

            if (game[x, y] == pMark || game[x, y] == cColor || game[x, y] == cMark)
                return;

            if (!IsNeighbor(new Coords(x, y), pMark))
                return;

            countClick++;

            pColor = game[x, y];
            FloodField(1, pColor);
            RefreshField();

            cColor = PlayComp();
            FloodField(2, cColor);
            RefreshField();
            TestEnd();
        }

        //A function that fills a field with random colors
        private void RNDGame()
        {
            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Cols; j++)
                {
                    game[i, j] = rand.Next(maxColor);
                }
            }

            while (game[0, 0] == game[Rows - 1, Cols - 1] || (game[1, 0] == game[Rows - 1, Cols - 1] || game[0, 1] == game[Rows - 1, Cols - 1]))
            {
                game[Rows - 1, Cols - 1] = rand.Next(maxColor);
            }

            while (game[Rows - 2, Cols - 1] == game[0, 0] && game[Rows - 1, Cols - 2] == game[0, 0])
            {
                game[Rows - 2, Cols - 1] = rand.Next(maxColor);
                game[Rows - 1, Cols - 2] = rand.Next(maxColor);
            }
        }

        //A function that updates information on the field after a move is made
        private void RefreshField()
        {
            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Cols; j++)
                {
                    if (game[i, j] == pMark)
                        field[i, j].BackColor = colors[pColor];
                    else if (game[i, j] == cMark)
                        field[i, j].BackColor = colors[cColor];
                    else
                        field[i, j].BackColor = colors[game[i, j]];
                }
            }
            lblComp.Text = Convert.ToString(comp);
            lblPlayer.Text = Convert.ToString(player);
            lblCount.Text = Convert.ToString(countClick);

            BarRefresh();
        }

        //A function that makes changes to the game array and calculates the number of points
        private void FloodField(int gamer, int numC)
        {
            Coords np, tmp;
            int x, y, cc;

            if (gamer == 1)
            {
                x = 0;
                y = 0;
                cc = pMark;
                player = 1;
            }
            else
            {
                x = Rows - 1;
                y = Cols - 1;
                cc = cMark;
                comp = 1;
            }

            tmpQ.Clear();
            tmpQ.Enqueue(new Coords(x, y));

            tgameClear();
            tgame[x, y] = 0;

            while (tmpQ.Count > 0)
            {
                tmp = tmpQ.Dequeue();
                for (i = 0; i < 4; i++)
                {
                    np.x = tmp.x + dir[0, i];
                    np.y = tmp.y + dir[1, i];
                    if (IsCorectCoords(np) && tgame[np.x, np.y] == 1 && (game[np.x, np.y] == numC || game[np.x, np.y] == game[tmp.x, tmp.y]))
                    {
                        tmpQ.Enqueue(np);
                        tgame[np.x, np.y] = 0;
                        game[np.x, np.y] = cc;
                        if (gamer == 1)
                            player++;
                        else
                            comp++;
                    }
                }
            }
        }

        //Check if the selected cell is adjacent
        private bool IsNeighbor(Coords p, int c)
        {
            Coords np, tmp;
            tmpQ.Clear();
            tmpQ.Enqueue(p);

            tgameClear();
            tgame[p.x, p.y] = 0;

            while (tmpQ.Count > 0)
            {
                tmp = tmpQ.Dequeue();
                for (i = 0; i < 4; i++)
                {
                    np.x = tmp.x + dir[0, i];
                    np.y = tmp.y + dir[1, i];
                    if (IsCorectCoords(np))
                    {
                        if (game[np.x, np.y] == game[0, 0])
                            return true;
                        if (tgame[np.x, np.y] == 1 && game[np.x, np.y] == game[p.x, p.y])
                        {
                            tmpQ.Enqueue(np);
                            tgame[np.x, np.y] = 0;
                        }
                    }
                }
            }
            return false;
        }

        //Cleaning an additional array
        private void tgameClear()
        {
            for (i = 0; i < Rows; i++)
            {
                for (j = 0; j < Cols; j++)
                {
                    tgame[i, j] = 1;
                }
            }
        }

        //"New game" button
        private void butNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        //Check if cell coordinates are correct
        private bool IsCorectCoords(Coords p)
        {
            if (p.x >= 0 && p.x < Rows && p.y >= 0 && p.y < Cols)
                return true;
            else
                return false;
        }

        //Button "About the author"
        private void butAbout_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            Form RuleForm = new RuleBox();
            RuleForm.ShowDialog();
        }

        //The function that is responsible for computer moves
        private int PlayComp()
        {
            for (i = 0; i < maxColor; i++)
                col[i] = 0;

            tmpQ.Clear();
            tgameClear();
            Coords tmp, np;

            tmpQ.Enqueue(new Coords(Rows - 1, Cols - 1));
            tgame[Rows - 1, Cols - 1] = 0;

            while (tmpQ.Count > 0)
            {
                tmp = tmpQ.Dequeue();
                for (i = 0; i < 4; i++)
                {
                    np.x = tmp.x + dir[0, i];
                    np.y = tmp.y + dir[1, i];
                    if (IsCorectCoords(np) && tgame[np.x, np.y] == 1)
                    {
                        if (game[np.x, np.y] == cMark)
                        {
                            tmpQ.Enqueue(np);
                            tgame[np.x, np.y] = 0;
                        }
                        else if (game[np.x, np.y] != pMark && game[np.x, np.y] != pColor)
                        {
                            col[game[np.x, np.y]] += CountCellColor(np, game[np.x, np.y]);
                        }
                    }
                }
            }
            int mi = 0;
            for (i = 0; i < maxColor; i++)
            {
                if (col[i] > col[mi])
                    mi = i;
            }
            return mi;
        }

        //Checking if the game is over
        private bool TheEnd(int gamer)
        {
            int x, y, cc1, cc2;
            Coords np, tmp;
            if (gamer == 1)
            {
                x = 0;
                y = 0;
                cc1 = pMark;
                cc2 = cMark;
            }
            else
            {
                x = Rows - 1;
                y = Cols - 1;
                cc1 = cMark;
                cc2 = pMark;
            }
            tmpQ.Clear();
            tmpQ.Enqueue(new Coords(x, y));

            tgameClear();
            tgame[x, y] = 0;

            while (tmpQ.Count > 0)
            {
                tmp = tmpQ.Dequeue();
                for (i = 0; i < 4; i++)
                {
                    np.x = tmp.x + dir[0, i];
                    np.y = tmp.y + dir[1, i];

                    if (IsCorectCoords(np) && tgame[np.x, np.y] == 1)
                    {
                        if (game[np.x, np.y] == cc1)
                        {
                            tmpQ.Enqueue(np);
                            tgame[np.x, np.y] = 0;
                        }
                        else if (game[np.x, np.y] != cc2)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        //Checks whether it is possible to continue the game and displays a message about who is the winner
        private void TestEnd()
        {
            if (player + comp == Rows * Cols || TheEnd(1) || TheEnd(2))
            {
                if (player == comp)
                {
                    MessageBox.Show("Dwar!", "Flood It", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (player > comp)
                {
                    MessageBox.Show("You have won :)", "Flood It", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You lost :(", "Flood It", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                flagEnd = true;
            }
        }

        //A function that counts the number of adjacent cells of a given color
        private int CountCellColor(Coords CoordCell, int C)
        {
            int k = 1;
            colQ.Clear();
            Coords tmp, nc;

            colQ.Enqueue(CoordCell);
            tgame[CoordCell.x, CoordCell.y] = 0;
            while (colQ.Count > 0)
            {
                tmp = colQ.Dequeue();
                for (i = 0; i < 4; i++)
                {
                    nc.x = tmp.x + dir[0, i];
                    nc.y = tmp.y + dir[1, i];
                    if (IsCorectCoords(nc) && game[nc.x, nc.y] == C && tgame[nc.x, nc.y] == 1)
                    {
                        colQ.Enqueue(nc);
                        tgame[nc.x, nc.y] = 0;
                        k++;
                    }
                }
            }
            return k;
        }

        //A function that updates information in the ProgressBar
        private void BarRefresh()
        {
            lblPlayerColor.BackColor = colors[pColor];
            lblCompColor.BackColor = colors[cColor];

            int All = Rows * Cols;
            int WBar = lblBarBase.Width;

            lblBarPlayer.BackColor = colors[pColor];
            int x = (player * 100) / All;
            lblBarPlayer.Width = WBar * x / 100;

            lblBarComp.BackColor = colors[cColor];
            x = (comp * 100) / All;
            int widthComp = WBar * x / 100;
            lblBarComp.Left = (lblBarBase.Left + lblBarBase.Width) - widthComp;
            lblBarComp.Width = widthComp;
        }
    }
}

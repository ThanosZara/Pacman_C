using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsAppPacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            newGame();
        }
        bool moveUp, moveDown, moveRight, moveLeft, ghostDown;
        int score, movingSpeed, gameDuration, ghostSpeed;
        Random rand = new Random();//cherries placement 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveUp = true;
                    break;
                case Keys.Down:
                    moveDown = true;
                    break;
                case Keys.Left:
                    moveLeft = true;
                    break;
                case Keys.Right:
                    moveRight = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveUp = false;
                    break;
                case Keys.Down:
                    moveDown = false;
                    break;
                case Keys.Left:
                    moveLeft = false;
                    break;
                case Keys.Right:
                    moveRight = false;
                    break;

            }
        }

        private void pacmanTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;
            //pacman movement
            if (moveUp)
            {
                pacman.Top -= movingSpeed;
                pacman.Image = Properties.Resources.Pacman_Up;

            }
            else if (moveDown)
            {
                pacman.Top += movingSpeed;
                pacman.Image = Properties.Resources.Pacman_Down;
            }
            else if (moveLeft)
            {
                pacman.Left -= movingSpeed;
                pacman.Image = Properties.Resources.Pacman_Left;
            }
            else if (moveRight)
            {
                pacman.Left += movingSpeed;
                pacman.Image = Properties.Resources.Pacman_Right;
            }

            //if pacman goes outside the form it appears on the other side
            if (pacman.Left < -10)
            {
                pacman.Left = 770;
            }
            if (pacman.Left > 770)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < 23)
            {
                pacman.Top = 420;
            }
            if (pacman.Top > 420)
            {
                pacman.Top = 23;
            }

            if (pacman.Bounds.IntersectsWith(cherry1.Bounds))
            {
                score += 10;

                cherry1Timer.Stop();//resets 4 second timer

                cherry1.Left = rand.Next(0, this.Width - cherry1.Width);
                cherry1.Top = rand.Next(24, this.ClientSize.Height - cherry1.ClientSize.Height);//24 is menustrip height

                cherry1Timer.Start();//resets 4 second timer

                label1.Text = "Score: " + score;
            }
            if (pacman.Bounds.IntersectsWith(cherry2.Bounds))
            {
                score += 10;

                cherry2Timer.Stop();

                cherry2.Left = rand.Next(0, this.Width - cherry2.Width);
                cherry2.Top = rand.Next(24, this.ClientSize.Height - cherry2.Height);

                cherry2Timer.Start();

                label1.Text = "Score: " + score;
            }
        }
        private void newGame()
        {
            movingSpeed = 6;
            gameDuration = 45;
            score = 0;

            pacman.Left = 31;
            pacman.Top = 40;

            label3.Visible = false;//"Game over" label


            cherry1.Left = rand.Next(0, this.Width - cherry1.Width);
            cherry1.Top = rand.Next(24, this.ClientSize.Height - cherry1.ClientSize.Height);//24 is menustrip height

            cherry2.Left = rand.Next(0, this.Width - cherry2.Width);
            cherry2.Top = rand.Next(24, this.ClientSize.Height - cherry2.Height);

            pacmanTimer.Start();
            gameTimer.Start();

            cherry1Timer.Stop();//reset cherry timers
            cherry2Timer.Stop();
            cherry1Timer.Start();
            cherry2Timer.Start();
            
            ghost.Top = 24;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = "Time: " + gameDuration;
            gameDuration--;
            if (gameDuration < 0)
            {
                gameOver();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            if (ghost.Visible == true) { //only if its in hard mode, it restarts the ghost timer

                ghostDown = true;
                ghostTimer.Start();
            }
        }

        private void cherry1Timer_Tick(object sender, EventArgs e)
        {

            cherry1.Left = rand.Next(0, this.Width - cherry1.Width);
            cherry1.Top = rand.Next(24, this.ClientSize.Height - cherry1.ClientSize.Height);

        }

        private void cherry2Timer_Tick(object sender, EventArgs e)
        {
            cherry2.Left = rand.Next(0, this.Width - cherry2.Width);
            cherry2.Top = rand.Next(24, this.ClientSize.Height - cherry2.Height);
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cherry1Timer.Interval = 4000;
            cherry2Timer.Interval = 4000;

            ghost.Visible = false;

            newGame();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cherry1Timer.Interval = 3000;
            cherry2Timer.Interval = 3000;

            ghost.Visible = false;

            newGame();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cherry1Timer.Interval = 3000;
            cherry2Timer.Interval = 3000;

            ghost.Visible = true;
            ghostDown = true;
            ghostSpeed = 15;

            newGame();
            ghostTimer.Start();

        }

        private void ghost_Click(object sender, EventArgs e)
        {

        }

        private void ghostTimer_Tick(object sender, EventArgs e)
        {
                if (ghostDown)
                {
                    ghost.Top += ghostSpeed;
                    if (ghost.Top + ghost.Height >= this.ClientSize.Height)//goes up when it reaches the bottom
                    {
                        ghostDown = false;
                    }
                }
                else
                {
                    ghost.Top -= ghostSpeed;
                    if (ghost.Top == 24) //goes down when it touches menustrip
                    {
                        ghostDown = true;
                    }
                }

                if (pacman.Bounds.IntersectsWith(ghost.Bounds))
                {
                    gameOver();
                }

        }
        private void gameOver()
        {
            gameTimer.Stop();
            pacmanTimer.Stop();
            cherry1Timer.Stop();
            cherry2Timer.Stop();
            ghostTimer.Stop();

            label3.Text = "Game Over!" + Environment.NewLine +
                "Your score: " + score;
            label3.Visible = true;
        }
    }
}

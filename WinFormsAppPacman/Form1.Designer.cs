namespace WinFormsAppPacman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pacman = new PictureBox();
            cherry1 = new PictureBox();
            pacmanTimer = new System.Windows.Forms.Timer(components);
            cherry2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            difficultyToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            label2 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            cherry1Timer = new System.Windows.Forms.Timer(components);
            cherry2Timer = new System.Windows.Forms.Timer(components);
            ghost = new PictureBox();
            ghostTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pacman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cherry1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cherry2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ghost).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 414);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 0;
            label1.Text = "Score: 0";
            // 
            // pacman
            // 
            pacman.BackColor = SystemColors.ActiveCaptionText;
            pacman.BackgroundImageLayout = ImageLayout.Stretch;
            pacman.Image = Properties.Resources.Pacman_Right;
            pacman.Location = new Point(31, 41);
            pacman.Name = "pacman";
            pacman.Size = new Size(40, 40);
            pacman.SizeMode = PictureBoxSizeMode.StretchImage;
            pacman.TabIndex = 1;
            pacman.TabStop = false;
            // 
            // cherry1
            // 
            cherry1.Image = Properties.Resources.cherries_pac_man;
            cherry1.Location = new Point(596, 40);
            cherry1.Name = "cherry1";
            cherry1.Size = new Size(40, 40);
            cherry1.SizeMode = PictureBoxSizeMode.StretchImage;
            cherry1.TabIndex = 2;
            cherry1.TabStop = false;
            cherry1.Click += pictureBox2_Click;
            // 
            // pacmanTimer
            // 
            pacmanTimer.Interval = 10;
            pacmanTimer.Tick += pacmanTimer_Tick;
            // 
            // cherry2
            // 
            cherry2.Image = Properties.Resources.cherries_pac_man;
            cherry2.Location = new Point(330, 247);
            cherry2.Name = "cherry2";
            cherry2.Size = new Size(40, 40);
            cherry2.SizeMode = PictureBoxSizeMode.StretchImage;
            cherry2.TabIndex = 3;
            cherry2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 161);
            menuStrip1.Items.AddRange(new ToolStripItem[] { difficultyToolStripMenuItem, newGameToolStripMenuItem, exitToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // difficultyToolStripMenuItem
            // 
            difficultyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem, mediumToolStripMenuItem, hardToolStripMenuItem });
            difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            difficultyToolStripMenuItem.Size = new Size(68, 20);
            difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(119, 22);
            easyToolStripMenuItem.Text = "Easy";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(119, 22);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(119, 22);
            hardToolStripMenuItem.Text = "Hard";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(77, 20);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(38, 20);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(674, 414);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 5;
            label2.Text = "Time: ";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(164, 122);
            label3.Name = "label3";
            label3.Size = new Size(313, 62);
            label3.TabIndex = 6;
            label3.Text = "Game Over!";
            label3.Visible = false;
            // 
            // cherry1Timer
            // 
            cherry1Timer.Interval = 4000;
            cherry1Timer.Tick += cherry1Timer_Tick;
            // 
            // cherry2Timer
            // 
            cherry2Timer.Interval = 4000;
            cherry2Timer.Tick += cherry2Timer_Tick;
            // 
            // ghost
            // 
            ghost.Image = Properties.Resources.ghostPacman;
            ghost.Location = new Point(330, 24);
            ghost.Name = "ghost";
            ghost.Size = new Size(69, 61);
            ghost.SizeMode = PictureBoxSizeMode.StretchImage;
            ghost.TabIndex = 7;
            ghost.TabStop = false;
            ghost.Visible = false;
            ghost.Click += ghost_Click;
            // 
            // ghostTimer
            // 
            ghostTimer.Interval = 50;
            ghostTimer.Tick += ghostTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cherry1);
            Controls.Add(cherry2);
            Controls.Add(pacman);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(ghost);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "PacMan";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pacman).EndInit();
            ((System.ComponentModel.ISupportInitialize)cherry1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cherry2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ghost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pacman;
        private PictureBox cherry1;
        private System.Windows.Forms.Timer pacmanTimer;
        private PictureBox cherry2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem difficultyToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private Label label2;
        private System.Windows.Forms.Timer gameTimer;
        private Label label3;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Timer cherry1Timer;
        private System.Windows.Forms.Timer cherry2Timer;
        private PictureBox ghost;
        private System.Windows.Forms.Timer ghostTimer;
    }
}

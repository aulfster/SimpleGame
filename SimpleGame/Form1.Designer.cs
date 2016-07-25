namespace SimpleGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downMoveButton = new System.Windows.Forms.Button();
            this.rightMoveButton = new System.Windows.Forms.Button();
            this.leftMoveButton = new System.Windows.Forms.Button();
            this.upMoveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downAttackButton = new System.Windows.Forms.Button();
            this.rightAttackButton = new System.Windows.Forms.Button();
            this.leftAttackButton = new System.Windows.Forms.Button();
            this.upAttackButton = new System.Windows.Forms.Button();
            this.batBox = new System.Windows.Forms.PictureBox();
            this.ghostBox = new System.Windows.Forms.PictureBox();
            this.ghoulBox = new System.Windows.Forms.PictureBox();
            this.rBox = new System.Windows.Forms.PictureBox();
            this.bBox = new System.Windows.Forms.PictureBox();
            this.swordBox = new System.Windows.Forms.PictureBox();
            this.bowBox = new System.Windows.Forms.PictureBox();
            this.maceBox = new System.Windows.Forms.PictureBox();
            this.swordPictureBox = new System.Windows.Forms.PictureBox();
            this.bowPictureBox = new System.Windows.Forms.PictureBox();
            this.macePictureBox = new System.Windows.Forms.PictureBox();
            this.bluePotionPictureBox = new System.Windows.Forms.PictureBox();
            this.redPotionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImage = global::SimpleGame.Properties.Resources.player;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox.Location = new System.Drawing.Point(80, 62);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(30, 30);
            this.playerBox.TabIndex = 0;
            this.playerBox.TabStop = false;
            this.playerBox.Click += new System.EventHandler(this.playerBox_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.24363F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.75637F));
            this.tablePanel.Controls.Add(this.playerLabel, 0, 0);
            this.tablePanel.Controls.Add(this.playerHitPoints, 1, 0);
            this.tablePanel.Controls.Add(this.batLabel, 0, 1);
            this.tablePanel.Controls.Add(this.batHitPoints, 1, 1);
            this.tablePanel.Controls.Add(this.ghostLabel, 0, 2);
            this.tablePanel.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tablePanel.Controls.Add(this.ghoulLabel, 0, 3);
            this.tablePanel.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tablePanel.Location = new System.Drawing.Point(343, 239);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 4;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.Size = new System.Drawing.Size(175, 46);
            this.tablePanel.TabIndex = 1;
            this.tablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 11);
            this.playerLabel.TabIndex = 17;
            this.playerLabel.Text = "Player";
            this.playerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(47, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 11);
            this.playerHitPoints.TabIndex = 18;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.Location = new System.Drawing.Point(3, 11);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(23, 11);
            this.batLabel.TabIndex = 19;
            this.batLabel.Text = "Bat";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(47, 11);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 11);
            this.batHitPoints.TabIndex = 20;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Location = new System.Drawing.Point(3, 22);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(35, 11);
            this.ghostLabel.TabIndex = 21;
            this.ghostLabel.Text = "Ghost";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(47, 22);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 11);
            this.ghostHitPoints.TabIndex = 22;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Location = new System.Drawing.Point(3, 33);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulLabel.TabIndex = 23;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(47, 33);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 24;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.downMoveButton);
            this.groupBox1.Controls.Add(this.rightMoveButton);
            this.groupBox1.Controls.Add(this.leftMoveButton);
            this.groupBox1.Controls.Add(this.upMoveButton);
            this.groupBox1.Location = new System.Drawing.Point(356, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // downMoveButton
            // 
            this.downMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downMoveButton.Location = new System.Drawing.Point(34, 39);
            this.downMoveButton.Name = "downMoveButton";
            this.downMoveButton.Size = new System.Drawing.Size(15, 15);
            this.downMoveButton.TabIndex = 20;
            this.downMoveButton.Text = "D";
            this.downMoveButton.UseVisualStyleBackColor = true;
            this.downMoveButton.Click += new System.EventHandler(this.downMoveButton_Click);
            // 
            // rightMoveButton
            // 
            this.rightMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMoveButton.Location = new System.Drawing.Point(55, 28);
            this.rightMoveButton.Name = "rightMoveButton";
            this.rightMoveButton.Size = new System.Drawing.Size(15, 15);
            this.rightMoveButton.TabIndex = 19;
            this.rightMoveButton.Text = "R";
            this.rightMoveButton.UseVisualStyleBackColor = true;
            this.rightMoveButton.Click += new System.EventHandler(this.rightMoveButton_Click);
            // 
            // leftMoveButton
            // 
            this.leftMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMoveButton.Location = new System.Drawing.Point(13, 28);
            this.leftMoveButton.Name = "leftMoveButton";
            this.leftMoveButton.Size = new System.Drawing.Size(15, 15);
            this.leftMoveButton.TabIndex = 18;
            this.leftMoveButton.Text = "L";
            this.leftMoveButton.UseVisualStyleBackColor = true;
            this.leftMoveButton.Click += new System.EventHandler(this.leftMoveButton_Click);
            // 
            // upMoveButton
            // 
            this.upMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upMoveButton.Location = new System.Drawing.Point(34, 19);
            this.upMoveButton.Name = "upMoveButton";
            this.upMoveButton.Size = new System.Drawing.Size(15, 15);
            this.upMoveButton.TabIndex = 17;
            this.upMoveButton.Text = "U";
            this.upMoveButton.UseVisualStyleBackColor = true;
            this.upMoveButton.Click += new System.EventHandler(this.upMoveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.downAttackButton);
            this.groupBox2.Controls.Add(this.rightAttackButton);
            this.groupBox2.Controls.Add(this.leftAttackButton);
            this.groupBox2.Controls.Add(this.upAttackButton);
            this.groupBox2.Location = new System.Drawing.Point(445, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // downAttackButton
            // 
            this.downAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downAttackButton.Location = new System.Drawing.Point(37, 39);
            this.downAttackButton.Name = "downAttackButton";
            this.downAttackButton.Size = new System.Drawing.Size(15, 15);
            this.downAttackButton.TabIndex = 21;
            this.downAttackButton.Text = "D";
            this.downAttackButton.UseVisualStyleBackColor = true;
            this.downAttackButton.Click += new System.EventHandler(this.downAttackButton_Click);
            // 
            // rightAttackButton
            // 
            this.rightAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAttackButton.Location = new System.Drawing.Point(58, 28);
            this.rightAttackButton.Name = "rightAttackButton";
            this.rightAttackButton.Size = new System.Drawing.Size(15, 15);
            this.rightAttackButton.TabIndex = 20;
            this.rightAttackButton.Text = "R";
            this.rightAttackButton.UseVisualStyleBackColor = true;
            this.rightAttackButton.Click += new System.EventHandler(this.rightAttackButton_Click);
            // 
            // leftAttackButton
            // 
            this.leftAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftAttackButton.Location = new System.Drawing.Point(16, 28);
            this.leftAttackButton.Name = "leftAttackButton";
            this.leftAttackButton.Size = new System.Drawing.Size(15, 15);
            this.leftAttackButton.TabIndex = 19;
            this.leftAttackButton.Text = "L";
            this.leftAttackButton.UseVisualStyleBackColor = true;
            this.leftAttackButton.Click += new System.EventHandler(this.leftAttackButton_Click);
            // 
            // upAttackButton
            // 
            this.upAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upAttackButton.Location = new System.Drawing.Point(37, 19);
            this.upAttackButton.Name = "upAttackButton";
            this.upAttackButton.Size = new System.Drawing.Size(15, 15);
            this.upAttackButton.TabIndex = 18;
            this.upAttackButton.Text = "U";
            this.upAttackButton.UseVisualStyleBackColor = true;
            this.upAttackButton.Click += new System.EventHandler(this.upAttackButton_Click);
            // 
            // batBox
            // 
            this.batBox.BackColor = System.Drawing.Color.Transparent;
            this.batBox.BackgroundImage = global::SimpleGame.Properties.Resources.bat;
            this.batBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batBox.InitialImage = global::SimpleGame.Properties.Resources.bat;
            this.batBox.Location = new System.Drawing.Point(116, 62);
            this.batBox.Name = "batBox";
            this.batBox.Size = new System.Drawing.Size(30, 30);
            this.batBox.TabIndex = 4;
            this.batBox.TabStop = false;
            // 
            // ghostBox
            // 
            this.ghostBox.BackColor = System.Drawing.Color.Transparent;
            this.ghostBox.BackgroundImage = global::SimpleGame.Properties.Resources.ghost;
            this.ghostBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostBox.Location = new System.Drawing.Point(152, 62);
            this.ghostBox.Name = "ghostBox";
            this.ghostBox.Size = new System.Drawing.Size(30, 30);
            this.ghostBox.TabIndex = 5;
            this.ghostBox.TabStop = false;
            // 
            // ghoulBox
            // 
            this.ghoulBox.BackColor = System.Drawing.Color.Transparent;
            this.ghoulBox.BackgroundImage = global::SimpleGame.Properties.Resources.ghoul;
            this.ghoulBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghoulBox.Location = new System.Drawing.Point(188, 62);
            this.ghoulBox.Name = "ghoulBox";
            this.ghoulBox.Size = new System.Drawing.Size(30, 30);
            this.ghoulBox.TabIndex = 6;
            this.ghoulBox.TabStop = false;
            // 
            // rBox
            // 
            this.rBox.BackColor = System.Drawing.Color.Transparent;
            this.rBox.BackgroundImage = global::SimpleGame.Properties.Resources.potion_red;
            this.rBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rBox.Location = new System.Drawing.Point(224, 62);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(30, 30);
            this.rBox.TabIndex = 7;
            this.rBox.TabStop = false;
            // 
            // bBox
            // 
            this.bBox.BackColor = System.Drawing.Color.Transparent;
            this.bBox.BackgroundImage = global::SimpleGame.Properties.Resources.potion_blue;
            this.bBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBox.Location = new System.Drawing.Point(260, 62);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(30, 30);
            this.bBox.TabIndex = 8;
            this.bBox.TabStop = false;
            this.bBox.Click += new System.EventHandler(this.bPotionPictureBox_Click);
            // 
            // swordBox
            // 
            this.swordBox.BackColor = System.Drawing.Color.Transparent;
            this.swordBox.BackgroundImage = global::SimpleGame.Properties.Resources.sword;
            this.swordBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordBox.Location = new System.Drawing.Point(296, 62);
            this.swordBox.Name = "swordBox";
            this.swordBox.Size = new System.Drawing.Size(30, 30);
            this.swordBox.TabIndex = 9;
            this.swordBox.TabStop = false;
            // 
            // bowBox
            // 
            this.bowBox.BackColor = System.Drawing.Color.Transparent;
            this.bowBox.BackgroundImage = global::SimpleGame.Properties.Resources.bow;
            this.bowBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowBox.Location = new System.Drawing.Point(332, 62);
            this.bowBox.Name = "bowBox";
            this.bowBox.Size = new System.Drawing.Size(30, 30);
            this.bowBox.TabIndex = 10;
            this.bowBox.TabStop = false;
            // 
            // maceBox
            // 
            this.maceBox.BackColor = System.Drawing.Color.Transparent;
            this.maceBox.BackgroundImage = global::SimpleGame.Properties.Resources.mace;
            this.maceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maceBox.Location = new System.Drawing.Point(368, 62);
            this.maceBox.Name = "maceBox";
            this.maceBox.Size = new System.Drawing.Size(30, 30);
            this.maceBox.TabIndex = 11;
            this.maceBox.TabStop = false;
            // 
            // swordPictureBox
            // 
            this.swordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.swordPictureBox.BackgroundImage = global::SimpleGame.Properties.Resources.sword;
            this.swordPictureBox.Location = new System.Drawing.Point(80, 308);
            this.swordPictureBox.Name = "swordPictureBox";
            this.swordPictureBox.Size = new System.Drawing.Size(50, 50);
            this.swordPictureBox.TabIndex = 12;
            this.swordPictureBox.TabStop = false;
            this.swordPictureBox.Visible = false;
            this.swordPictureBox.Click += new System.EventHandler(this.swordPictureBox_Click);
            // 
            // bowPictureBox
            // 
            this.bowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bowPictureBox.BackgroundImage = global::SimpleGame.Properties.Resources.bow;
            this.bowPictureBox.Location = new System.Drawing.Point(136, 308);
            this.bowPictureBox.Name = "bowPictureBox";
            this.bowPictureBox.Size = new System.Drawing.Size(50, 50);
            this.bowPictureBox.TabIndex = 13;
            this.bowPictureBox.TabStop = false;
            this.bowPictureBox.Visible = false;
            this.bowPictureBox.Click += new System.EventHandler(this.bowPictureBox_Click);
            // 
            // macePictureBox
            // 
            this.macePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.macePictureBox.BackgroundImage = global::SimpleGame.Properties.Resources.mace;
            this.macePictureBox.Location = new System.Drawing.Point(192, 308);
            this.macePictureBox.Name = "macePictureBox";
            this.macePictureBox.Size = new System.Drawing.Size(50, 50);
            this.macePictureBox.TabIndex = 14;
            this.macePictureBox.TabStop = false;
            this.macePictureBox.Visible = false;
            this.macePictureBox.Click += new System.EventHandler(this.macePictureBox_Click);
            // 
            // bluePotionPictureBox
            // 
            this.bluePotionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionPictureBox.BackgroundImage = global::SimpleGame.Properties.Resources.potion_blue;
            this.bluePotionPictureBox.Location = new System.Drawing.Point(248, 308);
            this.bluePotionPictureBox.Name = "bluePotionPictureBox";
            this.bluePotionPictureBox.Size = new System.Drawing.Size(50, 50);
            this.bluePotionPictureBox.TabIndex = 15;
            this.bluePotionPictureBox.TabStop = false;
            this.bluePotionPictureBox.Visible = false;
            this.bluePotionPictureBox.Click += new System.EventHandler(this.bluePotionPictureBox_Click);
            // 
            // redPotionPictureBox
            // 
            this.redPotionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.redPotionPictureBox.BackgroundImage = global::SimpleGame.Properties.Resources.potion_red;
            this.redPotionPictureBox.Location = new System.Drawing.Point(304, 308);
            this.redPotionPictureBox.Name = "redPotionPictureBox";
            this.redPotionPictureBox.Size = new System.Drawing.Size(50, 50);
            this.redPotionPictureBox.TabIndex = 16;
            this.redPotionPictureBox.TabStop = false;
            this.redPotionPictureBox.Visible = false;
            this.redPotionPictureBox.Click += new System.EventHandler(this.redPotionPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 386);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.redPotionPictureBox);
            this.Controls.Add(this.bluePotionPictureBox);
            this.Controls.Add(this.macePictureBox);
            this.Controls.Add(this.bowPictureBox);
            this.Controls.Add(this.swordPictureBox);
            this.Controls.Add(this.maceBox);
            this.Controls.Add(this.bowBox);
            this.Controls.Add(this.swordBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.ghoulBox);
            this.Controls.Add(this.ghostBox);
            this.Controls.Add(this.batBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox batBox;
        private System.Windows.Forms.PictureBox ghostBox;
        private System.Windows.Forms.PictureBox ghoulBox;
        private System.Windows.Forms.PictureBox rBox;
        private System.Windows.Forms.PictureBox bBox;
        private System.Windows.Forms.PictureBox swordBox;
        private System.Windows.Forms.PictureBox bowBox;
        private System.Windows.Forms.PictureBox maceBox;
        private System.Windows.Forms.PictureBox swordPictureBox;
        private System.Windows.Forms.PictureBox bowPictureBox;
        private System.Windows.Forms.PictureBox macePictureBox;
        private System.Windows.Forms.PictureBox bluePotionPictureBox;
        private System.Windows.Forms.PictureBox redPotionPictureBox;
        private System.Windows.Forms.Button upMoveButton;
        private System.Windows.Forms.Button downMoveButton;
        private System.Windows.Forms.Button rightMoveButton;
        private System.Windows.Forms.Button leftMoveButton;
        private System.Windows.Forms.Button leftAttackButton;
        private System.Windows.Forms.Button upAttackButton;
        private System.Windows.Forms.Button downAttackButton;
        private System.Windows.Forms.Button rightAttackButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label ghoulHitPoints;
    }
}


namespace CKarnasProgram13
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
            this.cboxTeams = new System.Windows.Forms.ComboBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblSuperbowl = new System.Windows.Forms.Label();
            this.cboxChamps = new System.Windows.Forms.ComboBox();
            this.btnWins = new System.Windows.Forms.Button();
            this.btnBack2Back = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxTeams
            // 
            this.cboxTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTeams.FormattingEnabled = true;
            this.cboxTeams.IntegralHeight = false;
            this.cboxTeams.Items.AddRange(new object[] {
            "Cardinals",
            "Falcons",
            "Ravens",
            "Bills",
            "Panthers",
            "Bears",
            "Bengals",
            "Browns",
            "Cowboys",
            "Broncos",
            "Lions",
            "Packers",
            "Texans",
            "Colts",
            "Jaguars",
            "Chiefs",
            "Dolphins",
            "Vikings",
            "Patriots",
            "Saints",
            "Giants",
            "Jets",
            "Raiders",
            "Eagles",
            "Steelers",
            "Chargers",
            "49ers",
            "Seahawks",
            "Rams",
            "Buccaneers",
            "Titans",
            "Washington"});
            this.cboxTeams.Location = new System.Drawing.Point(12, 134);
            this.cboxTeams.MaxDropDownItems = 10;
            this.cboxTeams.Name = "cboxTeams";
            this.cboxTeams.Size = new System.Drawing.Size(246, 32);
            this.cboxTeams.TabIndex = 1;
            // 
            // lblTeams
            // 
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(54, 65);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(156, 52);
            this.lblTeams.TabIndex = 2;
            this.lblTeams.Text = "NFL Teams (Select One)";
            this.lblTeams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuperbowl
            // 
            this.lblSuperbowl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperbowl.Location = new System.Drawing.Point(302, 65);
            this.lblSuperbowl.Name = "lblSuperbowl";
            this.lblSuperbowl.Size = new System.Drawing.Size(204, 52);
            this.lblSuperbowl.TabIndex = 3;
            this.lblSuperbowl.Text = "Super Bowl Champions Display List";
            this.lblSuperbowl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxChamps
            // 
            this.cboxChamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxChamps.FormattingEnabled = true;
            this.cboxChamps.IntegralHeight = false;
            this.cboxChamps.Items.AddRange(new object[] {
            "Packers",
            "Packers",
            "Jets",
            "Chiefs",
            "Colts",
            "Cowboys",
            "Dolphins",
            "Dolphins",
            "Steelers",
            "Steelers",
            "Raiders",
            "Cowboys",
            "Steelers",
            "Steelers",
            "Raiders",
            "49ers",
            "Washington",
            "Raiders",
            "49ers",
            "Bears",
            "Giants",
            "Washington",
            "49ers",
            "49ers",
            "Giants",
            "Washington",
            "Cowboys",
            "Cowboys",
            "49ers",
            "Cowboys",
            "Packers",
            "Broncos",
            "Broncos",
            "Rams",
            "Ravens",
            "Patriots",
            "Buccaneers",
            "Patriots",
            "Patriots",
            "Steelers",
            "Colts",
            "Giants",
            "Steelers",
            "Saints",
            "Packers",
            "Giants",
            "Ravens",
            "Seahawks",
            "Patriots",
            "Broncos",
            "Patriots",
            "Eagles",
            "Patriots",
            "Chiefs"});
            this.cboxChamps.Location = new System.Drawing.Point(279, 134);
            this.cboxChamps.MaxDropDownItems = 10;
            this.cboxChamps.Name = "cboxChamps";
            this.cboxChamps.Size = new System.Drawing.Size(246, 32);
            this.cboxChamps.TabIndex = 4;
            // 
            // btnWins
            // 
            this.btnWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWins.Location = new System.Drawing.Point(541, 44);
            this.btnWins.Name = "btnWins";
            this.btnWins.Size = new System.Drawing.Size(225, 59);
            this.btnWins.TabIndex = 5;
            this.btnWins.Text = "Team Super Bowl Wins?";
            this.btnWins.UseVisualStyleBackColor = true;
            this.btnWins.Click += new System.EventHandler(this.btnWins_Click);
            // 
            // btnBack2Back
            // 
            this.btnBack2Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2Back.Location = new System.Drawing.Point(772, 44);
            this.btnBack2Back.Name = "btnBack2Back";
            this.btnBack2Back.Size = new System.Drawing.Size(225, 59);
            this.btnBack2Back.TabIndex = 6;
            this.btnBack2Back.Text = "Number of Back-to-Back Championships?";
            this.btnBack2Back.UseVisualStyleBackColor = true;
            this.btnBack2Back.Click += new System.EventHandler(this.btnBack2Back_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(803, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(541, 124);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(456, 62);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(9, 242);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloper.TabIndex = 9;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 264);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack2Back);
            this.Controls.Add(this.btnWins);
            this.Controls.Add(this.cboxChamps);
            this.Controls.Add(this.lblSuperbowl);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.cboxTeams);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 13 - Winning NFL Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblSuperbowl;
        private System.Windows.Forms.ComboBox cboxChamps;
        private System.Windows.Forms.Button btnWins;
        private System.Windows.Forms.Button btnBack2Back;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDeveloper;
    }
}


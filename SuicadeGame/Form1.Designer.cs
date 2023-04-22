namespace SuicadeGame
{
    partial class Wisielec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string password;
        private int IndexBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wisielec));
            this.SuicadeBox = new System.Windows.Forms.PictureBox();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.I = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuicadeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SuicadeBox
            // 
            this.SuicadeBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("SuicadeBox.InitialImage")));
            this.SuicadeBox.Location = new System.Drawing.Point(75, 20);
            this.SuicadeBox.Name = "SuicadeBox";
            this.SuicadeBox.Size = new System.Drawing.Size(450, 280);
            this.SuicadeBox.TabIndex = 0;
            this.SuicadeBox.TabStop = false;
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(25, 325);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(60, 60);
            this.A.TabIndex = 1;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.Clicked);
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(95, 325);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(60, 60);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.Clicked);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(165, 325);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(60, 60);
            this.C.TabIndex = 3;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Clicked);
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(235, 325);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(60, 60);
            this.D.TabIndex = 4;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.Clicked);
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(305, 325);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(60, 60);
            this.E.TabIndex = 5;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.Clicked);
            // 
            // F
            // 
            this.F.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(375, 325);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(60, 60);
            this.F.TabIndex = 6;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.Clicked);
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(445, 325);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(60, 60);
            this.G.TabIndex = 7;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.Clicked);
            // 
            // H
            // 
            this.H.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(515, 325);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(60, 60);
            this.H.TabIndex = 8;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.Clicked);
            // 
            // I
            // 
            this.I.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(55, 395);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(60, 60);
            this.I.TabIndex = 9;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.Clicked);
            // 
            // J
            // 
            this.J.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J.Location = new System.Drawing.Point(125, 395);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(60, 60);
            this.J.TabIndex = 10;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            this.J.Click += new System.EventHandler(this.Clicked);
            // 
            // K
            // 
            this.K.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K.Location = new System.Drawing.Point(195, 395);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(60, 60);
            this.K.TabIndex = 11;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.Clicked);
            // 
            // L
            // 
            this.L.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L.Location = new System.Drawing.Point(265, 395);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(60, 60);
            this.L.TabIndex = 12;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.Clicked);
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(335, 395);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(60, 60);
            this.M.TabIndex = 13;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.Clicked);
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(405, 395);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(60, 60);
            this.N.TabIndex = 14;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.Clicked);
            // 
            // O
            // 
            this.O.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O.Location = new System.Drawing.Point(475, 395);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(60, 60);
            this.O.TabIndex = 15;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.Clicked);
            // 
            // W
            // 
            this.W.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W.Location = new System.Drawing.Point(515, 465);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(60, 60);
            this.W.TabIndex = 23;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.Clicked);
            // 
            // V
            // 
            this.V.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(445, 465);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(60, 60);
            this.V.TabIndex = 22;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.Clicked);
            // 
            // U
            // 
            this.U.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U.Location = new System.Drawing.Point(375, 465);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(60, 60);
            this.U.TabIndex = 21;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.Clicked);
            // 
            // T
            // 
            this.T.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(305, 465);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(60, 60);
            this.T.TabIndex = 20;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.Clicked);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(235, 465);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(60, 60);
            this.S.TabIndex = 19;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.Clicked);
            // 
            // R
            // 
            this.R.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(165, 465);
            this.R.Name = "R";
            this.R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.R.Size = new System.Drawing.Size(60, 60);
            this.R.TabIndex = 18;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.Clicked);
            // 
            // Q
            // 
            this.Q.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(95, 465);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(60, 60);
            this.Q.TabIndex = 17;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.Click += new System.EventHandler(this.Clicked);
            // 
            // P
            // 
            this.P.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(25, 465);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(60, 60);
            this.P.TabIndex = 16;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.Clicked);
            // 
            // Z
            // 
            this.Z.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z.Location = new System.Drawing.Point(265, 535);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(60, 60);
            this.Z.TabIndex = 26;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.Clicked);
            // 
            // Y
            // 
            this.Y.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.Location = new System.Drawing.Point(195, 535);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(60, 60);
            this.Y.TabIndex = 25;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Clicked);
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(125, 535);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(60, 60);
            this.X.TabIndex = 24;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.Clicked);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(25, 621);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(422, 54);
            this.Password.TabIndex = 27;
            this.Password.Text = "==OG==WA=0=E";
            // 
            // Wisielec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.W);
            this.Controls.Add(this.V);
            this.Controls.Add(this.U);
            this.Controls.Add(this.T);
            this.Controls.Add(this.S);
            this.Controls.Add(this.R);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.N);
            this.Controls.Add(this.M);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.I);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.SuicadeBox);
            this.Name = "Wisielec";
            this.Text = "Wisielec";
            this.Load += new System.EventHandler(this.Wisielec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuicadeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SuicadeBox;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button H;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label Password;
    }
}


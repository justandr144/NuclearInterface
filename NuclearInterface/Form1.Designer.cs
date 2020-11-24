namespace NuclearInterface
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorLabel1 = new System.Windows.Forms.Label();
            this.reactorLabel2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Bisque;
            this.titleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(161, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(450, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Controls";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.titleLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // reactorLabel1
            // 
            this.reactorLabel1.AutoSize = true;
            this.reactorLabel1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel1.Location = new System.Drawing.Point(164, 113);
            this.reactorLabel1.Name = "reactorLabel1";
            this.reactorLabel1.Size = new System.Drawing.Size(100, 23);
            this.reactorLabel1.TabIndex = 1;
            this.reactorLabel1.Text = "Reactor 1";
            // 
            // reactorLabel2
            // 
            this.reactorLabel2.AutoSize = true;
            this.reactorLabel2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel2.Location = new System.Drawing.Point(505, 113);
            this.reactorLabel2.Name = "reactorLabel2";
            this.reactorLabel2.Size = new System.Drawing.Size(100, 23);
            this.reactorLabel2.TabIndex = 2;
            this.reactorLabel2.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(121, 149);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(189, 134);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(459, 149);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(189, 134);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Coral;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(224, 328);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(322, 39);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.Color.White;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(205, 397);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(359, 90);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "Reactor Stable";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.stateLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(779, 510);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactorLabel2);
            this.Controls.Add(this.reactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Nuclear Power Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorLabel1;
        private System.Windows.Forms.Label reactorLabel2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label stateLabel;
    }
}


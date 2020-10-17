namespace PathFinder
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassageRadioButton = new System.Windows.Forms.RadioButton();
            this.ObstacleRadioButton = new System.Windows.Forms.RadioButton();
            this.DestinationRadioButton = new System.Windows.Forms.RadioButton();
            this.StartPointRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PassageRadioButton);
            this.panel1.Controls.Add(this.ObstacleRadioButton);
            this.panel1.Controls.Add(this.DestinationRadioButton);
            this.panel1.Controls.Add(this.StartPointRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 73);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Run IDFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassageRadioButton
            // 
            this.PassageRadioButton.AutoSize = true;
            this.PassageRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PassageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassageRadioButton.Location = new System.Drawing.Point(291, 0);
            this.PassageRadioButton.Name = "PassageRadioButton";
            this.PassageRadioButton.Size = new System.Drawing.Size(92, 73);
            this.PassageRadioButton.TabIndex = 3;
            this.PassageRadioButton.Text = "passway";
            this.PassageRadioButton.UseVisualStyleBackColor = true;
            this.PassageRadioButton.CheckedChanged += new System.EventHandler(this.PassageRadioButton_CheckedChanged);
            // 
            // ObstacleRadioButton
            // 
            this.ObstacleRadioButton.AutoSize = true;
            this.ObstacleRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ObstacleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObstacleRadioButton.Location = new System.Drawing.Point(201, 0);
            this.ObstacleRadioButton.Name = "ObstacleRadioButton";
            this.ObstacleRadioButton.Size = new System.Drawing.Size(90, 73);
            this.ObstacleRadioButton.TabIndex = 2;
            this.ObstacleRadioButton.Text = "obstacle";
            this.ObstacleRadioButton.UseVisualStyleBackColor = true;
            this.ObstacleRadioButton.CheckedChanged += new System.EventHandler(this.ObstacleRadioButton_CheckedChanged);
            // 
            // DestinationRadioButton
            // 
            this.DestinationRadioButton.AutoSize = true;
            this.DestinationRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DestinationRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationRadioButton.Location = new System.Drawing.Point(104, 0);
            this.DestinationRadioButton.Name = "DestinationRadioButton";
            this.DestinationRadioButton.Size = new System.Drawing.Size(97, 73);
            this.DestinationRadioButton.TabIndex = 1;
            this.DestinationRadioButton.Text = "End point";
            this.DestinationRadioButton.UseVisualStyleBackColor = true;
            this.DestinationRadioButton.CheckedChanged += new System.EventHandler(this.DestinationRadioButton_CheckedChanged);
            // 
            // StartPointRadioButton
            // 
            this.StartPointRadioButton.AutoSize = true;
            this.StartPointRadioButton.Checked = true;
            this.StartPointRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartPointRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPointRadioButton.Location = new System.Drawing.Point(0, 0);
            this.StartPointRadioButton.Name = "StartPointRadioButton";
            this.StartPointRadioButton.Size = new System.Drawing.Size(104, 73);
            this.StartPointRadioButton.TabIndex = 0;
            this.StartPointRadioButton.TabStop = true;
            this.StartPointRadioButton.Text = "Start point";
            this.StartPointRadioButton.UseVisualStyleBackColor = true;
            this.StartPointRadioButton.CheckedChanged += new System.EventHandler(this.StartPointRadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 363);
            this.panel2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton StartPointRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton PassageRadioButton;
        private System.Windows.Forms.RadioButton ObstacleRadioButton;
        private System.Windows.Forms.RadioButton DestinationRadioButton;
        private System.Windows.Forms.Panel panel2;

    }
}
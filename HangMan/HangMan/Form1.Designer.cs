namespace HangMan
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
            this.components = new System.ComponentModel.Container();
            this.unnsTries = new System.Windows.Forms.ProgressBar();
            this.timeLeft = new System.Windows.Forms.ProgressBar();
            this.letterToSubmit = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.allLetters = new System.Windows.Forms.Label();
            this.MaskedWord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unnsTries
            // 
            this.unnsTries.Location = new System.Drawing.Point(50, 360);
            this.unnsTries.Name = "unnsTries";
            this.unnsTries.Size = new System.Drawing.Size(547, 23);
            this.unnsTries.TabIndex = 0;
            // 
            // timeLeft
            // 
            this.timeLeft.Location = new System.Drawing.Point(50, 410);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(547, 23);
            this.timeLeft.TabIndex = 1;
            // 
            // letterToSubmit
            // 
            this.letterToSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterToSubmit.Location = new System.Drawing.Point(50, 162);
            this.letterToSubmit.Name = "letterToSubmit";
            this.letterToSubmit.Size = new System.Drawing.Size(98, 83);
            this.letterToSubmit.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(172, 162);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 83);
            this.submit.TabIndex = 4;
            this.submit.Text = "Try";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // allLetters
            // 
            this.allLetters.AutoSize = true;
            this.allLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allLetters.Location = new System.Drawing.Point(52, 299);
            this.allLetters.Name = "allLetters";
            this.allLetters.Size = new System.Drawing.Size(0, 39);
            this.allLetters.TabIndex = 5;
            // 
            // MaskedWord
            // 
            this.MaskedWord.AutoSize = true;
            this.MaskedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedWord.Location = new System.Drawing.Point(56, 68);
            this.MaskedWord.Name = "MaskedWord";
            this.MaskedWord.Size = new System.Drawing.Size(0, 39);
            this.MaskedWord.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(541, 21);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(86, 31);
            this.time.TabIndex = 7;
            this.time.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 463);
            this.Controls.Add(this.time);
            this.Controls.Add(this.MaskedWord);
            this.Controls.Add(this.allLetters);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.letterToSubmit);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.unnsTries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar unnsTries;
        private System.Windows.Forms.ProgressBar timeLeft;
        private System.Windows.Forms.TextBox letterToSubmit;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label allLetters;
        private System.Windows.Forms.Label MaskedWord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
    }
}


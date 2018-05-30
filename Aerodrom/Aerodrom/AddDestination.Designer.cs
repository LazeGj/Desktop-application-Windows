namespace Aerodrom
{
    partial class AddDestination
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameOfDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveDest = new System.Windows.Forms.Button();
            this.cancelAddingDest = new System.Windows.Forms.Button();
            this.distanceDest = new System.Windows.Forms.NumericUpDown();
            this.priceDest = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.distanceDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // nameOfDest
            // 
            this.nameOfDest.Location = new System.Drawing.Point(38, 61);
            this.nameOfDest.Name = "nameOfDest";
            this.nameOfDest.Size = new System.Drawing.Size(100, 20);
            this.nameOfDest.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оддалеченост";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Додади дестинација";
            // 
            // saveDest
            // 
            this.saveDest.Location = new System.Drawing.Point(47, 213);
            this.saveDest.Name = "saveDest";
            this.saveDest.Size = new System.Drawing.Size(75, 23);
            this.saveDest.TabIndex = 7;
            this.saveDest.Text = "Зачувај";
            this.saveDest.UseVisualStyleBackColor = true;
            this.saveDest.Click += new System.EventHandler(this.saveDest_Click);
            // 
            // cancelAddingDest
            // 
            this.cancelAddingDest.Location = new System.Drawing.Point(210, 213);
            this.cancelAddingDest.Name = "cancelAddingDest";
            this.cancelAddingDest.Size = new System.Drawing.Size(75, 23);
            this.cancelAddingDest.TabIndex = 8;
            this.cancelAddingDest.Text = "Откажи";
            this.cancelAddingDest.UseVisualStyleBackColor = true;
            this.cancelAddingDest.Click += new System.EventHandler(this.cancelAddingDest_Click);
            // 
            // distanceDest
            // 
            this.distanceDest.Location = new System.Drawing.Point(38, 112);
            this.distanceDest.Name = "distanceDest";
            this.distanceDest.Size = new System.Drawing.Size(120, 20);
            this.distanceDest.TabIndex = 9;
            // 
            // priceDest
            // 
            this.priceDest.Location = new System.Drawing.Point(43, 167);
            this.priceDest.Name = "priceDest";
            this.priceDest.Size = new System.Drawing.Size(120, 20);
            this.priceDest.TabIndex = 10;
            // 
            // AddDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.priceDest);
            this.Controls.Add(this.distanceDest);
            this.Controls.Add(this.cancelAddingDest);
            this.Controls.Add(this.saveDest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameOfDest);
            this.Controls.Add(this.label1);
            this.Name = "AddDestination";
            this.Text = "AddDestination";
            ((System.ComponentModel.ISupportInitialize)(this.distanceDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameOfDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveDest;
        private System.Windows.Forms.Button cancelAddingDest;
        private System.Windows.Forms.NumericUpDown distanceDest;
        private System.Windows.Forms.NumericUpDown priceDest;
    }
}
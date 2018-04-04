namespace Aerodrom
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
            this.listAirports = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAirport = new System.Windows.Forms.Button();
            this.listDest = new System.Windows.Forms.ListBox();
            this.addDestination = new System.Windows.Forms.Button();
            this.deleteAirport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.longestDest = new System.Windows.Forms.TextBox();
            this.averageDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listAirports
            // 
            this.listAirports.FormattingEnabled = true;
            this.listAirports.Location = new System.Drawing.Point(32, 60);
            this.listAirports.Name = "listAirports";
            this.listAirports.Size = new System.Drawing.Size(212, 290);
            this.listAirports.TabIndex = 0;
            this.listAirports.SelectedIndexChanged += new System.EventHandler(this.listAirports_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аеродроми";
            // 
            // addAirport
            // 
            this.addAirport.Location = new System.Drawing.Point(32, 373);
            this.addAirport.Name = "addAirport";
            this.addAirport.Size = new System.Drawing.Size(166, 23);
            this.addAirport.TabIndex = 2;
            this.addAirport.Text = "Додади аеродром";
            this.addAirport.UseVisualStyleBackColor = true;
            this.addAirport.Click += new System.EventHandler(this.addAirport_Click);
            // 
            // listDest
            // 
            this.listDest.FormattingEnabled = true;
            this.listDest.Location = new System.Drawing.Point(355, 60);
            this.listDest.Name = "listDest";
            this.listDest.Size = new System.Drawing.Size(193, 290);
            this.listDest.TabIndex = 3;
            // 
            // addDestination
            // 
            this.addDestination.Location = new System.Drawing.Point(35, 429);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(166, 23);
            this.addDestination.TabIndex = 4;
            this.addDestination.Text = "Додади дестинација";
            this.addDestination.UseVisualStyleBackColor = true;
            this.addDestination.Click += new System.EventHandler(this.addDestination_Click);
            // 
            // deleteAirport
            // 
            this.deleteAirport.Location = new System.Drawing.Point(35, 402);
            this.deleteAirport.Name = "deleteAirport";
            this.deleteAirport.Size = new System.Drawing.Size(166, 23);
            this.deleteAirport.TabIndex = 5;
            this.deleteAirport.Text = "Избриши аеродром";
            this.deleteAirport.UseVisualStyleBackColor = true;
            this.deleteAirport.Click += new System.EventHandler(this.deleteAirport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дестинации";
            // 
            // longestDest
            // 
            this.longestDest.Location = new System.Drawing.Point(355, 389);
            this.longestDest.Name = "longestDest";
            this.longestDest.ReadOnly = true;
            this.longestDest.Size = new System.Drawing.Size(193, 20);
            this.longestDest.TabIndex = 7;
            // 
            // averageDest
            // 
            this.averageDest.Location = new System.Drawing.Point(355, 429);
            this.averageDest.Name = "averageDest";
            this.averageDest.ReadOnly = true;
            this.averageDest.Size = new System.Drawing.Size(193, 20);
            this.averageDest.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна должина на дестинаиите";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageDest);
            this.Controls.Add(this.longestDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteAirport);
            this.Controls.Add(this.addDestination);
            this.Controls.Add(this.listDest);
            this.Controls.Add(this.addAirport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAirports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAirports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAirport;
        private System.Windows.Forms.ListBox listDest;
        private System.Windows.Forms.Button addDestination;
        private System.Windows.Forms.Button deleteAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox longestDest;
        private System.Windows.Forms.TextBox averageDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


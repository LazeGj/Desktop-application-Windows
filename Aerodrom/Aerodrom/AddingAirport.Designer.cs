namespace Aerodrom
{
    partial class AddingAirport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cityOfAirport = new System.Windows.Forms.TextBox();
            this.nameOfAirport = new System.Windows.Forms.TextBox();
            this.shortNameOfAirport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveAirport = new System.Windows.Forms.Button();
            this.cancelAddinAirport = new System.Windows.Forms.Button();
            this.nameOfAirportErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameOfAirportErrorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додади Аеродром";
            // 
            // cityOfAirport
            // 
            this.cityOfAirport.Location = new System.Drawing.Point(41, 95);
            this.cityOfAirport.Name = "cityOfAirport";
            this.cityOfAirport.Size = new System.Drawing.Size(100, 20);
            this.cityOfAirport.TabIndex = 1;
            this.cityOfAirport.Validating += new System.ComponentModel.CancelEventHandler(this.cityOfAirport_Validating);
            // 
            // nameOfAirport
            // 
            this.nameOfAirport.Location = new System.Drawing.Point(38, 147);
            this.nameOfAirport.Name = "nameOfAirport";
            this.nameOfAirport.Size = new System.Drawing.Size(100, 20);
            this.nameOfAirport.TabIndex = 2;
            this.nameOfAirport.Validating += new System.ComponentModel.CancelEventHandler(this.nameOfAirport_Validating);
            // 
            // shortNameOfAirport
            // 
            this.shortNameOfAirport.Location = new System.Drawing.Point(38, 217);
            this.shortNameOfAirport.Name = "shortNameOfAirport";
            this.shortNameOfAirport.Size = new System.Drawing.Size(100, 20);
            this.shortNameOfAirport.TabIndex = 3;
            this.shortNameOfAirport.Validating += new System.ComponentModel.CancelEventHandler(this.shortNameOfAirport_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Град";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кратенка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Име";
            // 
            // saveAirport
            // 
            this.saveAirport.Location = new System.Drawing.Point(38, 276);
            this.saveAirport.Name = "saveAirport";
            this.saveAirport.Size = new System.Drawing.Size(75, 23);
            this.saveAirport.TabIndex = 7;
            this.saveAirport.Text = "Зачувај";
            this.saveAirport.UseVisualStyleBackColor = true;
            this.saveAirport.Click += new System.EventHandler(this.saveAirport_Click);
            // 
            // cancelAddinAirport
            // 
            this.cancelAddinAirport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelAddinAirport.Location = new System.Drawing.Point(155, 276);
            this.cancelAddinAirport.Name = "cancelAddinAirport";
            this.cancelAddinAirport.Size = new System.Drawing.Size(75, 23);
            this.cancelAddinAirport.TabIndex = 8;
            this.cancelAddinAirport.Text = "Откажи";
            this.cancelAddinAirport.UseVisualStyleBackColor = true;
            this.cancelAddinAirport.Click += new System.EventHandler(this.cancelAddinAirport_Click);
            // 
            // nameOfAirportErrorP
            // 
            this.nameOfAirportErrorP.ContainerControl = this;
            // 
            // AddingAirport
            // 
            this.AcceptButton = this.saveAirport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelAddinAirport;
            this.ClientSize = new System.Drawing.Size(258, 359);
            this.Controls.Add(this.cancelAddinAirport);
            this.Controls.Add(this.saveAirport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shortNameOfAirport);
            this.Controls.Add(this.nameOfAirport);
            this.Controls.Add(this.cityOfAirport);
            this.Controls.Add(this.label1);
            this.Name = "AddingAirport";
            this.Text = "AddingAirport";
            ((System.ComponentModel.ISupportInitialize)(this.nameOfAirportErrorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityOfAirport;
        private System.Windows.Forms.TextBox nameOfAirport;
        private System.Windows.Forms.TextBox shortNameOfAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveAirport;
        private System.Windows.Forms.Button cancelAddinAirport;
        private System.Windows.Forms.ErrorProvider nameOfAirportErrorP;
    }
}
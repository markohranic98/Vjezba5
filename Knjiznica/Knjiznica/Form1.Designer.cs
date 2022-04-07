namespace Knjiznica
{
    partial class KnjiznicaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unesiKnjiguBtn = new System.Windows.Forms.Button();
            this.knjigaNazivTextBox = new System.Windows.Forms.TextBox();
            this.ispisTextBox = new System.Windows.Forms.TextBox();
            this.pretraziButton = new System.Windows.Forms.Button();
            this.pretraziTextBox = new System.Windows.Forms.TextBox();
            this.dodajAutoraButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(190, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(224, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 397);
            this.dataGridView2.TabIndex = 1;
            // 
            // unesiKnjiguBtn
            // 
            this.unesiKnjiguBtn.Location = new System.Drawing.Point(337, 515);
            this.unesiKnjiguBtn.Name = "unesiKnjiguBtn";
            this.unesiKnjiguBtn.Size = new System.Drawing.Size(75, 23);
            this.unesiKnjiguBtn.TabIndex = 2;
            this.unesiKnjiguBtn.Text = "Unesi knjigu";
            this.unesiKnjiguBtn.UseVisualStyleBackColor = true;
            this.unesiKnjiguBtn.Click += new System.EventHandler(this.unesiKnjiguBtn_Click);
            // 
            // knjigaNazivTextBox
            // 
            this.knjigaNazivTextBox.Location = new System.Drawing.Point(322, 489);
            this.knjigaNazivTextBox.Name = "knjigaNazivTextBox";
            this.knjigaNazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.knjigaNazivTextBox.TabIndex = 3;
            // 
            // ispisTextBox
            // 
            this.ispisTextBox.Location = new System.Drawing.Point(722, 49);
            this.ispisTextBox.Multiline = true;
            this.ispisTextBox.Name = "ispisTextBox";
            this.ispisTextBox.Size = new System.Drawing.Size(199, 243);
            this.ispisTextBox.TabIndex = 4;
            // 
            // pretraziButton
            // 
            this.pretraziButton.Location = new System.Drawing.Point(785, 350);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(75, 23);
            this.pretraziButton.TabIndex = 5;
            this.pretraziButton.Text = "Pretrazi";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // pretraziTextBox
            // 
            this.pretraziTextBox.Location = new System.Drawing.Point(772, 324);
            this.pretraziTextBox.Name = "pretraziTextBox";
            this.pretraziTextBox.Size = new System.Drawing.Size(100, 20);
            this.pretraziTextBox.TabIndex = 6;
            // 
            // dodajAutoraButton
            // 
            this.dodajAutoraButton.Location = new System.Drawing.Point(542, 168);
            this.dodajAutoraButton.Name = "dodajAutoraButton";
            this.dodajAutoraButton.Size = new System.Drawing.Size(75, 23);
            this.dodajAutoraButton.TabIndex = 7;
            this.dodajAutoraButton.Text = "DodajAutora";
            this.dodajAutoraButton.UseVisualStyleBackColor = true;
            this.dodajAutoraButton.Click += new System.EventHandler(this.dodajAutoraButton_Click);
            // 
            // KnjiznicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 575);
            this.Controls.Add(this.dodajAutoraButton);
            this.Controls.Add(this.pretraziTextBox);
            this.Controls.Add(this.pretraziButton);
            this.Controls.Add(this.ispisTextBox);
            this.Controls.Add(this.knjigaNazivTextBox);
            this.Controls.Add(this.unesiKnjiguBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KnjiznicaForm";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.KnjiznicaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button unesiKnjiguBtn;
        private System.Windows.Forms.TextBox knjigaNazivTextBox;
        private System.Windows.Forms.TextBox ispisTextBox;
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.TextBox pretraziTextBox;
        private System.Windows.Forms.Button dodajAutoraButton;
    }
}


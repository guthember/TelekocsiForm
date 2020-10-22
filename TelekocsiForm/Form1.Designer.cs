namespace TelekocsiForm
{
  partial class frmFo
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
      this.btnBeolvasas = new System.Windows.Forms.Button();
      this.lbKimenet = new System.Windows.Forms.ListBox();
      this.btnSecond = new System.Windows.Forms.Button();
      this.btnThird = new System.Windows.Forms.Button();
      this.btnFourth = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnBeolvasas
      // 
      this.btnBeolvasas.Location = new System.Drawing.Point(12, 12);
      this.btnBeolvasas.Name = "btnBeolvasas";
      this.btnBeolvasas.Size = new System.Drawing.Size(116, 29);
      this.btnBeolvasas.TabIndex = 0;
      this.btnBeolvasas.Text = "Beolvasás";
      this.btnBeolvasas.UseVisualStyleBackColor = true;
      this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
      // 
      // lbKimenet
      // 
      this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lbKimenet.FormattingEnabled = true;
      this.lbKimenet.ItemHeight = 16;
      this.lbKimenet.Location = new System.Drawing.Point(143, 12);
      this.lbKimenet.Name = "lbKimenet";
      this.lbKimenet.Size = new System.Drawing.Size(429, 276);
      this.lbKimenet.TabIndex = 1;
      // 
      // btnSecond
      // 
      this.btnSecond.Enabled = false;
      this.btnSecond.Location = new System.Drawing.Point(12, 47);
      this.btnSecond.Name = "btnSecond";
      this.btnSecond.Size = new System.Drawing.Size(116, 30);
      this.btnSecond.TabIndex = 2;
      this.btnSecond.Text = "2. Feladat";
      this.btnSecond.UseVisualStyleBackColor = true;
      this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
      // 
      // btnThird
      // 
      this.btnThird.Enabled = false;
      this.btnThird.Location = new System.Drawing.Point(12, 83);
      this.btnThird.Name = "btnThird";
      this.btnThird.Size = new System.Drawing.Size(116, 32);
      this.btnThird.TabIndex = 3;
      this.btnThird.Text = "3. Feladat";
      this.btnThird.UseVisualStyleBackColor = true;
      this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
      // 
      // btnFourth
      // 
      this.btnFourth.Enabled = false;
      this.btnFourth.Location = new System.Drawing.Point(12, 121);
      this.btnFourth.Name = "btnFourth";
      this.btnFourth.Size = new System.Drawing.Size(116, 32);
      this.btnFourth.TabIndex = 4;
      this.btnFourth.Text = "4. Feladat";
      this.btnFourth.UseVisualStyleBackColor = true;
      this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
      // 
      // frmFo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 361);
      this.Controls.Add(this.btnFourth);
      this.Controls.Add(this.btnThird);
      this.Controls.Add(this.btnSecond);
      this.Controls.Add(this.lbKimenet);
      this.Controls.Add(this.btnBeolvasas);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "frmFo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Telekocsi";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnBeolvasas;
    private System.Windows.Forms.ListBox lbKimenet;
    private System.Windows.Forms.Button btnSecond;
    private System.Windows.Forms.Button btnThird;
    private System.Windows.Forms.Button btnFourth;
  }
}


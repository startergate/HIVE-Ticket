namespace HIVE_Ticket
{
  partial class Login
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
      System.ComponentModel.ComponentResourceManager resources =
        new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(242, 134);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(324, 188);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // textBox1
      // 
      this.textBox1.AccessibleDescription = "ID Input Space";
      this.textBox1.AccessibleName = "ID Input Space";
      this.textBox1.Location = new System.Drawing.Point(297, 358);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(186, 23);
      this.textBox1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AccessibleDescription = "Enter ID";
      this.label1.AccessibleName = "ID Input Label";
      this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(242, 358);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 22);
      this.label1.TabIndex = 2;
      this.label1.Text = "ID";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 8F);
      this.button1.Location = new System.Drawing.Point(489, 358);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(76, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "입력";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor =
        System.Drawing.Color.FromArgb(((int) (((byte) (61)))), ((int) (((byte) (65)))), ((int) (((byte) (77)))));
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.pictureBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Login";
      this.Text = "HIVE TICKET MANAGEMENT";
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
  }
}
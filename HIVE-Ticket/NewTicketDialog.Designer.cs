using System.ComponentModel;

namespace HIVE_Ticket
{
  partial class NewTicketDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(5, 6);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(444, 249);
      this.dataGridView1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(464, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "영화 ID";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(464, 74);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(55, 23);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(464, 121);
      this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(139, 23);
      this.textBox2.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(464, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 18);
      this.label2.TabIndex = 3;
      this.label2.Text = "영화 시간";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(464, 209);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(139, 46);
      this.button1.TabIndex = 5;
      this.button1.Text = "완료";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(464, 31);
      this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(55, 23);
      this.textBox3.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(464, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "영화 ID";
      // 
      // NewTicketDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 261);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "NewTicketDialog";
      this.Text = "NewTicketDialog";
      this.Load += new System.EventHandler(this.NewTicketDialog_Load);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
  }
}
using System.ComponentModel;

namespace HIVE_Ticket
{
  partial class Tickets
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
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.customer_name = new System.Windows.Forms.TextBox();
      this.movie_name = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.movie_time = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(6, 8);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(589, 545);
      this.dataGridView1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(609, 405);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(179, 46);
      this.button1.TabIndex = 1;
      this.button1.Text = "검색";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(605, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "고객 이름";
      // 
      // customer_name
      // 
      this.customer_name.Location = new System.Drawing.Point(609, 28);
      this.customer_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.customer_name.Name = "customer_name";
      this.customer_name.Size = new System.Drawing.Size(179, 23);
      this.customer_name.TabIndex = 3;
      // 
      // movie_name
      // 
      this.movie_name.Location = new System.Drawing.Point(609, 81);
      this.movie_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.movie_name.Name = "movie_name";
      this.movie_name.Size = new System.Drawing.Size(179, 23);
      this.movie_name.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(605, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 18);
      this.label2.TabIndex = 4;
      this.label2.Text = "영화 이름";
      // 
      // movie_time
      // 
      this.movie_time.Location = new System.Drawing.Point(609, 134);
      this.movie_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.movie_time.Name = "movie_time";
      this.movie_time.Size = new System.Drawing.Size(179, 23);
      this.movie_time.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(605, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 18);
      this.label3.TabIndex = 6;
      this.label3.Text = "영화 시간";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(609, 505);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(179, 46);
      this.button2.TabIndex = 8;
      this.button2.Text = "예매";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(720, 365);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(68, 35);
      this.button3.TabIndex = 9;
      this.button3.Text = "추가 동작";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(646, 365);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(68, 35);
      this.button4.TabIndex = 10;
      this.button4.Text = "삭제";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(609, 455);
      this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(179, 46);
      this.button5.TabIndex = 11;
      this.button5.Text = "수정";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // Tickets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.movie_time);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.movie_name);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.customer_name);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Tickets";
      this.Text = "Tickets";
      this.Load += new System.EventHandler(this.Tickets_Load);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox movie_time;
    private System.Windows.Forms.TextBox customer_name;
    private System.Windows.Forms.TextBox movie_name;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
  }
}
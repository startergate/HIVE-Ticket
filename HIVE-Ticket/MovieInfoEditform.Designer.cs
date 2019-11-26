using System.ComponentModel;

namespace HIVE_Ticket
{
  partial class MovieInfoEditform
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.textBoxMovieDesc = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonSearch1 = new System.Windows.Forms.Button();
      this.buttonInsert1 = new System.Windows.Forms.Button();
      this.buttonEdit1 = new System.Windows.Forms.Button();
      this.buttonDelete1 = new System.Windows.Forms.Button();
      this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.buttonSearch2 = new System.Windows.Forms.Button();
      this.buttonInsert = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.dataGridViewDist = new System.Windows.Forms.DataGridView();
      this.textBoxMovieDirector = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxMovieActor = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMovie)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewDist)).BeginInit();
      this.SuspendLayout();
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(11, 10);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(778, 548);
      this.tabControl1.TabIndex = 0;
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.textBoxMovieActor);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.textBoxMovieDirector);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.textBoxMovieDesc);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.textBoxMovieTitle);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.buttonSearch1);
      this.tabPage1.Controls.Add(this.buttonInsert1);
      this.tabPage1.Controls.Add(this.buttonEdit1);
      this.tabPage1.Controls.Add(this.buttonDelete1);
      this.tabPage1.Controls.Add(this.dataGridViewMovie);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Size = new System.Drawing.Size(770, 520);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "영화";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.textBoxMovieDesc.Location = new System.Drawing.Point(631, 81);
      this.textBoxMovieDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieDesc.Name = "textBoxMovieDesc";
      this.textBoxMovieDesc.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieDesc.TabIndex = 9;
      this.label2.Location = new System.Drawing.Point(632, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 19);
      this.label2.TabIndex = 8;
      this.label2.Text = "영화 설명";
      this.textBoxMovieTitle.Location = new System.Drawing.Point(631, 31);
      this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieTitle.Name = "textBoxMovieTitle";
      this.textBoxMovieTitle.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieTitle.TabIndex = 7;
      this.label1.Location = new System.Drawing.Point(632, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 19);
      this.label1.TabIndex = 6;
      this.label1.Text = "영화 제목";
      this.buttonSearch1.Location = new System.Drawing.Point(630, 360);
      this.buttonSearch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonSearch1.Name = "buttonSearch1";
      this.buttonSearch1.Size = new System.Drawing.Size(134, 32);
      this.buttonSearch1.TabIndex = 5;
      this.buttonSearch1.Text = "검색";
      this.buttonSearch1.UseVisualStyleBackColor = true;
      this.buttonInsert1.Location = new System.Drawing.Point(630, 399);
      this.buttonInsert1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonInsert1.Name = "buttonInsert1";
      this.buttonInsert1.Size = new System.Drawing.Size(134, 32);
      this.buttonInsert1.TabIndex = 4;
      this.buttonInsert1.Text = "추가";
      this.buttonInsert1.UseVisualStyleBackColor = true;
      this.buttonEdit1.Location = new System.Drawing.Point(630, 438);
      this.buttonEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonEdit1.Name = "buttonEdit1";
      this.buttonEdit1.Size = new System.Drawing.Size(134, 32);
      this.buttonEdit1.TabIndex = 3;
      this.buttonEdit1.Text = "수정";
      this.buttonEdit1.UseVisualStyleBackColor = true;
      this.buttonDelete1.Location = new System.Drawing.Point(630, 478);
      this.buttonDelete1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonDelete1.Name = "buttonDelete1";
      this.buttonDelete1.Size = new System.Drawing.Size(134, 32);
      this.buttonDelete1.TabIndex = 2;
      this.buttonDelete1.Text = "삭제";
      this.buttonDelete1.UseVisualStyleBackColor = true;
      this.dataGridViewMovie.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMovie.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewMovie.Name = "dataGridViewMovie";
      this.dataGridViewMovie.RowTemplate.Height = 23;
      this.dataGridViewMovie.Size = new System.Drawing.Size(622, 519);
      this.dataGridViewMovie.TabIndex = 0;
      this.tabPage2.Controls.Add(this.buttonSearch2);
      this.tabPage2.Controls.Add(this.buttonInsert);
      this.tabPage2.Controls.Add(this.button3);
      this.tabPage2.Controls.Add(this.button4);
      this.tabPage2.Controls.Add(this.dataGridViewDist);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Size = new System.Drawing.Size(770, 522);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "영화 배급사";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.buttonSearch2.Location = new System.Drawing.Point(633, 360);
      this.buttonSearch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonSearch2.Name = "buttonSearch2";
      this.buttonSearch2.Size = new System.Drawing.Size(134, 32);
      this.buttonSearch2.TabIndex = 10;
      this.buttonSearch2.Text = "검색";
      this.buttonSearch2.UseVisualStyleBackColor = true;
      this.buttonInsert.Location = new System.Drawing.Point(633, 399);
      this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonInsert.Name = "buttonInsert";
      this.buttonInsert.Size = new System.Drawing.Size(134, 32);
      this.buttonInsert.TabIndex = 9;
      this.buttonInsert.Text = "추가";
      this.buttonInsert.UseVisualStyleBackColor = true;
      this.button3.Location = new System.Drawing.Point(633, 438);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(134, 32);
      this.button3.TabIndex = 8;
      this.button3.Text = "수정";
      this.button3.UseVisualStyleBackColor = true;
      this.button4.Location = new System.Drawing.Point(633, 478);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(134, 32);
      this.button4.TabIndex = 7;
      this.button4.Text = "삭제";
      this.button4.UseVisualStyleBackColor = true;
      this.dataGridViewDist.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDist.Location = new System.Drawing.Point(3, 0);
      this.dataGridViewDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewDist.Name = "dataGridViewDist";
      this.dataGridViewDist.RowTemplate.Height = 23;
      this.dataGridViewDist.Size = new System.Drawing.Size(622, 519);
      this.dataGridViewDist.TabIndex = 6;
      this.textBoxMovieDirector.Location = new System.Drawing.Point(631, 127);
      this.textBoxMovieDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieDirector.Name = "textBoxMovieDirector";
      this.textBoxMovieDirector.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieDirector.TabIndex = 11;
      this.label3.Location = new System.Drawing.Point(632, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 19);
      this.label3.TabIndex = 10;
      this.label3.Text = "영화 감독";
      this.textBoxMovieActor.Location = new System.Drawing.Point(631, 174);
      this.textBoxMovieActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieActor.Name = "textBoxMovieActor";
      this.textBoxMovieActor.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieActor.TabIndex = 13;
      this.label4.Location = new System.Drawing.Point(632, 152);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 19);
      this.label4.TabIndex = 12;
      this.label4.Text = "영화 배우";
      this.textBox1.Location = new System.Drawing.Point(631, 221);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(133, 23);
      this.textBox1.TabIndex = 15;
      this.label5.Location = new System.Drawing.Point(632, 199);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(106, 19);
      this.label5.TabIndex = 14;
      this.label5.Text = "배급사 일련 번호";
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MovieInfoEditform";
      this.Text = "MovieInfoEditform";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMovie)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewDist)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.Button buttonEdit1;
    private System.Windows.Forms.Button buttonInsert1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button buttonInsert;
    private System.Windows.Forms.Button buttonSearch2;
    private System.Windows.Forms.Button buttonSearch1;
    private System.Windows.Forms.Button buttonDelete1;
    private System.Windows.Forms.DataGridView dataGridViewDist;
    private System.Windows.Forms.DataGridView dataGridViewMovie;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxMovieTitle;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxMovieDesc;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxMovieDirector;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxMovieActor;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox1;
  }
}
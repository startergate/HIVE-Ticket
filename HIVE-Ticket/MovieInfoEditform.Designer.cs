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
      this.textBoxMovieDistID = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxMovieActor = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxMovieDirector = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.textBoxDistMother = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.textBoxDistName = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.buttonSearch2 = new System.Windows.Forms.Button();
      this.buttonInsert = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.dataGridViewDist = new System.Windows.Forms.DataGridView();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMovie)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewDist)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(11, 10);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(778, 548);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.textBoxMovieDistID);
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
      // 
      // textBoxMovieDistID
      // 
      this.textBoxMovieDistID.Location = new System.Drawing.Point(631, 288);
      this.textBoxMovieDistID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieDistID.Name = "textBoxMovieDistID";
      this.textBoxMovieDistID.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieDistID.TabIndex = 15;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(632, 265);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(106, 19);
      this.label5.TabIndex = 14;
      this.label5.Text = "배급사 일련 번호";
      // 
      // textBoxMovieActor
      // 
      this.textBoxMovieActor.Location = new System.Drawing.Point(631, 222);
      this.textBoxMovieActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieActor.Name = "textBoxMovieActor";
      this.textBoxMovieActor.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieActor.TabIndex = 13;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(632, 200);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 19);
      this.label4.TabIndex = 12;
      this.label4.Text = "영화 배우";
      // 
      // textBoxMovieDirector
      // 
      this.textBoxMovieDirector.Location = new System.Drawing.Point(631, 158);
      this.textBoxMovieDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieDirector.Name = "textBoxMovieDirector";
      this.textBoxMovieDirector.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieDirector.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(632, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 19);
      this.label3.TabIndex = 10;
      this.label3.Text = "영화 감독";
      // 
      // textBoxMovieDesc
      // 
      this.textBoxMovieDesc.Location = new System.Drawing.Point(631, 90);
      this.textBoxMovieDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieDesc.Name = "textBoxMovieDesc";
      this.textBoxMovieDesc.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieDesc.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(632, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 19);
      this.label2.TabIndex = 8;
      this.label2.Text = "영화 설명";
      // 
      // textBoxMovieTitle
      // 
      this.textBoxMovieTitle.Location = new System.Drawing.Point(631, 31);
      this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxMovieTitle.Name = "textBoxMovieTitle";
      this.textBoxMovieTitle.Size = new System.Drawing.Size(133, 23);
      this.textBoxMovieTitle.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(632, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 19);
      this.label1.TabIndex = 6;
      this.label1.Text = "영화 제목";
      // 
      // buttonSearch1
      // 
      this.buttonSearch1.Location = new System.Drawing.Point(630, 360);
      this.buttonSearch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonSearch1.Name = "buttonSearch1";
      this.buttonSearch1.Size = new System.Drawing.Size(134, 32);
      this.buttonSearch1.TabIndex = 5;
      this.buttonSearch1.Text = "검색";
      this.buttonSearch1.UseVisualStyleBackColor = true;
      this.buttonSearch1.Click += new System.EventHandler(this.buttonSearch1_Click);
      // 
      // buttonInsert1
      // 
      this.buttonInsert1.Location = new System.Drawing.Point(630, 399);
      this.buttonInsert1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonInsert1.Name = "buttonInsert1";
      this.buttonInsert1.Size = new System.Drawing.Size(134, 32);
      this.buttonInsert1.TabIndex = 4;
      this.buttonInsert1.Text = "추가";
      this.buttonInsert1.UseVisualStyleBackColor = true;
      this.buttonInsert1.Click += new System.EventHandler(this.buttonInsert1_Click);
      // 
      // buttonEdit1
      // 
      this.buttonEdit1.Location = new System.Drawing.Point(630, 438);
      this.buttonEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonEdit1.Name = "buttonEdit1";
      this.buttonEdit1.Size = new System.Drawing.Size(134, 32);
      this.buttonEdit1.TabIndex = 3;
      this.buttonEdit1.Text = "수정";
      this.buttonEdit1.UseVisualStyleBackColor = true;
      this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
      // 
      // buttonDelete1
      // 
      this.buttonDelete1.Location = new System.Drawing.Point(630, 478);
      this.buttonDelete1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonDelete1.Name = "buttonDelete1";
      this.buttonDelete1.Size = new System.Drawing.Size(134, 32);
      this.buttonDelete1.TabIndex = 2;
      this.buttonDelete1.Text = "삭제";
      this.buttonDelete1.UseVisualStyleBackColor = true;
      this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
      // 
      // dataGridViewMovie
      // 
      this.dataGridViewMovie.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMovie.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewMovie.Name = "dataGridViewMovie";
      this.dataGridViewMovie.RowTemplate.Height = 23;
      this.dataGridViewMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewMovie.Size = new System.Drawing.Size(622, 519);
      this.dataGridViewMovie.TabIndex = 0;
      this.dataGridViewMovie.CellContentDoubleClick +=
        new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellContentDoubleClick);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Controls.Add(this.textBoxDistMother);
      this.tabPage2.Controls.Add(this.label9);
      this.tabPage2.Controls.Add(this.textBoxDistName);
      this.tabPage2.Controls.Add(this.label10);
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
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton3);
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Location = new System.Drawing.Point(634, 132);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Size = new System.Drawing.Size(133, 112);
      this.groupBox1.TabIndex = 21;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "배급사 종류";
      // 
      // radioButton3
      // 
      this.radioButton3.Location = new System.Drawing.Point(10, 78);
      this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(111, 22);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "중소";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.Location = new System.Drawing.Point(10, 51);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(111, 22);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "미니메이저";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton1
      // 
      this.radioButton1.Location = new System.Drawing.Point(10, 22);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(111, 22);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "메이저 / 직배";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // textBoxDistMother
      // 
      this.textBoxDistMother.Location = new System.Drawing.Point(634, 90);
      this.textBoxDistMother.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxDistMother.Name = "textBoxDistMother";
      this.textBoxDistMother.Size = new System.Drawing.Size(133, 23);
      this.textBoxDistMother.TabIndex = 19;
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(635, 68);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(63, 19);
      this.label9.TabIndex = 18;
      this.label9.Text = "모회사명";
      // 
      // textBoxDistName
      // 
      this.textBoxDistName.Location = new System.Drawing.Point(634, 31);
      this.textBoxDistName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxDistName.Name = "textBoxDistName";
      this.textBoxDistName.Size = new System.Drawing.Size(133, 23);
      this.textBoxDistName.TabIndex = 17;
      // 
      // label10
      // 
      this.label10.Location = new System.Drawing.Point(635, 9);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(63, 19);
      this.label10.TabIndex = 16;
      this.label10.Text = "배급사명";
      // 
      // buttonSearch2
      // 
      this.buttonSearch2.Location = new System.Drawing.Point(633, 360);
      this.buttonSearch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonSearch2.Name = "buttonSearch2";
      this.buttonSearch2.Size = new System.Drawing.Size(134, 32);
      this.buttonSearch2.TabIndex = 10;
      this.buttonSearch2.Text = "검색";
      this.buttonSearch2.UseVisualStyleBackColor = true;
      this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
      // 
      // buttonInsert
      // 
      this.buttonInsert.Location = new System.Drawing.Point(633, 399);
      this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonInsert.Name = "buttonInsert";
      this.buttonInsert.Size = new System.Drawing.Size(134, 32);
      this.buttonInsert.TabIndex = 9;
      this.buttonInsert.Text = "추가";
      this.buttonInsert.UseVisualStyleBackColor = true;
      this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(633, 438);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(134, 32);
      this.button3.TabIndex = 8;
      this.button3.Text = "수정";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(633, 478);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(134, 32);
      this.button4.TabIndex = 7;
      this.button4.Text = "삭제";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // dataGridViewDist
      // 
      this.dataGridViewDist.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDist.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewDist.Name = "dataGridViewDist";
      this.dataGridViewDist.RowTemplate.Height = 23;
      this.dataGridViewDist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDist.Size = new System.Drawing.Size(625, 519);
      this.dataGridViewDist.TabIndex = 6;
      this.dataGridViewDist.CellContentDoubleClick +=
        new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDist_CellContentDoubleClick);
      // 
      // MovieInfoEditform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MovieInfoEditform";
      this.Text = "Movie Info - HIVE TICKET MANAGEMENT";
      this.Load += new System.EventHandler(this.MovieInfoEditform_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridViewMovie)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
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
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.TextBox textBoxDistMother;
    private System.Windows.Forms.TextBox textBoxDistName;
    private System.Windows.Forms.TextBox textBoxMovieDistID;
  }
}
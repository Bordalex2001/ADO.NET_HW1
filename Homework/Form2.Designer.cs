namespace Homework
{
    partial class Form2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.showNamesBtn = new System.Windows.Forms.Button();
            this.showColorsBtn = new System.Windows.Forms.Button();
            this.minCaloriesBtn = new System.Windows.Forms.Button();
            this.maxCaloriesBtn = new System.Windows.Forms.Button();
            this.avgCaloriesBtn = new System.Windows.Forms.Button();
            this.countVegetablesBtn = new System.Windows.Forms.Button();
            this.countFruitsBtn = new System.Windows.Forms.Button();
            this.countByChosenColorBtn = new System.Windows.Forms.Button();
            this.countEachColorBtn = new System.Windows.Forms.Button();
            this.caloriesBelowValueBtn = new System.Windows.Forms.Button();
            this.caloriesAboveValueBtn = new System.Windows.Forms.Button();
            this.caloriesByRangeBtn = new System.Windows.Forms.Button();
            this.yellowOrRedColorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(758, 250);
            this.dataGridView.TabIndex = 0;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(12, 270);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(375, 40);
            this.showAllBtn.TabIndex = 1;
            this.showAllBtn.Text = "Всі овочі і фрукти";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // showNamesBtn
            // 
            this.showNamesBtn.Location = new System.Drawing.Point(12, 316);
            this.showNamesBtn.Name = "showNamesBtn";
            this.showNamesBtn.Size = new System.Drawing.Size(375, 40);
            this.showNamesBtn.TabIndex = 2;
            this.showNamesBtn.Text = "Назви овочів і фруктів";
            this.showNamesBtn.UseVisualStyleBackColor = true;
            this.showNamesBtn.Click += new System.EventHandler(this.showNamesBtn_Click);
            // 
            // showColorsBtn
            // 
            this.showColorsBtn.Location = new System.Drawing.Point(12, 362);
            this.showColorsBtn.Name = "showColorsBtn";
            this.showColorsBtn.Size = new System.Drawing.Size(375, 40);
            this.showColorsBtn.TabIndex = 3;
            this.showColorsBtn.Text = "Кольори овочів і фруктів";
            this.showColorsBtn.UseVisualStyleBackColor = true;
            this.showColorsBtn.Click += new System.EventHandler(this.showColorsBtn_Click);
            // 
            // minCaloriesBtn
            // 
            this.minCaloriesBtn.Location = new System.Drawing.Point(12, 408);
            this.minCaloriesBtn.Name = "minCaloriesBtn";
            this.minCaloriesBtn.Size = new System.Drawing.Size(375, 40);
            this.minCaloriesBtn.TabIndex = 4;
            this.minCaloriesBtn.Text = "Найменша калорійність";
            this.minCaloriesBtn.UseVisualStyleBackColor = true;
            this.minCaloriesBtn.Click += new System.EventHandler(this.minCaloriesBtn_Click);
            // 
            // maxCaloriesBtn
            // 
            this.maxCaloriesBtn.Location = new System.Drawing.Point(12, 454);
            this.maxCaloriesBtn.Name = "maxCaloriesBtn";
            this.maxCaloriesBtn.Size = new System.Drawing.Size(375, 40);
            this.maxCaloriesBtn.TabIndex = 5;
            this.maxCaloriesBtn.Text = "Найбільша калорійність";
            this.maxCaloriesBtn.UseVisualStyleBackColor = true;
            this.maxCaloriesBtn.Click += new System.EventHandler(this.maxCaloriesBtn_Click);
            // 
            // avgCaloriesBtn
            // 
            this.avgCaloriesBtn.Location = new System.Drawing.Point(12, 500);
            this.avgCaloriesBtn.Name = "avgCaloriesBtn";
            this.avgCaloriesBtn.Size = new System.Drawing.Size(375, 40);
            this.avgCaloriesBtn.TabIndex = 6;
            this.avgCaloriesBtn.Text = "Середня калорійність";
            this.avgCaloriesBtn.UseVisualStyleBackColor = true;
            this.avgCaloriesBtn.Click += new System.EventHandler(this.avgCaloriesBtn_Click);
            // 
            // countVegetablesBtn
            // 
            this.countVegetablesBtn.Location = new System.Drawing.Point(12, 546);
            this.countVegetablesBtn.Name = "countVegetablesBtn";
            this.countVegetablesBtn.Size = new System.Drawing.Size(375, 40);
            this.countVegetablesBtn.TabIndex = 7;
            this.countVegetablesBtn.Text = "Кількість овочів";
            this.countVegetablesBtn.UseVisualStyleBackColor = true;
            this.countVegetablesBtn.Click += new System.EventHandler(this.countVegetablesBtn_Click);
            // 
            // countFruitsBtn
            // 
            this.countFruitsBtn.Location = new System.Drawing.Point(395, 270);
            this.countFruitsBtn.Name = "countFruitsBtn";
            this.countFruitsBtn.Size = new System.Drawing.Size(375, 40);
            this.countFruitsBtn.TabIndex = 8;
            this.countFruitsBtn.Text = "Кількість фруктів";
            this.countFruitsBtn.UseVisualStyleBackColor = true;
            this.countFruitsBtn.Click += new System.EventHandler(this.countFruitsBtn_Click);
            // 
            // countByChosenColorBtn
            // 
            this.countByChosenColorBtn.Location = new System.Drawing.Point(394, 316);
            this.countByChosenColorBtn.Name = "countByChosenColorBtn";
            this.countByChosenColorBtn.Size = new System.Drawing.Size(376, 40);
            this.countByChosenColorBtn.TabIndex = 9;
            this.countByChosenColorBtn.Text = "Кількість овочів і фруктів заданого кольору";
            this.countByChosenColorBtn.UseVisualStyleBackColor = true;
            this.countByChosenColorBtn.Click += new System.EventHandler(this.countByChosenColorBtn_Click);
            // 
            // countEachColorBtn
            // 
            this.countEachColorBtn.Location = new System.Drawing.Point(394, 362);
            this.countEachColorBtn.Name = "countEachColorBtn";
            this.countEachColorBtn.Size = new System.Drawing.Size(376, 40);
            this.countEachColorBtn.TabIndex = 10;
            this.countEachColorBtn.Text = "Кількість овочів і фруктів кожного кольору";
            this.countEachColorBtn.UseVisualStyleBackColor = true;
            this.countEachColorBtn.Click += new System.EventHandler(this.countEachColorBtn_Click);
            // 
            // caloriesBelowValueBtn
            // 
            this.caloriesBelowValueBtn.Location = new System.Drawing.Point(394, 408);
            this.caloriesBelowValueBtn.Name = "caloriesBelowValueBtn";
            this.caloriesBelowValueBtn.Size = new System.Drawing.Size(376, 40);
            this.caloriesBelowValueBtn.TabIndex = 11;
            this.caloriesBelowValueBtn.Text = "Калорійність овочів і фруктів нижче зазначеної";
            this.caloriesBelowValueBtn.UseVisualStyleBackColor = true;
            this.caloriesBelowValueBtn.Click += new System.EventHandler(this.caloriesBelowValueBtn_Click);
            // 
            // caloriesAboveValueBtn
            // 
            this.caloriesAboveValueBtn.Location = new System.Drawing.Point(394, 454);
            this.caloriesAboveValueBtn.Name = "caloriesAboveValueBtn";
            this.caloriesAboveValueBtn.Size = new System.Drawing.Size(376, 40);
            this.caloriesAboveValueBtn.TabIndex = 12;
            this.caloriesAboveValueBtn.Text = "Калорійність овочів і фруктів вище зазначеної";
            this.caloriesAboveValueBtn.UseVisualStyleBackColor = true;
            this.caloriesAboveValueBtn.Click += new System.EventHandler(this.caloriesAboveValueBtn_Click);
            // 
            // caloriesByRangeBtn
            // 
            this.caloriesByRangeBtn.Location = new System.Drawing.Point(394, 500);
            this.caloriesByRangeBtn.Name = "caloriesByRangeBtn";
            this.caloriesByRangeBtn.Size = new System.Drawing.Size(376, 40);
            this.caloriesByRangeBtn.TabIndex = 13;
            this.caloriesByRangeBtn.Text = "Калорійність овочів і фруктів за зазначеним діапазоном";
            this.caloriesByRangeBtn.UseVisualStyleBackColor = true;
            this.caloriesByRangeBtn.Click += new System.EventHandler(this.caloriesByRangeBtn_Click);
            // 
            // yellowOrRedColorBtn
            // 
            this.yellowOrRedColorBtn.Location = new System.Drawing.Point(394, 546);
            this.yellowOrRedColorBtn.Name = "yellowOrRedColorBtn";
            this.yellowOrRedColorBtn.Size = new System.Drawing.Size(376, 40);
            this.yellowOrRedColorBtn.TabIndex = 14;
            this.yellowOrRedColorBtn.Text = "Усі овочі і фрукти жовтого або червоного кольору";
            this.yellowOrRedColorBtn.UseVisualStyleBackColor = true;
            this.yellowOrRedColorBtn.Click += new System.EventHandler(this.yellowOrRedColorBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 598);
            this.Controls.Add(this.yellowOrRedColorBtn);
            this.Controls.Add(this.caloriesByRangeBtn);
            this.Controls.Add(this.caloriesAboveValueBtn);
            this.Controls.Add(this.caloriesBelowValueBtn);
            this.Controls.Add(this.countEachColorBtn);
            this.Controls.Add(this.countByChosenColorBtn);
            this.Controls.Add(this.countFruitsBtn);
            this.Controls.Add(this.countVegetablesBtn);
            this.Controls.Add(this.avgCaloriesBtn);
            this.Controls.Add(this.maxCaloriesBtn);
            this.Controls.Add(this.minCaloriesBtn);
            this.Controls.Add(this.showColorsBtn);
            this.Controls.Add(this.showNamesBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button showNamesBtn;
        private System.Windows.Forms.Button showColorsBtn;
        private System.Windows.Forms.Button minCaloriesBtn;
        private System.Windows.Forms.Button maxCaloriesBtn;
        private System.Windows.Forms.Button avgCaloriesBtn;
        private System.Windows.Forms.Button countVegetablesBtn;
        private System.Windows.Forms.Button countFruitsBtn;
        private System.Windows.Forms.Button countByChosenColorBtn;
        private System.Windows.Forms.Button countEachColorBtn;
        private System.Windows.Forms.Button caloriesBelowValueBtn;
        private System.Windows.Forms.Button caloriesAboveValueBtn;
        private System.Windows.Forms.Button caloriesByRangeBtn;
        private System.Windows.Forms.Button yellowOrRedColorBtn;
    }
}
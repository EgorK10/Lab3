
namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBoxMath = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSecondSystem = new System.Windows.Forms.ComboBox();
            this.comboBoxFirstSystem = new System.Windows.Forms.ComboBox();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.radioButtonMath = new System.Windows.Forms.RadioButton();
            this.comboBoxCompare = new System.Windows.Forms.ComboBox();
            this.radioButtonCompare = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ComboBoxMath
            // 
            this.ComboBoxMath.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboBoxMath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMath.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxMath.FormattingEnabled = true;
            this.ComboBoxMath.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.ComboBoxMath.Location = new System.Drawing.Point(270, 234);
            this.ComboBoxMath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ComboBoxMath.Name = "ComboBoxMath";
            this.ComboBoxMath.Size = new System.Drawing.Size(39, 27);
            this.ComboBoxMath.TabIndex = 0;
            this.ComboBoxMath.Visible = false;
            this.ComboBoxMath.SelectionChangeCommitted += new System.EventHandler(this.MathChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирите операцию:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstNumber.Location = new System.Drawing.Point(32, 87);
            this.textBoxFirstNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(165, 26);
            this.textBoxFirstNumber.TabIndex = 2;
            this.textBoxFirstNumber.TextChanged += new System.EventHandler(this.MathChanged);
            this.textBoxFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstNumber_KeyPress);
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSecondNumber.Location = new System.Drawing.Point(319, 87);
            this.textBoxSecondNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(163, 26);
            this.textBoxSecondNumber.TabIndex = 3;
            this.textBoxSecondNumber.TextChanged += new System.EventHandler(this.MathChanged);
            this.textBoxSecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Первое число:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(319, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Второе число:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSecondSystem
            // 
            this.comboBoxSecondSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSecondSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondSystem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSecondSystem.FormattingEnabled = true;
            this.comboBoxSecondSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxSecondSystem.Location = new System.Drawing.Point(423, 134);
            this.comboBoxSecondSystem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxSecondSystem.Name = "comboBoxSecondSystem";
            this.comboBoxSecondSystem.Size = new System.Drawing.Size(59, 27);
            this.comboBoxSecondSystem.TabIndex = 7;
            this.comboBoxSecondSystem.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSecondSystem_SelectionChangeCommitted);
            // 
            // comboBoxFirstSystem
            // 
            this.comboBoxFirstSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFirstSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirstSystem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFirstSystem.FormattingEnabled = true;
            this.comboBoxFirstSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxFirstSystem.Location = new System.Drawing.Point(138, 134);
            this.comboBoxFirstSystem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxFirstSystem.Name = "comboBoxFirstSystem";
            this.comboBoxFirstSystem.Size = new System.Drawing.Size(59, 27);
            this.comboBoxFirstSystem.TabIndex = 8;
            this.comboBoxFirstSystem.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFirstSystem_SelectionChangeCommitted);
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.AutoSize = true;
            this.LabelAnswer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAnswer.Location = new System.Drawing.Point(96, 308);
            this.LabelAnswer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(0, 23);
            this.LabelAnswer.TabIndex = 9;
            // 
            // radioButtonMath
            // 
            this.radioButtonMath.AutoSize = true;
            this.radioButtonMath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMath.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMath.Location = new System.Drawing.Point(14, 234);
            this.radioButtonMath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMath.Name = "radioButtonMath";
            this.radioButtonMath.Size = new System.Drawing.Size(198, 23);
            this.radioButtonMath.TabIndex = 10;
            this.radioButtonMath.TabStop = true;
            this.radioButtonMath.Text = "Математические операции";
            this.radioButtonMath.UseVisualStyleBackColor = true;
            this.radioButtonMath.CheckedChanged += new System.EventHandler(this.radioButtonMath_CheckedChanged);
            // 
            // comboBoxCompare
            // 
            this.comboBoxCompare.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompare.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCompare.FormattingEnabled = true;
            this.comboBoxCompare.Items.AddRange(new object[] {
            "=",
            "≠",
            ">",
            "<",
            "≤",
            "≥"});
            this.comboBoxCompare.Location = new System.Drawing.Point(270, 234);
            this.comboBoxCompare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxCompare.Name = "comboBoxCompare";
            this.comboBoxCompare.Size = new System.Drawing.Size(39, 27);
            this.comboBoxCompare.TabIndex = 12;
            this.comboBoxCompare.Visible = false;
            this.comboBoxCompare.SelectionChangeCommitted += new System.EventHandler(this.MathChanged);
            // 
            // radioButtonCompare
            // 
            this.radioButtonCompare.AutoSize = true;
            this.radioButtonCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCompare.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCompare.Location = new System.Drawing.Point(347, 234);
            this.radioButtonCompare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonCompare.Name = "radioButtonCompare";
            this.radioButtonCompare.Size = new System.Drawing.Size(160, 23);
            this.radioButtonCompare.TabIndex = 13;
            this.radioButtonCompare.TabStop = true;
            this.radioButtonCompare.Text = "Операции сравнения";
            this.radioButtonCompare.UseVisualStyleBackColor = true;
            this.radioButtonCompare.CheckedChanged += new System.EventHandler(this.radioButtonCompare_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.radioButtonCompare);
            this.Controls.Add(this.comboBoxCompare);
            this.Controls.Add(this.radioButtonMath);
            this.Controls.Add(this.LabelAnswer);
            this.Controls.Add(this.comboBoxFirstSystem);
            this.Controls.Add(this.comboBoxSecondSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxMath);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор систем счисления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxMath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSecondSystem;
        private System.Windows.Forms.ComboBox comboBoxFirstSystem;
        private System.Windows.Forms.Label LabelAnswer;
        private System.Windows.Forms.RadioButton radioButtonMath;
        private System.Windows.Forms.ComboBox comboBoxCompare;
        private System.Windows.Forms.RadioButton radioButtonCompare;
    }
}
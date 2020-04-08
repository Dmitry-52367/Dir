namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.labelEquel = new System.Windows.Forms.Label();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxFirstNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSecondNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelEquel
            // 
            this.labelEquel.AutoSize = true;
            this.labelEquel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquel.Location = new System.Drawing.Point(306, 16);
            this.labelEquel.Name = "labelEquel";
            this.labelEquel.Size = new System.Drawing.Size(18, 18);
            this.labelEquel.TabIndex = 2;
            this.labelEquel.Text = "=";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperation.ForeColor = System.Drawing.Color.ForestGreen;
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^",
            "root"});
            this.comboBoxOperation.Location = new System.Drawing.Point(127, 13);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(62, 24);
            this.comboBoxOperation.TabIndex = 4;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // maskedTextBoxFirstNumber
            // 
            this.maskedTextBoxFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxFirstNumber.Location = new System.Drawing.Point(12, 16);
            this.maskedTextBoxFirstNumber.Name = "maskedTextBoxFirstNumber";
            this.maskedTextBoxFirstNumber.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBoxFirstNumber.TabIndex = 5;
            this.maskedTextBoxFirstNumber.TextChanged += new System.EventHandler(this.maskedTextBoxFirstNumber_TextChanged);
            // 
            // maskedTextBoxSecondNumber
            // 
            this.maskedTextBoxSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxSecondNumber.Location = new System.Drawing.Point(195, 16);
            this.maskedTextBoxSecondNumber.Name = "maskedTextBoxSecondNumber";
            this.maskedTextBoxSecondNumber.Size = new System.Drawing.Size(110, 20);
            this.maskedTextBoxSecondNumber.TabIndex = 6;
            this.maskedTextBoxSecondNumber.TextChanged += new System.EventHandler(this.maskedTextBoxSecondNumber_TextChanged);
            // 
            // LabelResult
            // 
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult.ForeColor = System.Drawing.Color.Black;
            this.LabelResult.Location = new System.Drawing.Point(323, 19);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(370, 20);
            this.LabelResult.TabIndex = 7;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 47);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.maskedTextBoxSecondNumber);
            this.Controls.Add(this.maskedTextBoxFirstNumber);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.labelEquel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEquel;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFirstNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSecondNumber;
        private System.Windows.Forms.Label LabelResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

